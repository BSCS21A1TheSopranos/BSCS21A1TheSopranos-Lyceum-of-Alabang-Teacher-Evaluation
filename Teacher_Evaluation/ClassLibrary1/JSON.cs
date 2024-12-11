using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ClassLibrary1
{
    public class JsonDataSaveandRetrieve : IDataSaveandRetrieve
    { 
        private readonly string _studentsFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "students.json");
        private readonly string _adminFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "admin.json");
        private readonly string _teacherFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "teachers.json");
        private readonly string _studentsteachersFilePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "studentsteachers.json");

        public Dictionary<string, Student> GetAllStudents()
        {
            if (!File.Exists(_studentsFilePath))
            {
                return new Dictionary<string, Student>();
            }

            var jsonString = File.ReadAllText(_studentsFilePath);
            return JsonSerializer.Deserialize<Dictionary<string, Student>>(jsonString)
                   ?? new Dictionary<string, Student>();
        }

        public Dictionary<string, Admin> GetAllAdmin()
        {
            if (!File.Exists(_adminFilePath))
            {
                return new Dictionary<string, Admin>();
            }

            var jsonString = File.ReadAllText(_adminFilePath);
            return JsonSerializer.Deserialize<Dictionary<string, Admin>>(jsonString)
                   ?? new Dictionary<string, Admin>();
        }

        public Dictionary<string, Teacher> GetAllTeacher()
        {
            if (!File.Exists(_teacherFilePath))
            {
                return new Dictionary<string, Teacher>();
            }

            var jsonString = File.ReadAllText(_teacherFilePath);
            return JsonSerializer.Deserialize<Dictionary<string, Teacher>>(jsonString)
                   ?? new Dictionary<string, Teacher>();
        }

        public Dictionary<string, List<(string ProfID, string Subject, string Status)>> GetStudentsTeachers()
        {
            var studentTeacherData = new Dictionary<string, List<(string ProfID, string Subject, string Status)>>();
            if (File.Exists(_studentsteachersFilePath))
            {
                string jsonData = File.ReadAllText(_studentsteachersFilePath);
                var data = JsonSerializer.Deserialize<Dictionary<string, List<Dictionary<string, string>>>>(jsonData);

                if (data != null)
                {
                    foreach (var entry in data)
                    {
                        string studentId = entry.Key;
                        foreach (var teacherSubject in entry.Value)
                        {
                            string profId = teacherSubject["ProfID"];
                            string subject = teacherSubject["Subject"];
                            string status = teacherSubject["Status"];
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
            return GetFeedback();
        }
    }

}
