using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    using System.Data.OleDb;

    public class MSAcessDataSaveandRetrieve : IDataSaveandRetrieve
    {
        private readonly string _connectionString;

        public MSAcessDataSaveandRetrieve(string databasePath)
        {
            _connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath}";
        }

        public Dictionary<string, Student> GetAllStudents()
        {
            var students = new Dictionary<string, Student>();

            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT StudentID, Password, Email, Role FROM Students";

                using (var command = new OleDbCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var studentID = reader["StudentID"].ToString();
                        var password = reader["Password"].ToString();
                        var email = reader["Email"].ToString();
                        var role = reader["Role"].ToString();

                        students[studentID] = new Student(studentID, password, email, role);
                    }
                }
            }

            return students;
        }

        public Dictionary<string, Admin> GetAllAdmin()
        {
            var admins = new Dictionary<string, Admin>();

            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT AdminNo, Password, Email, Role FROM Admin";

                using (var command = new OleDbCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var adminNo = reader["AdminNo"].ToString();
                        var password = reader["Password"].ToString();
                        var email = reader["Email"].ToString();
                        var role = reader["Role"].ToString();

                        admins[adminNo] = new Admin(adminNo, password, email, role);
                    }
                }
            }

            return admins;
        }

        public Dictionary<string, Teacher> GetAllTeacher()
        {
            var teachers = new Dictionary<string, Teacher>();

            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT ProfID, Password, Email, Role FROM Prof";

                using (var command = new OleDbCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var profID = reader["ProfID"].ToString();
                        var password = reader["Password"].ToString();
                        var email = reader["Email"].ToString();
                        var role = reader["Role"].ToString();

                        teachers[profID] = new Teacher(profID, password, email, role);
                    }
                }
            }

            return teachers;
        }
    }
}
