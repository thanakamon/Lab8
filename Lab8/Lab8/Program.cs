using System;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] data = new int[10];

            data[0] = 0;
            data[1] = 1;
            data[2] = 2;
            data[3] = 3;
            data[4] = 4;
            data[5] = 5;
            data[6] = 6;
            data[7] = 7;
            data[8] = 8;
            data[9] = 9;


            for(i=0;i<10;i++)

            Console.WriteLine(data[i]);
            
            Console.ReadLine();
        }
    }
}
