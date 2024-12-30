using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutput_Practice
{
    internal class FileWriteOperation
    {
        public static void FileWrite()
        {
            string path = @"C:\Users\ADMIN\Desktop\PoojaFile\filemove.txt";
            string contents = "This is the file write operation";
           
            if(File.Exists(path))
            {
                //It overrides the existing content in the perticular file
                File.WriteAllText(path, contents);
                Console.WriteLine("The content is added to the file successfully");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("The file is created and added the content");
            }
        }
    }
}
