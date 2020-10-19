using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(EvenSum(intList));

            List<string> wordList = new List<string> { "word", "write", "list", "debug" };
            Console.WriteLine("What word length do you want to search for? ");
            string userLength = Console.ReadLine();
            int length = int.Parse(userLength);
            Console.WriteLine(WordSearch(wordList,length));

            Dictionary<int, string> studentIds = new Dictionary<int, string>
            {
                {1,"Mike" },
                {2,"Bella" },
                {3,"Sophia" }
            };
            PrintStudentIds(studentIds);
        }

        public static int EvenSum(List<int> numlist)
        {
            int sum = 0;
            foreach (int num in numlist)
            {
                if (num % 2 == 0)
                {
                    sum = sum + num;
                }
            }

        return sum;     
        }

        public static string WordSearch(List<string> wordList,int length)
        {
            string wordOutput = "";
            foreach (string word in wordList)
            {
                if (word.Length == length)
                {
                    wordOutput = wordOutput + word + " ";
                }
            }
            return wordOutput;
        }

        public static void PrintStudentIds(Dictionary<int,string> studentIds)
        {
            foreach (KeyValuePair<int,string> id in studentIds)
            {
                Console.WriteLine(id.Value + "(ID=" + id.Key + ")");
            }
        }
    }
}
