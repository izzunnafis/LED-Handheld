
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.lbHumidity = new System.Windows.Forms.Label();
            this.lbTemperature = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbOperator = new System.Windows.Forms.TextBox();
            this.tbModule = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.lbOperator = new System.Windows.Forms.Label();
            this.lbModule = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.rtbSerialData = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.lbPort = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.SuspendLayout();
            // 
            // tbHumidity
            // 
            this.tbHumidity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHumidity.Location = new System.Drawing.Point(124, 131);
            this.tbHumidity.Margin = new System.Windows.Forms.Padding(2);
            this.tbHumidity.Multiline = true;
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.Size = new System.Drawing.Size(68, 18);
            this.tbHumidity.TabIndex = 39;
            // 
            // tbTemperature
            // 
            this.tbTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemperature.Location = new System.Drawing.Point(124, 108);
            this.tbTemperature.Margin = new System.Windows.Forms.Padding(2);
            this.tbTemperature.Multiline = true;
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(68, 18);
            this.tbTemperature.TabIndex = 38;
            // 
            // lbHumidity
            // 
            this.lbHumidity.AutoSize = true;
            this.lbHumidity.BackColor = System.Drawing.SystemColors.Control;
            this.lbHumidity.ForeColor = System.Drawing.Color.Black;
            this.lbHumidity.Location = new System.Drawing.Point(34, 130);
            this.lbHumidity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHumidity.Name = "lbHumidity";
            this.lbHumidity.Size = new System.Drawing.Size(47, 13);
            this.lbHumidity.TabIndex = 37;
            this.lbHumidity.Text = "Humidity";
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.BackColor = System.Drawing.SystemColors.Control;
            this.lbTemperature.ForeColor = System.Drawing.Color.Black;
            this.lbTemperature.Location = new System.Drawing.Point(34, 107);
            this.lbTemperature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(67, 13);
            this.lbTemperature.TabIndex = 36;
            this.lbTemperature.Text = "Temperature";
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(220, 152);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(67, 28);
            this.btnStart.TabIndex = 34;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbOperator
            // 
            this.tbOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOperator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOperator.Location = new System.Drawing.Point(374, 77);
            this.tbOperator.Margin = new System.Windows.Forms.Padding(2);
            this.tbOperator.Multiline = true;
            this.tbOperator.Name = "tbOperator";
            this.tbOperator.Size = new System.Drawing.Size(116, 18);
            this.tbOperator.TabIndex = 32;
            this.tbOperator.Text = " ";
            this.tbOperator.UseWaitCursor = true;
            // 
            // tbModule
            // 
            this.tbModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModule.Location = new System.Drawing.Point(374, 49);
            this.tbModule.Margin = new System.Windows.Forms.Padding(2);
            this.tbModule.Multiline = true;
            this.tbModule.Name = "tbModule";
            this.tbModule.Size = new System.Drawing.Size(116, 18);
            this.tbModule.TabIndex = 31;
            this.tbModule.Text = " ";
            this.tbModule.UseWaitCursor = true;
            // 
            // tbDate
            // 
            this.tbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDate.Location = new System.Drawing.Point(374, 20);
            this.tbDate.Margin = new System.Windows.Forms.Padding(2);
            this.tbDate.Multiline = true;
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(116, 18);
            this.tbDate.TabIndex = 30;
            // 
            // lbOperator
            // 
            this.lbOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOperator.AutoSize = true;
            this.lbOperator.BackColor = System.Drawing.SystemColors.Control;
            this.lbOperator.ForeColor = System.Drawing.Color.Black;
            this.lbOperator.Location = new System.Drawing.Point(286, 77);
            this.lbOperator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOperator.Name = "lbOperator";
            this.lbOperator.Size = new System.Drawing.Size(62, 13);
            this.lbOperator.TabIndex = 29;
            this.lbOperator.Text = "Operator ID";
            this.lbOperator.Click += new System.EventHandler(this.lbOperator_Click);
            // 
            // lbModule
            // 
            this.lbModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbModule.AutoSize = true;
            this.lbModule.BackColor = System.Drawing.SystemColors.Control;
            this.lbModule.ForeColor = System.Drawing.Color.Black;
            this.lbModule.Location = new System.Drawing.Point(286, 49);
            this.lbModule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbModule.Name = "lbModule";
            this.lbModule.Size = new System.Drawing.Size(56, 13);
            this.lbModule.TabIndex = 28;
            this.lbModule.Text = "Module ID";
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbDate.ForeColor = System.Drawing.Color.Black;
            this.lbDate.Location = new System.Drawing.Point(286, 20);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(30, 13);
            this.lbDate.TabIndex = 27;
            this.lbDate.Text = "Date";
            // 
            // rtbSerialData
            // 
            this.rtbSerialData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSerialData.Location = new System.Drawing.Point(37, 512);
            this.rtbSerialData.Margin = new System.Windows.Forms.Padding(2);
            this.rtbSerialData.Name = "rtbSerialData";
            this.rtbSerialData.Size = new System.Drawing.Size(484, 28);
            this.rtbSerialData.TabIndex = 26;
            this.rtbSerialData.Text = "";
            this.rtbSerialData.TextChanged += new System.EventHandler(this.rtbSerialData_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(424, 466);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(67, 28);
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
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartData.Legends.Add(legend1);
            this.chartData.Location = new System.Drawing.Point(37, 187);
            this.chartData.Margin = new System.Windows.Forms.Padding(2);
            this.chartData.Name = "chartData";
            this.chartData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "V1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "V2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "V3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "V4";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "V5";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "V6";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "V7";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "V8";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "V9";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "VRef1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "VRef2";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "VOut1";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.Name = "VOut2";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Legend = "Legend1";
            series14.Name = "VOut3";
            this.chartData.Series.Add(series1);
            this.chartData.Series.Add(series2);
            this.chartData.Series.Add(series3);
            this.chartData.Series.Add(series4);
            this.chartData.Series.Add(series5);
            this.chartData.Series.Add(series6);
            this.chartData.Series.Add(series7);
            this.chartData.Series.Add(series8);
            this.chartData.Series.Add(series9);
            this.chartData.Series.Add(series10);
            this.chartData.Series.Add(series11);
            this.chartData.Series.Add(series12);
            this.chartData.Series.Add(series13);
            this.chartData.Series.Add(series14);
            this.chartData.Size = new System.Drawing.Size(454, 233);
            this.chartData.TabIndex = 24;
            this.chartData.Text = "chartData";
            // 
            // cbPort
            // 
            this.cbPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(124, 156);
            this.cbPort.Margin = new System.Windows.Forms.Padding(2);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(92, 21);
            this.cbPort.TabIndex = 23;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.BackColor = System.Drawing.SystemColors.Control;
            this.lbPort.ForeColor = System.Drawing.Color.Black;
            this.lbPort.Location = new System.Drawing.Point(34, 159);
            this.lbPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(57, 13);
            this.lbPort.TabIndex = 22;
            this.lbPort.Text = "Port Name";
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
            this.btnGridTable.Location = new System.Drawing.Point(440, 156);
            this.btnGridTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnGridTable.Name = "btnGridTable";
            this.btnGridTable.Size = new System.Drawing.Size(50, 28);
            this.btnGridTable.TabIndex = 69;
            this.btnGridTable.Text = "Grid OFF";
            this.btnGridTable.UseVisualStyleBackColor = true;
            this.btnGridTable.Click += new System.EventHandler(this.btnGridTable_Click);
            // 
            // btnHold
            // 
            this.btnHold.FlatAppearance.BorderSize = 0;
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Location = new System.Drawing.Point(291, 152);
            this.btnHold.Margin = new System.Windows.Forms.Padding(2);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(67, 28);
            this.btnHold.TabIndex = 70;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // cekV1
            // 
            this.cekV1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV1.AutoSize = true;
            this.cekV1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV1.ForeColor = System.Drawing.Color.White;
            this.cekV1.Location = new System.Drawing.Point(37, 433);
            this.cekV1.Margin = new System.Windows.Forms.Padding(2);
            this.cekV1.Name = "cekV1";
            this.cekV1.Size = new System.Drawing.Size(36, 17);
            this.cekV1.TabIndex = 72;
            this.cekV1.Text = "V1";
            this.cekV1.UseVisualStyleBackColor = true;
            // 
            // cekV2
            // 
            this.cekV2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV2.AutoSize = true;
            this.cekV2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV2.ForeColor = System.Drawing.Color.White;
            this.cekV2.Location = new System.Drawing.Point(37, 461);
            this.cekV2.Margin = new System.Windows.Forms.Padding(2);
            this.cekV2.Name = "cekV2";
            this.cekV2.Size = new System.Drawing.Size(36, 17);
            this.cekV2.TabIndex = 73;
            this.cekV2.Text = "V2";
            this.cekV2.UseVisualStyleBackColor = true;
            // 
            // cekV3
            // 
            this.cekV3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV3.AutoSize = true;
            this.cekV3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV3.ForeColor = System.Drawing.Color.White;
            this.cekV3.Location = new System.Drawing.Point(37, 490);
            this.cekV3.Margin = new System.Windows.Forms.Padding(2);
            this.cekV3.Name = "cekV3";
            this.cekV3.Size = new System.Drawing.Size(36, 17);
            this.cekV3.TabIndex = 74;
            this.cekV3.Text = "V3";
            this.cekV3.UseVisualStyleBackColor = true;
            // 
            // cekV6
            // 
            this.cekV6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV6.AutoSize = true;
            this.cekV6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV6.ForeColor = System.Drawing.Color.White;
            this.cekV6.Location = new System.Drawing.Point(87, 490);
            this.cekV6.Margin = new System.Windows.Forms.Padding(2);
            this.cekV6.Name = "cekV6";
            this.cekV6.Size = new System.Drawing.Size(36, 17);
            this.cekV6.TabIndex = 77;
            this.cekV6.Text = "V6";
            this.cekV6.UseVisualStyleBackColor = true;
            // 
            // cekV5
            // 
            this.cekV5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV5.AutoSize = true;
            this.cekV5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV5.ForeColor = System.Drawing.Color.White;
            this.cekV5.Location = new System.Drawing.Point(87, 461);
            this.cekV5.Margin = new System.Windows.Forms.Padding(2);
            this.cekV5.Name = "cekV5";
            this.cekV5.Size = new System.Drawing.Size(36, 17);
            this.cekV5.TabIndex = 76;
            this.cekV5.Text = "V5";
            this.cekV5.UseVisualStyleBackColor = true;
            // 
            // cekV4
            // 
            this.cekV4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV4.AutoSize = true;
            this.cekV4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV4.ForeColor = System.Drawing.Color.White;
            this.cekV4.Location = new System.Drawing.Point(87, 433);
            this.cekV4.Margin = new System.Windows.Forms.Padding(2);
            this.cekV4.Name = "cekV4";
            this.cekV4.Size = new System.Drawing.Size(36, 17);
            this.cekV4.TabIndex = 75;
            this.cekV4.Text = "V4";
            this.cekV4.UseVisualStyleBackColor = true;
            // 
            // cekV9
            // 
            this.cekV9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV9.AutoSize = true;
            this.cekV9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV9.ForeColor = System.Drawing.Color.White;
            this.cekV9.Location = new System.Drawing.Point(142, 490);
            this.cekV9.Margin = new System.Windows.Forms.Padding(2);
            this.cekV9.Name = "cekV9";
            this.cekV9.Size = new System.Drawing.Size(36, 17);
            this.cekV9.TabIndex = 80;
            this.cekV9.Text = "V9";
            this.cekV9.UseVisualStyleBackColor = true;
            // 
            // cekV8
            // 
            this.cekV8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV8.AutoSize = true;
            this.cekV8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV8.ForeColor = System.Drawing.Color.White;
            this.cekV8.Location = new System.Drawing.Point(142, 461);
            this.cekV8.Margin = new System.Windows.Forms.Padding(2);
            this.cekV8.Name = "cekV8";
            this.cekV8.Size = new System.Drawing.Size(36, 17);
            this.cekV8.TabIndex = 79;
            this.cekV8.Text = "V8";
            this.cekV8.UseVisualStyleBackColor = true;
            // 
            // cekV7
            // 
            this.cekV7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV7.AutoSize = true;
            this.cekV7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV7.ForeColor = System.Drawing.Color.White;
            this.cekV7.Location = new System.Drawing.Point(142, 433);
            this.cekV7.Margin = new System.Windows.Forms.Padding(2);
            this.cekV7.Name = "cekV7";
            this.cekV7.Size = new System.Drawing.Size(36, 17);
            this.cekV7.TabIndex = 78;
            this.cekV7.Text = "V7";
            this.cekV7.UseVisualStyleBackColor = true;
            // 
            // cekVOut3
            // 
            this.cekVOut3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekVOut3.AutoSize = true;
            this.cekVOut3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekVOut3.ForeColor = System.Drawing.Color.White;
            this.cekVOut3.Location = new System.Drawing.Point(212, 490);
            this.cekVOut3.Margin = new System.Windows.Forms.Padding(2);
            this.cekVOut3.Name = "cekVOut3";
            this.cekVOut3.Size = new System.Drawing.Size(53, 17);
            this.cekVOut3.TabIndex = 83;
            this.cekVOut3.Text = "VOut3";
            this.cekVOut3.UseVisualStyleBackColor = true;
            // 
            // cekVOut2
            // 
            this.cekVOut2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekVOut2.AutoSize = true;
            this.cekVOut2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekVOut2.ForeColor = System.Drawing.Color.White;
            this.cekVOut2.Location = new System.Drawing.Point(212, 461);
            this.cekVOut2.Margin = new System.Windows.Forms.Padding(2);
            this.cekVOut2.Name = "cekVOut2";
            this.cekVOut2.Size = new System.Drawing.Size(53, 17);
            this.cekVOut2.TabIndex = 82;
            this.cekVOut2.Text = "VOut2";
            this.cekVOut2.UseVisualStyleBackColor = true;
            // 
            // cekVOut1
            // 
            this.cekVOut1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekVOut1.AutoSize = true;
            this.cekVOut1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekVOut1.ForeColor = System.Drawing.Color.White;
            this.cekVOut1.Location = new System.Drawing.Point(212, 433);
            this.cekVOut1.Margin = new System.Windows.Forms.Padding(2);
            this.cekVOut1.Name = "cekVOut1";
            this.cekVOut1.Size = new System.Drawing.Size(53, 17);
            this.cekVOut1.TabIndex = 81;
            this.cekVOut1.Text = "VOut1";
            this.cekVOut1.UseVisualStyleBackColor = true;
            // 
            // cekVRef2
            // 
            this.cekVRef2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekVRef2.AutoSize = true;
            this.cekVRef2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekVRef2.ForeColor = System.Drawing.Color.White;
            this.cekVRef2.Location = new System.Drawing.Point(291, 461);
            this.cekVRef2.Margin = new System.Windows.Forms.Padding(2);
            this.cekVRef2.Name = "cekVRef2";
            this.cekVRef2.Size = new System.Drawing.Size(53, 17);
            this.cekVRef2.TabIndex = 85;
            this.cekVRef2.Text = "VRef2";
            this.cekVRef2.UseVisualStyleBackColor = true;
            // 
            // cekVRef1
            // 
            this.cekVRef1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekVRef1.AutoSize = true;
            this.cekVRef1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekVRef1.ForeColor = System.Drawing.Color.White;
            this.cekVRef1.Location = new System.Drawing.Point(291, 433);
            this.cekVRef1.Margin = new System.Windows.Forms.Padding(2);
            this.cekVRef1.Name = "cekVRef1";
            this.cekVRef1.Size = new System.Drawing.Size(53, 17);
            this.cekVRef1.TabIndex = 84;
            this.cekVRef1.Text = "VRef1";
            this.cekVRef1.UseVisualStyleBackColor = true;
            // 
            // FormReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(627, 539);
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
            this.Controls.Add(this.tbHumidity);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.lbHumidity);
            this.Controls.Add(this.lbTemperature);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbOperator);
            this.Controls.Add(this.tbModule);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.lbOperator);
            this.Controls.Add(this.lbModule);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.rtbSerialData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chartData);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.lbPort);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReal";
            this.Text = "Real Time";
            this.Load += new System.EventHandler(this.FormReal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbHumidity;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.Label lbHumidity;
        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbOperator;
        private System.Windows.Forms.TextBox tbModule;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label lbOperator;
        private System.Windows.Forms.Label lbModule;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.RichTextBox rtbSerialData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label lbPort;
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
    }
}