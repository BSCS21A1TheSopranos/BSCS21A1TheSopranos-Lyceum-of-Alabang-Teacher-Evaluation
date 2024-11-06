using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        private string name;
        private string studentNumber;
        private string password;

        public Student(string name, string studentNumber, string password)
        {
            this.name = name;
            this.studentNumber = studentNumber.TrimEnd();
            this.password = password;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
