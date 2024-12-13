using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Teacher
    {
        public string ProfID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public Teacher(string profId, string password, string email, string role, string name)
        {
            ProfID = profId;
            Password = password;
            Email = email;
            Role = role;
            Name = name;
        }
    }
    public static class TeacherDataHolder
    {
        public static Dictionary<string, Teacher> Teachers { get; private set; }


        public static void LoadTeacher(IDataSaveandRetrieve repository)
        {
            Teachers = repository.GetAllTeacher();
        }

        public static bool AddTeacherToDictionary(string profID, string name, string email, string password)
        {
            if (!Teachers.ContainsKey(profID))
            {
                var newTeacher = new Teacher(profID, password, email, "Teacher", name);
                Teachers.Add(profID, newTeacher);
                return true;
            }
            return false;
        }


        public static bool DeleteTeacherFromDictionary(string profID)
        {
            if (Teachers.ContainsKey(profID))
            {
                Teachers.Remove(profID);
                StudentTeacherData.RemoveTeacherFromStudentTeacherData(profID);
                return true;
            }
            return false;
        }
        public static string GetTeacherNameByProfID(string profID)
        {
            if (Teachers.ContainsKey(profID))
            {
                return Teachers[profID].Name;
            }
            return null;
        }
        public static string CountTeachers()
        {
            if (Teachers != null)
            {
                return Teachers.Count.ToString();
            }
            return "0"; 
        }

    }
}
