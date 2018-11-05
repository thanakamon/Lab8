using System;
using System.Collections;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable c = new Hashtable();
            c.Add("60030007", "ging");
            c.Add("60030014", "jimmy");
            c.Add("60030015", "golf");
            c.Add("60030016", "first");
            c.Add("60030029", "aun");
            c.Add("60030031", "may");
            c.Add("600300", "meen");
            c.Add("60030041", "o");
            c.Add("60030049", "tar");
            c.Add("60030089", "boat");
            c.Add("60030098", "aomsin");
            c.Add("60030112", "rut");

            foreach (DictionaryEntry day in c)
            {
                Console.WriteLine(day.Key + "\n   " + day.Value);
            }
            Console.WriteLine("pls input sid: ");
            Console.WriteLine("" + c.ContainsKey(Console.ReadLine()));
            Console.ReadLine();
        }
    }
}

