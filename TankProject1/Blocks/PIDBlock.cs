using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankProject1.Blocks
{
    public class PIDBlock : BaseBlock
    {
        private double prevX = 0;
        private double dt;
        private double intSum = 0;

        public double UpLimit { get; set; } = 100;
        public double DownLimit { get; set; } = 0;
        public bool ManualMode { get; set; } = false;
        public double Umanual { get; set; }
        public double U { get; set; }

        private double ki = 0.000001;

        public double Kp { get; set; }
        public double Ti
        {
            get { return 1 / ki; }
            set
            {
                if (value == 0) ki = double.MaxValue;
                else ki = 1 / value;
            }
        }
        public double Ki { get { return ki; } set { ki = value; } }
        public double Kd { get; set; } = 0;

        public PIDBlock(double dt)
        {
            this.dt = dt;
        }

        public override double Calc(double x)
        {
            if (ManualMode)
            {
                intSum = (Umanual - Kp * x - Kd * (x - prevX) / dt) / ki;
            }
            else
            {
                intSum += (prevX + x) * dt / 2;
            }
            var u = Kp * x + ki * intSum + Kd * (x - prevX) / dt;
            var limited = false;
            if (u > UpLimit)
            {
                u = UpLimit;
                limited = true;
            }
            if (u < DownLimit)
            {
                u = DownLimit;
                limited = true;
            }
            if (ki != 0 && limited)
            {
                intSum = (u - Kp * x - Kd * (x - prevX) / dt) / ki;
            }
            prevX = x;
            U = u;
            return U;
        }
    }
}
