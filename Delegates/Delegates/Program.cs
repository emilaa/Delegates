using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Cavid", "Emil", "Seadet", "Seid" };

            GetCheckNames(CheckName, names);
        }

        public static bool CheckName(string name)
        {
            return name != "Cavid";
        }

        public static void GetCheckNames(Predicate<string> predicate, List<string> names)
        {
            foreach (var item in names)
            {
                if (predicate(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
