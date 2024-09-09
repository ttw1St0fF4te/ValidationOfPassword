using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidationOfPassword
{
    public class PasswordCheck
    {
        public int Checker(string password)
        {
            if (string.IsNullOrEmpty(password))
                return 0;

            int point = 0;
            string specialCharacters = @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]";

            if (password.Any(char.IsDigit))
                point++;

            if (password.Any(char.IsLower))
                point++;

            if (password.Any(char.IsUpper))
                point++;

            if (Regex.IsMatch(password, specialCharacters))
                point++; 

            if (password.Length > 10)
                point++;

            return point;
        }
        static void Main() { }
    }
}

