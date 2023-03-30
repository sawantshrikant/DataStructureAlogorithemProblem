using System;
using System.IO;

namespace DataStructureAlgorithmProblems
{
    public class BubbleSort
    {
        public void ReadFile(string filePath)
        {
            string readData = File.ReadAllText(filePath);
            string[] words = readData.Split(' ');
            int[] arr = new int[words.Length];
            int count = 0;
            foreach (string data in words)
            {
                arr[count] = Convert.ToInt32(data);
                count++;
                Console.Write(data + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }

                }
            }
            foreach (int data in arr)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine();
        }
    }
}
