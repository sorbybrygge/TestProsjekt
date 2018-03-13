using System;
using System.Collections.Generic;
using System.Linq;

namespace Morten
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] theStrings = {"Morten", "Julenissen", "Jesus", "Hitler"};

            Console.WriteLine("Original:");
            foreach (var s in theStrings)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            Console.WriteLine("Etterpå:");
            Console.WriteLine(theStrings.JoinWithAnd());

            Console.WriteLine("PRESS ENTER");
            Console.ReadLine();
        }


    }

    public static class Helpers
    {

        public static string JoinWithAnd(this IEnumerable<string> s)
        {
            var enumerable = s as string[] ?? s.ToArray();
            return string.Join(", ", enumerable.Take(enumerable.Count() - 1)) + (enumerable.Count() <= 1 ? "" : " and ") +
                   enumerable.LastOrDefault();
        }


    }

}
