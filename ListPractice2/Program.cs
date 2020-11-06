using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace ListPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> someInts = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<string> somewords = new List<string> { "a", "aa", "aaa", "aaaa", "qqqqq", "eeeeee", "ttttttt" };

            Console.WriteLine(evenSum(someInts));
            printXLengthWords(somewords);
        }

        public static int evenSum(List<int> integers)
        {
            int sum = 0;
            foreach (int i in integers)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }            
            return sum;
        }

        public static void printXLengthWords(List<String> words)
        {
            string input;
            int length;

            Console.WriteLine("What length of word do you want to search for:");
            input = Console.ReadLine();
            length = int.Parse(input);

            foreach (string word in words)
            {
                if (word.Length == length)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
