using System.Data.SqlClient;

namespace Data
{
    public class DatabaseHandler
    {
        private readonly string ConnectionString;

        public DatabaseHandler()
        {
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jaspe\source\repos\MessApp\Data\MessageAppDatabase.mdf;Integrated Security=True";
        }

        public int GetAffectedRowCount(string query)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            using SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int result = (int)command.ExecuteScalar();
            connection.Close();
            return result;
        }
    }
}