using System;
using System.Collections;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict1 = new Dictionary<string, string>();
            dict1.Add("txt", "Notepad.exe");
            dict1.Add("bmp", "paint.exe");
            dict1.Add("rtf", "wordpad.exe");
            dict1.Add("pdf", "acrobat.exe");

            foreach (var item in dict1)
            {
                Console.WriteLine(item);
            }

            foreach (var item in dict1)
            {
                Console.WriteLine("key = {0}, value = {1}", item.Key, item.Value);
            }

            Console.ReadLine();
        }
    }
}
