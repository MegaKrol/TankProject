namespace TankProject1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnStart = new Button();
            btnStop = new Button();
            modelTimer = new System.Windows.Forms.Timer(components);
            modelChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnX10 = new Button();
            pictureBox1 = new PictureBox();
            btnDown1 = new Button();
            btnUp1 = new Button();
            btnDown2 = new Button();
            btnUp2 = new Button();
            tBx1 = new TextBox();
            tBx2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)modelChart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(57, 647);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 34);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(1214, 647);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(112, 34);
            btnStop.TabIndex = 1;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // modelTimer
            // 
            modelTimer.Interval = 1000;
            modelTimer.Tick += modelTimer_Tick;
            // 
            // modelChart
            // 
            chartArea1.Name = "ChartArea1";
            modelChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            modelChart.Legends.Add(legend1);
            modelChart.Location = new Point(71, 193);
            modelChart.Name = "modelChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Y";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "X1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "X2";
            modelChart.Series.Add(series1);
            modelChart.Series.Add(series2);
            modelChart.Series.Add(series3);
            modelChart.Size = new Size(1255, 418);
            modelChart.TabIndex = 2;
            modelChart.Text = "chart1";
            // 
            // btnX10
            // 
            btnX10.Location = new Point(233, 647);
            btnX10.Name = "btnX10";
            btnX10.Size = new Size(112, 34);
            btnX10.TabIndex = 3;
            btnX10.Text = "x10";
            btnX10.UseVisualStyleBackColor = true;
            btnX10.Click += btnX10_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.photo_2025_03_26_02_41_30;
            pictureBox1.Location = new Point(559, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnDown1
            // 
            btnDown1.Location = new Point(404, 12);
            btnDown1.Name = "btnDown1";
            btnDown1.Size = new Size(34, 34);
            btnDown1.TabIndex = 5;
            btnDown1.Text = "<";
            btnDown1.UseVisualStyleBackColor = true;
            btnDown1.Click += btnDown1_Click;
            // 
            // btnUp1
            // 
            btnUp1.Location = new Point(520, 12);
            btnUp1.Name = "btnUp1";
            btnUp1.Size = new Size(34, 34);
            btnUp1.TabIndex = 6;
            btnUp1.Text = ">";
            btnUp1.UseVisualStyleBackColor = true;
            btnUp1.Click += btnUp1_Click;
            // 
            // btnDown2
            // 
            btnDown2.Location = new Point(404, 140);
            btnDown2.Name = "btnDown2";
            btnDown2.Size = new Size(34, 34);
            btnDown2.TabIndex = 7;
            btnDown2.Text = "<";
            btnDown2.UseVisualStyleBackColor = true;
            btnDown2.Click += btnDown2_Click;
            // 
            // btnUp2
            // 
            btnUp2.Location = new Point(520, 140);
            btnUp2.Name = "btnUp2";
            btnUp2.Size = new Size(34, 34);
            btnUp2.TabIndex = 8;
            btnUp2.Text = ">";
            btnUp2.UseVisualStyleBackColor = true;
            btnUp2.Click += btnUp2_Click;
            // 
            // tBx1
            // 
            tBx1.Location = new Point(442, 14);
            tBx1.Name = "tBx1";
            tBx1.Size = new Size(72, 31);
            tBx1.TabIndex = 9;
            // 
            // tBx2
            // 
            tBx2.Location = new Point(444, 142);
            tBx2.Name = "tBx2";
            tBx2.Size = new Size(72, 31);
            tBx2.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1400, 736);
            Controls.Add(tBx2);
            Controls.Add(tBx1);
            Controls.Add(btnUp2);
            Controls.Add(btnDown2);
            Controls.Add(btnUp1);
            Controls.Add(btnDown1);
            Controls.Add(pictureBox1);
            Controls.Add(btnX10);
            Controls.Add(modelChart);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)modelChart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private System.Windows.Forms.Timer modelTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart modelChart;
        private Button btnX10;
        private PictureBox pictureBox1;
        private Button btnDown1;
        private Button btnUp1;
        private Button btnDown2;
        private Button btnUp2;
        private TextBox tBx1;
        private TextBox tBx2;
    }
}
