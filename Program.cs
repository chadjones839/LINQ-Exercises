using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //RESTRICTION/FILTERING OPERATIONS

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits where fruit.StartsWith("L") select fruit;

            Console.WriteLine("Fruits that start with the letter L");
            foreach (string LFruit in LFruits)
            {
                Console.WriteLine($"{LFruit}");
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            List<int> fourMultiples = new List<int>();
            List<int> sixMultiples = new List<int>();

            IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 6 == 0 || number % 4 == 0);

            Console.WriteLine();
            Console.WriteLine("Multiples of 4 and 6");

            foreach (int number in fourSixMultiples)
            {
                Console.WriteLine(number);
            }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            List<string> descend = names.OrderByDescending(name => name).ToList();

            Console.WriteLine();
            Console.WriteLine("NAMES IN DESCENDING ORDER");
            foreach (string name in descend)
            {
                Console.WriteLine(name);
            }
        }
    }
}