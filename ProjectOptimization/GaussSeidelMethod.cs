using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOptimization
{
    internal class GaussSeidelMethod
    {
        private GoldenSection GoldSecMeth = new GoldenSection();

        public double u1 { get; set; }
        public double u2 { get; set; }
        public double GaussMin(Func<double, double, double> f, Point start)
        {
            u1 = start.u1;
            u2 = start.u2;
            double h1, h2; //increments
            for (int k = 0; k < 1000; k++)
            {
                h1 = GoldSecMeth.FindMin((u) => f(u, u2), u1);
                u1 = u1 + h1;

                h2 = GoldSecMeth.FindMin((u) => f(u1, u), u2);
                u2 = u2 + h2;

                // Checking the stop condition
                if (h1 == 0 & h2 == 0)
                {
                    Console.WriteLine($"Done. Number of steps: {k}");
                    break;
                }
            }
            return f(u1, u2);
        }


    }
}
