using System;
using Trimailov;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation myQuadraticEquation = new QuadraticEquation();
           
            try
            {
                MyLog.Log("Корни уравнения: " + String.Join(" ", myQuadraticEquation.Solve(1, -2, -3)));
            }
            catch (Exception e)
            {
                MyLog.Log(e.Message);
            }

            MyLog.Write();
            Console.ReadKey();
        }
    }
}
