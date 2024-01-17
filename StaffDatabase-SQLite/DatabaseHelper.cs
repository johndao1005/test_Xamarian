using System.Data.SQLite;

namespace StaffDatabase_SQLite
{
    public class DatabaseHelper
    {
        private static string databaseDirectory = @"..\..\..\..\StaffDatabase-SQLite\database\staffDB.db";
        private static string connectionString = @"Data Source={databaseDirectory};Version=3";

        public static void InitalizeDatabase()
        {
            if (!File.Exists(databaseDirectory))
            {

                SQLiteConnection.CreateFile(databaseDirectory);

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // create table and insert data here.
                    string createStaffTableQuery = @"
                        CREATE TABLE IF NOT EXISTS CREATE TABLE StaffContacts (
                        StaffID INTEGER PRIMARY KEY AUTOINCREMENT ,
                        StaffType INT,
                        Title INT,
                        FirstName VARCHAR(50) NOT NULL,
                        LastName VARCHAR(50) NOT NULL,
                        MiddleInitial CHAR(1),
                        HomePhone VARCHAR(15),
                        CellPhone VARCHAR(15),
                        OfficeExtension VARCHAR(10),
                        IRDNumber VARCHAR(11),
                        Status INT,
                        ManagerID INT NULL
                    );";

                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = createStaffTableQuery;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
