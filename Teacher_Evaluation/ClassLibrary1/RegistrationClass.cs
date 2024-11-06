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
    }
}
