using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using Newtonsoft.Json;

namespace CSV_JSON_Practice
{
    internal class Program
    {
        static void Main()
        { 

            Console.WriteLine("CSV-JSON File Operation");

            //string filePath = @"C:\Users\ADMIN\source\repos\FileInputOutput Practice\CSV JSON Practice\person.csv";
            string filePath = @"C:\Users\ADMIN\source\repos\FileInputOutput Practice\CSV JSON Practice\personDemo.json";
            var records = new List<Person>
            {
            new Person{Id=1, Name = "John", Email = "john@gmail.com"},
            new Person{Id=2, Name = "Alex", Email= "alex@gmail.com"},
            new Person{Id=3, Name= "Smith", Email = "smith@gmail.com"}
            };

            //File.Create(filePath);
            string jsonData = JsonConvert.SerializeObject(records, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);

            Console.WriteLine("Json data added successfully");
            string jsonRead = File.ReadAllText(filePath);
            var deserializedData = JsonConvert.DeserializeObject<List<Person>>(jsonRead);
            foreach(var person in deserializedData)
            {
                Console.WriteLine($"Id : {person.Id}, Name : {person.Name}, Email : {person.Email}");
            }
            
            //if (File.Exists(filePath))
            //{
            //    //Writing
            //    using (var writer = new StreamWriter(filePath))
            //    using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            //    {
            //        csvWriter.WriteRecords(records);
            //    }
            //    Console.WriteLine("data added to csv file successfully");

            //    //Reading
            //    using(var reader = new StreamReader(filePath))
            //        using(var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            //    {
            //        var readRecords = csvReader.GetRecords<Person>();
            //        foreach(var record in readRecords)
            //        {
            //            Console.WriteLine($"Id : {record.Id}, Name : {record.Name}, Email : {record.Email}");
            //        }
            //    }
            //}
            //else
            //{
            //    File.Create(filePath);
            //    Console.WriteLine("File is created");
            //}
        }
    }
}