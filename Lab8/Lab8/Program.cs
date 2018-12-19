using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace week8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] md = new string[2][];
            md [0] = new string[] {"sunday","monday","tuesday","wednesday","thursday","friday","saturday"};
            md[1] = new string[] {"January", "February", "March", "April", "May", "June", "July", "August", "September	", "October", "November	", "December" };

            for (int row = 0; row < md.Length; row++)
            {
                for (int col = 0; col < md[row].Length; col++)

                    Console.Write(md[row][col] + " ");
                Console.WriteLine();
            }
        }
    }
}