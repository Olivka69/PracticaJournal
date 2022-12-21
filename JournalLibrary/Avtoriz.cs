using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JournalLibrary
{
    public static class Avtoriz
    {
        public static bool ValidLogin(string log)
        {
            Regex regex = new Regex("^[a-z A-Z 0-9]*$");
            if (regex.IsMatch(log))
            {
                return true;
            }
            return false;
        }

    }
}
