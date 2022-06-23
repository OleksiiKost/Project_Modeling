using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOptimization
{
    internal class CoordinateDescent
    {
        private GoldenSection gs = new GoldenSection();
        public double eps { get; set; } = 0.01;

        public double Optimize(GoldenSection.Function func, double[] vars, double a, double b)
        {
            double y1 = func(vars);
            double y2 = y1 + 100;
            while (Math.Abs(y2 - y1) > eps)
            {
                y2 = y1;
                for (int i = 0; i < vars.Length; i++)
                {
                    y1 = gs.Optimize(func, vars, i, a, b);
                }
            }
            return func(vars);
        }
    }
}
