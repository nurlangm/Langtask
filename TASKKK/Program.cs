using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedlist = new SortedList();

            sortedlist.Add("Csharp", 2000);
            sortedlist.Add("Cplusplus", 1983);
            sortedlist.Add("Python", 1991);
            sortedlist.Add("Css", 1996);


            foreach (DictionaryEntry item in sortedlist)
            {
                Console.WriteLine(item.Key);
            }
            Console.WriteLine("**");
            foreach (DictionaryEntry item in sortedlist)

            {

                Console.WriteLine(item.Value);
            }
        }
    }
}