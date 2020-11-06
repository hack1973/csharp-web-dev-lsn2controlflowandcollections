using System;

namespace ArrayPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someNums = { 1, 1, 2, 3, 5, 8 };

            foreach (int num in someNums)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }              
            }            
        }
    }
}
