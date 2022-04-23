using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class IntBlock : BaseBlock
    {
        private double prev_hot = 0.0;
        private double sum_hot = 0.0;
        private double prev_cold = 0.0;
        private double sum_cold = 0.0;
        private double dt;
        

        public IntBlock(double dt){
            this.dt = dt; 
        }
        public override double Calc(double x)
        {
            sum_hot += (prev_hot + x) * dt / 2;
            prev_hot = x;
            return sum_hot;
        }
    }
}
