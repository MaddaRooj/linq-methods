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
            };

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
            };

            // Aggregate Operators Problem 1 -- Chapter 9
            // Output how many total numbers are contained in the following list
            List<int> ynumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            Console.WriteLine("");
            Console.WriteLine($"Number of items in ynumbers List: {ynumbers.Count()}");

            // Aggregate Operators Problem 2 -- Chapter 9
            // Output the total amount of the following list of purchases
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            Console.WriteLine("");
            Console.WriteLine($"Sum of purchases: {purchases.Sum()}");

            // Aggregate Operators Problem 3 -- Chapter 9
            // Output the largest number from the following list
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            Console.WriteLine("");
            Console.WriteLine($"Largest number: {prices.Max()}");

            // Using Custom Types Practice Problem -- Chapter 9
            // Determine how many millionaires belong to each individual Bank
            List<Bank> banks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
            };

            List<Customer> customers = new List<Customer>() 
            {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Jim Brown", Balance=49582.68, Bank="CITI"}
            };

            // IEnumerable<Customer> MillionairesClub = customers.Where(customer => customer.Balance >= 1000000);
            // foreach(Customer c in MillionairesClub)
            // {
            //     System.Console.WriteLine(c.Name);
            // };

            IEnumerable<Customer> allCustomers = 
                from customer in customers
                select customer;
            System.Console.WriteLine();
            System.Console.WriteLine("Full list of customers:");
            foreach(Customer c in allCustomers)
            {
                System.Console.WriteLine(c.Name);
            };

            IEnumerable<Customer> MillionairesClubTwo = 
                from customer in customers
                where customer.Balance >= 1000000
                select customer;
            Console.WriteLine();
            System.Console.WriteLine("List of Millionaires:");
            foreach(Customer c in MillionairesClubTwo)
            {
                System.Console.WriteLine(c.Name);
            };

            // IEnumerable<IGrouping<string, Customer>> MillionairesPerBank = MillionairesClubTwo.GroupBy(customer => customer.Bank);
            // System.Console.WriteLine();
            // System.Console.WriteLine("Customer by Bank:");
            // foreach (IGrouping<string, Customer> m in MillionairesPerBank)
            // {
            //     System.Console.WriteLine($"{m.Key}: {m.Count()}");
            // };

            // IEnumerable<IGrouping<string, Customer>> MillionairesPerBank = 
            //     from millionaire in MillionairesClubTwo
            //     group millionaire by millionaire.Bank into bankGroup
            //     select bankGroup;
            // foreach (IGrouping<string, Customer> m in MillionairesPerBank)
            // {
            //     System.Console.WriteLine($"{m.Key}: {m.Count()}");
            //     foreach (Customer c in m)
            //     {
            //         System.Console.WriteLine(c.Name);
            //     }
            // };

            var results = from person in customers
              where person.Balance >= 1000000
              group person by person.Bank into millionsGroup
              select new { Banks = millionsGroup.ToList() };
              Console.WriteLine();
              Console.WriteLine("List of millionaires by Bank: ");
              Console.WriteLine();
              foreach(var result in results)
              {
                  Console.WriteLine($"Bank: {result.Banks[0].Bank} - {result.Banks.Count}");
                  foreach(var millionaire in result.Banks)
                  {
                      Console.WriteLine($"Customer name: {millionaire.Name}");
                  }
                  Console.WriteLine();
              }; 

            // Final problem - GroupJoin
            List<ReportItem> millionaireReport = (from customer in customers
                where customer.Balance >= 1000000
                orderby customer.Name.Split()[1]
                join bank in banks on customer.Bank equals bank.Symbol
                select new ReportItem {
                    CustomerName = customer.Name,
                    BankName = bank.Name
                }).ToList();

            System.Console.WriteLine();
            System.Console.WriteLine("Group by problem: ");
            foreach (var item in millionaireReport)
            {
                System.Console.WriteLine($"{item.CustomerName} at {item.BankName}");
            }
 
        }
    }
}
