using System;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] data = { 3.1, 3.3, 3.2, 3.5, 3.4, 3.5, 3.2, 3.2  };
           
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
            Console.WriteLine("GPA=" + (data[0] + data[1] + data[2] + data[3] + data[4] + data[5] + data[6] + data[7])/8);
            Console.ReadLine();
        }
    }
}



