using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankProject1.Blocks
{
    public class DelayBlock : BaseBlock
    {
        private double dt;
        private int cnt;
        private Queue<double> delayQueue = new Queue<double>();
        public DelayBlock(double dt, double tau)
        {
            if (tau >= dt)
            {
                cnt = (int)(tau / dt);
            }
            else
            {
                throw new Exception("tau should be greater than dt");
            }
        }
        public override double Calc(double x)
        {
            delayQueue.Enqueue(x);
            if (delayQueue.Count > cnt)
            {
                return delayQueue.Dequeue();
            }
            else { return 0; }
        }
    }
}
