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
        private readonly string _studentTeachersFilePath;

        public JsonDataSaveandRetrieve(string studentsFilePath)
        {
            _studentsFilePath = studentsFilePath;
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

    }

}
