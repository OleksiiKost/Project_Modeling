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
        private ControlSystem system;

        // Змінні Об'єкту Керування
        private double dt = 0.1;

        /*
        private double x_cold_out;
        private double x_hot_out;
        private double T_hot_out;
        private double T_cold_out;
        private double T_hot_in = 70;  // 70 degree Celsius
        private double T_cold_in = 10; // 10 degree Celsius
        private double G_hot = 0.2;    // 0.2 Kilogram per minute
        private double G_cold = 0.2;// // 0.2 Kilogram per minute
        */

        /*   Рівняння ОК
                x_hot_out = 12 * G_hot + 0.38 * T_hot_in + 1.15 * T_cold_in - 5 * G_cold;
                x_cold_out = -10 * G_cold + 0.41 * T_hot_in + 0.95 * T_cold_in + 10 * G_hot; 
         */

        public MainForm()
        {
            InitializeComponent();
            system = new ControlSystem(dt);

            btn_G_hot_in_Down.Enabled = system.ManualMode;
            btn_G_hot_in_Up.Enabled = system.ManualMode;
        }
        private void tmModel_Tick(object sender, EventArgs e)
        {
           
            system.Calc();

            system.Time += dt;
            chMainPlot.Series[0].Points.AddXY(system.Time, system.Output);
            chMainPlot.Series[1].Points.AddXY(system.Time, system.G_hot);


            label_T_hot_out.Text = system.Output.ToString("F2");
            label_T_cold_out.Text = system.Output.ToString("F2");

            label_T_hot_in.Text = system.T_hot_in.ToString("F2");
            label_G_hot.Text = system.G_hot.ToString("F2");
            label_G_cold_in.Text = system.G_cold.ToString("F2");
            label_T_cold_in.Text = system.T_cold_in.ToString("F2");

            system.SetPoint = Convert.ToDouble(tbSetPoint.Text);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            system.T_hot_in -= 1;
        }
        private void btnUp_Click(object sender, EventArgs e)
        {
            system.T_hot_in += 1;
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
            system.G_hot -= 1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            system.G_hot += 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            system.T_cold_in += 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            system.T_cold_in -= 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            system.G_cold -= 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            system.G_cold += 1;
        }
        private void btnSetPup_Click(object sender, EventArgs e)
        {
            system.SetPoint += 1;
            tbSetPoint.Text = system.SetPoint.ToString("F2");
        }

        private void btnSetPdown_Click(object sender, EventArgs e)
        {
            system.SetPoint -= 1;
            tbSetPoint.Text = system.SetPoint.ToString("F2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            tmModel.Interval = 10;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double value = 0;
            if (Double.TryParse(tbSetPoint.Text, out value))
            {
                system.SetPoint = value;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Ti_Click(object sender, EventArgs e)
        {

        }

        private void btnKup_Click(object sender, EventArgs e)
        {
            system.K += 1;
            tbK.Text = system.K.ToString("F2");
        }

        private void btnKdown_Click(object sender, EventArgs e)
        {
            system.K -= 1;
            tbK.Text = system.K.ToString("F2");
        }

        private void btnTiup_Click(object sender, EventArgs e)
        {
            system.Ti += 1;
            tbTi.Text = system.Ti.ToString("F2");
        }

        private void btnTidown_Click(object sender, EventArgs e)
        {
            system.Ti -= 1;
            tbTi.Text = system.Ti.ToString("F2");
        }

        private void btnTdup_Click(object sender, EventArgs e)
        {
            system.Td += 1;
            tbTd.Text = system.Td.ToString("F2");
        }

        private void btnTddown_Click(object sender, EventArgs e)
        {
            system.Td -= 1;
            tbTd.Text = system.Td.ToString("F2");
        }

        private void tbK_TextChanged(object sender, EventArgs e)
        {
            double value = 0;
            if (Double.TryParse(tbK.Text, out value))
            {
                system.K = value;
            }
        }

        private void tbTi_TextChanged(object sender, EventArgs e)
        {
            double value = 0;
            if (Double.TryParse(tbTi.Text, out value))
            {
                system.Ti = value;
            }
        }

        private void tbTd_TextChanged(object sender, EventArgs e)
        {
            double value = 0;
            if (Double.TryParse(tbTd.Text, out value))
            {
                system.Td = value;
            }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            system.ManualMode = !system.ManualMode;
            btnManual.Text = system.ManualMode ? "Manual" : "Auto";
            btn_G_hot_in_Down.Enabled = system.ManualMode;
            btn_G_hot_in_Up.Enabled = system.ManualMode;
        }
    }
}
