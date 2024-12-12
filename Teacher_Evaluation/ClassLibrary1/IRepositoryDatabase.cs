using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IDataSaveandRetrieve
    {
        Dictionary<string, Student> GetAllStudents();
        Dictionary<string, Admin> GetAllAdmin();
        Dictionary<string, Teacher> GetAllTeacher();
        Dictionary<string, List<(string ProfID, string Subject, string Status)>> GetStudentsTeachers();
        Dictionary<string, List<(string Feedback, string Sentiment, string Date)>> GetFeedback();
    }
}
