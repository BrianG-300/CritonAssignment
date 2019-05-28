using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CritonTechnical
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkstatus = false;
            while (!checkstatus)
            {
                Console.WriteLine(Regex.Unescape("Please enter new password.\n----"));
                string newPass = Console.ReadLine();

                Console.WriteLine(Regex.Unescape("Please re-enter new password for confirmation.\n----"));
                string confirmnewPass = Console.ReadLine();

                checkstatus = checkPassword(newPass, confirmnewPass);
                Console.WriteLine(Regex.Unescape("----\n" + checkstatus + "\n----"));
            }
        }

        private static bool checkPassword(string newPass, string confirmnewPass)
        {
            bool matched, desiredLength, containsUpperCase, containsLowerCase, containsNumber;
            if (!newPass.Equals(confirmnewPass))
            {
                matched = false;
                return false;
            }
            else
            {
                matched = true;
                if (newPass.Length >= 8)
                {
                    desiredLength = true;
                }
                else
                {
                    desiredLength = false; 
                }
                containsLowerCase = newPass.Any(char.IsLower);
                containsUpperCase = newPass.Any(char.IsUpper);
                containsNumber = newPass.Any(char.IsNumber);
            }

            if (matched && desiredLength && containsLowerCase && containsUpperCase && containsNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
