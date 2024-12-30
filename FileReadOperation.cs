using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutput_Practice
{
    internal class FileReadOperation
    {
        public static void ReadAllTestsFromFile()
        {
            string path = @"C:\Users\ADMIN\Desktop\gitcommand\googlemeet.txt";
            if (File.Exists(path))
            {
                string notes = File.ReadAllText(path);
            }
            else
            {
                Console.WriteLine("There is no file to read text");
            }
        }
        public static void ReadAllTestsFromerticularLine()
        {
            string path = @"C:\Users\ADMIN\Desktop\gitcommand\googlemeet.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                Console.WriteLine(lines[3]);
            }
            else
            {
                Console.WriteLine("There is no file to read text");
            }
        }
    }
}
