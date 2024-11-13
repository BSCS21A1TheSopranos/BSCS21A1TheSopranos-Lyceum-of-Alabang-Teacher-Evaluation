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
    
    }
}