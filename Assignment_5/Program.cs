using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> prime = new Dictionary<string, int>() { { "Atal Bihari Vajpayee", 1998},
                { "Narendra Modi", 2014 }, { "Manmohan Singh", 2004 } };
            Console.WriteLine(prime.FirstOrDefault(x => x.Value==2004).Key + " was the Prime Minister in 2004.");

            prime.Add("Narenda Modi", 2019);

            var sorted = from entry in prime orderby entry.Value ascending select entry;

            foreach (KeyValuePair<string,int> item in sorted)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            Console.ReadKey();

        }
    }
}
