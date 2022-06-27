namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbSetPoint = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDn = new System.Windows.Forms.Button();
            this.chMainPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_T_hot_out = new System.Windows.Forms.Label();
            this.tmModel = new System.Windows.Forms.Timer(this.components);
            this.btnX1 = new System.Windows.Forms.Button();
            this.btnX10 = new System.Windows.Forms.Button();
            this.label_G_hot = new System.Windows.Forms.Label();
            this.label_T_hot_in = new System.Windows.Forms.Label();
            this.label_T_cold_out = new System.Windows.Forms.Label();
            this.label_G_cold_in = new System.Windows.Forms.Label();
            this.label_T_cold_in = new System.Windows.Forms.Label();
            this.btn_G_hot_in_Down = new System.Windows.Forms.Button();
            this.btn_G_hot_in_Up = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSetPdown = new System.Windows.Forms.Button();
            this.btnSetPup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnKdown = new System.Windows.Forms.Button();
            this.btnKup = new System.Windows.Forms.Button();
            this.tbK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTidown = new System.Windows.Forms.Button();
            this.btnTiup = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTddown = new System.Windows.Forms.Button();
            this.btnTdup = new System.Windows.Forms.Button();
            this.tbTd = new System.Windows.Forms.TextBox();
            this.tbTi = new System.Windows.Forms.TextBox();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnOptimization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chMainPlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(1089, 657);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(1200, 657);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 36);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbSetPoint
            // 
            this.tbSetPoint.Location = new System.Drawing.Point(1143, 37);
            this.tbSetPoint.Name = "tbSetPoint";
            this.tbSetPoint.Size = new System.Drawing.Size(99, 22);
            this.tbSetPoint.TabIndex = 2;
            this.tbSetPoint.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnUp
            // 
            this.btnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUp.Location = new System.Drawing.Point(390, 223);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(46, 26);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDn
            // 
            this.btnDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDn.Location = new System.Drawing.Point(390, 248);
            this.btnDn.Name = "btnDn";
            this.btnDn.Size = new System.Drawing.Size(46, 26);
            this.btnDn.TabIndex = 3;
            this.btnDn.Text = "↓";
            this.btnDn.UseVisualStyleBackColor = true;
            this.btnDn.Click += new System.EventHandler(this.button2_Click);
            // 
            // chMainPlot
            // 
            chartArea1.Name = "ChartArea1";
            this.chMainPlot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chMainPlot.Legends.Add(legend1);
            this.chMainPlot.Location = new System.Drawing.Point(16, 283);
            this.chMainPlot.Name = "chMainPlot";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "First";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Second";
            this.chMainPlot.Series.Add(series1);
            this.chMainPlot.Series.Add(series2);
            this.chMainPlot.Size = new System.Drawing.Size(1295, 368);
            this.chMainPlot.TabIndex = 5;
            this.chMainPlot.Text = "chart1";
            this.chMainPlot.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label_T_hot_out
            // 
            this.label_T_hot_out.AutoSize = true;
            this.label_T_hot_out.Location = new System.Drawing.Point(442, 18);
            this.label_T_hot_out.Name = "label_T_hot_out";
            this.label_T_hot_out.Size = new System.Drawing.Size(24, 16);
            this.label_T_hot_out.TabIndex = 7;
            this.label_T_hot_out.Text = "0.0";
            this.label_T_hot_out.Click += new System.EventHandler(this.label2_Click);
            // 
            // tmModel
            // 
            this.tmModel.Interval = 1000;
            this.tmModel.Tick += new System.EventHandler(this.tmModel_Tick);
            // 
            // btnX1
            // 
            this.btnX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnX1.Location = new System.Drawing.Point(16, 657);
            this.btnX1.Name = "btnX1";
            this.btnX1.Size = new System.Drawing.Size(105, 36);
            this.btnX1.TabIndex = 8;
            this.btnX1.Text = "x1";
            this.btnX1.UseVisualStyleBackColor = true;
            this.btnX1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnX10
            // 
            this.btnX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnX10.Location = new System.Drawing.Point(127, 657);
            this.btnX10.Name = "btnX10";
            this.btnX10.Size = new System.Drawing.Size(105, 36);
            this.btnX10.TabIndex = 9;
            this.btnX10.Text = "x10";
            this.btnX10.UseVisualStyleBackColor = true;
            this.btnX10.Click += new System.EventHandler(this.btnX10_Click);
            // 
            // label_G_hot
            // 
            this.label_G_hot.AutoSize = true;
            this.label_G_hot.Location = new System.Drawing.Point(442, 167);
            this.label_G_hot.Name = "label_G_hot";
            this.label_G_hot.Size = new System.Drawing.Size(24, 16);
            this.label_G_hot.TabIndex = 11;
            this.label_G_hot.Text = "0.0";
            // 
            // label_T_hot_in
            // 
            this.label_T_hot_in.AutoSize = true;
            this.label_T_hot_in.Location = new System.Drawing.Point(442, 238);
            this.label_T_hot_in.Name = "label_T_hot_in";
            this.label_T_hot_in.Size = new System.Drawing.Size(24, 16);
            this.label_T_hot_in.TabIndex = 12;
            this.label_T_hot_in.Text = "0.0";
            // 
            // label_T_cold_out
            // 
            this.label_T_cold_out.AutoSize = true;
            this.label_T_cold_out.Location = new System.Drawing.Point(997, 22);
            this.label_T_cold_out.Name = "label_T_cold_out";
            this.label_T_cold_out.Size = new System.Drawing.Size(24, 16);
            this.label_T_cold_out.TabIndex = 13;
            this.label_T_cold_out.Text = "0.0";
            // 
            // label_G_cold_in
            // 
            this.label_G_cold_in.AutoSize = true;
            this.label_G_cold_in.Location = new System.Drawing.Point(997, 167);
            this.label_G_cold_in.Name = "label_G_cold_in";
            this.label_G_cold_in.Size = new System.Drawing.Size(24, 16);
            this.label_G_cold_in.TabIndex = 14;
            this.label_G_cold_in.Text = "0.0";
            // 
            // label_T_cold_in
            // 
            this.label_T_cold_in.AutoSize = true;
            this.label_T_cold_in.Location = new System.Drawing.Point(997, 238);
            this.label_T_cold_in.Name = "label_T_cold_in";
            this.label_T_cold_in.Size = new System.Drawing.Size(24, 16);
            this.label_T_cold_in.TabIndex = 15;
            this.label_T_cold_in.Text = "0.0";
            // 
            // btn_G_hot_in_Down
            // 
            this.btn_G_hot_in_Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_G_hot_in_Down.Location = new System.Drawing.Point(390, 167);
            this.btn_G_hot_in_Down.Name = "btn_G_hot_in_Down";
            this.btn_G_hot_in_Down.Size = new System.Drawing.Size(46, 26);
            this.btn_G_hot_in_Down.TabIndex = 16;
            this.btn_G_hot_in_Down.Text = "↓";
            this.btn_G_hot_in_Down.UseVisualStyleBackColor = true;
            this.btn_G_hot_in_Down.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_G_hot_in_Up
            // 
            this.btn_G_hot_in_Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_G_hot_in_Up.Location = new System.Drawing.Point(390, 142);
            this.btn_G_hot_in_Up.Name = "btn_G_hot_in_Up";
            this.btn_G_hot_in_Up.Size = new System.Drawing.Size(46, 26);
            this.btn_G_hot_in_Up.TabIndex = 17;
            this.btn_G_hot_in_Up.Text = "↑";
            this.btn_G_hot_in_Up.UseVisualStyleBackColor = true;
            this.btn_G_hot_in_Up.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(1045, 167);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 26);
            this.button7.TabIndex = 22;
            this.button7.Text = "↓";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(1045, 142);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 26);
            this.button8.TabIndex = 23;
            this.button8.Text = "↑";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(1045, 248);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 26);
            this.button9.TabIndex = 24;
            this.button9.Text = "↓";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(1045, 223);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(42, 26);
            this.button10.TabIndex = 25;
            this.button10.Text = "↑";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(238, 657);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 36);
            this.button3.TabIndex = 27;
            this.button3.Text = "x100";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(482, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // btnSetPdown
            // 
            this.btnSetPdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetPdown.Location = new System.Drawing.Point(1248, 37);
            this.btnSetPdown.Name = "btnSetPdown";
            this.btnSetPdown.Size = new System.Drawing.Size(63, 26);
            this.btnSetPdown.TabIndex = 28;
            this.btnSetPdown.Text = "↓";
            this.btnSetPdown.UseVisualStyleBackColor = true;
            this.btnSetPdown.Click += new System.EventHandler(this.btnSetPdown_Click);
            // 
            // btnSetPup
            // 
            this.btnSetPup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetPup.Location = new System.Drawing.Point(1248, 12);
            this.btnSetPup.Name = "btnSetPup";
            this.btnSetPup.Size = new System.Drawing.Size(63, 26);
            this.btnSetPup.TabIndex = 29;
            this.btnSetPup.Text = "↑";
            this.btnSetPup.UseVisualStyleBackColor = true;
            this.btnSetPup.Click += new System.EventHandler(this.btnSetPup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "SetPoint";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "K";
            // 
            // btnKdown
            // 
            this.btnKdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKdown.Location = new System.Drawing.Point(136, 40);
            this.btnKdown.Name = "btnKdown";
            this.btnKdown.Size = new System.Drawing.Size(63, 26);
            this.btnKdown.TabIndex = 32;
            this.btnKdown.Text = "↓";
            this.btnKdown.UseVisualStyleBackColor = true;
            this.btnKdown.Click += new System.EventHandler(this.btnKdown_Click);
            // 
            // btnKup
            // 
            this.btnKup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKup.Location = new System.Drawing.Point(136, 15);
            this.btnKup.Name = "btnKup";
            this.btnKup.Size = new System.Drawing.Size(63, 26);
            this.btnKup.TabIndex = 33;
            this.btnKup.Text = "↑";
            this.btnKup.UseVisualStyleBackColor = true;
            this.btnKup.Click += new System.EventHandler(this.btnKup_Click);
            // 
            // tbK
            // 
            this.tbK.Location = new System.Drawing.Point(31, 40);
            this.tbK.Name = "tbK";
            this.tbK.Size = new System.Drawing.Size(99, 22);
            this.tbK.TabIndex = 31;
            this.tbK.TextChanged += new System.EventHandler(this.tbK_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Ti";
            this.label9.Click += new System.EventHandler(this.Ti_Click);
            // 
            // btnTidown
            // 
            this.btnTidown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTidown.Location = new System.Drawing.Point(136, 108);
            this.btnTidown.Name = "btnTidown";
            this.btnTidown.Size = new System.Drawing.Size(63, 26);
            this.btnTidown.TabIndex = 36;
            this.btnTidown.Text = "↓";
            this.btnTidown.UseVisualStyleBackColor = true;
            this.btnTidown.Click += new System.EventHandler(this.btnTidown_Click);
            // 
            // btnTiup
            // 
            this.btnTiup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTiup.Location = new System.Drawing.Point(136, 83);
            this.btnTiup.Name = "btnTiup";
            this.btnTiup.Size = new System.Drawing.Size(63, 26);
            this.btnTiup.TabIndex = 37;
            this.btnTiup.Text = "↑";
            this.btnTiup.UseVisualStyleBackColor = true;
            this.btnTiup.Click += new System.EventHandler(this.btnTiup_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Td";
            // 
            // btnTddown
            // 
            this.btnTddown.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTddown.Location = new System.Drawing.Point(136, 180);
            this.btnTddown.Name = "btnTddown";
            this.btnTddown.Size = new System.Drawing.Size(63, 26);
            this.btnTddown.TabIndex = 40;
            this.btnTddown.Text = "↓";
            this.btnTddown.UseVisualStyleBackColor = true;
            this.btnTddown.Click += new System.EventHandler(this.btnTddown_Click);
            // 
            // btnTdup
            // 
            this.btnTdup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTdup.Location = new System.Drawing.Point(136, 155);
            this.btnTdup.Name = "btnTdup";
            this.btnTdup.Size = new System.Drawing.Size(63, 26);
            this.btnTdup.TabIndex = 41;
            this.btnTdup.Text = "↑";
            this.btnTdup.UseVisualStyleBackColor = true;
            this.btnTdup.Click += new System.EventHandler(this.btnTdup_Click);
            // 
            // tbTd
            // 
            this.tbTd.Location = new System.Drawing.Point(31, 180);
            this.tbTd.Name = "tbTd";
            this.tbTd.Size = new System.Drawing.Size(99, 22);
            this.tbTd.TabIndex = 39;
            this.tbTd.TextChanged += new System.EventHandler(this.tbTd_TextChanged);
            // 
            // tbTi
            // 
            this.tbTi.Location = new System.Drawing.Point(31, 110);
            this.tbTi.Name = "tbTi";
            this.tbTi.Size = new System.Drawing.Size(99, 22);
            this.tbTi.TabIndex = 43;
            this.tbTi.TextChanged += new System.EventHandler(this.tbTi_TextChanged);
            // 
            // btnManual
            // 
            this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManual.Location = new System.Drawing.Point(357, 97);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(90, 26);
            this.btnManual.TabIndex = 44;
            this.btnManual.Text = "Auto";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnOptimization
            // 
            this.btnOptimization.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOptimization.Location = new System.Drawing.Point(1143, 137);
            this.btnOptimization.Name = "btnOptimization";
            this.btnOptimization.Size = new System.Drawing.Size(140, 80);
            this.btnOptimization.TabIndex = 45;
            this.btnOptimization.Text = "Optimization";
            this.btnOptimization.UseVisualStyleBackColor = true;
            this.btnOptimization.Click += new System.EventHandler(this.btnOptimization_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1323, 753);
            this.Controls.Add(this.btnOptimization);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.tbTi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnTddown);
            this.Controls.Add(this.btnTdup);
            this.Controls.Add(this.tbTd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTidown);
            this.Controls.Add(this.btnTiup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnKdown);
            this.Controls.Add(this.btnKup);
            this.Controls.Add(this.tbK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetPdown);
            this.Controls.Add(this.btnSetPup);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btn_G_hot_in_Down);
            this.Controls.Add(this.btn_G_hot_in_Up);
            this.Controls.Add(this.label_T_cold_in);
            this.Controls.Add(this.label_G_cold_in);
            this.Controls.Add(this.label_T_cold_out);
            this.Controls.Add(this.label_T_hot_in);
            this.Controls.Add(this.label_G_hot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnX10);
            this.Controls.Add(this.btnX1);
            this.Controls.Add(this.label_T_hot_out);
            this.Controls.Add(this.chMainPlot);
            this.Controls.Add(this.btnDn);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.tbSetPoint);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chMainPlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbSetPoint;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chMainPlot;
        private System.Windows.Forms.Label label_T_hot_out;
        private System.Windows.Forms.Timer tmModel;
        private System.Windows.Forms.Button btnX1;
        private System.Windows.Forms.Button btnX10;
        private System.Windows.Forms.Label label_G_hot;
        private System.Windows.Forms.Label label_T_hot_in;
        private System.Windows.Forms.Label label_T_cold_out;
        private System.Windows.Forms.Label label_G_cold_in;
        private System.Windows.Forms.Label label_T_cold_in;
        private System.Windows.Forms.Button btn_G_hot_in_Down;
        private System.Windows.Forms.Button btn_G_hot_in_Up;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSetPdown;
        private System.Windows.Forms.Button btnSetPup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnKdown;
        private System.Windows.Forms.Button btnKup;
        private System.Windows.Forms.TextBox tbK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTidown;
        private System.Windows.Forms.Button btnTiup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTddown;
        private System.Windows.Forms.Button btnTdup;
        private System.Windows.Forms.TextBox tbTd;
        private System.Windows.Forms.TextBox tbTi;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnOptimization;
    }
}

