using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ControlSystem
    {
        private double dt;
        private PIDBlock PID;
        private HeatExchanger Heat;

        private LimitBlock limBlock_T_hot = new LimitBlock(60, 120);
        private LimitBlock limBlock_T_cold = new LimitBlock(5, 20);
        private LimitBlock limBlock_G = new LimitBlock(0, 50);
        private LimitBlock limBlock_setpoint = new LimitBlock(45, 60);

        private double setPoint;
        private double g_hot=2;
        private double t_hot_in=70;
        private double t_cold_in=10;
        private double g_cold=2;

        public double K { get { return PID.K; } set { PID.K = value; } }
        public double Ti { get { return PID.Ti; } set { PID.Ti = value; } }
        public double Td { get { return PID.Td; } set { PID.Td = value; } }
        public double Output { get; set; }
        public double Time { get; set; } = 0;
        public bool ManualMode { get { return PID.ManualMode; } set { PID.ManualMode = value; } } 
        public double SetPoint { get { return setPoint; } set { setPoint = limBlock_setpoint.Calc(value); } }
        public double G_hot { get { return g_hot; } set { g_hot = limBlock_G.Calc(value); } }
        public double T_hot_in { get { return t_hot_in; } set { t_hot_in = limBlock_T_hot.Calc(value); } }
        public double T_cold_in { get { return t_cold_in; } set { t_cold_in = limBlock_T_cold.Calc(value); } }
        public double G_cold { get{ return g_cold; } set { g_cold = limBlock_G.Calc(value); } }
        


        public ControlSystem(double dt)
        {
            this.dt = dt;
            PID  = new PIDBlock(dt);
            Heat = new HeatExchanger(dt);
        }

        public void Calc()
        {
            Output = Heat.CalcCold(g_hot, t_hot_in, t_cold_in, g_cold);
            var e = SetPoint - Output;
            var u = PID.Calc(e);
            if (!ManualMode)
            {
                G_hot = u;
            }
            else
            {
                PID.U_Manual = G_hot;
            }
            Time += dt;
        }
    }

}
