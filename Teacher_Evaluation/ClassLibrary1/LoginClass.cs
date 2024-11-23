using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ClassLibrary1
{
    public class LoginClass
    {

        public string id;

        public LoginClass(string id)
        {
            this.id = id;
        }

        public bool checkpassword(string password)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(password));
                password = Convert.ToBase64String(data);
            }

            if (StudentDataHolder.Students.ContainsKey(id))
                return StudentDataHolder.Students[id].Password == password;

            if (TeacherDataHolder.Teachers.ContainsKey(id))
                return TeacherDataHolder.Teachers[id].Password == password;

            if (AdminDataHolder.Admins.ContainsKey(id))
                return AdminDataHolder.Admins[id].Password == password;

            return false;
        }

        public bool checkStudent()
        {
            return StudentDataHolder.Students.ContainsKey(id)
                || TeacherDataHolder.Teachers.ContainsKey(id)
                || AdminDataHolder.Admins.ContainsKey(id);
        }

        public string GetRole()
        {
            if (StudentDataHolder.Students.ContainsKey(id))
                return StudentDataHolder.Students[id].Role;

            if (TeacherDataHolder.Teachers.ContainsKey(id))
                return TeacherDataHolder.Teachers[id].Role;

            if (AdminDataHolder.Admins.ContainsKey(id))
                return AdminDataHolder.Admins[id].Role;

            return "Wala Boi";
        }


    }

}