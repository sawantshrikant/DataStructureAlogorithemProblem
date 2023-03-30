
using AlgorithmsProblem;
using DataStructureAlgorithmProblems;
using DataStructures;
using System;

namespace DataStructureAlgorithmProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Algorithm Problem!");

            BinarySearch binarySearch = new BinarySearch();
            binarySearch.ReadFile("D:\\class\\BL_.net_Exercise\\DataStructureAlogorithemProblem\\DataStructureAlogorithemProblems\\File.txt");

            InsertionSort sort = new InsertionSort();
            sort.ReadFile("D:\\class\\BL_.net_Exercise\\DataStructureAlogorithemProblem\\DataStructureAlogorithemProblems\\File.txt");


            Anagram anagram = new Anagram();
            anagram.CheckAnagram();



        }
    }
}