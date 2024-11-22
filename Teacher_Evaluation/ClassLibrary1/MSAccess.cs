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
    }
}
