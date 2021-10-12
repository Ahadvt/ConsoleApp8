using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sortedlist = new SortedList<int, string>();

            sortedlist.Add(1995, "java");
            sortedlist.Add(1972, "c#");
            sortedlist.Add(1990, "python");

            foreach (var item in sortedlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
