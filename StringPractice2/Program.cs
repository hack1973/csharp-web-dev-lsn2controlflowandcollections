using System;

namespace StringPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";
            string[] paragraphArray = paragraph.Split(".");

            Console.WriteLine(string.Join(",", paragraphArray));

            //Console.WriteLine("Hello World!");
        }
    }
}
