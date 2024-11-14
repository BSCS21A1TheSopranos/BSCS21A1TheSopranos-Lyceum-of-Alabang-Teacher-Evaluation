using System;
using System.Data;
using System.Data.OleDb;
namespace Teacher_Evaluation
{
    public  static class DatabaseConnection
    {
        static string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"..","..", "..", "..", "Teacher_Evaluation_Database.accdb");
        static OleDbConnection connection = new OleDbConnection($@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath}");

        public static void RegisterPassword(string studentno, string password)
        {
            connection.Open();
            OleDbCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Students SET [Password] = @Password WHERE StudentID = @StudentID";
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@StudentID", studentno);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static UserInfo UserData(string userno)
        {
            UserInfo user = null;
            connection.Open();
            try
            {
                var tables = new (string TableName, string IDField)[]
                {
            ("Students", "StudentID"),
            ("Prof", "ProfID"),
            ("Admin", "AdminNO")
                };

                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;

                foreach (var (tableName, idField) in tables)
                {
                    command.CommandText = $"SELECT * FROM {tableName} WHERE {idField} = @userNo";
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@userNo", userno);

                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new UserInfo
                            {
                                ID = reader[idField].ToString(),
                                Role = reader["Role"].ToString(),
                                Password = reader["Password"].ToString()
                            };
                            return user;
                        }
                    }
                }
            }
            finally
            {
                connection.Close();
            }
            return user;
        }


    }

    public class UserInfo
    {
        public string ID { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
    }

}