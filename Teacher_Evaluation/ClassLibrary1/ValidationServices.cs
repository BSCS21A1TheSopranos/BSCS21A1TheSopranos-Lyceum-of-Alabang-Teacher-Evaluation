using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Services
{
    public class Validation
    {
        public bool validID(String ProfID)
        {
            string profID = ProfID;
            string pattern = @"^[0-9]{4}-[0-9]{2}$";
            return Regex.IsMatch(ProfID, pattern);
        }

        public bool validpaassword(string newpassword)
        {
            string password = newpassword;
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!%*?&])[A-Za-z0-9@$!%*?&]{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        public string encryptpassword(string newpassword)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(newpassword));
                newpassword = Convert.ToBase64String(data);

            }

            return newpassword;
        }

        public bool checkpassword(string password, string id)
        {
            string encryptedInput = encryptpassword(password);
            if (StudentDataHolder.Students.ContainsKey(id))
                return encryptedInput == StudentDataHolder.Students[id].Password;

            if (TeacherDataHolder.Teachers.ContainsKey(id))
                return encryptedInput == TeacherDataHolder.Teachers[id].Password;

            if (AdminDataHolder.Admins.ContainsKey(id))
                return encryptedInput == AdminDataHolder.Admins[id].Password;

            return false;
        }

    }
    
}
