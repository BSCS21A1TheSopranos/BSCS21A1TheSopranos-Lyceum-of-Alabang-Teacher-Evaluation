using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Teacher
    {
        public string ProfID { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public Teacher(string profId, string password, string email, string role)
        {
            ProfID = profId;
            Password = password;
            Email = email;
            Role = role;
        }
    }
    public static class TeacherDataHolder
    {

        public static Dictionary<string, Teacher> Teachers { get; private set; }

        static TeacherDataHolder()
        {
            Teachers = new Dictionary<string, Teacher>();
        }

        public static void LoadTeacher(IDataSaveandRetrieve repository)
        {
            Teachers = repository.GetAllTeacher();
        }
    }

}
