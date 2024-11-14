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
        public string testpassword;
        public string testusername;
        public string teststudentno;

        public LoginClass(string testpassword, string testusername, string teststudentno)
        {
            this.testpassword = testpassword;
            this.testusername = testusername;
            this.teststudentno = teststudentno;
        }

        public bool checkpassword(string password)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(password));
                password = Convert.ToBase64String(data);
            }
            return testpassword == password;
        }

        public bool checkusername(string username) 
        { 
            return testusername == username;
        }

        public bool checkstudentno(string studentno) 
        { 
            return teststudentno == studentno;
        }
    }

}
