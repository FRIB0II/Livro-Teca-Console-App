using MySql.Data.MySqlClient;

namespace Data;

public class DataProgram
{
    static void DataMain()
    {
        string connectionString = "Server=localhost;Database=livroteca;User=root;Password=Password123#@!;";
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                
            }
    }
}