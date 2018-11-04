﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            dict1.Add("One", 1);
            dict1.Add("Two", 2);
            dict1.Add("Three", 3);
            dict1.Add("Four", 4);
            dict1.Add("Five", 5);
            dict1.Add("Six", 6);
            dict1.Add("Seven", 7);
            dict1.Add("Eight", 8);
            dict1.Add("Nine", 9);
            dict1.Add("Ten", 10);
            if (dict1.ContainsKey("One"))
            {
                int value = dict1["One"];
                Console.WriteLine(value);
            }
            if (dict1.ContainsKey("Eleven"))
            {
                int value = dict1["Eleven"];
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
