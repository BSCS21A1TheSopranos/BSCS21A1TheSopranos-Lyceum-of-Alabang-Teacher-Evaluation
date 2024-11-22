using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Admin
    {
        public string AdminNo { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public Admin(string adminNo, string password, string email, string role)
        {
            AdminNo = adminNo;
            Password = password;
            Email = email;
            Role = role;
        }
    }
    public static class AdminDataHolder
    {

        public static Dictionary<string, Admin> Admins { get; private set; }

        static AdminDataHolder()
        {
            Admins = new Dictionary<string, Admin>();
        }

        public static void LoadAdmin(IDataSaveandRetrieve repository)
        {
            Admins = repository.GetAllAdmin();
        }
    }

}
