using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutput_Practice
{
    internal class FileIODemo
    {
        public static void FileExistance()
        {
            string path = @"C:\Users\ADMIN\source\repos\FileInputOutput Practice\FileInputOutput Practice\Demo.txt";
            bool result = File.Exists(path);
            if (result)
            {
                Console.WriteLine("File exists in the given path");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File is not present path is created");
            }
        }
        public static void CSVFile()
        {
            String path = @"C:\Users\ADMIN\source\repos\FileInputOutput Practice\FileInputOutput Practice\Demo.csv";
            if (File.Exists(path))
            {
                Console.WriteLine("The file exists");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("The does not exists it is created");
            }
        }
        
    }
}
