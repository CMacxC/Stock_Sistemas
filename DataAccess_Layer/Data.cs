using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Dapper;

namespace DataAccess_Layer
{
    public class Data
    {
        #region Singleton
        private static volatile Data instance = null;
        private static readonly object padLock = new object();
        public static string InitialCatalog = "";
        public static string DataSource = "";
        public static string UserID = "";
        public static string Password = "";
        public static string conString = @"Data Source = SISTEMAS-02\SQLEXPRESS; Initial Catalog = Inventario_Sistemas; User ID = sa; Password = sa123; ";
        private byte[] Clave = Encoding.ASCII.GetBytes("KirSto12");
        private byte[] IV = Encoding.ASCII.GetBytes("Stock.soft1");

        private Data() { }

        public static Data Instance()
        {
            if (instance == null)
            {
                lock (padLock)
                {
                    if (instance == null)
                    {
                        instance = new Data();
                    }
                }
            }
            return instance;
        }
        #endregion

        #region Query/Execute
        public T QuerySingle<T>(string query)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle<T>(query, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public T QuerySingle<T>(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle<T>(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public T QuerySingleOrDefault<T>(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingleOrDefault<T>(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public string QueryString(string query)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle(query, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public string QueryString(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.QuerySingle(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public IEnumerable<T> Query<T>(string query)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.Query<T>(query, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public IEnumerable<T> Query<T>(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.Query<T>(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public int Execute(string query, DynamicParameters parameters)
        {
            using (var con = new SqlConnection(conString))
            {
                return con.Execute(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300);
            }
        }

        public int Insert(string query, DynamicParameters parameters, string fieldName)
        {
            using (var con = new SqlConnection(conString))
            {
                return (int)((IDictionary<string, object>)con.QuerySingle(query, parameters, commandType: CommandType.StoredProcedure, commandTimeout: 300))[fieldName];
            }
        }
        #endregion
    }
}
