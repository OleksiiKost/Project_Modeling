using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class NoiseBlock : BaseBlock 
    {
        private double noise { get; set; }
        private Random rand;

        public NoiseBlock(double noise)
        {
            rand = new Random();
            this.noise = noise;
        }

        public override double Calc(double x)
        {
            var nn = x * noise / 100;
            return x + 2 * nn * rand.NextDouble() - nn;
        }

    }
}
