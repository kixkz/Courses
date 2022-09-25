using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersonInfo.Models;

namespace PersonInfo.Core
{
    public class Engine
    {
        private Smartphone smartphone;
        private IList<string> phoneNumbers;
        private IList<string> urls;

        public Engine()
        {
            this.smartphone = new Smartphone();
            this.phoneNumbers = new List<string>();
            this.urls = new List<string>();
        }

        public void Run()
        {
            this.phoneNumbers = Console.ReadLine().Split().ToList();
            this.urls = Console.ReadLine().Split().ToList();

            CallPhoneNumber();
            BrowseUrls();
        }

        private void BrowseUrls()
        {
            foreach (var url in urls)
            {
                try
                {
                    Console.WriteLine(this.smartphone.Browse(url));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void CallPhoneNumber()
        {
            foreach (var phoneNumber in this.phoneNumbers)
            {
                try
                {
                    Console.WriteLine(this.smartphone.Call(phoneNumber));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
