using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryItem = new Dictionary<string, int>();

            Dictionary<string, int> junk = new Dictionary<string, int>();

            bool isNotObtained = true;

            while (isNotObtained)
            {
                string[] materials = Console.ReadLine().ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < materials.Length; i += 2)
                {
                    int quantity = int.Parse(materials[i]);
                    string material = materials[i + 1];

                    if (material == "motes" || material == "shards" || material == "fragments") 
                    {
                        if (legendaryItem.ContainsKey(material))
                        {
                            legendaryItem[material] += quantity;
                        }
                        else
                        {
                            legendaryItem[material] = quantity;
                        }

                        if (legendaryItem[material] >= 250)
                        {
                            if (material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            else if (material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }

                            legendaryItem[material] -= 250;
                            isNotObtained = false;
                            break;
                        }

                        continue;
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk[material] = quantity;
                        }
                        else
                        {
                            junk[material] += quantity;
                        }
                    }
                }
            }

            foreach (var item in legendaryItem)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
