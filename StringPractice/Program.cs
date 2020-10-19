using System;

namespace StringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string suess = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house. I will not eat them with a mouse.";

            String[] suessWords = suess.Split(' ');
            Console.WriteLine(suess);

            foreach (string word in suessWords)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine(string.Join(",", suessWords));

            String[] suessSentences = suess.Split(".");
            
            foreach (string sentence in suessSentences)
            {
                Console.WriteLine(sentence);
            }

            Console.WriteLine(string.Join(",", suessSentences));

        }
    }
}
