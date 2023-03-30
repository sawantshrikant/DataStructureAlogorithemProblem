using System;

namespace AlgorithmsProblem
{
    internal class Anagram
    {
        public void CheckAnagram()
        {
            Console.WriteLine("Enter words to check for anagram");
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            if (word1.Length != word2.Length)
                Console.WriteLine("Given words are not anagrams");
            else
            {
                char[] result1 = word1.ToCharArray();
                Array.Sort(result1);
                word1 = new string(result1);
                char[] result2 = word2.ToCharArray();
                Array.Sort(result2);
                word2 = new string(result2);
                if (word1.Equals(word2))
                    Console.WriteLine("Anagrams");
                else
                    Console.WriteLine("Not anagrams");
            }
        }
    }
}
