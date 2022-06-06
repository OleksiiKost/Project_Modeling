using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class PIDBlock : BaseBlock
    {
        private double dt;
        private double ki = 0.00001;

        private double IntSum = 0.0;
        private double PrevX = 0.0;
        private LimitBlock LimU = new LimitBlock(0, 50);

        
        public bool ManualMode { get; set; } = false;
        public double U_Manual { get; set; }
        public double K { get; set; } = 0;
        
        public double KI { get { return ki; } set { ki = value; } }
        public double Td { get; set; }
        public double Ti
        {
            get 
            { 
                return 1 / ki; 
            }
            set
            {
                if (value == 0)
                    ki = double.MaxValue;
                else ki = 1 / value;
            }
        }

        public PIDBlock(double dt)
        { 
            this.dt = dt;
        }

        public override double Calc(double x)
        {
            if (ManualMode)
            {
                IntSum = (U_Manual - K * x - Td * (x - PrevX) / dt) / ki;
            }
            else
            {
                IntSum += (PrevX + x) * dt / 2;
            }
            var u = K * x + ki * IntSum + Td * ((x - PrevX) / dt);
            PrevX = x;
            var U = LimU.Calc(u);
            return U;
        }

    }
}
