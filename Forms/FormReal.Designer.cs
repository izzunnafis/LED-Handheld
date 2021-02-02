﻿
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
            this.rtbSerialData = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbVRef2 = new System.Windows.Forms.Label();
            this.lbVRef1 = new System.Windows.Forms.Label();
            this.lbVOut3 = new System.Windows.Forms.Label();
            this.lbVOut2 = new System.Windows.Forms.Label();
            this.lbVOut1 = new System.Windows.Forms.Label();
            this.lbV9 = new System.Windows.Forms.Label();
            this.lbV8 = new System.Windows.Forms.Label();
            this.lbV7 = new System.Windows.Forms.Label();
            this.lbV6 = new System.Windows.Forms.Label();
            this.lbV5 = new System.Windows.Forms.Label();
            this.lbV4 = new System.Windows.Forms.Label();
            this.lbV3 = new System.Windows.Forms.Label();
            this.lbV2 = new System.Windows.Forms.Label();
            this.lbV1 = new System.Windows.Forms.Label();
            this.cekVRef2 = new System.Windows.Forms.CheckBox();
            this.cekVRef1 = new System.Windows.Forms.CheckBox();
            this.cekVOut3 = new System.Windows.Forms.CheckBox();
            this.cekVOut2 = new System.Windows.Forms.CheckBox();
            this.cekVOut1 = new System.Windows.Forms.CheckBox();
            this.cekV9 = new System.Windows.Forms.CheckBox();
            this.cekV8 = new System.Windows.Forms.CheckBox();
            this.cekV7 = new System.Windows.Forms.CheckBox();
            this.cekV6 = new System.Windows.Forms.CheckBox();
            this.cekV5 = new System.Windows.Forms.CheckBox();
            this.cekV4 = new System.Windows.Forms.CheckBox();
            this.cekV3 = new System.Windows.Forms.CheckBox();
            this.cekV2 = new System.Windows.Forms.CheckBox();
            this.cekV1 = new System.Windows.Forms.CheckBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.cboxLampType = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbHumidity = new System.Windows.Forms.TextBox();
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.lbTemperature = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.tbOperator = new System.Windows.Forms.TextBox();
            this.tbSerialNumber = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.btnHold = new System.Windows.Forms.Button();
            this.btnGridTable = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.SuspendLayout();
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
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.cboxLampType);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbHumidity);
            this.panel1.Controls.Add(this.tbHumidity);
            this.panel1.Controls.Add(this.lbTemperature);
            this.panel1.Controls.Add(this.tbTemperature);
            this.panel1.Controls.Add(this.tbOperator);
            this.panel1.Controls.Add(this.tbSerialNumber);
            this.panel1.Controls.Add(this.tbDate);
            this.panel1.Controls.Add(this.btnHold);
            this.panel1.Controls.Add(this.btnGridTable);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.chartData);
            this.panel1.Controls.Add(this.cbPort);
            this.panel1.Controls.Add(this.lbVRef2);
            this.panel1.Controls.Add(this.lbVRef1);
            this.panel1.Controls.Add(this.lbVOut3);
            this.panel1.Controls.Add(this.lbVOut2);
            this.panel1.Controls.Add(this.lbVOut1);
            this.panel1.Controls.Add(this.lbV9);
            this.panel1.Controls.Add(this.lbV8);
            this.panel1.Controls.Add(this.lbV7);
            this.panel1.Controls.Add(this.lbV6);
            this.panel1.Controls.Add(this.lbV5);
            this.panel1.Controls.Add(this.lbV4);
            this.panel1.Controls.Add(this.lbV3);
            this.panel1.Controls.Add(this.lbV2);
            this.panel1.Controls.Add(this.lbV1);
            this.panel1.Controls.Add(this.cekVRef2);
            this.panel1.Controls.Add(this.cekVRef1);
            this.panel1.Controls.Add(this.cekVOut3);
            this.panel1.Controls.Add(this.cekVOut2);
            this.panel1.Controls.Add(this.cekVOut1);
            this.panel1.Controls.Add(this.cekV9);
            this.panel1.Controls.Add(this.cekV8);
            this.panel1.Controls.Add(this.cekV7);
            this.panel1.Controls.Add(this.cekV6);
            this.panel1.Controls.Add(this.cekV5);
            this.panel1.Controls.Add(this.cekV4);
            this.panel1.Controls.Add(this.cekV3);
            this.panel1.Controls.Add(this.cekV2);
            this.panel1.Controls.Add(this.cekV1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 813);
            this.panel1.TabIndex = 283;
            // 
            // lbVRef2
            // 
            this.lbVRef2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVRef2.AutoSize = true;
            this.lbVRef2.BackColor = System.Drawing.SystemColors.Control;
            this.lbVRef2.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVRef2.ForeColor = System.Drawing.Color.Black;
            this.lbVRef2.Location = new System.Drawing.Point(257, 696);
            this.lbVRef2.Name = "lbVRef2";
            this.lbVRef2.Size = new System.Drawing.Size(131, 41);
            this.lbVRef2.TabIndex = 127;
            this.lbVRef2.Text = "VRef2  ";
            this.lbVRef2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVRef1
            // 
            this.lbVRef1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVRef1.AutoSize = true;
            this.lbVRef1.BackColor = System.Drawing.SystemColors.Control;
            this.lbVRef1.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVRef1.ForeColor = System.Drawing.Color.Black;
            this.lbVRef1.Location = new System.Drawing.Point(257, 634);
            this.lbVRef1.Name = "lbVRef1";
            this.lbVRef1.Size = new System.Drawing.Size(116, 41);
            this.lbVRef1.TabIndex = 126;
            this.lbVRef1.Text = "VRef1 ";
            this.lbVRef1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVOut3
            // 
            this.lbVOut3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVOut3.AutoSize = true;
            this.lbVOut3.BackColor = System.Drawing.SystemColors.Control;
            this.lbVOut3.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVOut3.ForeColor = System.Drawing.Color.Black;
            this.lbVOut3.Location = new System.Drawing.Point(62, 758);
            this.lbVOut3.Name = "lbVOut3";
            this.lbVOut3.Size = new System.Drawing.Size(135, 41);
            this.lbVOut3.TabIndex = 125;
            this.lbVOut3.Text = "VOut3  ";
            this.lbVOut3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVOut2
            // 
            this.lbVOut2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVOut2.AutoSize = true;
            this.lbVOut2.BackColor = System.Drawing.SystemColors.Control;
            this.lbVOut2.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVOut2.ForeColor = System.Drawing.Color.Black;
            this.lbVOut2.Location = new System.Drawing.Point(62, 696);
            this.lbVOut2.Name = "lbVOut2";
            this.lbVOut2.Size = new System.Drawing.Size(135, 41);
            this.lbVOut2.TabIndex = 124;
            this.lbVOut2.Text = "VOut2  ";
            this.lbVOut2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVOut1
            // 
            this.lbVOut1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbVOut1.AutoSize = true;
            this.lbVOut1.BackColor = System.Drawing.SystemColors.Control;
            this.lbVOut1.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVOut1.ForeColor = System.Drawing.Color.Black;
            this.lbVOut1.Location = new System.Drawing.Point(62, 634);
            this.lbVOut1.Name = "lbVOut1";
            this.lbVOut1.Size = new System.Drawing.Size(119, 41);
            this.lbVOut1.TabIndex = 123;
            this.lbVOut1.Text = "VOut1 ";
            this.lbVOut1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV9
            // 
            this.lbV9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV9.AutoSize = true;
            this.lbV9.BackColor = System.Drawing.SystemColors.Control;
            this.lbV9.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV9.ForeColor = System.Drawing.Color.Black;
            this.lbV9.Location = new System.Drawing.Point(743, 753);
            this.lbV9.Name = "lbV9";
            this.lbV9.Size = new System.Drawing.Size(60, 41);
            this.lbV9.TabIndex = 122;
            this.lbV9.Text = "V9";
            this.lbV9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV8
            // 
            this.lbV8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV8.AutoSize = true;
            this.lbV8.BackColor = System.Drawing.SystemColors.Control;
            this.lbV8.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV8.ForeColor = System.Drawing.Color.Black;
            this.lbV8.Location = new System.Drawing.Point(743, 691);
            this.lbV8.Name = "lbV8";
            this.lbV8.Size = new System.Drawing.Size(59, 41);
            this.lbV8.TabIndex = 121;
            this.lbV8.Text = "V8";
            this.lbV8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV7
            // 
            this.lbV7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV7.AutoSize = true;
            this.lbV7.BackColor = System.Drawing.SystemColors.Control;
            this.lbV7.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV7.ForeColor = System.Drawing.Color.Black;
            this.lbV7.Location = new System.Drawing.Point(743, 629);
            this.lbV7.Name = "lbV7";
            this.lbV7.Size = new System.Drawing.Size(59, 41);
            this.lbV7.TabIndex = 120;
            this.lbV7.Text = "V7";
            this.lbV7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV6
            // 
            this.lbV6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV6.AutoSize = true;
            this.lbV6.BackColor = System.Drawing.SystemColors.Control;
            this.lbV6.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV6.ForeColor = System.Drawing.Color.Black;
            this.lbV6.Location = new System.Drawing.Point(599, 753);
            this.lbV6.Name = "lbV6";
            this.lbV6.Size = new System.Drawing.Size(59, 41);
            this.lbV6.TabIndex = 119;
            this.lbV6.Text = "V6";
            this.lbV6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV5
            // 
            this.lbV5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV5.AutoSize = true;
            this.lbV5.BackColor = System.Drawing.SystemColors.Control;
            this.lbV5.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV5.ForeColor = System.Drawing.Color.Black;
            this.lbV5.Location = new System.Drawing.Point(599, 691);
            this.lbV5.Name = "lbV5";
            this.lbV5.Size = new System.Drawing.Size(58, 41);
            this.lbV5.TabIndex = 118;
            this.lbV5.Text = "V5";
            this.lbV5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV4
            // 
            this.lbV4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV4.AutoSize = true;
            this.lbV4.BackColor = System.Drawing.SystemColors.Control;
            this.lbV4.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV4.ForeColor = System.Drawing.Color.Black;
            this.lbV4.Location = new System.Drawing.Point(599, 629);
            this.lbV4.Name = "lbV4";
            this.lbV4.Size = new System.Drawing.Size(59, 41);
            this.lbV4.TabIndex = 117;
            this.lbV4.Text = "V4";
            this.lbV4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV3
            // 
            this.lbV3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV3.AutoSize = true;
            this.lbV3.BackColor = System.Drawing.SystemColors.Control;
            this.lbV3.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV3.ForeColor = System.Drawing.Color.Black;
            this.lbV3.Location = new System.Drawing.Point(458, 753);
            this.lbV3.Name = "lbV3";
            this.lbV3.Size = new System.Drawing.Size(58, 41);
            this.lbV3.TabIndex = 116;
            this.lbV3.Text = "V3";
            this.lbV3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV2
            // 
            this.lbV2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV2.AutoSize = true;
            this.lbV2.BackColor = System.Drawing.SystemColors.Control;
            this.lbV2.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV2.ForeColor = System.Drawing.Color.Black;
            this.lbV2.Location = new System.Drawing.Point(458, 691);
            this.lbV2.Name = "lbV2";
            this.lbV2.Size = new System.Drawing.Size(58, 41);
            this.lbV2.TabIndex = 115;
            this.lbV2.Text = "V2";
            this.lbV2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbV1
            // 
            this.lbV1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbV1.AutoSize = true;
            this.lbV1.BackColor = System.Drawing.SystemColors.Control;
            this.lbV1.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbV1.ForeColor = System.Drawing.Color.Black;
            this.lbV1.Location = new System.Drawing.Point(458, 629);
            this.lbV1.Name = "lbV1";
            this.lbV1.Size = new System.Drawing.Size(53, 41);
            this.lbV1.TabIndex = 114;
            this.lbV1.Text = "V1";
            this.lbV1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cekVRef2
            // 
            this.cekVRef2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekVRef2.AutoSize = true;
            this.cekVRef2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekVRef2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekVRef2.ForeColor = System.Drawing.Color.White;
            this.cekVRef2.Location = new System.Drawing.Point(239, 709);
            this.cekVRef2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekVRef2.Name = "cekVRef2";
            this.cekVRef2.Size = new System.Drawing.Size(65, 21);
            this.cekVRef2.TabIndex = 113;
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
            this.cekVRef1.Location = new System.Drawing.Point(239, 647);
            this.cekVRef1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekVRef1.Name = "cekVRef1";
            this.cekVRef1.Size = new System.Drawing.Size(65, 21);
            this.cekVRef1.TabIndex = 112;
            this.cekVRef1.Text = "VRef1";
            this.cekVRef1.UseVisualStyleBackColor = true;
            // 
            // cekVOut3
            // 
            this.cekVOut3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekVOut3.AutoSize = true;
            this.cekVOut3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekVOut3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekVOut3.ForeColor = System.Drawing.Color.White;
            this.cekVOut3.Location = new System.Drawing.Point(43, 771);
            this.cekVOut3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekVOut3.Name = "cekVOut3";
            this.cekVOut3.Size = new System.Drawing.Size(66, 21);
            this.cekVOut3.TabIndex = 111;
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
            this.cekVOut2.Location = new System.Drawing.Point(43, 709);
            this.cekVOut2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekVOut2.Name = "cekVOut2";
            this.cekVOut2.Size = new System.Drawing.Size(66, 21);
            this.cekVOut2.TabIndex = 110;
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
            this.cekVOut1.Location = new System.Drawing.Point(43, 647);
            this.cekVOut1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekVOut1.Name = "cekVOut1";
            this.cekVOut1.Size = new System.Drawing.Size(66, 21);
            this.cekVOut1.TabIndex = 109;
            this.cekVOut1.Text = "VOut1";
            this.cekVOut1.UseVisualStyleBackColor = true;
            // 
            // cekV9
            // 
            this.cekV9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV9.AutoSize = true;
            this.cekV9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekV9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV9.ForeColor = System.Drawing.Color.White;
            this.cekV9.Location = new System.Drawing.Point(725, 766);
            this.cekV9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV9.Name = "cekV9";
            this.cekV9.Size = new System.Drawing.Size(43, 21);
            this.cekV9.TabIndex = 108;
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
            this.cekV8.Location = new System.Drawing.Point(725, 704);
            this.cekV8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV8.Name = "cekV8";
            this.cekV8.Size = new System.Drawing.Size(43, 21);
            this.cekV8.TabIndex = 107;
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
            this.cekV7.Location = new System.Drawing.Point(725, 642);
            this.cekV7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV7.Name = "cekV7";
            this.cekV7.Size = new System.Drawing.Size(43, 21);
            this.cekV7.TabIndex = 106;
            this.cekV7.Text = "V7";
            this.cekV7.UseVisualStyleBackColor = true;
            // 
            // cekV6
            // 
            this.cekV6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV6.AutoSize = true;
            this.cekV6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekV6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV6.ForeColor = System.Drawing.Color.White;
            this.cekV6.Location = new System.Drawing.Point(580, 766);
            this.cekV6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV6.Name = "cekV6";
            this.cekV6.Size = new System.Drawing.Size(43, 21);
            this.cekV6.TabIndex = 105;
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
            this.cekV5.Location = new System.Drawing.Point(580, 704);
            this.cekV5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV5.Name = "cekV5";
            this.cekV5.Size = new System.Drawing.Size(43, 21);
            this.cekV5.TabIndex = 104;
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
            this.cekV4.Location = new System.Drawing.Point(580, 642);
            this.cekV4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV4.Name = "cekV4";
            this.cekV4.Size = new System.Drawing.Size(43, 21);
            this.cekV4.TabIndex = 103;
            this.cekV4.Text = "V4";
            this.cekV4.UseVisualStyleBackColor = true;
            // 
            // cekV3
            // 
            this.cekV3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV3.AutoSize = true;
            this.cekV3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekV3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV3.ForeColor = System.Drawing.Color.White;
            this.cekV3.Location = new System.Drawing.Point(439, 766);
            this.cekV3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV3.Name = "cekV3";
            this.cekV3.Size = new System.Drawing.Size(43, 21);
            this.cekV3.TabIndex = 102;
            this.cekV3.Text = "V3";
            this.cekV3.UseVisualStyleBackColor = true;
            // 
            // cekV2
            // 
            this.cekV2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV2.AutoSize = true;
            this.cekV2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekV2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV2.ForeColor = System.Drawing.Color.White;
            this.cekV2.Location = new System.Drawing.Point(439, 704);
            this.cekV2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV2.Name = "cekV2";
            this.cekV2.Size = new System.Drawing.Size(43, 21);
            this.cekV2.TabIndex = 101;
            this.cekV2.Text = "V2";
            this.cekV2.UseVisualStyleBackColor = true;
            // 
            // cekV1
            // 
            this.cekV1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cekV1.AutoSize = true;
            this.cekV1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.cekV1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cekV1.ForeColor = System.Drawing.Color.White;
            this.cekV1.Location = new System.Drawing.Point(439, 642);
            this.cekV1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cekV1.Name = "cekV1";
            this.cekV1.Size = new System.Drawing.Size(43, 21);
            this.cekV1.TabIndex = 100;
            this.cekV1.Text = "V1";
            this.cekV1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(45, 191);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(189, 27);
            this.textBox5.TabIndex = 301;
            this.textBox5.Text = "Lamp Type";
            // 
            // cboxLampType
            // 
            this.cboxLampType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxLampType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxLampType.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxLampType.FormattingEnabled = true;
            this.cboxLampType.Items.AddRange(new object[] {
            "V3.0",
            "V3.1",
            "V4.0"});
            this.cboxLampType.Location = new System.Drawing.Point(251, 192);
            this.cboxLampType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxLampType.Name = "cboxLampType";
            this.cboxLampType.Size = new System.Drawing.Size(189, 26);
            this.cboxLampType.TabIndex = 300;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(45, 151);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 27);
            this.textBox4.TabIndex = 299;
            this.textBox4.Text = "Port Name";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(45, 111);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 27);
            this.textBox3.TabIndex = 298;
            this.textBox3.Text = "Operator";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(45, 71);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 27);
            this.textBox2.TabIndex = 297;
            this.textBox2.Text = "Serial Number";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(45, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 27);
            this.textBox1.TabIndex = 296;
            this.textBox1.Text = "Date";
            // 
            // lbHumidity
            // 
            this.lbHumidity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHumidity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbHumidity.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHumidity.Location = new System.Drawing.Point(821, 320);
            this.lbHumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbHumidity.Multiline = true;
            this.lbHumidity.Name = "lbHumidity";
            this.lbHumidity.Size = new System.Drawing.Size(181, 41);
            this.lbHumidity.TabIndex = 295;
            this.lbHumidity.Text = "Humidity";
            // 
            // tbHumidity
            // 
            this.tbHumidity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHumidity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHumidity.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHumidity.Location = new System.Drawing.Point(1008, 320);
            this.tbHumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHumidity.Multiline = true;
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.Size = new System.Drawing.Size(119, 41);
            this.tbHumidity.TabIndex = 294;
            this.tbHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTemperature
            // 
            this.lbTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbTemperature.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemperature.Location = new System.Drawing.Point(821, 275);
            this.lbTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbTemperature.Multiline = true;
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(181, 41);
            this.lbTemperature.TabIndex = 293;
            this.lbTemperature.Text = "Temperature";
            // 
            // tbTemperature
            // 
            this.tbTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTemperature.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemperature.Location = new System.Drawing.Point(1008, 275);
            this.tbTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTemperature.Multiline = true;
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(119, 41);
            this.tbTemperature.TabIndex = 292;
            this.tbTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbOperator
            // 
            this.tbOperator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOperator.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOperator.Location = new System.Drawing.Point(251, 113);
            this.tbOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOperator.Multiline = true;
            this.tbOperator.Name = "tbOperator";
            this.tbOperator.Size = new System.Drawing.Size(189, 27);
            this.tbOperator.TabIndex = 291;
            // 
            // tbSerialNumber
            // 
            this.tbSerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSerialNumber.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSerialNumber.Location = new System.Drawing.Point(251, 72);
            this.tbSerialNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSerialNumber.Multiline = true;
            this.tbSerialNumber.Name = "tbSerialNumber";
            this.tbSerialNumber.Size = new System.Drawing.Size(189, 27);
            this.tbSerialNumber.TabIndex = 290;
            // 
            // tbDate
            // 
            this.tbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDate.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDate.ForeColor = System.Drawing.Color.White;
            this.tbDate.Location = new System.Drawing.Point(251, 31);
            this.tbDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDate.Multiline = true;
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(189, 27);
            this.tbDate.TabIndex = 289;
            // 
            // btnHold
            // 
            this.btnHold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHold.FlatAppearance.BorderSize = 0;
            this.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHold.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.Location = new System.Drawing.Point(880, 458);
            this.btnHold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(200, 60);
            this.btnHold.TabIndex = 288;
            this.btnHold.Text = "Hold";
            this.btnHold.UseVisualStyleBackColor = true;
            // 
            // btnGridTable
            // 
            this.btnGridTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGridTable.FlatAppearance.BorderSize = 0;
            this.btnGridTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGridTable.Font = new System.Drawing.Font("Montserrat Medium", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGridTable.Location = new System.Drawing.Point(1059, 11);
            this.btnGridTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGridTable.Name = "btnGridTable";
            this.btnGridTable.Size = new System.Drawing.Size(85, 40);
            this.btnGridTable.TabIndex = 287;
            this.btnGridTable.Text = "Grid OFF";
            this.btnGridTable.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(880, 391);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 60);
            this.btnStart.TabIndex = 286;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(880, 525);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 60);
            this.btnSave.TabIndex = 285;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // chartData
            // 
            this.chartData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.chartData.BorderlineWidth = 0;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineWidth = 5;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineWidth = 5;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chartData.Legends.Add(legend1);
            this.chartData.Location = new System.Drawing.Point(-17, 275);
            this.chartData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartData.Name = "chartData";
            this.chartData.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "V1";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "V2";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "V3";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "V4";
            series5.BorderWidth = 5;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "V5";
            series6.BorderWidth = 5;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "V6";
            series7.BorderWidth = 5;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "V7";
            series8.BorderWidth = 5;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "V8";
            series9.BorderWidth = 5;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "V9";
            series10.BorderWidth = 5;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "VRef1";
            series11.BorderWidth = 5;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "VRef2";
            series12.BorderWidth = 5;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "VOut1";
            series13.BorderWidth = 5;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Legend1";
            series13.Name = "VOut2";
            series14.BorderWidth = 5;
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
            this.chartData.Size = new System.Drawing.Size(810, 323);
            this.chartData.TabIndex = 284;
            this.chartData.Text = "chartData";
            // 
            // cbPort
            // 
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPort.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(251, 154);
            this.cbPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(189, 26);
            this.cbPort.TabIndex = 283;
            // 
            // FormReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1160, 813);
            this.Controls.Add(this.rtbSerialData);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormReal";
            this.Text = "Real Time";
            this.Load += new System.EventHandler(this.FormReal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbSerialData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbVRef2;
        private System.Windows.Forms.Label lbVRef1;
        private System.Windows.Forms.Label lbVOut3;
        private System.Windows.Forms.Label lbVOut2;
        private System.Windows.Forms.Label lbVOut1;
        private System.Windows.Forms.Label lbV9;
        private System.Windows.Forms.Label lbV8;
        private System.Windows.Forms.Label lbV7;
        private System.Windows.Forms.Label lbV6;
        private System.Windows.Forms.Label lbV5;
        private System.Windows.Forms.Label lbV4;
        private System.Windows.Forms.Label lbV3;
        private System.Windows.Forms.Label lbV2;
        private System.Windows.Forms.Label lbV1;
        private System.Windows.Forms.CheckBox cekVRef2;
        private System.Windows.Forms.CheckBox cekVRef1;
        private System.Windows.Forms.CheckBox cekVOut3;
        private System.Windows.Forms.CheckBox cekVOut2;
        private System.Windows.Forms.CheckBox cekVOut1;
        private System.Windows.Forms.CheckBox cekV9;
        private System.Windows.Forms.CheckBox cekV8;
        private System.Windows.Forms.CheckBox cekV7;
        private System.Windows.Forms.CheckBox cekV6;
        private System.Windows.Forms.CheckBox cekV5;
        private System.Windows.Forms.CheckBox cekV4;
        private System.Windows.Forms.CheckBox cekV3;
        private System.Windows.Forms.CheckBox cekV2;
        private System.Windows.Forms.CheckBox cekV1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox cboxLampType;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox lbHumidity;
        private System.Windows.Forms.TextBox tbHumidity;
        private System.Windows.Forms.TextBox lbTemperature;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.TextBox tbOperator;
        private System.Windows.Forms.TextBox tbSerialNumber;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Button btnHold;
        private System.Windows.Forms.Button btnGridTable;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.ComboBox cbPort;
    }
}