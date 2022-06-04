using System;
using System.Linq;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Article article = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                if (command[0] == "Edit")
                {
                    article.EditContent(command[1]);
                }
                if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                if (command[0] == "Rename")
                {
                    article.RenameTitle(command[1]);
                }
            }

            Console.WriteLine(article);
        }
    }
}
