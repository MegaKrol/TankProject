using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TankProject1.Blocks;

namespace TankProject1
{
    public class ControlSystem
    {
        private double dt;
        private PIDBlock pid;
        private Tank Tank;
        private LimitBlock xLimit = new LimitBlock(0, 100);
        private LimitBlock levelLimit = new LimitBlock(0, 100);
        
        private double time = 0;
        public double Time { get {return time;} }

        private double input1;
        private double input2;
        public double Input1 { get { return Tank.X1; } set { Tank.X1 = value; } }
        public double Input2 { get { return Tank.X2; } set { Tank.X2 = value; } }

        public double Output { get { return Tank.Y; } }

        private double setPoint = 20;
        public double SetPoint { get { return setPoint; } set { setPoint = levelLimit.Calc(value); } }

        public double Kp { get { return pid.Kp; } set { pid.Kp = value; } }
        public double Ti { get { return pid.Ti; } set { pid.Ti = value; } }
        public double Kd { get { return pid.Kd; } set { pid.Kd = value; } }
        public bool ManualMode { get { return pid.ManualMode; } set { pid.ManualMode = value; } }

        public double E { get; set; }

        public ControlSystem(double dt)
        {
            this.dt = dt;
            pid = new PIDBlock(dt);
            Tank = new Tank(dt, 2, 1, -0.5);
        }


        public void Calc()
        {
            //var z = Tank.Calc(Input1, Input2);
            var z = Tank.Calc();
            E = SetPoint - z;
            var u = pid.Calc(E);
            if (!ManualMode)
            {
                Input1 = u;
            }
            else
            {
                pid.Umanual = Input1;
            }
            time += dt;
        }
    }
}
