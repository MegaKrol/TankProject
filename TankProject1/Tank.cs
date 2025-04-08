using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TankProject1.Blocks;

namespace TankProject1
{
    public class Tank
    {
        private double dt = 1;
        private ComplexBlock tank;
        private LimitBlock limit = new LimitBlock(0, 100);

        private GainBlock gain1;
        private GainBlock gain2;

        private double y = 0;
        private double x1 = 0;
        private double x2 = 0;
        private double x3 = 1;

        public double Y { get { return y; } }
        public double X1 { get { return x1; } set {  x1 = limit.Calc(value); } }
        public double X2 { get { return x2; } set {  x2 = limit.Calc(value); } }
        public double X3  { get { return x3; } set { x3 = limit.Calc(value); } } 

        private double t;
        public double T
        {
            get { return t; }
            set
            {
                if (value == 0) throw new Exception("T can`t be 0");
                t = value;
            }
        }

        public Tank(double dt, double t, double K1, double K2)
        {
            this.dt = dt;
            tank = new ComplexBlock();
            tank.Add(new GainBlock(1 / t));
            tank.Add(new LimitedIntBlock(dt, 0, 10));
            this.dt = dt;
            gain1 = new GainBlock(K1);
            gain2 = new GainBlock(K2);
        }

        public double Calc()
        {
            y = tank.Calc(gain1.Calc(x1) + gain2.Calc(x2) - x3);
            return y;
        }
    }
}
