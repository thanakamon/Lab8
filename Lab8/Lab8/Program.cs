using System;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string[] array5 = Array.FindAll(array1,
            element => element.Length <= 3);
            string[] array2 = Array.FindAll(array1,
            element => element.Length >= 10);
            string[] array3 = Array.FindAll(array1,
            element => element.StartsWith("J", 
            StringComparison.Ordinal));
            Console.WriteLine(string.Join(",", array5));
            Console.WriteLine(string.Join(",", array2));
            Console.WriteLine(string.Join(",", array3));


        }
    }
}
