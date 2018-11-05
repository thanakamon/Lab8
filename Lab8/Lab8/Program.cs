using System;
using System.Collections;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable c = new Hashtable();
            c.Add("72000", "suphan");


            Console.WriteLine("pls input num: ");
            Console.WriteLine("" + c.ContainsKey(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}