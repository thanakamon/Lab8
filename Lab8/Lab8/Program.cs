using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplyTable = new int[13, 13];

            for (int a = 1; a <= 12; a++)
            {

                for (int i = 1; i <= 12; i++) 
                {
                    Console.WriteLine(multiplyTable[a, i] = a * i);
                    for (int row = 0; row < multiplyTable.GetLength(0); row++)
                    {
                        for (int col = 0; col < multiplyTable.GetLength(1); col++)
                {
                Console.Write("{0,5}", multiplyTable[row, col]);
            }
            Console.WriteLine();
        }
        Console.ReadLine();

                }
}
            

        }
    }
}
