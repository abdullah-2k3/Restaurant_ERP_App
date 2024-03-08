using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    internal class DatabaseConnection
    {
        private SQLiteConnection Con;

        public DatabaseConnection(string databasePath)
        {
            // Initialize the SQLite connection with the provided database path
            string connectionString = $"Data Source={databasePath};Version=3;";
            Con = new SQLiteConnection(connectionString);
        }

        public void Open()
        {
            Con.Open();
        }

        public void Close()
        {
            Con.Close();
        }

        public SQLiteDataReader ExecuteQuery(string query)
        {
            // Create a SQLite command
            using (SQLiteCommand command = Con.CreateCommand())
            {
                // Set the SQL query
                command.CommandText = query;

                // Execute the query and return the SQLiteDataReader
                return command.ExecuteReader();
            }
        }

        public int ExecuteNonQuery(string query)
        {
            // Create a SQLite command
            using (SQLiteCommand command = Con.CreateCommand())
            {
                // Set the SQL query
                command.CommandText = query;

                // Execute the non-query SQL command and return the number of rows affected
                return command.ExecuteNonQuery();
            }
        }

    }
}
