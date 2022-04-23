using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private ComplexBlock complBlockHot;
        private ComplexBlock complBlockCold;
        private GainBlock gainBlock;
        private IntBlock intBlock;
        private APBlock apBlock;
        private LimitBlock limBlock_T_hot = new LimitBlock(60, 120);
        private LimitBlock limBlock_T_cold = new LimitBlock(5, 20);
        private LimitBlock limBlock_G = new LimitBlock(0, 1);

        DelayBlock delayBlock;

        private double x_cold_out;
        private double x_hot_out;
        private double time = 0;
        private double dt = 0.5;

        private double T_hot_out;
        private double T_cold_out;
        private double T_hot_in = 70;  // 70 degree Celsius
        private double T_cold_in = 10; // 10 degree Celsius
        private double G_hot = 0.2;    // 0.2 Kilogram per minute
        private double G_cold = 0.2;// // 0.2 Kilogram per minute


        public MainForm()
        {
            InitializeComponent();
            complBlockHot = new ComplexBlock();
            complBlockHot.Add(new DelayBlock(dt, 1));
            complBlockHot.Add(new GainBlock(1));
            complBlockHot.Add(new APBlock(dt,5));
            complBlockHot.Add(new APBlock(dt,15));
            complBlockHot.Add(new NoiseBlock(2));

            complBlockCold = new ComplexBlock();
            complBlockCold.Add(new DelayBlock(dt, 1));
            complBlockCold.Add(new GainBlock(1));
            complBlockCold.Add(new APBlock(dt, 5));
            complBlockCold.Add(new APBlock(dt, 13));
            complBlockCold.Add(new NoiseBlock(2));
        }
        private void tmModel_Tick(object sender, EventArgs e)
        {
            x_hot_out = 12 * G_hot + 0.38 * T_hot_in + 1.15 * T_cold_in - 2 * G_cold;
            x_cold_out = -10 * G_cold + 0.41 * T_hot_in + 0.95 * T_cold_in + 2.5 * G_hot;

            T_hot_out = complBlockHot.Calc(x_hot_out);
            T_cold_out=complBlockCold.Calc(x_cold_out);

            time += dt;
            chMainPlot.Series[0].Points.AddXY(time, T_cold_out);
            chMainPlot.Series[1].Points.AddXY(time, T_hot_out);


            label2.Text = T_hot_out.ToString("F2");
            label3.Text = G_hot.ToString("F2");
            label4.Text = T_hot_in.ToString("F2");
            label5.Text = T_cold_out.ToString("F2");
            label6.Text = G_cold.ToString("F2");
            label7.Text = T_cold_in.ToString("F2");
            tbX.Text = x_hot_out.ToString("F2");
            textBox1.Text = x_cold_out.ToString("F2");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            T_hot_in -= 1;
            T_hot_in = limBlock_T_hot.Calc(T_hot_in);
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            T_hot_in += 1;
            T_hot_in = limBlock_T_hot.Calc(T_hot_in);

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            tmModel.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tmModel.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmModel.Interval = 1000;
        }

        private void btnX10_Click(object sender, EventArgs e)
        {
            tmModel.Interval = 100;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            G_hot -= 0.1;
            G_hot = limBlock_G.Calc(G_hot);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            G_hot += 0.1;
            G_hot = limBlock_G.Calc(G_hot);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            T_cold_in += 1;
            T_cold_in = limBlock_T_cold.Calc(T_cold_in);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            T_cold_in -= 1;
            T_cold_in = limBlock_T_cold.Calc(T_cold_in);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            G_cold -= 0.1;
            G_hot = limBlock_G.Calc(G_cold);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            G_cold += 0.1;
            G_hot = limBlock_G.Calc(G_cold);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tmModel.Interval = 10;
        }
    }
}
