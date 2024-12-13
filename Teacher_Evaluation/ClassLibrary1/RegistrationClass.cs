using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Text;

namespace ClassLibrary1
{
    public class RegistrationClass
    {
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
