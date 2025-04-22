using System.Runtime.CompilerServices;

namespace TankProject1
{
    public partial class MainForm : Form
    {
        private double dt = 1;
        private ControlSystem controlSystem;

        public MainForm()
        {
            InitializeComponent();
            controlSystem = new ControlSystem(dt);
            controlSystem.Kp = 3;
            controlSystem.Ti = 10;
            controlSystem.Kd = 0;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            modelTimer.Start();
            modelChart.Series[0].Points.Clear();
            modelChart.Series[1].Points.Clear();
            modelChart.Series[2].Points.Clear();
            modelChart.Series[3].Points.Clear();

            tbKp.Text = controlSystem.Kp.ToString("F2");
            tbTi.Text = controlSystem.Ti.ToString("F2");
            tbKd.Text = controlSystem.Kd.ToString("F2");
            tbSetPoint.Text = controlSystem.SetPoint.ToString("F2");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            modelTimer.Stop();
        }

        private void btnUp1_Click(object sender, EventArgs e)
        {
            ++controlSystem.Input1;
            tBx1.Text = controlSystem.Input1.ToString("F2");
        }

        private void btnDown1_Click(object sender, EventArgs e)
        {
            --controlSystem.Input1;
            tBx1.Text = controlSystem.Input1.ToString("F2");
        }

        private void btnUp2_Click(object sender, EventArgs e)
        {
            ++controlSystem.Input2;
            tBx2.Text = controlSystem.Input2.ToString("F2");
        }

        private void btnDown2_Click(object sender, EventArgs e)
        {
            --controlSystem.Input2;
            tBx2.Text = controlSystem.Input2.ToString("F2");
        }

        private void modelTimer_Tick(object sender, EventArgs e)
        {
            modelTimer.Start();
            modelChart.Series[0].Points.AddXY(controlSystem.Time, controlSystem.Output);
            modelChart.Series[1].Points.AddXY(controlSystem.Time, controlSystem.Input1);
            modelChart.Series[2].Points.AddXY(controlSystem.Time, controlSystem.Input2);
            modelChart.Series[3].Points.AddXY(controlSystem.Time, controlSystem.E);
            lbY.Text = "Y: " + controlSystem.Output.ToString("F2");
            tBx1.Text = controlSystem.Input1.ToString("F2");
            tBx2.Text = controlSystem.Input2.ToString("F2");
            controlSystem.Calc();
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

        private void tbSetPoint_TextChanged(object sender, EventArgs e)
        {
            double x;

            if (Double.TryParse(tbSetPoint.Text, out x))
            {
                controlSystem.SetPoint = x;
            }
        }

        private void tbKp_TextChanged(object sender, EventArgs e)
        {
            double x;

            if (Double.TryParse(tbKp.Text, out x))
            {
                controlSystem.Kp = x;
            }
        }

        private void tbTi_TextChanged(object sender, EventArgs e)
        {
            double x;

            if (Double.TryParse(tbTi.Text, out x))
            {
                controlSystem.Ti = x;
            }
        }

        private void tbKd_TextChanged(object sender, EventArgs e)
        {
            double x;

            if (Double.TryParse(tbKd.Text, out x))
            {
                controlSystem.Kd = x;
            }
        }

        private void modelChart_Click(object sender, EventArgs e)
        {

        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            controlSystem.ManualMode = !controlSystem.ManualMode;
            btnAuto.Text = controlSystem.ManualMode ? "Manual" : "Auto";
        }
    }
}
