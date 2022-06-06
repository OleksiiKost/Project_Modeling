using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class IntBlock : BaseBlock
    {
        private double sum = 0.0;
        private double prev = 0.0;
        private double dt;

        public IntBlock(double dt){
            this.dt = dt; 
        }
        public override double Calc(double x)
        {
            sum += (prev + x) * dt / 2;
            prev = x;
            return sum;
        }
    }
}
