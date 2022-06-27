using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class GaussSeidel
    {
        public delegate double Function(double U1, double U2, double U3);
        public double[] GaussMin(Function f, double U1, double U2, double U3)
        {
            double u1 = U1;
            double u2 = U2;
            double u3 = U3;
            double h1, h2, h3; 

            for (int k = 0; k < 1000; k++)
            {
                h1 = LinMin((u) => f(u, u2,u3), u1);
                u1 = u1 + h1;

                h2 = LinMin((u) => f(u1, u,u3), u2);
                u2 = u2 + h2;

                h3 = LinMin((u) => f(u1, u2,u), u3);
                u3 = u3 + h3;

                if (h1 == 0 & h2 == 0)
                {
                    Console.WriteLine($"Done. Number of steps: {k}");
                    break;
                }
            }
            double[] vars = new double[3];
            vars[0] = u1;
            vars[1] = u2;
            vars[2] = u3;
            return vars;
        }

        public static double LinMin(Func<double, double> f, double u, double eps = 1)
        {
            double a = 0, b = 1000, z = (3 - Math.Sqrt(5)) / 2;
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

