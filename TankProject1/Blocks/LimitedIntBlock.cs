using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankProject1.Blocks
{
    public class LimitedIntBlock : BaseBlock
    {
        private double prev = 0;
        private double dt;
        private double sum = 0;
        public double UpLimit { get; set; }
        public double DownLimit { get; set; }
        public LimitedIntBlock(double dt)
        {
            this.dt = dt;
        }
        public LimitedIntBlock(double dt, double downLimit, double upLimit)
        {
            this.dt = dt;
            UpLimit = upLimit;
            DownLimit = downLimit;
        }
        public override double Calc(double x)
        {
            sum += (prev + x) * dt / 2;
            sum = (sum > UpLimit) ? UpLimit : sum;
            sum = (sum < DownLimit) ? DownLimit : sum;
            prev = x;
            return sum;
        }
    }
}
