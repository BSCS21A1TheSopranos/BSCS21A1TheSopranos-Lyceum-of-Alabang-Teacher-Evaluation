using System;
using System.Data.SqlClient;

public static class DatabaseConnection
{
    public static SqlConnection Cn = new SqlConnection();
    public static SqlCommand cmd;
    public static SqlDataReader dr;
    public static string sql;

    public static void Connection()
    {
        try
        {
            // Close the connection if it's already open
            if (Cn.State == System.Data.ConnectionState.Open)
            {
                Cn.Close();
            }

            // Set the connection string 
            Cn.ConnectionString = "Data Source=your_server;Initial Catalog=your_database;User ID=your_username;Password=your_password";

            // Open the connection
            Cn.Open();
            Console.WriteLine("Database connection established.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    // Method to close the connection
    public static void CloseConnection()
    {
        if (Cn.State == System.Data.ConnectionState.Open)
        {
            Cn.Close();
            Console.WriteLine("Database connection closed.");
        }
    }
}
