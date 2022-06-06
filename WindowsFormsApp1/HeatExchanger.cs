using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /*   Рівняння ОК
            *   x_hot_out = 12 * G_hot + 0.38 * T_hot_in + 1.15 * T_cold_in - 5 * G_cold;
                x_cold_out = -10 * G_cold + 0.41 * T_hot_in + 0.95 * T_cold_in + 10 * G_hot; */
    public class HeatExchanger
    {
        //private ComplexBlock complBlockHot;
        private ComplexBlock complBlockCold;
        private double dt  = 0.1;
        private GainBlock kx1;
        private GainBlock kx2;

        public HeatExchanger(double dt)
        {
            this.dt = dt;
            kx1 = new GainBlock(1);
            kx2 = new GainBlock(-1);

            complBlockCold = new ComplexBlock();
            complBlockCold.Add(new APBlock(dt, 5));
        }


        public double CalcCold(double G_hot, double T_hot_in, double T_cold_in, double G_cold)
        {
            var x_cold_out = kx2.Calc(G_cold) + 0.5 * kx1.Calc(T_hot_in) + kx1.Calc(T_cold_in) + kx1.Calc(G_hot);
            return complBlockCold.Calc(x_cold_out);
        }

        /*public double CalcHot(double x)
        {
            return complBlockHot.Calc(x);
        }*/

    }
}
