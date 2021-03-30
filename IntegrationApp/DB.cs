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
        /// Класс для работы с базой данных
        /// </summary>
        class DB
        {
            private static readonly string ConnStr = @"Data Source=localhost; Initial Catalog = СпортКлуб; Integrated Security=true";
            public static DataSet ds;
            private static SqlDataAdapter sqlad;
            private static SqlCommand comnd;

            /// <summary>
            /// Метод выполняющий запрос к базе данных. Подходит для INSERT, UPDATE, DELETE, EXECUTE
            /// </summary>
            /// <param name="QueryString">Строка запроса к БД</param>
            public static void Execute(string QueryString)
            {
                using (SqlConnection sqlconn = new SqlConnection(ConnStr))
                {
                    sqlconn.Open();
                    sqlad = new SqlDataAdapter(QueryString, ConnStr);
                    ds = new DataSet();
                    comnd = new SqlCommand(QueryString, sqlconn);
                    comnd.ExecuteNonQuery();
                    sqlconn.Close();
                }
            }

            /// <summary>
            /// Модифицированный метод выполнения запроса к БД, возвращающий результат в виде таблицы
            /// Подходит только для SELECT
            /// </summary>
            /// <param name="QueryString">Строка запроса к БД</param>
            /// <returns>Результат выполнения запроса</returns>
            public static object SearchValuesQuery(string QueryString)
            {
                Execute(QueryString);
                sqlad.Fill(ds);
                return ds.Tables[0];
            }
        }
    }



