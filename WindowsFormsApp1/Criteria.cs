using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Criteria
    {
        static public double dt = 0.01;
        static public double MaxTime = 10;
        static public double I2Criteria(double u1, double u2, double u3)
        {
            double sum = 0;

            var controlSyst = new ControlSystem(dt);
            controlSyst.PID.K = u1;
            controlSyst.PID.Ti = u2;
            controlSyst.PID.Td = u3;
            controlSyst.SetPoint = 5;
            var StepCount = (int)(MaxTime / dt);
            for(int i = 0; i < StepCount; i++)
            {
                controlSyst.Calc();
                sum += controlSyst.e * controlSyst.e * dt;
            }
            return sum;
        }
    }
}
