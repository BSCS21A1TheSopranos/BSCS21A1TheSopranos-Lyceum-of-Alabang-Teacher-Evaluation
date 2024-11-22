using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        public string StudentID { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Student(string studentID, string password, string email)
        {
            StudentID = studentID;
            Password = password;
            Email = email;
        }
    }
    public static class StudentDataHolder
    {
       
        public static Dictionary<string, Student> Students { get; private set; }

        static StudentDataHolder()
        {
            Students = new Dictionary<string, Student>();
        }

        // Method to load data into the holder
        public static void LoadStudents(IDataSaveandRetrieve repository)
        {
            Students = repository.GetAllStudents();
        }
    }

}
