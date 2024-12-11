using Services;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;

namespace ClassLibrary1
{
    public class MSAcessDataSaveandRetrieve : IDataSaveandRetrieve
    {
        private readonly string _connectionString;

        public MSAcessDataSaveandRetrieve()
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "Teacher_Evaluation_Database.accdb");
            string absolutePath = Path.GetFullPath(databasePath);
            Console.WriteLine($"Resolved database path: {absolutePath}");
            if (!File.Exists(absolutePath))
            {
                throw new FileNotFoundException("Database file not found", absolutePath);
            }
            _connectionString = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={absolutePath}";
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

        public Dictionary<string, List<(string ProfID, string Subject, string Status)>> GetStudentsTeachers()
        {
            var studentTeacherData = new Dictionary<string, List<(string ProfID, string Subject, string Status)>>();

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT StudentID, ProfID, Subject, Status FROM StudentsTeachers";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string studentId = reader["StudentID"].ToString();
                            string profId = reader["ProfID"].ToString();
                            string subject = reader["Subject"].ToString();
                            string status = reader["Status"].ToString();
                            if (!studentTeacherData.ContainsKey(studentId))
                            {
                                studentTeacherData[studentId] = new List<(string, string, string)>();
                            }
                            studentTeacherData[studentId].Add((profId, subject, status));
                        }
                    }
                }
            }
            return studentTeacherData;
        }

        public Dictionary<string, List<(string Feedback, string Sentiment)>> GetFeedback()
        {
            var teacherFeedbackData = new Dictionary<string, List<(string Feedback, string Sentiment)>>();

            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT ProfID, Feedback, Sentiment FROM FeedBack";

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string profId = reader["ProfID"].ToString();
                            string feedback = reader["Feedback"].ToString();
                            string sentiment = reader["Sentiment"].ToString();

                            if (!teacherFeedbackData.ContainsKey(profId))
                            {
                                teacherFeedbackData[profId] = new List<(string, string)>();
                            }
                            teacherFeedbackData[profId].Add((feedback, sentiment));
                        }
                    }
                }
            }
            return teacherFeedbackData;
        }


        public void SaveStudents()
        {
            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                foreach (var student in StudentDataHolder.Students.Values)
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

        public void SaveStudentsTeachers()
        {
            var studentTeacherData = StudentTeacherData.studentTeacherData; // Dictionary<string, List<(string ProfID, string Subject, string Status)>>
            using (OleDbConnection connection = new OleDbConnection(_connectionString))
            {
                connection.Open();

                // Start a transaction to handle all operations atomically
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Step 1: Fetch existing records from the database
                        string selectExistingQuery = "SELECT StudentID, ProfID FROM StudentsTeachers";
                        var existingRecords = new HashSet<(string StudentID, string ProfID)>();

                        using (OleDbCommand selectExistingCommand = new OleDbCommand(selectExistingQuery, connection, transaction))
                        {
                            using (var reader = selectExistingCommand.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string studentId = reader["StudentID"].ToString();
                                    string profId = reader["ProfID"].ToString();
                                    existingRecords.Add((studentId, profId));
                                }
                            }
                        }

                        // Step 2: Collect current records from the dictionary
                        var currentRecords = new HashSet<(string StudentID, string ProfID)>();
                        foreach (var studentId in studentTeacherData.Keys)
                        {
                            foreach (var teacherInfo in studentTeacherData[studentId])
                            {
                                currentRecords.Add((studentId, teacherInfo.ProfID));
                            }
                        }

                        // Step 3: Find records to delete (existing in DB but not in the dictionary)
                        var recordsToDelete = existingRecords.Except(currentRecords);

                        foreach (var record in recordsToDelete)
                        {
                            string deleteQuery = "DELETE FROM StudentsTeachers WHERE StudentID = ? AND ProfID = ?";
                            using (OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, connection, transaction))
                            {
                                deleteCommand.Parameters.AddWithValue("?", record.StudentID);
                                deleteCommand.Parameters.AddWithValue("?", record.ProfID);
                                deleteCommand.ExecuteNonQuery();
                            }
                        }

                        // Step 4: Insert or update records from the dictionary
                        foreach (var studentId in studentTeacherData.Keys)
                        {
                            foreach (var teacherInfo in studentTeacherData[studentId])
                            {
                                // Check if this record already exists in the database
                                string selectQuery = "SELECT COUNT(*) FROM StudentsTeachers WHERE StudentID = ? AND ProfID = ?";
                                using (OleDbCommand selectCommand = new OleDbCommand(selectQuery, connection, transaction))
                                {
                                    selectCommand.Parameters.AddWithValue("?", studentId);
                                    selectCommand.Parameters.AddWithValue("?", teacherInfo.ProfID);

                                    int count = (int)selectCommand.ExecuteScalar();
                                    if (count == 0)
                                    {
                                        // Insert new record if it doesn't exist
                                        string insertQuery = "INSERT INTO StudentsTeachers (StudentID, ProfID, Subject, Status) VALUES (?, ?, ?, ?)";
                                        using (OleDbCommand insertCommand = new OleDbCommand(insertQuery, connection, transaction))
                                        {
                                            insertCommand.Parameters.AddWithValue("?", studentId);
                                            insertCommand.Parameters.AddWithValue("?", teacherInfo.ProfID);
                                            insertCommand.Parameters.AddWithValue("?", teacherInfo.Subject);
                                            insertCommand.Parameters.AddWithValue("?", teacherInfo.Status);
                                            insertCommand.ExecuteNonQuery();
                                        }
                                    }
                                    else
                                    {
                                        // Update existing record if it exists
                                        string updateQuery = "UPDATE StudentsTeachers SET Subject = ?, Status = ? WHERE StudentID = ? AND ProfID = ?";
                                        using (OleDbCommand updateCommand = new OleDbCommand(updateQuery, connection, transaction))
                                        {
                                            updateCommand.Parameters.AddWithValue("?", teacherInfo.Subject);
                                            updateCommand.Parameters.AddWithValue("?", teacherInfo.Status);
                                            updateCommand.Parameters.AddWithValue("?", studentId);
                                            updateCommand.Parameters.AddWithValue("?", teacherInfo.ProfID);
                                            updateCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error saving student-teacher data.", ex);
                    }
                }
            }
        }

        public void SaveAllTeachers()
        {
            var teachers = TeacherDataHolder.Teachers;

            using (var connection = new OleDbConnection(_connectionString))
            {
                connection.Open();
                var teacherIds = teachers.Keys.Select(id => id.ToString()).ToList();
                string idsToKeep = string.Join(",", teacherIds.Select(id => $"'{id}'"));

                string deleteQuery = $"DELETE FROM Prof WHERE ProfID NOT IN ({idsToKeep})";
                using (var deleteCommand = new OleDbCommand(deleteQuery, connection))
                {
                    deleteCommand.ExecuteNonQuery();
                }

                foreach (var entry in teachers)
                {
                    var teacher = entry.Value;

                    string checkQuery = "SELECT COUNT(*) FROM Prof WHERE ProfID = ?";
                    using (var checkCommand = new OleDbCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("?", teacher.ProfID);
                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0)
                        {
                            string updateQuery = @"
                    UPDATE Prof
                    SET [Password] = ?, Email = ?, [Role] = ?, Name = ?
                    WHERE ProfID = ?";
                            using (var updateCommand = new OleDbCommand(updateQuery, connection))
                            {
                                updateCommand.Parameters.AddWithValue("?", teacher.Password);
                                updateCommand.Parameters.AddWithValue("?", teacher.Email);
                                updateCommand.Parameters.AddWithValue("?", teacher.Role);
                                updateCommand.Parameters.AddWithValue("?", teacher.Name);
                                updateCommand.Parameters.AddWithValue("?", teacher.ProfID);

                                updateCommand.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            string insertQuery = @"
                    INSERT INTO Prof (ProfID, [Password], Email, [Role], Name)
                    VALUES (?, ?, ?, ?, ?)";
                            using (var insertCommand = new OleDbCommand(insertQuery, connection))
                            {
                                insertCommand.Parameters.AddWithValue("?", teacher.ProfID);
                                insertCommand.Parameters.AddWithValue("?", teacher.Password);
                                insertCommand.Parameters.AddWithValue("?", teacher.Email);
                                insertCommand.Parameters.AddWithValue("?", teacher.Role);
                                insertCommand.Parameters.AddWithValue("?", teacher.Name);

                                insertCommand.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }
    }
}
