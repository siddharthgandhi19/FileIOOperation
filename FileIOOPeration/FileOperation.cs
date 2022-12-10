using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperation
{
    public class FileOperation
    {
        public static void FileExist()
        {
            string filePath = @"E:\Bridgelabz\FileIOOperation\FileIOOPeration\Operation.txt";
            if (File.Exists(filePath))
                Console.WriteLine("File Path Exists");
            else
                Console.WriteLine("File Path Doesnt Exists");
        }

        public static void ReadAllLines()
        {
            string filePath = @"E:\Bridgelabz\FileIOOperation\FileIOOPeration\Operation.txt";
            string[] lines = File.ReadAllLines(filePath);
            foreach (var data in lines)
            {
                Console.WriteLine(data);
            }
        }
    }
}
