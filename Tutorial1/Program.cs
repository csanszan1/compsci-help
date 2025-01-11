using Microsoft.Data.Sqlite;

using var connection = new SqliteConnection("Data Source=D:\\Source\\Repos\\Tutorial1\\asd.db");
connection.Open();

using var command = connection.CreateCommand();
command.CommandText = "SELECT * FROM users";

using var reader = command.ExecuteReader();
while (reader.Read())
{
    var username = reader.GetString(1);
    Console.WriteLine(username);
}
connection.Close();
