using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IntegrationApp
{
    class DBv2
    {
        private static readonly string ConnStr = @"Data Source=localhost; Initial Catalog = СпортКлуб; Integrated Security=true";
        public static DataSet ds;
        private static SqlDataAdapter sqlad;
        private static SqlCommand comnd;

        public static void Execution(string QueryString, List<string> Params = null)
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

                    comnd.ExecuteNonQuery();
                }
                else
                {
                    comnd.ExecuteNonQuery();
                }
            }
        }

        public static object ReturnableQuery(string QueryString, List<string> Params)
        {
            Execution(QueryString, Params);
            sqlad.Fill(ds);
            return ds.Tables[0];
        }
    }
}
