using System;
using System.Collections.Generic;

namespace Trimailov
{
    public class QuadraticEquation : LinearEquation
    {
        public new List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                return base.Solve(b, c, 0);
            }
            float D = discriminant(a, b, c);
            
            if (D == 0)
            {
                return X = new List<float>() { (float)(-b + Math.Sqrt(D)) / (2 * a) };
            }
            if (D > 0)
            {
                return X = new List<float>()
                {
                    (float)(-b + Math.Sqrt(D)) / (2 * a),
                    (float)(-b - Math.Sqrt(D)) / (2 * a)
                };
            }
            if (D < 0)
            {
                throw new Exception("Ошибка: уравнение не имеет решений.");
            }
            return X;
        }
        protected float discriminant(float a, float b, float c)
        {
            return (float)Math.Pow(b, 2) - 4 * a * c;
        }
    }
}
