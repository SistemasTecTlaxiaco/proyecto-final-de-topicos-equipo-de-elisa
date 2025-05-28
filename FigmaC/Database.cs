using MySql.Data.MySqlClient;

namespace FigmaC
{
    public class Database
    {
        private readonly string connectionString = "server=localhost;port=3306;user=root;password=goku11795;database=loginapp;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}

