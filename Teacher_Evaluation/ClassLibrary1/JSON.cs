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

        public JsonDataSaveandRetrieve(string studentsFilePath, string adminFilePath, string teacherFilePath)
        {
            _studentsFilePath = studentsFilePath;
            _adminFilePath = adminFilePath;
            _teacherFilePath = teacherFilePath;
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
    }

}
