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
        private readonly string _connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "Teacher_Evaluation_Database.accdb")}";

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
                string query = "SELECT ProfID, Password, Email, Role, Name FROM Prof";

                using (var command = new OleDbCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var profID = reader["ProfID"].ToString();
                        var password = reader["Password"].ToString();
                        var email = reader["Email"].ToString();
                        var role = reader["Role"].ToString();
                        var name = reader["Name"].ToString();

                        teachers[profID] = new Teacher(profID, password, email, role, name);
                    }
                }
            }

            return teachers;
        }

        public Dictionary<string, List<(string ProfID, string Subject)>> GetStudentsTeachers()
        {
            var studentTeacherData = new Dictionary<string, List<(string ProfID, string Subject)>>();

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT StudentID, ProfID, Subject FROM StudentsTeachers";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string studentId = reader["StudentID"].ToString();
                            string profId = reader["ProfID"].ToString();
                            string subject = reader["Subject"].ToString();
                            if (!studentTeacherData.ContainsKey(studentId))
                            {
                                studentTeacherData[studentId] = new List<(string, string)>();
                            }
                            studentTeacherData[studentId].Add((profId, subject));
                        }
                    }
                }
            }
            return studentTeacherData;
        }

        public void SaveStudents(Dictionary<string, Student> students)
        {
            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                foreach (var student in students.Values)
                {
                    string checkQuery = "SELECT COUNT(*) FROM Students WHERE [StudentID] = ?";
                    using (var checkCommand = new OleDbCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("?", student.StudentID);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if (count > 0)
                        {
                            string updateQuery = "UPDATE Students SET [Password] = ?, [Email] = ?, [Role] = ? WHERE [StudentID] = ?";
                            using (var updateCommand = new OleDbCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("?", student.Password);
                                updateCommand.Parameters.AddWithValue("?", student.Email);
                                updateCommand.Parameters.AddWithValue("?", student.Role);
                                updateCommand.Parameters.AddWithValue("?", student.StudentID);
                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO Students ([StudentID], [Password], [Email], [Role]) VALUES (?, ?, ?, ?)";
                            using (var insertCommand = new OleDbCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("?", student.StudentID);
                                insertCommand.Parameters.AddWithValue("?", student.Password);
                                insertCommand.Parameters.AddWithValue("?", student.Email);
                                insertCommand.Parameters.AddWithValue("?", student.Role);
                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
    }
}
