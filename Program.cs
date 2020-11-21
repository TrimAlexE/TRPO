using System;
using Trimailov;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation myQuadraticEquation = new QuadraticEquation();

            float a, b, c;
            Console.WriteLine("Введите 3 параметра a, b и с");
            Console.Write("a = ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToSingle(Console.ReadLine());

            try
            {
                MyLog.Log("Корни уравнения: " + String.Join(" ", myQuadraticEquation.Solve(a, b, c)));
            }
            catch (TrimailovException e)
            {
                MyLog.Log(e.Message);
            }

            MyLog.Write();
            Console.ReadKey();
        }
    }
}
