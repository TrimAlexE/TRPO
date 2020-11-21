using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            try
            {
                printResult(b.Solve(2, 4));  
                printResult(b.Solve(1,-2, -3));  
                printResult(b.Solve(1,4, 4));  
                printResult(b.Solve(-2, 3));  
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
        public static void printResult(List<float> result)
        {
            foreach (float x in result)
            {
                Console.Write(x + " ; ");
            }
            Console.WriteLine();
        }
    }
}
