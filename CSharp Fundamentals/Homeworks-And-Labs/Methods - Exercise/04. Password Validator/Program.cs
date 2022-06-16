using System;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isPasswordLengthValid = ValidatePasswordLength(password);
            bool isPasswordContainsValidSymbols = IsPasswordContainsLettersOrDigits(password);
            bool isDigitsInPasswordAtLeastTwo = ValidatePasswordDigit(password);

            if (!isPasswordLengthValid)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isPasswordContainsValidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!isDigitsInPasswordAtLeastTwo)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isDigitsInPasswordAtLeastTwo && isPasswordContainsValidSymbols && isPasswordLengthValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool ValidatePasswordLength(string password)
        {
            return password.Length >= 6 && password.Length <=10;
        }

        static bool IsPasswordContainsLettersOrDigits(string password)
        {
            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }

            return true;

            //return password.All(ch => char.IsLetterOrDigit(ch));
        }

        static bool ValidatePasswordDigit(string password)
        {
            int count = 0;
            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    count++;
                }
            }

            if (count >= 2)
            {
                return true;
            }

            return false;
        }
    }
}
