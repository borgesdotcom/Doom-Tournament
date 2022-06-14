using Microsoft.Data.SqlClient;

namespace Projeto_Final.DAO
{
    public class ConnectDB
    {
        public static SqlConnection Connection()
        {
            string connectionString =
                "Server=DESKTOP-14AP2D6\\SQLEXPRESS;Database=Tournament;Trusted_Connection=True;MultipleActiveResultSets=true";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
