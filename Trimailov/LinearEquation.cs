using System.Collections.Generic;
using core;

namespace Trimailov
{
    public class LinearEquation : IEquationInterface
    {
        protected List<float> X;
        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                throw new Exception("Определено, что такое уравнение не существует");
            }
            return X = new List<float>() { -b / a };
        }
    }
}
