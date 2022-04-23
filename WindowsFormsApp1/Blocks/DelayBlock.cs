using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DelayBlock : BaseBlock
    {
        
        private int cnt;
        private double dt;
        private Queue<double> delayQueue =new Queue<double>();

        public DelayBlock(double dt, double tau)
        {
            if (tau >= dt)
            {
                cnt = (int)(tau / dt);
            }
            else
            {
                throw new Exception("Tau should be grater than 'dt'");
            }
        }
        public override double Calc(double x)
        {
            delayQueue.Enqueue(x);
            if (delayQueue.Count > cnt) 
            {
                return delayQueue.Dequeue();
            }
            else
                return 0;
        }
    }
}
