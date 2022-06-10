using System;
using System.Runtime.CompilerServices;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            filePath = filePath.Substring(filePath.LastIndexOf('\\') + 1);

            string fileName = filePath.Substring(filePath.LastIndexOf('\\') + 1, filePath.LastIndexOf('.'));
            string fileExtension = filePath.Substring(filePath.LastIndexOf('.') + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
