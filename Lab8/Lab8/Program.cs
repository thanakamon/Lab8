﻿using System;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[10];
            
            data[1] = 1;
            data[9] = 9;
           
            
            Console.WriteLine(data[1]);
            Console.WriteLine(data[9]);
            
            Console.ReadLine();
        }
    }
}
