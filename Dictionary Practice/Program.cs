using System;
using System.Collections.Generic;

namespace DictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> studentIds = new Dictionary<int, string>
            {
                {1,"Mike" },
                {2,"Bella" },
                {3,"Sophia" }
            };
            PrintStudentIds(studentIds);
        }

        public static void PrintStudentIds(Dictionary<int, string> studentIds)
        {
            foreach (KeyValuePair<int, string> id in studentIds)
            {
                Console.WriteLine(id.Value + "(ID=" + id.Key + ")");
            }
        }

    }
}
