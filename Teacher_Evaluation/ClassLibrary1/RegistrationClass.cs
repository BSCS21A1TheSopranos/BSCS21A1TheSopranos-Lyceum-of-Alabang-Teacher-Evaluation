using System.Text.RegularExpressions;

namespace ClassLibrary1
{
    public class RegistrationClass
    {
        public bool validstudentNo(Student student)
        {
            string studentnum = student.StudentNumber;
            string pattern = @"^[0-9]{4}-[0-9]{2}$";
            return Regex.IsMatch(studentnum, pattern); 
        }

        public bool validpaassword(Student student)
        {
            string password = student.Password;
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!%*?&])[A-Za-z0-9@$!%*?&]{8,}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
