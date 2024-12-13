using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Services;

namespace ClassLibrary1
{
    public class LoginClass : Validation
    {

        public string id;
        public bool isAdmin;
        public bool isTeacher;
        public bool isStudent;


        public LoginClass(string id)
        {
            this.id = id;
        }

        public bool checkStudent()
        {
            return StudentDataHolder.Students.ContainsKey(id)
                || TeacherDataHolder.Teachers.ContainsKey(id)
                || AdminDataHolder.Admins.ContainsKey(id);
        }

        public bool HasRole(string roleType)
        {
            switch (roleType)
            {
                case "Admin":
                    return AdminDataHolder.Admins.ContainsKey(id);
                case "Teacher":
                    return TeacherDataHolder.Teachers.ContainsKey(id);
                case "Student":
                    return StudentDataHolder.Students.ContainsKey(id);
                default:
                    return false;
            }
        }

        public void GetRoles()
        {
            isAdmin = HasRole("Admin");
            isTeacher = HasRole("Teacher");
            isStudent = HasRole("Student");
        }

    }

}