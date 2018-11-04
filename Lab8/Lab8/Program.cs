using System;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            string[] array2 = Array.FindAll(array1,
              element => element.EndsWith("ber",
              StringComparison.Ordinal));
            string[] array3 = Array.FindAll(array1,
              element => element.EndsWith("ly",
              StringComparison.Ordinal));
            string[] arrayC = new string[4];
            Array.Copy(array2, arrayC, array2.Length);
            for (int i = 0; i < arrayC.Length; i++)
            {
                Console.WriteLine("{0}", arrayC[i]);
            }
            string[] arraya = new string[1];
            Array.Copy(array3, arraya, array3.Length);
            for (int i = 0; i < arraya.Length; i++)
            {
                Console.WriteLine("{0}", arraya[i]);
            }

        }
    }
}