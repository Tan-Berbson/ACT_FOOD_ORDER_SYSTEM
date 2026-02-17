using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace ACT_FOOD_ORDER
{
    internal class Class1
    {
        public static class db
        {
            private static readonly string connectionString = "Data Source=actordermanagement.db";
            public static SqliteConnection GetConnection()
            {
                return new SqliteConnection(connectionString);
            }
        }
        public class auth
        {
            public bool login(string username, string password)
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    var result = (long)command.ExecuteScalar();
                    return result > 0;
                }
            }
            public bool register(string username, string password)
            {
                using (var connection = db.GetConnection())
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO users (username, password) VALUES (@username, @password)";
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqliteException ex) when (ex.SqliteErrorCode == 19) // Unique constraint violation
                    {
                        return false; // Username already exists
                    }
                }
            }
        }
    }
}
