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
        private readonly string _studentsFilePath;
        private readonly string _adminFilePath;
        private readonly string _teacherFilePath;
        private readonly string _studentsteachersFilePath;

        public JsonDataSaveandRetrieve(string studentsFilePath, string adminFilePath, string teacherFilePath, string studentsteachersFilePath)
        {
            _studentsFilePath = studentsFilePath;
            _adminFilePath = adminFilePath;
            _teacherFilePath = teacherFilePath;
            _studentsteachersFilePath = studentsteachersFilePath;
        }

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

        public Dictionary<string, List<(string ProfID, string Subject)>> GetStudentsTeachers()
        {
            var studentTeacherData = new Dictionary<string, List<(string ProfID, string Subject)>>();
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

    }

}
