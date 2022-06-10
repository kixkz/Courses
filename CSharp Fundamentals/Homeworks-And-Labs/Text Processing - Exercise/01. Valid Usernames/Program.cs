using System;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main()
        {
            string[] userNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var currName in userNames)
            {
                if (currName.Length >= 3 && currName.Length <= 16)
                {
                    bool isValid = true;
                    foreach (char currChar in currName)
                    {
                        if (!(char.IsLetterOrDigit(currChar) || currChar == '-' || currChar == '_'))
                        {
                            isValid = false;
                            break;
                            
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(currName);
                    }
                }
            }
        }
    }
}
