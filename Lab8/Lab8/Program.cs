using System;
using System.Linq;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
         

            string[] m = new string[] { "January", "February",
              "March", "April", "May", "June",
              "July", "August", "September	", "October","November","December" };

          
            var sortAscending = from Month in m
                                orderby Month
                                select Month;
            var sortDescending = from Month in m
                                 orderby Month descending
                                 select Month;


            Console.WriteLine("------String sort ascending----------");
            foreach (string c in sortAscending)
                Console.WriteLine(c);

            Console.WriteLine("------String sort descending----------");
            foreach (string c in sortDescending)
                Console.WriteLine(c);
          
            Console.ReadLine();
        }
    }
}

