using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class APBlock : BaseBlock
    {
        private double dt;
        private double T;
        private double prev_hot;
        private double prev_cold;

        public APBlock(double dt, double T)
        {
            this.dt = dt;
            this.T = T;
        }

        public override double Calc(double x)
        {
            var y = (dt * x + T * prev_hot) / (T + dt);
            prev_hot = y;    
            return y;
        }
    }
}
