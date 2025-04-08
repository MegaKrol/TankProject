using System.Runtime.CompilerServices;

namespace TankProject1
{
    public partial class MainForm : Form
    {
        private double dt = 1;
        private Tank tank;
        private double time = 0;

        public MainForm()
        {
            InitializeComponent();
            tank = new Tank(dt, 10, 1, -0.5);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            modelTimer.Start();
            modelChart.Series[0].Points.Clear();
            modelChart.Series[1].Points.Clear();
            modelChart.Series[2].Points.Clear();
            time = 0;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            modelTimer.Stop();
        }

        private void btnUp1_Click(object sender, EventArgs e)
        {
            ++tank.X1;
            tBx1.Text = tank.X1.ToString("F2");
        }

        private void btnDown1_Click(object sender, EventArgs e)
        {
            --tank.X1;
            tBx1.Text = tank.X1.ToString("F2");
        }

        private void btnUp2_Click(object sender, EventArgs e)
        {
            ++tank.X2;
            tBx2.Text = tank.X2.ToString("F2");
        }

        private void btnDown2_Click(object sender, EventArgs e)
        {
            --tank.X2;
            tBx2.Text = tank.X2.ToString("F2");
        }

        private void modelTimer_Tick(object sender, EventArgs e)
        {
            modelTimer.Start();
            modelChart.Series[0].Points.AddXY(time, tank.Y);
            modelChart.Series[1].Points.AddXY(time, tank.X1);
            modelChart.Series[2].Points.AddXY(time, tank.X2);
            tank.Calc();
            time += dt;
        }
        private void btnX10_Click(object sender, EventArgs e)
        {
            if (modelTimer.Interval == 100)
            {
                modelTimer.Interval = 1000;
                btnX10.Text = "x10";
            }
            else
            {
                modelTimer.Interval = 100;
                btnX10.Text = "x1";
            }
        }
    }
}
