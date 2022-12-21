using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Journal.Helpers
{
    static class ProverkaBox
    {
        public static string ValidTextBox(string text)
        {
            Regex regex = new Regex("[0-9]+");
            if (regex.IsMatch(text))
            {
                
            }
            return text;
           //throw new FormatException("Неверный формат ввода данных! Ожидается число.");
        }


    }
}

