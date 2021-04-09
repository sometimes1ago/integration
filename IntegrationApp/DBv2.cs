using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IntegrationApp
{
    /// <summary>
    /// Улучшенная версия класса DB, позволяющая передавать запрос и список параметров в методы выполнения запросов.
    /// Передаваемые параметры нумеруются от 0 до n
    /// </summary>
    class DBv2
    {
        private static readonly string ConnStr = @"Data Source=localhost; Initial Catalog = СпортКлуб; Integrated Security=true";
        public static DataSet ds;
        private static SqlDataAdapter sqlad;
        private static SqlCommand comnd;

        /// <summary>
        /// Метод, подходящий для выполнения запросов INSERT, DELETE, UPDATE
        /// </summary>
        /// <param name="QueryString">Строка запроса к БД</param>
        /// <param name="Params">Список параметров. По умолчанию пустой. Параметры в запросе нумеруются от 0 до n.
        /// Для выполнения без параметров передается null</param>
        public static void Execute(string QueryString, List<string> Params = null)
        {
            using (SqlConnection sqlconn = new SqlConnection(ConnStr))
            {
                sqlconn.Open();
                comnd = new SqlCommand(QueryString, sqlconn);

                if (Params != null)
                { 
                    for (int i = 0; i < Params.Count; i++)
                    {
                        comnd.Parameters.AddWithValue($@"@{i}", Params[i]);
                    }

                    comnd.ExecuteNonQuery();
                }
                else
                {
                    comnd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Метод, возвращающий результат выполнения запроса. Подходит только для SELECT
        /// </summary>
        /// <param name="QueryString">Строка запроса к БД</param>
        /// <param name="Params">Список параметров. По умолчанию пустой. Параметры в запросе нумеруются от 0 до n. 
        /// Для выполнения без параметров передается null</param>
        /// <returns>Строки данных записанные в экземпляр класса Dataset объект ds</returns>
        public static object QuerySelect(string QueryString, List<string> Params)
        {
            using (SqlConnection sqlconn = new SqlConnection(ConnStr))
            {
                sqlconn.Open();
                comnd = new SqlCommand(QueryString, sqlconn);
                sqlad = new SqlDataAdapter(QueryString, ConnStr);
                ds = new DataSet();

                if (Params != null)
                {
                    for (int i = 0; i < Params.Count; i++)
                    {
                        comnd.Parameters.AddWithValue($@"@{i}", Params[i]);
                    }

                    sqlad.SelectCommand = comnd;
                    sqlad.SelectCommand.ExecuteNonQuery();
                }
                else
                {
                    sqlad.SelectCommand = comnd;
                    sqlad.SelectCommand.ExecuteNonQuery();
                }

                sqlad.Fill(ds);
                sqlconn.Close();
                return ds.Tables[0];
            }
        }
    }
}
