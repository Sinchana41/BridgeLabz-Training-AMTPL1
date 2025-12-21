using FileIOUsingJson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace FileIOUsingJson
{
    class Program
    {
        static void Main()
        {
            string path = "people.json";

            List<Person> people = new List<Person>()
        {
            new Person { Name = "Sinchana", Age = 25 },
            new Person { Name = "Shyam", Age = 30 }
        };

            //SERIALIZE (Object → JSON string)
            string jsonData = JsonSerializer.Serialize(people,
                new JsonSerializerOptions { WriteIndented = true });
               //WriteIndented = true makes JSON clean and readable

            // Write Json to File
            File.WriteAllText(path, jsonData);

            // Read Json from File
            string jsonText = File.ReadAllText(path);

            // DESERIALIZE (JSON → Object)
            List<Person> list = JsonSerializer.Deserialize<List<Person>>(jsonText);

            Console.WriteLine("JSON File Output:\n");
            foreach (var p in list)
            {
                Console.WriteLine(p.Name + " - " + p.Age);
            }

        }
    }
}