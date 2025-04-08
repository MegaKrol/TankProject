using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankProject1.Blocks
{
    public class IntBlock : BaseBlock
    {
        private double prev = 0;
        private double dt;
        private double sum = 0;
        public IntBlock(double dt)
        {
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
