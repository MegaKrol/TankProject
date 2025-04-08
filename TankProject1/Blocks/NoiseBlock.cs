using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankProject1.Blocks
{
    public class NoiseBlock : BaseBlock
    {
        private double noise { get; set; }
        private Random rand;

        public NoiseBlock(double noise)
        {
            this.noise = noise;
            rand = new Random();
        }

        public override double Calc(double x)
        {
            var nn = x * noise / 100;
            return x + 2 * nn * rand.NextDouble() - nn;
        }
    }
}
