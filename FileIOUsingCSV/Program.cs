using System;
using System.Collections.Generic;
using System.IO;

namespace FileIOUsingCSV
{
    class Program
    {
        static void Main()
        {
            string path = "people.csv";

            // 1. Write to csv
            string[] lines =
            {
            "Name,Age",
            "Sinchana,22",
            "Sushma,23",
            "Ram,24"

            };

            File.WriteAllLines(path, lines);

            // 2. Read from csv
            string[] csvData = File.ReadAllLines(path);

            List<Person> people = new List<Person>();

            for (int i = 1; i < csvData.Length; i++) // skip header
            {
                string[] parts = csvData[i].Split(',');

                people.Add(new Person
                {
                    Name = parts[0],
                    Age = int.Parse(parts[1])
                });
            }

            // 3. Display
            Console.WriteLine("CSV File Output:\n");

            foreach (var p in people)
            {
                Console.WriteLine(p.Name + " - " + p.Age);
            }
        }
    }
}