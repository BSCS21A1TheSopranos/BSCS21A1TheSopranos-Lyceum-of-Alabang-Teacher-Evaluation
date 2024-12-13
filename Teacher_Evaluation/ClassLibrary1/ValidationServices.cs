using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Services
{
    public class Validation
    {
        public bool validID(String ProfID)
        {
            string profID = ProfID;
            string pattern = @"^[0-9]{4}-[0-9]{2}$";
            return Regex.IsMatch(ProfID, pattern);
        }

    }
    
}
