using System;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 0,0, 3, 3, 6, 1, 4, 6, 2,5,0,3,5  };
            Console.WriteLine("Date");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Month");
            int a = int.Parse(Console.ReadLine());
            int s = i + a -1;
            int b = s % 7;
            Console.WriteLine(b);
            if (b == 0) 
            Console.WriteLine("{0}//{1}//2560(Sunday)", i,a);
            if (b == 1) 
            Console.WriteLine("{0}//{1}//2560(Monday)", i, a);
            if (b == 2) 
            Console.WriteLine("{0}//{1}//2560(Tuesday)", i, a);
            if (b == 3) 
            Console.WriteLine("{0}//{1}//2560(Wednesday)", i, a);
            if (b == 4) 
            Console.WriteLine("{0}//{1}//2560(Thursday)", i, a);
            if (b == 5) 
            Console.WriteLine("{0}//{1}//2560(Friday)", i, a);
            if (b == 6) 
            Console.WriteLine("{0}//{1}//2560(Saturday)", i, a);

        }
    }
}



