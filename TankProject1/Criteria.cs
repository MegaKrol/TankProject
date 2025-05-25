using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TankProject1;

namespace SampleModel
{
    public class Criteria
    {
        public static double dt = 0.1;
        public static double maxTime = 100;
        public static double eps = 0.1;
        public static double I2Criteria(double[] vars)
        {
            double sum = 0;
            ControlSystem sys = new ControlSystem(dt);
            sys.pid.Kp = vars[0];
            sys.pid.Ti = vars[1];
            sys.pid.Kd = vars[2];
            sys.SetPoint = 5;
            var stepCnt = (int)(maxTime / dt);

            for (int i = 0; i < stepCnt; i++)
            {
                sys.Calc();
                sum += sys.E * sys.E * dt;
            }

            return sum;
        }
    }
}