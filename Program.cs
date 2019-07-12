using System;
using System.Collections.Generic;
using System.Linq;

namespace linqPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Restriction/Filtering Operations -- Chapter 9
            Console.WriteLine("");
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};
            IEnumerable<string> LFruits = from fruit in fruits
                where fruit[0] == 'L'
                select fruit;
                foreach(string fruit in LFruits)
                {
                    Console.WriteLine(fruit);
                }

            // Restriction/Filtering Operations Problem 2 -- Chapter 9
            Console.WriteLine("");
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);
            foreach(int number in fourSixMultiples)
            {
                Console.WriteLine(number);
            }

            // Ordering Operations Problem 1 -- Chapter 9
            // Order these student names alphabetically, in descending order (Z to A)
            Console.WriteLine("");
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

            // Ordering Operations Problem 2 -- Chapter 9
            // Build a collection of these numbers sorted in ascending order
            Console.WriteLine("");
            List<int> xnumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            List<int> ascendingNums = xnumbers.OrderBy(num => num).ToList();
            foreach(int n in ascendingNums)
            {
                Console.WriteLine(n);
            }

            List<int> ynumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            Console.WriteLine("");
            Console.WriteLine($"Number of items in ynumbers List: {numbers.Count()}");

            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            Console.WriteLine("");
            Console.WriteLine($"Sum of purchases: {purchases.Sum()}");

            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            Console.WriteLine("");
            Console.WriteLine($"Largest number: {prices.Max()}");

            /*
            Store each number in the following List until a perfect square
            is detected.

            Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };
        }
    }
}
