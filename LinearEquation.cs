using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class LinearEquation
    {
        protected List<float> X;
        public List<float> Solve(float b, float c)
        {
            if (a == 0)
            {
                throw new Exception("Уравнение не имеет решения, a = 0");
            }
            return X = new List<float>() { -b / a };
        }
    }
}
