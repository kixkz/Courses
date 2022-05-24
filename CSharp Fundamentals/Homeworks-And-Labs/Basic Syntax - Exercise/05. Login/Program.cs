using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            int counter = 0;

            while (true)
            {
                password = Console.ReadLine();
                string tempPass = string.Empty;
                foreach (var c in password)
                {
                    tempPass = c + tempPass;
                }

                if (username == tempPass)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (counter >= 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    counter++;
                }
            }
        }
    }
}
