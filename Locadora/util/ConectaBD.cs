using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.util
{
    public class ConectaBD
    {
        //dados necessário para conexão com o banco de dados PostgreSQL
        private static string serverName = "localhost";
        private static string port = "5432";
        private static string userName = "postgres";
        private static string password = "pgadmin";
        private static string dataBaseName = "dbLocadora";


        public static NpgsqlConnection getConexao()
        {
            try
            {
                string stgConexao = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4}",
                    serverName, port, userName, password, dataBaseName);

                NpgsqlConnection npsqlConnection = new NpgsqlConnection(stgConexao);

                return npsqlConnection;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
