
namespace LED_Handheld_Project.Forms
{
    partial class FormReal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStart = new System.Windows.Forms.Button();
            this.rtbSerialData = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnGridTable = new System.Windows.Forms.Button();
            this.btnHold = new System.Windows.Forms.Button();
            this.cekV1 = new System.Windows.Forms.CheckBox();
            this.cekV2 = new System.Windows.Forms.CheckBox();
            this.cekV3 = new System.Windows.Forms.CheckBox();
            this.cekV6 = new System.Windows.Forms.CheckBox();
            this.cekV5 = new System.Windows.Forms.CheckBox();
            this.cekV4 = new System.Windows.Forms.CheckBox();
            this.cekV9 = new System.Windows.Forms.CheckBox();
            this.cekV8 = new System.Windows.Forms.CheckBox();
            this.cekV7 = new System.Windows.Forms.CheckBox();
            this.cekVOut3 = new System.Windows.Forms.CheckBox();
            this.cekVOut2 = new System.Windows.Forms.CheckBox();
            this.cekVOut1 = new System.Windows.Forms.CheckBox();
            this.cekVRef2 = new System.Windows.Forms.CheckBox();
            this.cekVRef1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbOperator = new System.Windows.Forms.TextBox();
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(450, 189);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 30);
            this.btnStart.TabIndex = 34;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rtbSerialData
            // 
            this.rtbSerialData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSerialData.Location = new System.Drawing.Point(25, 346);
            this.rtbSerialData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbSerialData.Name = "rtbSerialData";
            this.rtbSerialData.Size = new System.Drawing.Size(724, 34);
            this.rtbSerialData.TabIndex = 26;
            this.rtbSerialData.Text = "";
            this.rtbSerialData.TextChanged += new System.EventHandler(this.rtbSerialData_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1008, 750);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 50);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chartData
            // 
            this.chartData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.chartData.BorderlineWidth = 0;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineWidth = 5;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineWidth = 5;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Legend1";
            this.chartData.Legends.Add(legend2);
            this.chartData.Location = new System.Drawing.Point(-13, 275);
            this.chartData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartData.Name = "chartData";
            this.chartData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series15.BorderWidth = 5;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Legend = "Legend1";
            series15.Name = "V1";
            series16.BorderWidth = 5;
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Legend = "Legend1";
            series16.Name = "V2";
            series17.BorderWidth = 5;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series17.Legend = "Legend1";
            series17.Name = "V3";
            series18.BorderWidth = 5;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series18.Legend = "Legend1";
            series18.Name = "V4";
            series19.BorderWidth = 5;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series19.Legend = "Legend1";
            series19.Name = "V5";
            series20.BorderWidth = 5;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.Legend = "Legend1";
            series20.Name = "V6";
            series21.BorderWidth = 5;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Legend = "Legend1";
            series21.Name = "V7";
            series22.BorderWidth = 5;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Legend = "Legend1";
            series22.Name = "V8";
            series23.BorderWidth = 5;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Legend = "Legend1";
            series23.Name = "V9";
            series24.BorderWidth = 5;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series24.Legend = "Legend1";
            series24.Name = "VRef1";
            series25.BorderWidth = 5;
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series25.Legend = "Legend1";
            series25.Name = "VRef2";
            series26.BorderWidth = 5;
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series26.Legend = "Legend1";
            series26.Name = "VOut1";
            series27.BorderWidth = 5;
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series27.Legend = "Legend1";
            series27.Name = "VOut2";
            series28.BorderWidth = 5;
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series28.Legend = "Legend1";
            series28.Name = "VOut3";
            this.chartData.Series.Add(series15);
            this.chartData.Series.Add(series16);
            this.chartData.Series.Add(series17);
            this.chartData.Series.Add(series18);
            this.chartData.Series.Add(series19);
            this.chartData.Series.Add(series20);
            this.chartData.Series.Add(series21);
            this.chartData.Series.Add(series22);
            this.chartData.Series.Add(series23);
            this.chartData.Series.Add(series24);
            this.chartData.Series.Add(series25);
            this.chartData.Series.Add(series26);
            this.chartData.Series.Add(series27);
            this.chartData.Series.Add(series28);
            this.chartData.Size = new System.Drawing.Size(810, 323);
            this.chartData.TabIndex = 24;
            this.chartData.Text = "chartData";
            // 
            // cbPort
            // 
            this.cbPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(255, 154);
            this.cbPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(189, 24);
            this.cbPort.TabIndex = 23;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnGridTable
            // 
            this.btnGridTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGridTable.FlatAppearance.BorderSize = 0;
            this.btnGridTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGridTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGridTable.Location = new System.Drawing.Point(712, 231);
            this.btnGridTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGridTable.Name = "btnGridTable";
            this.btnGridTable.Size = new System.Drawing.Size(85, 40);
            this.btnGridTable.TabIndex = 69;
            this.btnGridTable.Text = "Grid OFF";
            this.btnGridTable.UseVisualStyleBackColor = true;
            this.btnGridTable.Click += new System.EventHandler(this.btnGridTable_Click);
            // 
            // btnHold
            // 
            this.btnHold.FlatAppearance.BorderSize = 0;
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.Location = new System.Drawing.Point(536, 189);
            this.btnHold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(80, 30);
            this.btnHold.TabIndex = 70;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // cekV1
            // 
            this.cekV1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV1.AutoSize = true;
            this.cekV1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekV1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV1.ForeColor = System.Drawing.Color.White;
            this.cekV1.Location = new System.Drawing.Point(504, 630);
            this.cekV1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV1.Name = "cekV1";
            this.cekV1.Size = new System.Drawing.Size(43, 21);
            this.cekV1.TabIndex = 72;
            this.cekV1.Text = "V1";
            this.cekV1.UseVisualStyleBackColor = true;
            // 
            // cekV2
            // 
            this.cekV2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV2.AutoSize = true;
            this.cekV2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekV2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV2.ForeColor = System.Drawing.Color.White;
            this.cekV2.Location = new System.Drawing.Point(504, 692);
            this.cekV2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV2.Name = "cekV2";
            this.cekV2.Size = new System.Drawing.Size(43, 21);
            this.cekV2.TabIndex = 73;
            this.cekV2.Text = "V2";
            this.cekV2.UseVisualStyleBackColor = true;
            // 
            // cekV3
            // 
            this.cekV3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV3.AutoSize = true;
            this.cekV3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekV3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV3.ForeColor = System.Drawing.Color.White;
            this.cekV3.Location = new System.Drawing.Point(504, 754);
            this.cekV3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV3.Name = "cekV3";
            this.cekV3.Size = new System.Drawing.Size(43, 21);
            this.cekV3.TabIndex = 74;
            this.cekV3.Text = "V3";
            this.cekV3.UseVisualStyleBackColor = true;
            // 
            // cekV6
            // 
            this.cekV6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV6.AutoSize = true;
            this.cekV6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekV6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV6.ForeColor = System.Drawing.Color.White;
            this.cekV6.Location = new System.Drawing.Point(671, 754);
            this.cekV6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV6.Name = "cekV6";
            this.cekV6.Size = new System.Drawing.Size(43, 21);
            this.cekV6.TabIndex = 77;
            this.cekV6.Text = "V6";
            this.cekV6.UseVisualStyleBackColor = true;
            // 
            // cekV5
            // 
            this.cekV5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV5.AutoSize = true;
            this.cekV5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekV5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV5.ForeColor = System.Drawing.Color.White;
            this.cekV5.Location = new System.Drawing.Point(671, 692);
            this.cekV5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV5.Name = "cekV5";
            this.cekV5.Size = new System.Drawing.Size(43, 21);
            this.cekV5.TabIndex = 76;
            this.cekV5.Text = "V5";
            this.cekV5.UseVisualStyleBackColor = true;
            // 
            // cekV4
            // 
            this.cekV4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV4.AutoSize = true;
            this.cekV4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekV4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV4.ForeColor = System.Drawing.Color.White;
            this.cekV4.Location = new System.Drawing.Point(671, 630);
            this.cekV4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV4.Name = "cekV4";
            this.cekV4.Size = new System.Drawing.Size(43, 21);
            this.cekV4.TabIndex = 75;
            this.cekV4.Text = "V4";
            this.cekV4.UseVisualStyleBackColor = true;
            // 
            // cekV9
            // 
            this.cekV9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV9.AutoSize = true;
            this.cekV9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekV9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV9.ForeColor = System.Drawing.Color.White;
            this.cekV9.Location = new System.Drawing.Point(849, 754);
            this.cekV9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV9.Name = "cekV9";
            this.cekV9.Size = new System.Drawing.Size(43, 21);
            this.cekV9.TabIndex = 80;
            this.cekV9.Text = "V9";
            this.cekV9.UseVisualStyleBackColor = true;
            // 
            // cekV8
            // 
            this.cekV8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV8.AutoSize = true;
            this.cekV8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekV8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV8.ForeColor = System.Drawing.Color.White;
            this.cekV8.Location = new System.Drawing.Point(849, 692);
            this.cekV8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV8.Name = "cekV8";
            this.cekV8.Size = new System.Drawing.Size(43, 21);
            this.cekV8.TabIndex = 79;
            this.cekV8.Text = "V8";
            this.cekV8.UseVisualStyleBackColor = true;
            // 
            // cekV7
            // 
            this.cekV7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV7.AutoSize = true;
            this.cekV7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekV7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV7.ForeColor = System.Drawing.Color.White;
            this.cekV7.Location = new System.Drawing.Point(849, 630);
            this.cekV7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV7.Name = "cekV7";
            this.cekV7.Size = new System.Drawing.Size(43, 21);
            this.cekV7.TabIndex = 78;
            this.cekV7.Text = "V7";
            this.cekV7.UseVisualStyleBackColor = true;
            // 
            // cekVOut3
            // 
            this.cekVOut3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekVOut3.AutoSize = true;
            this.cekVOut3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekVOut3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekVOut3.ForeColor = System.Drawing.Color.White;
            this.cekVOut3.Location = new System.Drawing.Point(69, 759);
            this.cekVOut3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekVOut3.Name = "cekVOut3";
            this.cekVOut3.Size = new System.Drawing.Size(66, 21);
            this.cekVOut3.TabIndex = 83;
            this.cekVOut3.Text = "VOut3";
            this.cekVOut3.UseVisualStyleBackColor = true;
            // 
            // cekVOut2
            // 
            this.cekVOut2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekVOut2.AutoSize = true;
            this.cekVOut2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekVOut2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekVOut2.ForeColor = System.Drawing.Color.White;
            this.cekVOut2.Location = new System.Drawing.Point(69, 697);
            this.cekVOut2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekVOut2.Name = "cekVOut2";
            this.cekVOut2.Size = new System.Drawing.Size(66, 21);
            this.cekVOut2.TabIndex = 82;
            this.cekVOut2.Text = "VOut2";
            this.cekVOut2.UseVisualStyleBackColor = true;
            // 
            // cekVOut1
            // 
            this.cekVOut1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekVOut1.AutoSize = true;
            this.cekVOut1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekVOut1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekVOut1.ForeColor = System.Drawing.Color.White;
            this.cekVOut1.Location = new System.Drawing.Point(69, 635);
            this.cekVOut1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekVOut1.Name = "cekVOut1";
            this.cekVOut1.Size = new System.Drawing.Size(66, 21);
            this.cekVOut1.TabIndex = 81;
            this.cekVOut1.Text = "VOut1";
            this.cekVOut1.UseVisualStyleBackColor = true;
            // 
            // cekVRef2
            // 
            this.cekVRef2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekVRef2.AutoSize = true;
            this.cekVRef2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekVRef2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekVRef2.ForeColor = System.Drawing.Color.White;
            this.cekVRef2.Location = new System.Drawing.Point(297, 697);
            this.cekVRef2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekVRef2.Name = "cekVRef2";
            this.cekVRef2.Size = new System.Drawing.Size(65, 21);
            this.cekVRef2.TabIndex = 85;
            this.cekVRef2.Text = "VRef2";
            this.cekVRef2.UseVisualStyleBackColor = true;
            // 
            // cekVRef1
            // 
            this.cekVRef1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekVRef1.AutoSize = true;
            this.cekVRef1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekVRef1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekVRef1.ForeColor = System.Drawing.Color.White;
            this.cekVRef1.Location = new System.Drawing.Point(297, 635);
            this.cekVRef1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekVRef1.Name = "cekVRef1";
            this.cekVRef1.Size = new System.Drawing.Size(65, 21);
            this.cekVRef1.TabIndex = 84;
            this.cekVRef1.Text = "VRef1";
            this.cekVRef1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(523, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 41);
            this.label1.TabIndex = 86;
            this.label1.Text = "V1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(523, 679);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 41);
            this.label2.TabIndex = 87;
            this.label2.Text = "V2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(523, 741);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 41);
            this.label3.TabIndex = 88;
            this.label3.Text = "V3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(690, 741);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 41);
            this.label4.TabIndex = 91;
            this.label4.Text = "V6";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(690, 679);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 41);
            this.label5.TabIndex = 90;
            this.label5.Text = "V5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(690, 617);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 41);
            this.label6.TabIndex = 89;
            this.label6.Text = "V4";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(867, 741);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 41);
            this.label7.TabIndex = 94;
            this.label7.Text = "V9";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(867, 679);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 41);
            this.label8.TabIndex = 93;
            this.label8.Text = "V8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(867, 617);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 41);
            this.label9.TabIndex = 92;
            this.label9.Text = "V7";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(86, 746);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 41);
            this.label10.TabIndex = 97;
            this.label10.Text = "VOut3  ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(86, 684);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 41);
            this.label11.TabIndex = 96;
            this.label11.Text = "VOut2  ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(86, 622);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 41);
            this.label12.TabIndex = 95;
            this.label12.Text = "VOut1 ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(315, 684);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 41);
            this.label13.TabIndex = 99;
            this.label13.Text = "VRef2  ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Montserrat ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(315, 622);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 41);
            this.label14.TabIndex = 98;
            this.label14.Text = "VRef1 ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbOperator
            // 
            this.tbOperator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOperator.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOperator.Location = new System.Drawing.Point(255, 113);
            this.tbOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOperator.Multiline = true;
            this.tbOperator.Name = "tbOperator";
            this.tbOperator.Size = new System.Drawing.Size(189, 27);
            this.tbOperator.TabIndex = 121;
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSerialNumber.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSerialNumber.Location = new System.Drawing.Point(255, 72);
            this.tbSerialNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSerialNumber.Multiline = true;
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.Size = new System.Drawing.Size(189, 27);
            this.tbSerialNumber.TabIndex = 120;
            // 
            // tbDate
            // 
            this.tbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDate.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDate.ForeColor = System.Drawing.Color.White;
            this.tbDate.Location = new System.Drawing.Point(255, 31);
            this.tbDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDate.Multiline = true;
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(189, 27);
            this.tbDate.TabIndex = 119;
            // 
            // textBox41
            // 
            this.textBox41.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox41.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox41.Location = new System.Drawing.Point(822, 557);
            this.textBox41.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox41.Multiline = true;
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(181, 41);
            this.textBox41.TabIndex = 276;
            this.textBox41.Text = "Humidity";
            // 
            // tbHumidity
            // 
            this.tbHumidity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHumidity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHumidity.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHumidity.Location = new System.Drawing.Point(1009, 557);
            this.tbHumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHumidity.Multiline = true;
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.Size = new System.Drawing.Size(119, 41);
            this.tbHumidity.TabIndex = 275;
            this.tbHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox44
            // 
            this.textBox44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox44.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox44.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox44.Location = new System.Drawing.Point(822, 512);
            this.textBox44.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox44.Multiline = true;
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(181, 41);
            this.textBox44.TabIndex = 274;
            this.textBox44.Text = "Temperature";
            // 
            // tbTemperature
            // 
            this.tbTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTemperature.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemperature.Location = new System.Drawing.Point(1009, 512);
            this.tbTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTemperature.Multiline = true;
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(119, 41);
            this.tbTemperature.TabIndex = 273;
            this.tbTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(49, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 27);
            this.textBox1.TabIndex = 277;
            this.textBox1.Text = "Date";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(49, 71);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 27);
            this.textBox2.TabIndex = 278;
            this.textBox2.Text = "Serial Number";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(49, 111);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 27);
            this.textBox3.TabIndex = 279;
            this.textBox3.Text = "Operator";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(49, 151);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 27);
            this.textBox4.TabIndex = 280;
            this.textBox4.Text = "Port Name";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(49, 191);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(189, 27);
            this.textBox5.TabIndex = 282;
            this.textBox5.Text = "Lampu Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "V3.0",
            "V3.1",
            "V4.0"});
            this.comboBox1.Location = new System.Drawing.Point(255, 192);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 24);
            this.comboBox1.TabIndex = 281;
            // 
            // FormReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1160, 813);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox41);
            this.Controls.Add(this.tbHumidity);
            this.Controls.Add(this.textBox44);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.tbOperator);
            this.Controls.Add(this.tbSerialNumber);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cekVRef2);
            this.Controls.Add(this.cekVRef1);
            this.Controls.Add(this.cekVOut3);
            this.Controls.Add(this.cekVOut2);
            this.Controls.Add(this.cekVOut1);
            this.Controls.Add(this.cekV9);
            this.Controls.Add(this.cekV8);
            this.Controls.Add(this.cekV7);
            this.Controls.Add(this.cekV6);
            this.Controls.Add(this.cekV5);
            this.Controls.Add(this.cekV4);
            this.Controls.Add(this.cekV3);
            this.Controls.Add(this.cekV2);
            this.Controls.Add(this.cekV1);
            this.Controls.Add(this.btnHold);
            this.Controls.Add(this.btnGridTable);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rtbSerialData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chartData);
            this.Controls.Add(this.cbPort);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReal";
            this.Text = "Real Time";
            this.Load += new System.EventHandler(this.FormReal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox rtbSerialData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.ComboBox cbPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnGridTable;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.CheckBox cekV1;
        private System.Windows.Forms.CheckBox cekV2;
        private System.Windows.Forms.CheckBox cekV3;
        private System.Windows.Forms.CheckBox cekV6;
        private System.Windows.Forms.CheckBox cekV5;
        private System.Windows.Forms.CheckBox cekV4;
        private System.Windows.Forms.CheckBox cekV9;
        private System.Windows.Forms.CheckBox cekV8;
        private System.Windows.Forms.CheckBox cekV7;
        private System.Windows.Forms.CheckBox cekVOut3;
        private System.Windows.Forms.CheckBox cekVOut2;
        private System.Windows.Forms.CheckBox cekVOut1;
        private System.Windows.Forms.CheckBox cekVRef2;
        private System.Windows.Forms.CheckBox cekVRef1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbOperator;
        private System.Windows.Forms.TextBox tbSerialNumber;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox tbHumidity;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}