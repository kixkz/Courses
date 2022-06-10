using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            //StringBuilder sb = new StringBuilder();
            string encryptedText = String.Empty;
            foreach (char ch in text)
            {
                encryptedText += (char)(ch + 3);
                //sb.Append((char)(ch + 3));
            }

            Console.WriteLine(encryptedText);
            //Console.WriteLine(sb.ToString());
        }
    }
}
