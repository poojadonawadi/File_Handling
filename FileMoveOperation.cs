using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileInputOutput_Practice
{
    internal class FileMoveOperation
    {
        public static void MoveFile()
        {
            string source = @"C:\Users\ADMIN\Desktop\gitcommand\googlemeet.txt";
            string destination = @"C:\Users\ADMIN\Desktop\PoojaFile\googlemeet.txt";

            try
            {
                File.Delete(destination);
                File.Move(source, destination);
                Console.WriteLine("The file has been moved to the destination successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
