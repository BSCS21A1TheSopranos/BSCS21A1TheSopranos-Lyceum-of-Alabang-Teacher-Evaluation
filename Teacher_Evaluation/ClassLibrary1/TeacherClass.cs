﻿using System;
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

        static TeacherDataHolder()
        {
            Teachers = new Dictionary<string, Teacher>();
        }

        public static void LoadTeacher(IDataSaveandRetrieve repository)
        {
            Teachers = repository.GetAllTeacher();
        }

        public static void AddTeacherToDictionary(string profID, string name, string email, string password)
        {
            var newTeacher = new Teacher(profID, password, email, "Teacher", name);
            Teachers.Add(profID, newTeacher);
        }
    }
}
