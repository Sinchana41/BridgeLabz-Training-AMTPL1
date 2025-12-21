using System;

namespace LINQProgarms
{
    class Program
    {
        public static void Main()
        {
            int[] Numbers = {1,2,3, 4,5,6,7,8,9};
            var Evens = Numbers.Where(n => n % 2 == 0).Select(n => n * 10);
            foreach (int n in Evens)
            { 
            Console.Write(n+" ");//20 40 60 80
            }

            Console.WriteLine();

            int[] Odds = Numbers.Where(n => n % 1 == 0).ToArray();
            foreach (int n in Odds)
            {
                Console.Write(n+" ");//1 2 3 4 5 6 7 8 9
            }

            Console.WriteLine();

            var q = from n in Numbers
                    where n > 1
                    select n * 10;
            foreach (int n in q)
            {
                Console.Write(n+" ");//20 30 40 50 60 70 80 90
            }

            Console.WriteLine();

            var Nums = Enumerable.Range(1, 12);
            foreach (int n in Nums)
            {
                Console.Write(n+" ");//1 2 3 4 5 6 7 8 9 10 11 12
            }
            Console.WriteLine();

            var MultiplesOf3 = Nums.Where(n => n % 3 == 0);
            foreach (int n in MultiplesOf3)
            {
                Console.Write(n+" ");//3 6 9 12
            }
            Console.WriteLine();

            var people = new[]
       {
            new { Name = "Ram", Age = 30 },
            new { Name = "Seetha", Age = 22 },
            new { Name = "Hanuman", Age = 27 }
        };

            var greetings = people.Select(p => $"Hello {p.Name}," +
                                               $" age {p.Age}");
            foreach (var g in greetings)
            {
                Console.Write(g+" ");//Hello Ram, age 30 Hello Seetha, age 22 Hello Hanuman, age 27
            }
            Console.WriteLine();

            var customers = new[]
        {
            new { Name = "A", Orders = new[] { 100, 101 } },
            new { Name = "B", Orders = new[] { 200 } },
            new { Name = "C", Orders = Array.Empty<int>() }
        };

            var allOrders = customers.SelectMany(c => c.Orders);
            Console.WriteLine("All orders: " + (allOrders.Any() ? string.Join(", ", allOrders) : "(none)"));
            //All orders: 100, 101, 200

            string[] Fruits = new[] { "apple", "orange", "banana", "papaya", "grapes","kiwi","pomogranate"};

            var ordered = Fruits.OrderBy(s => s[0])    // primary: first letter(According to Alphabetic order)
                                .ThenBy(s => s.Length); // secondary: length(Accor

            Console.WriteLine("Ordered: " + string.Join(", ", ordered));//Ordered: apple, banana, grapes, kiwi, orange, papaya, pomogranate

            string[] words ={ "one", "two", "three", "four", "five", "six", "seven" };
            var grouped = words.GroupBy(w => w.Length);
            foreach (var g in grouped.OrderBy(g => g.Key))
            {
                Console.Write($"Length {g.Key}: {string.Join(", ", g)}"+" ");//Length 3: one, two, six Length 4: four, five Length 5: three, seven
            }
            Console.WriteLine();
            int[] values = { 5, 10, 15, 20 };

            Console.WriteLine("Any > 12? " + values.Any(v => v > 12));//True
            Console.WriteLine("All >= 5? " + values.All(v => v >= 5));//True
            Console.WriteLine("Count: " + values.Count());//4
            Console.WriteLine("Sum: " + values.Sum());//50
            Console.WriteLine("Average: " + values.Average());//12.5
            Console.WriteLine("Max: " + values.Max());//20
            Console.WriteLine("Min: " + values.Min());//5

            Console.WriteLine("First:" + values.First());//First:5
            Console.WriteLine("Last:" + values.Last());//20
            Console.WriteLine("Element At Index 2:"+ values.ElementAt(2));//Element At Index:15
            Console.WriteLine("First Element which is greater than 10: "+values.FirstOrDefault(x => x > 10));//15, default - 0
        }
    }
}