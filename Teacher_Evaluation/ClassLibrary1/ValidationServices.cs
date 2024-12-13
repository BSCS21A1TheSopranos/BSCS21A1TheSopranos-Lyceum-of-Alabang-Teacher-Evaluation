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

    }

    
}
