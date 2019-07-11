using System;
using System.Collections.Generic;
using System.Linq;

namespace linqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            // Restriction/Filtering Operations -- Chapter 9
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};
            IEnumerable<string> LFruits = from fruit in fruits
                where fruit[0] == 'L'
                select fruit;
                foreach(string fruit in LFruits)
                {
                    Console.WriteLine(fruit);
                }
            Console.WriteLine("");
            // Restriction/Filtering Operations Problem 2 -- Chapter 9
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);
            foreach(int number in fourSixMultiples)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("");
            // Ordering Operations Problem 1 -- Chapter 9
            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };
            List<string> descend = names.OrderByDescending(name => name).ToList();
            foreach(string name in descend)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("");
            // Ordering Operations Problem 2 -- Chapter 9
            // Build a collection of these numbers sorted in ascending order
            List<int> xnumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            List<int> ascendingNums = xnumbers.OrderBy(num => num).ToList();
            foreach(int n in ascendingNums)
            {
                Console.WriteLine(n);
            }
        }
    }
}
