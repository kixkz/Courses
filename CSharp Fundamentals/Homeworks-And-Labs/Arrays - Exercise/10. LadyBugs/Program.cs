using System;
using System.Linq;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugs = new int[fieldSize];
            int[] occupiedIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < occupiedIndexes.Length; i++)
            {
                int currIndex = occupiedIndexes[i];
                if (currIndex >= 0 && currIndex < ladyBugs.Length) 
                {
                    ladyBugs[currIndex] = 1;
                }
            }

            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split();
                int ladyBugsIndex = int.Parse(elements[0]);
                string direction = elements[1];
                int flyLength = int.Parse(elements[2]);

                if (ladyBugsIndex < 0 || ladyBugsIndex > ladyBugs.Length - 1 || ladyBugs[ladyBugsIndex] == 0)
                {
                    continue;
                }

                ladyBugs[ladyBugsIndex] = 0;

                if (direction == "right")
                {
                    int landIndex = ladyBugsIndex + flyLength;
                    if (landIndex > ladyBugs.Length - 1)
                    {
                        continue;
                    }

                    if (ladyBugs[landIndex] == 1)
                    {
                        while (ladyBugs[landIndex] == 1)
                        {
                            landIndex += flyLength;
                            if (landIndex > ladyBugs.Length -1)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex >= 0 && landIndex <= ladyBugs.Length - 1)
                    {
                        ladyBugs[landIndex] = 1;
                    }

                }
                else if (direction == "left")
                {
                    int landIndex = ladyBugsIndex - flyLength;
                    if (landIndex < 0)
                    {
                        continue;
                    }

                    if (ladyBugs[landIndex] == 1)
                    {
                        while (ladyBugs[landIndex] == 1)
                        {
                            landIndex -= flyLength;
                            if (landIndex < 0)
                            {
                                break;
                            }
                        }
                    }

                    if (landIndex >= 0 && landIndex <= ladyBugs.Length - 1)
                    {
                        ladyBugs[landIndex] = 1;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", ladyBugs));
        }
    }
}
