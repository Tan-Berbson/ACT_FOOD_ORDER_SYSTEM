using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ACT_FOOD_ORDER
{
    internal class class_dbinitializer
    {
        private static readonly string connectionString = "Data Source=actordermanagement.db";

        public static void Initialize()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();

                users(conn);

            }
        }
        private static void users(SqliteConnection conn)
        {
            string query = @"CREATE TABLE IF NOT EXISTS users (
                            id INTEGER PRIMARY KEY AUTOINCREMENT,
                            username TEXT NOT NULL UNIQUE,
                            password TEXT NOT NULL
                        );";
            Execute(conn, query);
        }
        private static void Execute(SqliteConnection conn, string query)
        {
            using (var cmd = new SqliteCommand(query, conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
}
