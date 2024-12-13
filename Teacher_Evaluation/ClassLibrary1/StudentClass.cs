using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        public string StudentID { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public Student(string studentID, string password, string email, string role)
        {
            StudentID = studentID;
            Password = password;
            Email = email;
            Role = role;
        }
    }
    public static class StudentDataHolder
    {
       
        public static Dictionary<string, Student> Students { get; private set; }

        static StudentDataHolder()
        {
            Students = new Dictionary<string, Student>();
        }

        public static void LoadStudents(IDataSaveandRetrieve repository)
        {
            Students = repository.GetAllStudents();
        }

        public static void AddStudent(Student newStudent)
        {
            Students.Add(newStudent.StudentID, newStudent);
        }

        public static string CountAllStudents()
        {
            return Students.Count.ToString();
        }
    }

}
