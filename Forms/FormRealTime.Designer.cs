
namespace LED_Handheld_Project.Forms
{
    partial class FormRealTime
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtbSerialData = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbModule = new System.Windows.Forms.TextBox();
            this.tbOperator = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbVRef2 = new System.Windows.Forms.ComboBox();
            this.vbVRef1 = new System.Windows.Forms.ComboBox();
            this.lbVRef2 = new System.Windows.Forms.Label();
            this.lbVRef1 = new System.Windows.Forms.Label();
            this.cbVOut3 = new System.Windows.Forms.ComboBox();
            this.cbVOut2 = new System.Windows.Forms.ComboBox();
            this.cbOut1 = new System.Windows.Forms.ComboBox();
            this.lbVOut3 = new System.Windows.Forms.Label();
            this.lbVOut2 = new System.Windows.Forms.Label();
            this.lbVOut1 = new System.Windows.Forms.Label();
            this.cbV9 = new System.Windows.Forms.ComboBox();
            this.cbV8 = new System.Windows.Forms.ComboBox();
            this.cbV7 = new System.Windows.Forms.ComboBox();
            this.lbV9 = new System.Windows.Forms.Label();
            this.lbV8 = new System.Windows.Forms.Label();
            this.lbV7 = new System.Windows.Forms.Label();
            this.cbV6 = new System.Windows.Forms.ComboBox();
            this.cbV5 = new System.Windows.Forms.ComboBox();
            this.cbV4 = new System.Windows.Forms.ComboBox();
            this.lbV6 = new System.Windows.Forms.Label();
            this.lbV5 = new System.Windows.Forms.Label();
            this.lbV4 = new System.Windows.Forms.Label();
            this.cbV3 = new System.Windows.Forms.ComboBox();
            this.cbV2 = new System.Windows.Forms.ComboBox();
            this.cbV1 = new System.Windows.Forms.ComboBox();
            this.lbV3 = new System.Windows.Forms.Label();
            this.lbV2 = new System.Windows.Forms.Label();
            this.lbV1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.lbHumidity = new System.Windows.Forms.Label();
            this.lbTemperature = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(37, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port Name";
            // 
            // cbPort
            // 
            this.cbPort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(157, 216);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 24);
            this.cbPort.TabIndex = 2;
            // 
            // chartData
            // 
            this.chartData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartData.Legends.Add(legend2);
            this.chartData.Location = new System.Drawing.Point(40, 254);
            this.chartData.Name = "chartData";
            this.chartData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Legend = "Legend1";
            series15.Name = "V1";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series16.Legend = "Legend1";
            series16.Name = "V2";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series17.Legend = "Legend1";
            series17.Name = "V3";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series18.Legend = "Legend1";
            series18.Name = "V4";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series19.Legend = "Legend1";
            series19.Name = "V5";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series20.Legend = "Legend1";
            series20.Name = "V6";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Legend = "Legend1";
            series21.Name = "V7";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Legend = "Legend1";
            series22.Name = "V8";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Legend = "Legend1";
            series23.Name = "V9";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series24.Legend = "Legend1";
            series24.Name = "VOut1";
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series25.Legend = "Legend1";
            series25.Name = "VOut2";
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series26.Legend = "Legend1";
            series26.Name = "VOut3";
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series27.Legend = "Legend1";
            series27.Name = "VRef1";
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series28.Legend = "Legend1";
            series28.Name = "VRef2";
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
            this.chartData.Size = new System.Drawing.Size(790, 300);
            this.chartData.TabIndex = 5;
            this.chartData.Text = "chartData";
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(741, 728);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rtbSerialData
            // 
            this.rtbSerialData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSerialData.Location = new System.Drawing.Point(40, 728);
            this.rtbSerialData.Name = "rtbSerialData";
            this.rtbSerialData.Size = new System.Drawing.Size(646, 34);
            this.rtbSerialData.TabIndex = 7;
            this.rtbSerialData.Text = "";
            this.rtbSerialData.TextChanged += new System.EventHandler(this.rtbSerialData_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(546, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(546, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "ModuleID";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(546, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Operator ID";
            // 
            // tbDate
            // 
            this.tbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDate.Location = new System.Drawing.Point(665, 68);
            this.tbDate.Multiline = true;
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(155, 22);
            this.tbDate.TabIndex = 11;
            // 
            // tbModule
            // 
            this.tbModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModule.Location = new System.Drawing.Point(665, 103);
            this.tbModule.Multiline = true;
            this.tbModule.Name = "tbModule";
            this.tbModule.Size = new System.Drawing.Size(155, 22);
            this.tbModule.TabIndex = 12;
            // 
            // tbOperator
            // 
            this.tbOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOperator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOperator.Location = new System.Drawing.Point(665, 138);
            this.tbOperator.Multiline = true;
            this.tbOperator.Name = "tbOperator";
            this.tbOperator.Size = new System.Drawing.Size(155, 22);
            this.tbOperator.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cbVRef2);
            this.groupBox1.Controls.Add(this.vbVRef1);
            this.groupBox1.Controls.Add(this.lbVRef2);
            this.groupBox1.Controls.Add(this.lbVRef1);
            this.groupBox1.Controls.Add(this.cbVOut3);
            this.groupBox1.Controls.Add(this.cbVOut2);
            this.groupBox1.Controls.Add(this.cbOut1);
            this.groupBox1.Controls.Add(this.lbVOut3);
            this.groupBox1.Controls.Add(this.lbVOut2);
            this.groupBox1.Controls.Add(this.lbVOut1);
            this.groupBox1.Controls.Add(this.cbV9);
            this.groupBox1.Controls.Add(this.cbV8);
            this.groupBox1.Controls.Add(this.cbV7);
            this.groupBox1.Controls.Add(this.lbV9);
            this.groupBox1.Controls.Add(this.lbV8);
            this.groupBox1.Controls.Add(this.lbV7);
            this.groupBox1.Controls.Add(this.cbV6);
            this.groupBox1.Controls.Add(this.cbV5);
            this.groupBox1.Controls.Add(this.cbV4);
            this.groupBox1.Controls.Add(this.lbV6);
            this.groupBox1.Controls.Add(this.lbV5);
            this.groupBox1.Controls.Add(this.lbV4);
            this.groupBox1.Controls.Add(this.cbV3);
            this.groupBox1.Controls.Add(this.cbV2);
            this.groupBox1.Controls.Add(this.cbV1);
            this.groupBox1.Controls.Add(this.lbV3);
            this.groupBox1.Controls.Add(this.lbV2);
            this.groupBox1.Controls.Add(this.lbV1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(40, 569);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 153);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voltage Measurement";
            // 
            // cbVRef2
            // 
            this.cbVRef2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVRef2.FormattingEnabled = true;
            this.cbVRef2.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbVRef2.Location = new System.Drawing.Point(688, 69);
            this.cbVRef2.Name = "cbVRef2";
            this.cbVRef2.Size = new System.Drawing.Size(84, 24);
            this.cbVRef2.TabIndex = 28;
            // 
            // vbVRef1
            // 
            this.vbVRef1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbVRef1.FormattingEnabled = true;
            this.vbVRef1.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.vbVRef1.Location = new System.Drawing.Point(688, 31);
            this.vbVRef1.Name = "vbVRef1";
            this.vbVRef1.Size = new System.Drawing.Size(84, 24);
            this.vbVRef1.TabIndex = 27;
            // 
            // lbVRef2
            // 
            this.lbVRef2.AutoSize = true;
            this.lbVRef2.ForeColor = System.Drawing.Color.Black;
            this.lbVRef2.Location = new System.Drawing.Point(617, 73);
            this.lbVRef2.Name = "lbVRef2";
            this.lbVRef2.Size = new System.Drawing.Size(47, 17);
            this.lbVRef2.TabIndex = 25;
            this.lbVRef2.Text = "VRef2";
            // 
            // lbVRef1
            // 
            this.lbVRef1.AutoSize = true;
            this.lbVRef1.ForeColor = System.Drawing.Color.Black;
            this.lbVRef1.Location = new System.Drawing.Point(617, 35);
            this.lbVRef1.Name = "lbVRef1";
            this.lbVRef1.Size = new System.Drawing.Size(47, 17);
            this.lbVRef1.TabIndex = 24;
            this.lbVRef1.Text = "VRef1";
            // 
            // cbVOut3
            // 
            this.cbVOut3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVOut3.FormattingEnabled = true;
            this.cbVOut3.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbVOut3.Location = new System.Drawing.Point(494, 108);
            this.cbVOut3.Name = "cbVOut3";
            this.cbVOut3.Size = new System.Drawing.Size(84, 24);
            this.cbVOut3.TabIndex = 23;
            // 
            // cbVOut2
            // 
            this.cbVOut2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbVOut2.FormattingEnabled = true;
            this.cbVOut2.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbVOut2.Location = new System.Drawing.Point(494, 70);
            this.cbVOut2.Name = "cbVOut2";
            this.cbVOut2.Size = new System.Drawing.Size(84, 24);
            this.cbVOut2.TabIndex = 22;
            // 
            // cbOut1
            // 
            this.cbOut1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOut1.FormattingEnabled = true;
            this.cbOut1.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbOut1.Location = new System.Drawing.Point(494, 32);
            this.cbOut1.Name = "cbOut1";
            this.cbOut1.Size = new System.Drawing.Size(84, 24);
            this.cbOut1.TabIndex = 21;
            // 
            // lbVOut3
            // 
            this.lbVOut3.AutoSize = true;
            this.lbVOut3.ForeColor = System.Drawing.Color.Black;
            this.lbVOut3.Location = new System.Drawing.Point(435, 112);
            this.lbVOut3.Name = "lbVOut3";
            this.lbVOut3.Size = new System.Drawing.Size(48, 17);
            this.lbVOut3.TabIndex = 20;
            this.lbVOut3.Text = "VOut3";
            // 
            // lbVOut2
            // 
            this.lbVOut2.AutoSize = true;
            this.lbVOut2.ForeColor = System.Drawing.Color.Black;
            this.lbVOut2.Location = new System.Drawing.Point(435, 74);
            this.lbVOut2.Name = "lbVOut2";
            this.lbVOut2.Size = new System.Drawing.Size(48, 17);
            this.lbVOut2.TabIndex = 19;
            this.lbVOut2.Text = "VOut2";
            // 
            // lbVOut1
            // 
            this.lbVOut1.AutoSize = true;
            this.lbVOut1.ForeColor = System.Drawing.Color.Black;
            this.lbVOut1.Location = new System.Drawing.Point(435, 36);
            this.lbVOut1.Name = "lbVOut1";
            this.lbVOut1.Size = new System.Drawing.Size(48, 17);
            this.lbVOut1.TabIndex = 18;
            this.lbVOut1.Text = "VOut1";
            // 
            // cbV9
            // 
            this.cbV9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbV9.FormattingEnabled = true;
            this.cbV9.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbV9.Location = new System.Drawing.Point(324, 108);
            this.cbV9.Name = "cbV9";
            this.cbV9.Size = new System.Drawing.Size(84, 24);
            this.cbV9.TabIndex = 17;
            // 
            // cbV8
            // 
            this.cbV8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbV8.FormattingEnabled = true;
            this.cbV8.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbV8.Location = new System.Drawing.Point(324, 70);
            this.cbV8.Name = "cbV8";
            this.cbV8.Size = new System.Drawing.Size(84, 24);
            this.cbV8.TabIndex = 16;
            // 
            // cbV7
            // 
            this.cbV7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbV7.FormattingEnabled = true;
            this.cbV7.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbV7.Location = new System.Drawing.Point(324, 32);
            this.cbV7.Name = "cbV7";
            this.cbV7.Size = new System.Drawing.Size(84, 24);
            this.cbV7.TabIndex = 15;
            // 
            // lbV9
            // 
            this.lbV9.AutoSize = true;
            this.lbV9.ForeColor = System.Drawing.Color.Black;
            this.lbV9.Location = new System.Drawing.Point(290, 112);
            this.lbV9.Name = "lbV9";
            this.lbV9.Size = new System.Drawing.Size(25, 17);
            this.lbV9.TabIndex = 14;
            this.lbV9.Text = "V9";
            // 
            // lbV8
            // 
            this.lbV8.AutoSize = true;
            this.lbV8.ForeColor = System.Drawing.Color.Black;
            this.lbV8.Location = new System.Drawing.Point(290, 74);
            this.lbV8.Name = "lbV8";
            this.lbV8.Size = new System.Drawing.Size(25, 17);
            this.lbV8.TabIndex = 13;
            this.lbV8.Text = "V8";
            // 
            // lbV7
            // 
            this.lbV7.AutoSize = true;
            this.lbV7.ForeColor = System.Drawing.Color.Black;
            this.lbV7.Location = new System.Drawing.Point(290, 36);
            this.lbV7.Name = "lbV7";
            this.lbV7.Size = new System.Drawing.Size(25, 17);
            this.lbV7.TabIndex = 12;
            this.lbV7.Text = "V7";
            // 
            // cbV6
            // 
            this.cbV6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbV6.FormattingEnabled = true;
            this.cbV6.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbV6.Location = new System.Drawing.Point(185, 108);
            this.cbV6.Name = "cbV6";
            this.cbV6.Size = new System.Drawing.Size(84, 24);
            this.cbV6.TabIndex = 11;
            // 
            // cbV5
            // 
            this.cbV5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbV5.FormattingEnabled = true;
            this.cbV5.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbV5.Location = new System.Drawing.Point(185, 70);
            this.cbV5.Name = "cbV5";
            this.cbV5.Size = new System.Drawing.Size(84, 24);
            this.cbV5.TabIndex = 10;
            // 
            // cbV4
            // 
            this.cbV4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbV4.FormattingEnabled = true;
            this.cbV4.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbV4.Location = new System.Drawing.Point(185, 32);
            this.cbV4.Name = "cbV4";
            this.cbV4.Size = new System.Drawing.Size(84, 24);
            this.cbV4.TabIndex = 9;
            // 
            // lbV6
            // 
            this.lbV6.AutoSize = true;
            this.lbV6.ForeColor = System.Drawing.Color.Black;
            this.lbV6.Location = new System.Drawing.Point(151, 112);
            this.lbV6.Name = "lbV6";
            this.lbV6.Size = new System.Drawing.Size(25, 17);
            this.lbV6.TabIndex = 8;
            this.lbV6.Text = "V6";
            // 
            // lbV5
            // 
            this.lbV5.AutoSize = true;
            this.lbV5.ForeColor = System.Drawing.Color.Black;
            this.lbV5.Location = new System.Drawing.Point(151, 74);
            this.lbV5.Name = "lbV5";
            this.lbV5.Size = new System.Drawing.Size(25, 17);
            this.lbV5.TabIndex = 7;
            this.lbV5.Text = "V5";
            // 
            // lbV4
            // 
            this.lbV4.AutoSize = true;
            this.lbV4.ForeColor = System.Drawing.Color.Black;
            this.lbV4.Location = new System.Drawing.Point(151, 36);
            this.lbV4.Name = "lbV4";
            this.lbV4.Size = new System.Drawing.Size(25, 17);
            this.lbV4.TabIndex = 6;
            this.lbV4.Text = "V4";
            // 
            // cbV3
            // 
            this.cbV3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbV3.FormattingEnabled = true;
            this.cbV3.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbV3.Location = new System.Drawing.Point(40, 108);
            this.cbV3.Name = "cbV3";
            this.cbV3.Size = new System.Drawing.Size(84, 24);
            this.cbV3.TabIndex = 5;
            // 
            // cbV2
            // 
            this.cbV2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbV2.FormattingEnabled = true;
            this.cbV2.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbV2.Location = new System.Drawing.Point(40, 70);
            this.cbV2.Name = "cbV2";
            this.cbV2.Size = new System.Drawing.Size(84, 24);
            this.cbV2.TabIndex = 4;
            // 
            // cbV1
            // 
            this.cbV1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbV1.FormattingEnabled = true;
            this.cbV1.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbV1.Location = new System.Drawing.Point(40, 32);
            this.cbV1.Name = "cbV1";
            this.cbV1.Size = new System.Drawing.Size(84, 24);
            this.cbV1.TabIndex = 3;
            // 
            // lbV3
            // 
            this.lbV3.AutoSize = true;
            this.lbV3.ForeColor = System.Drawing.Color.Black;
            this.lbV3.Location = new System.Drawing.Point(6, 112);
            this.lbV3.Name = "lbV3";
            this.lbV3.Size = new System.Drawing.Size(25, 17);
            this.lbV3.TabIndex = 2;
            this.lbV3.Text = "V3";
            // 
            // lbV2
            // 
            this.lbV2.AutoSize = true;
            this.lbV2.ForeColor = System.Drawing.Color.Black;
            this.lbV2.Location = new System.Drawing.Point(6, 74);
            this.lbV2.Name = "lbV2";
            this.lbV2.Size = new System.Drawing.Size(25, 17);
            this.lbV2.TabIndex = 1;
            this.lbV2.Text = "V2";
            // 
            // lbV1
            // 
            this.lbV1.AutoSize = true;
            this.lbV1.ForeColor = System.Drawing.Color.Black;
            this.lbV1.Location = new System.Drawing.Point(6, 36);
            this.lbV1.Name = "lbV1";
            this.lbV1.Size = new System.Drawing.Size(25, 17);
            this.lbV1.TabIndex = 0;
            this.lbV1.Text = "V1";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(284, 211);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(89, 34);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(382, 211);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 34);
            this.btnStop.TabIndex = 17;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbHumidity
            // 
            this.tbHumidity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbHumidity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHumidity.Location = new System.Drawing.Point(156, 185);
            this.tbHumidity.Multiline = true;
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.Size = new System.Drawing.Size(26, 22);
            this.tbHumidity.TabIndex = 21;
            // 
            // tbTemperature
            // 
            this.tbTemperature.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemperature.Location = new System.Drawing.Point(156, 157);
            this.tbTemperature.Multiline = true;
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(26, 22);
            this.tbTemperature.TabIndex = 20;
            // 
            // lbHumidity
            // 
            this.lbHumidity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbHumidity.AutoSize = true;
            this.lbHumidity.BackColor = System.Drawing.SystemColors.Control;
            this.lbHumidity.ForeColor = System.Drawing.Color.Black;
            this.lbHumidity.Location = new System.Drawing.Point(37, 184);
            this.lbHumidity.Name = "lbHumidity";
            this.lbHumidity.Size = new System.Drawing.Size(62, 17);
            this.lbHumidity.TabIndex = 19;
            this.lbHumidity.Text = "Humidity";
            // 
            // lbTemperature
            // 
            this.lbTemperature.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.BackColor = System.Drawing.SystemColors.Control;
            this.lbTemperature.ForeColor = System.Drawing.Color.Black;
            this.lbTemperature.Location = new System.Drawing.Point(37, 156);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(90, 17);
            this.lbTemperature.TabIndex = 18;
            this.lbTemperature.Text = "Temperature";
            // 
            // FormRealTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(852, 783);
            this.Controls.Add(this.tbHumidity);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.lbHumidity);
            this.Controls.Add(this.lbTemperature);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbOperator);
            this.Controls.Add(this.tbModule);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbSerialData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chartData);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.label2);
            this.Name = "FormRealTime";
            this.Text = "Real Time Mode";
            this.Load += new System.EventHandler(this.FormRealTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbSerialData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbModule;
        private System.Windows.Forms.TextBox tbOperator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbV1;
        private System.Windows.Forms.Label lbV3;
        private System.Windows.Forms.Label lbV2;
        private System.Windows.Forms.Label lbV1;
        private System.Windows.Forms.ComboBox cbVRef2;
        private System.Windows.Forms.ComboBox vbVRef1;
        private System.Windows.Forms.Label lbVRef2;
        private System.Windows.Forms.Label lbVRef1;
        private System.Windows.Forms.ComboBox cbVOut3;
        private System.Windows.Forms.ComboBox cbVOut2;
        private System.Windows.Forms.ComboBox cbOut1;
        private System.Windows.Forms.Label lbVOut3;
        private System.Windows.Forms.Label lbVOut2;
        private System.Windows.Forms.Label lbVOut1;
        private System.Windows.Forms.ComboBox cbV9;
        private System.Windows.Forms.ComboBox cbV8;
        private System.Windows.Forms.ComboBox cbV7;
        private System.Windows.Forms.Label lbV9;
        private System.Windows.Forms.Label lbV8;
        private System.Windows.Forms.Label lbV7;
        private System.Windows.Forms.ComboBox cbV6;
        private System.Windows.Forms.ComboBox cbV5;
        private System.Windows.Forms.ComboBox cbV4;
        private System.Windows.Forms.Label lbV6;
        private System.Windows.Forms.Label lbV5;
        private System.Windows.Forms.Label lbV4;
        private System.Windows.Forms.ComboBox cbV3;
        private System.Windows.Forms.ComboBox cbV2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbHumidity;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.Label lbHumidity;
        private System.Windows.Forms.Label lbTemperature;
    }
}