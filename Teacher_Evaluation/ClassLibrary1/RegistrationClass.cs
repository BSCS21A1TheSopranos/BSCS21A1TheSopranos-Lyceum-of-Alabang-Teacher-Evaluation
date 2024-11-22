using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

namespace ClassLibrary1
{
    public class RegistrationClass
    {
        public bool validstudentNo(Student student)
        {
            string studentnum = student.StudentID;
            string pattern = @"^[0-9]{4}-[0-9]{2}$";
            return Regex.IsMatch(studentnum, pattern); 
        }

        public bool validpaassword(Student student)
        {
            string password = student.Password;
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!%*?&])[A-Za-z0-9@$!%*?&]{8,}$";
            return Regex.IsMatch(password, pattern);
        }
        
        public void encryptpassword(Student student)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(student.Password));
                student.Password = Convert.ToBase64String(data);
            }
        }
    }
}
