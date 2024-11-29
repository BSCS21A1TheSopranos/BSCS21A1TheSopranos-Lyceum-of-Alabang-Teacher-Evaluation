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
        public bool checkpassword(Student student)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(student.Password));
                student.Password = Convert.ToBase64String(data);
            }
            if (StudentDataHolder.Students.ContainsKey(student.StudentID))
            {
                string password = student.Password;
                return password == StudentDataHolder.Students[student.StudentID].Password;
            }
            return false;
        }
        public bool validpaassword(string newpassword)
        {
            string password = newpassword;
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!%*?&])[A-Za-z0-9@$!%*?&]{8,}$";
            return Regex.IsMatch(password, pattern);
        }
        
        public void encryptpassword(string newpassword, Student student)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(newpassword));
                newpassword = Convert.ToBase64String(data);
                student.Password = newpassword;   
            }
        }

        public static void Update(Student student)
        {
            if (StudentDataHolder.Students.ContainsKey(student.StudentID))
            {
                var students = StudentDataHolder.Students[student.StudentID];
                students.Password = student.Password;
                students.Role = student.Role;
                MSAcessDataSaveandRetrieve mSAcessDataSaveandRetrieve = new MSAcessDataSaveandRetrieve();
                mSAcessDataSaveandRetrieve.SaveStudents();
            }
        }

    }
}
