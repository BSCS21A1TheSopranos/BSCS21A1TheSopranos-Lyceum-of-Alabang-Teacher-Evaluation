namespace Classes
{
    public class Teacher_Class
    {
        private int teachers_ID;
        private string teachers_Name;
        private List<string> teachers_Subject;

        public Teacher_Class(int teachers_ID, string teachers_Name)
        {
            this.teachers_ID = teachers_ID;
            this.teachers_Name = teachers_Name;
        }

        public int Teachers_ID
        {
            get { return teachers_ID;}
            set { teachers_ID = value;}
        }
        public string Teachers_Name
        {
            get { return teachers_Name; }
            set { teachers_Name = value; }
        }

        public void AddSubject(string subject) 
        {
            teachers_Subject.Add(subject);
        }

    }

}
