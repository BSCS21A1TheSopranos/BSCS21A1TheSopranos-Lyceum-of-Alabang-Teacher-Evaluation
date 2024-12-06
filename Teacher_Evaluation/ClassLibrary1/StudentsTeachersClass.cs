
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary1
{
    public static class StudentTeacherData
    {
        public static Dictionary<string, List<(string ProfID, string Subject, string Status)>> studentTeacherData = new Dictionary<string, List<(string, string, string)>>();
        public static void LoadStudentsTeachers(IDataSaveandRetrieve repository)
        {
            studentTeacherData = repository.GetStudentsTeachers();
        }
    }
}
