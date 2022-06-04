using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                foreach (Person person in persons)
                {
                    if (id == person.Id)
                    {
                        person.EditName(name);
                        person.EditAge(age);
                    }
                }

                Person newPerson = new Person(name, id, age);
                persons.Add(newPerson);
            }

            List<Person> orderedPerson = persons.OrderBy(age => age.Age).ToList();

            foreach (Person person in orderedPerson)
            {
                Console.WriteLine(person);
            }
        }
    }
}
