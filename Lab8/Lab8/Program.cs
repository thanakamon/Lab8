﻿using System;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine("Create a list");
            Console.WriteLine("List capacity = {0,2}", list.Capacity);
            for (int i = 0; i < 100; i++)
            {
                Console.Write("Add int to list : {0,2} => ", i);
                list.Add(i);
                Console.WriteLine("List count =  {0,3}, capacity = {1,3}  ",
    list.Count, list.Capacity);
            }
            Console.WriteLine("-----------------------");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("Remove int from list : {0,2} => ", i);
                list.Remove(i);
                Console.WriteLine("List count =  {0,3}, capacity = {1,3}  ",
    list.Count, list.Capacity);
            }
            Console.ReadLine();
        }
    }
}
