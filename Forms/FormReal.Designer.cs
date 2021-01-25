
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
            this.lbV1 = new System.Windows.Forms.Label();
            this.lbV2 = new System.Windows.Forms.Label();
            this.lbV3 = new System.Windows.Forms.Label();
            this.lbV6 = new System.Windows.Forms.Label();
            this.lbV5 = new System.Windows.Forms.Label();
            this.lbV4 = new System.Windows.Forms.Label();
            this.lbV9 = new System.Windows.Forms.Label();
            this.lbV8 = new System.Windows.Forms.Label();
            this.lbV7 = new System.Windows.Forms.Label();
            this.lbVOut3 = new System.Windows.Forms.Label();
            this.lbVOut2 = new System.Windows.Forms.Label();
            this.lbVOut1 = new System.Windows.Forms.Label();
            this.lbVRef2 = new System.Windows.Forms.Label();
            this.lbVRef1 = new System.Windows.Forms.Label();
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
            this.cboxLampType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(884, 454);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 60);
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
            this.btnSave.Location = new System.Drawing.Point(884, 588);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 60);
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
            this.btnGridTable.Location = new System.Drawing.Point(1063, 11);
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
            this.btnHold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHold.FlatAppearance.BorderSize = 0;
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.Location = new System.Drawing.Point(884, 521);
            this.btnHold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(200, 60);
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
            this.cekV1.Location = new System.Drawing.Point(463, 630);
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
            this.cekV2.Location = new System.Drawing.Point(463, 692);
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
            this.cekV3.Location = new System.Drawing.Point(463, 754);
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
            this.cekV6.Location = new System.Drawing.Point(604, 754);
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
            this.cekV5.Location = new System.Drawing.Point(604, 692);
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
            this.cekV4.Location = new System.Drawing.Point(604, 630);
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
            this.cekV9.Location = new System.Drawing.Point(749, 754);
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
            this.cekV8.Location = new System.Drawing.Point(749, 692);
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
            this.cekV7.Location = new System.Drawing.Point(749, 630);
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
            this.cekVOut3.Location = new System.Drawing.Point(67, 759);
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
            this.cekVOut2.Location = new System.Drawing.Point(67, 697);
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
            this.cekVOut1.Location = new System.Drawing.Point(67, 635);
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
            this.cekVRef2.Location = new System.Drawing.Point(263, 697);
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
            this.cekVRef1.Location = new System.Drawing.Point(263, 635);
            this.cekVRef1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekVRef1.Name = "cekVRef1";
            this.cekVRef1.Size = new System.Drawing.Size(65, 21);
            this.cekVRef1.TabIndex = 84;
            this.cekVRef1.Text = "VRef1";
            this.cekVRef1.UseVisualStyleBackColor = true;
            // 
            // lbV1
            // 
            this.lbV1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV1.AutoSize = true;
            this.lbV1.BackColor = System.Drawing.SystemColors.Control;
            this.lbV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV1.ForeColor = System.Drawing.Color.Black;
            this.lbV1.Location = new System.Drawing.Point(482, 617);
            this.lbV1.Name = "lbV1";
            this.lbV1.Size = new System.Drawing.Size(55, 36);
            this.lbV1.TabIndex = 86;
            this.lbV1.Text = "V1";
            this.lbV1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV2
            // 
            this.lbV2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV2.AutoSize = true;
            this.lbV2.BackColor = System.Drawing.SystemColors.Control;
            this.lbV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV2.ForeColor = System.Drawing.Color.Black;
            this.lbV2.Location = new System.Drawing.Point(482, 679);
            this.lbV2.Name = "lbV2";
            this.lbV2.Size = new System.Drawing.Size(55, 36);
            this.lbV2.TabIndex = 87;
            this.lbV2.Text = "V2";
            this.lbV2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV3
            // 
            this.lbV3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV3.AutoSize = true;
            this.lbV3.BackColor = System.Drawing.SystemColors.Control;
            this.lbV3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV3.ForeColor = System.Drawing.Color.Black;
            this.lbV3.Location = new System.Drawing.Point(482, 741);
            this.lbV3.Name = "lbV3";
            this.lbV3.Size = new System.Drawing.Size(55, 36);
            this.lbV3.TabIndex = 88;
            this.lbV3.Text = "V3";
            this.lbV3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV6
            // 
            this.lbV6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV6.AutoSize = true;
            this.lbV6.BackColor = System.Drawing.SystemColors.Control;
            this.lbV6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV6.ForeColor = System.Drawing.Color.Black;
            this.lbV6.Location = new System.Drawing.Point(623, 741);
            this.lbV6.Name = "lbV6";
            this.lbV6.Size = new System.Drawing.Size(55, 36);
            this.lbV6.TabIndex = 91;
            this.lbV6.Text = "V6";
            this.lbV6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV5
            // 
            this.lbV5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV5.AutoSize = true;
            this.lbV5.BackColor = System.Drawing.SystemColors.Control;
            this.lbV5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV5.ForeColor = System.Drawing.Color.Black;
            this.lbV5.Location = new System.Drawing.Point(623, 679);
            this.lbV5.Name = "lbV5";
            this.lbV5.Size = new System.Drawing.Size(55, 36);
            this.lbV5.TabIndex = 90;
            this.lbV5.Text = "V5";
            this.lbV5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV4
            // 
            this.lbV4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV4.AutoSize = true;
            this.lbV4.BackColor = System.Drawing.SystemColors.Control;
            this.lbV4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV4.ForeColor = System.Drawing.Color.Black;
            this.lbV4.Location = new System.Drawing.Point(623, 617);
            this.lbV4.Name = "lbV4";
            this.lbV4.Size = new System.Drawing.Size(55, 36);
            this.lbV4.TabIndex = 89;
            this.lbV4.Text = "V4";
            this.lbV4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV9
            // 
            this.lbV9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV9.AutoSize = true;
            this.lbV9.BackColor = System.Drawing.SystemColors.Control;
            this.lbV9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV9.ForeColor = System.Drawing.Color.Black;
            this.lbV9.Location = new System.Drawing.Point(767, 741);
            this.lbV9.Name = "lbV9";
            this.lbV9.Size = new System.Drawing.Size(55, 36);
            this.lbV9.TabIndex = 94;
            this.lbV9.Text = "V9";
            this.lbV9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV8
            // 
            this.lbV8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV8.AutoSize = true;
            this.lbV8.BackColor = System.Drawing.SystemColors.Control;
            this.lbV8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV8.ForeColor = System.Drawing.Color.Black;
            this.lbV8.Location = new System.Drawing.Point(767, 679);
            this.lbV8.Name = "lbV8";
            this.lbV8.Size = new System.Drawing.Size(55, 36);
            this.lbV8.TabIndex = 93;
            this.lbV8.Text = "V8";
            this.lbV8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV7
            // 
            this.lbV7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV7.AutoSize = true;
            this.lbV7.BackColor = System.Drawing.SystemColors.Control;
            this.lbV7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV7.ForeColor = System.Drawing.Color.Black;
            this.lbV7.Location = new System.Drawing.Point(767, 617);
            this.lbV7.Name = "lbV7";
            this.lbV7.Size = new System.Drawing.Size(55, 36);
            this.lbV7.TabIndex = 92;
            this.lbV7.Text = "V7";
            this.lbV7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVOut3
            // 
            this.lbVOut3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVOut3.AutoSize = true;
            this.lbVOut3.BackColor = System.Drawing.SystemColors.Control;
            this.lbVOut3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVOut3.ForeColor = System.Drawing.Color.Black;
            this.lbVOut3.Location = new System.Drawing.Point(86, 746);
            this.lbVOut3.Name = "lbVOut3";
            this.lbVOut3.Size = new System.Drawing.Size(123, 36);
            this.lbVOut3.TabIndex = 97;
            this.lbVOut3.Text = "VOut3  ";
            this.lbVOut3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVOut2
            // 
            this.lbVOut2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVOut2.AutoSize = true;
            this.lbVOut2.BackColor = System.Drawing.SystemColors.Control;
            this.lbVOut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVOut2.ForeColor = System.Drawing.Color.Black;
            this.lbVOut2.Location = new System.Drawing.Point(86, 684);
            this.lbVOut2.Name = "lbVOut2";
            this.lbVOut2.Size = new System.Drawing.Size(123, 36);
            this.lbVOut2.TabIndex = 96;
            this.lbVOut2.Text = "VOut2  ";
            this.lbVOut2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVOut1
            // 
            this.lbVOut1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVOut1.AutoSize = true;
            this.lbVOut1.BackColor = System.Drawing.SystemColors.Control;
            this.lbVOut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVOut1.ForeColor = System.Drawing.Color.Black;
            this.lbVOut1.Location = new System.Drawing.Point(86, 622);
            this.lbVOut1.Name = "lbVOut1";
            this.lbVOut1.Size = new System.Drawing.Size(114, 36);
            this.lbVOut1.TabIndex = 95;
            this.lbVOut1.Text = "VOut1 ";
            this.lbVOut1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVRef2
            // 
            this.lbVRef2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVRef2.AutoSize = true;
            this.lbVRef2.BackColor = System.Drawing.SystemColors.Control;
            this.lbVRef2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVRef2.ForeColor = System.Drawing.Color.Black;
            this.lbVRef2.Location = new System.Drawing.Point(281, 684);
            this.lbVRef2.Name = "lbVRef2";
            this.lbVRef2.Size = new System.Drawing.Size(122, 36);
            this.lbVRef2.TabIndex = 99;
            this.lbVRef2.Text = "VRef2  ";
            this.lbVRef2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVRef1
            // 
            this.lbVRef1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVRef1.AutoSize = true;
            this.lbVRef1.BackColor = System.Drawing.SystemColors.Control;
            this.lbVRef1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVRef1.ForeColor = System.Drawing.Color.Black;
            this.lbVRef1.Location = new System.Drawing.Point(281, 622);
            this.lbVRef1.Name = "lbVRef1";
            this.lbVRef1.Size = new System.Drawing.Size(113, 36);
            this.lbVRef1.TabIndex = 98;
            this.lbVRef1.Text = "VRef1 ";
            this.lbVRef1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbOperator
            // 
            this.tbOperator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tbSerialNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.textBox41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox41.Location = new System.Drawing.Point(825, 320);
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
            this.tbHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHumidity.Location = new System.Drawing.Point(1012, 320);
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
            this.textBox44.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox44.Location = new System.Drawing.Point(825, 275);
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
            this.tbTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemperature.Location = new System.Drawing.Point(1012, 275);
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
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(49, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 25);
            this.textBox1.TabIndex = 277;
            this.textBox1.Text = "Date";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(49, 71);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 25);
            this.textBox2.TabIndex = 278;
            this.textBox2.Text = "Serial Number";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(49, 111);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 25);
            this.textBox3.TabIndex = 279;
            this.textBox3.Text = "Operator";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(49, 151);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 25);
            this.textBox4.TabIndex = 280;
            this.textBox4.Text = "Port Name";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(49, 191);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(189, 25);
            this.textBox5.TabIndex = 282;
            this.textBox5.Text = "Lamp Type";
            // 
            // cboxLampType
            // 
            this.cboxLampType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxLampType.FormattingEnabled = true;
            this.cboxLampType.Items.AddRange(new object[] {
            "V3.0",
            "V3.1",
            "V4.0"});
            this.cboxLampType.Location = new System.Drawing.Point(255, 192);
            this.cboxLampType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxLampType.Name = "cboxLampType";
            this.cboxLampType.Size = new System.Drawing.Size(189, 24);
            this.cboxLampType.TabIndex = 281;
            // 
            // FormReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1160, 813);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.cboxLampType);
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
            this.Controls.Add(this.lbVRef2);
            this.Controls.Add(this.lbVRef1);
            this.Controls.Add(this.lbVOut3);
            this.Controls.Add(this.lbVOut2);
            this.Controls.Add(this.lbVOut1);
            this.Controls.Add(this.lbV9);
            this.Controls.Add(this.lbV8);
            this.Controls.Add(this.lbV7);
            this.Controls.Add(this.lbV6);
            this.Controls.Add(this.lbV5);
            this.Controls.Add(this.lbV4);
            this.Controls.Add(this.lbV3);
            this.Controls.Add(this.lbV2);
            this.Controls.Add(this.lbV1);
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
        private System.Windows.Forms.Label lbV1;
        private System.Windows.Forms.Label lbV2;
        private System.Windows.Forms.Label lbV3;
        private System.Windows.Forms.Label lbV6;
        private System.Windows.Forms.Label lbV5;
        private System.Windows.Forms.Label lbV4;
        private System.Windows.Forms.Label lbV9;
        private System.Windows.Forms.Label lbV8;
        private System.Windows.Forms.Label lbV7;
        private System.Windows.Forms.Label lbVOut3;
        private System.Windows.Forms.Label lbVOut2;
        private System.Windows.Forms.Label lbVOut1;
        private System.Windows.Forms.Label lbVRef2;
        private System.Windows.Forms.Label lbVRef1;
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
        private System.Windows.Forms.ComboBox cboxLampType;
    }
}