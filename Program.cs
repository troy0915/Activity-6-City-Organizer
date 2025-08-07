using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_6_City_Organizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            string input;

            Console.WriteLine("Enter city names (type 'exit' to finish):");
            while (true)
            {
                input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }
                cities.Add(input);
            }
            var distinctCities = cities.Distinct().ToList();
            distinctCities.Sort();
            Console.WriteLine("\nCities in alphabetical order:");
            foreach (var city in distinctCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}



    

