using System;
using System.IO;

namespace DataStructureAlgorithmProblems
{
    public class BinarySearch
    {
        public void ReadFile(string filePath)
        {
            string readData = File.ReadAllText(filePath);
            string[] words = readData.Split(' ');
            foreach (var data in words)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine();
            Console.Write("Enter the word to search: ");
            string search = Console.ReadLine();
            foreach (var data in words)
            {
                if (data.Equals(search))
                {
                    Console.WriteLine("Word found!");
                    return;
                }
            }
            Console.WriteLine("Word not found!");
        }
    }
}
