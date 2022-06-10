using System;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int bomb = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (bomb > 0 && line[i] != '>')
                {
                    line = line.Remove(i, 1);
                    bomb--;
                    i--;
                }
                else if (line[i] == '>')
                {
                    bomb += int.Parse(line[i + 1].ToString());
                }
            }

            Console.WriteLine(line);
        }
    }
}
