using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOptimization
{
    internal class GoldenSection
    {
        public delegate double Function(double[] x);
        public double eps { get; set; } = 0.01;
        private double fi;
        public long MaxSteps = 10000;
        public long Steps { get; set; } 
        public GoldenSection()
        {
            fi = (1 + Math.Sqrt(5)) / 2;
        }

        public double Optimize(Function f, double[] vars, int varIndex, double a, double b)
        {
            double x1, x2, y1, y2;
            Steps = 0;

            do
            {
                x1 = b - (b - a) / fi;
                x2 = a + (b - a) / fi;
                vars[varIndex] = x1;
                y1 = f(vars);
                vars[varIndex] = x2;
                y2 = f(vars);
                if (y1 >= y2) a = x1;
                else b = x2;
                Steps++;
                if (Steps > MaxSteps) break;
            }while(Math.Abs(b-a) > eps);

            vars[varIndex] = (b + a) / 2;

            return f(vars);  
        }

        public double FindMin(Func<double, double> f, double u, double eps = 0.001)
        {
            double a = u - 1000, b = u + 1000, z = (3 - Math.Sqrt(5)) / 2;
            double x1 = a + z * (b - a), x2 = b - z * (b - a);

            for (int i = 0; b - a > eps; i++)
            {
                if (f(x1) <= f(x2))
                {
                    b = x2;
                    x2 = x1;
                    x1 = a + b - x2;
                }
                else
                {
                    a = x1;
                    x1 = x2;
                    x2 = a + b - x1;
                }
            }
            double x = (a + b) / 2;
            return x - u;
        }
    }
}
