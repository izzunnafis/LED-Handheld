
namespace LED_Handheld_Project.Forms
{
    partial class ProductTest
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbLampTypes = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_Humid = new System.Windows.Forms.TextBox();
            this.text_Temp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textTanggal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textOperatorID = new System.Windows.Forms.TextBox();
            this.textModuleID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.text_ResultV2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text_ResultV1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.text_V2 = new System.Windows.Forms.TextBox();
            this.text_V1 = new System.Windows.Forms.TextBox();
            this.text_ResultV9 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.text_ResultV8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.text_ResultV7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.text_ResultV6 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.text_ResultV5 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.text_ResultV4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.text_ResultV3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.text_V9 = new System.Windows.Forms.TextBox();
            this.text_V8 = new System.Windows.Forms.TextBox();
            this.text_V7 = new System.Windows.Forms.TextBox();
            this.text_V6 = new System.Windows.Forms.TextBox();
            this.text_V5 = new System.Windows.Forms.TextBox();
            this.text_V4 = new System.Windows.Forms.TextBox();
            this.text_V3 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.text_TestResult = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel6 = new System.Windows.Forms.Panel();
            this.text_VOut3 = new System.Windows.Forms.TextBox();
            this.text_VOut2 = new System.Windows.Forms.TextBox();
            this.text_VOut1 = new System.Windows.Forms.TextBox();
            this.text_VRef2 = new System.Windows.Forms.TextBox();
            this.text_VRef1 = new System.Windows.Forms.TextBox();
            this.text_ResultVRef1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.text_ResultVRef2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.text_ResultVOut1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.text_ResultVOut2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.text_ResultVOut3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(958, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 784);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(0, 720);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(204, 64);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Location = new System.Drawing.Point(0, 369);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(204, 64);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStop.Location = new System.Drawing.Point(0, 305);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(204, 64);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "&Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStart.Location = new System.Drawing.Point(0, 241);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(204, 64);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbLampTypes);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 241);
            this.panel2.TabIndex = 2;
            // 
            // cbLampTypes
            // 
            this.cbLampTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLampTypes.FormattingEnabled = true;
            this.cbLampTypes.Items.AddRange(new object[] {
            "V3.0",
            "V3.1",
            "V4.0"});
            this.cbLampTypes.Location = new System.Drawing.Point(45, 198);
            this.cbLampTypes.Name = "cbLampTypes";
            this.cbLampTypes.Size = new System.Drawing.Size(148, 24);
            this.cbLampTypes.TabIndex = 2;
            this.cbLampTypes.TextChanged += new System.EventHandler(this.cbLampTypes_TextChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Gainsboro;
            this.label22.Location = new System.Drawing.Point(42, 168);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(114, 24);
            this.label22.TabIndex = 3;
            this.label22.Text = "Lamp Types";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(42, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ports";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.text_Humid);
            this.panel3.Controls.Add(this.text_Temp);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textTanggal);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textOperatorID);
            this.panel3.Controls.Add(this.textModuleID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(958, 176);
            this.panel3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(205, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Humid";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(205, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Temp";
            // 
            // text_Humid
            // 
            this.text_Humid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Humid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Humid.Location = new System.Drawing.Point(308, 69);
            this.text_Humid.Name = "text_Humid";
            this.text_Humid.Size = new System.Drawing.Size(74, 30);
            this.text_Humid.TabIndex = 7;
            // 
            // text_Temp
            // 
            this.text_Temp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Temp.Location = new System.Drawing.Point(308, 26);
            this.text_Temp.Name = "text_Temp";
            this.text_Temp.Size = new System.Drawing.Size(74, 30);
            this.text_Temp.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(581, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date";
            // 
            // textTanggal
            // 
            this.textTanggal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textTanggal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTanggal.Location = new System.Drawing.Point(731, 12);
            this.textTanggal.Name = "textTanggal";
            this.textTanggal.Size = new System.Drawing.Size(147, 27);
            this.textTanggal.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(581, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Operator ID";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(581, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Module ID";
            // 
            // textOperatorID
            // 
            this.textOperatorID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textOperatorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOperatorID.Location = new System.Drawing.Point(731, 111);
            this.textOperatorID.Name = "textOperatorID";
            this.textOperatorID.Size = new System.Drawing.Size(147, 27);
            this.textOperatorID.TabIndex = 1;
            // 
            // textModuleID
            // 
            this.textModuleID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textModuleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textModuleID.Location = new System.Drawing.Point(731, 62);
            this.textModuleID.Name = "textModuleID";
            this.textModuleID.Size = new System.Drawing.Size(147, 27);
            this.textModuleID.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.text_ResultV2);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.text_ResultV1);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.text_V2);
            this.panel4.Controls.Add(this.text_V1);
            this.panel4.Location = new System.Drawing.Point(158, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 103);
            this.panel4.TabIndex = 2;
            // 
            // text_ResultV2
            // 
            this.text_ResultV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ResultV2.Location = new System.Drawing.Point(201, 65);
            this.text_ResultV2.Name = "text_ResultV2";
            this.text_ResultV2.Size = new System.Drawing.Size(100, 30);
            this.text_ResultV2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(48, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "V2";
            // 
            // text_ResultV1
            // 
            this.text_ResultV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ResultV1.Location = new System.Drawing.Point(201, 21);
            this.text_ResultV1.Name = "text_ResultV1";
            this.text_ResultV1.Size = new System.Drawing.Size(100, 30);
            this.text_ResultV1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(48, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "V1";
            // 
            // text_V2
            // 
            this.text_V2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_V2.Location = new System.Drawing.Point(95, 65);
            this.text_V2.Name = "text_V2";
            this.text_V2.Size = new System.Drawing.Size(100, 30);
            this.text_V2.TabIndex = 1;
            // 
            // text_V1
            // 
            this.text_V1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_V1.Location = new System.Drawing.Point(95, 21);
            this.text_V1.Name = "text_V1";
            this.text_V1.Size = new System.Drawing.Size(100, 30);
            this.text_V1.TabIndex = 0;
            // 
            // text_ResultV9
            // 
            this.text_ResultV9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ResultV9.Location = new System.Drawing.Point(201, 269);
            this.text_ResultV9.Name = "text_ResultV9";
            this.text_ResultV9.Size = new System.Drawing.Size(100, 30);
            this.text_ResultV9.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gainsboro;
            this.label15.Location = new System.Drawing.Point(48, 272);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 24);
            this.label15.TabIndex = 22;
            this.label15.Text = "V9";
            // 
            // text_ResultV8
            // 
            this.text_ResultV8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ResultV8.Location = new System.Drawing.Point(201, 225);
            this.text_ResultV8.Name = "text_ResultV8";
            this.text_ResultV8.Size = new System.Drawing.Size(100, 30);
            this.text_ResultV8.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gainsboro;
            this.label14.Location = new System.Drawing.Point(48, 228);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 24);
            this.label14.TabIndex = 21;
            this.label14.Text = "V8";
            // 
            // text_ResultV7
            // 
            this.text_ResultV7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ResultV7.Location = new System.Drawing.Point(201, 181);
            this.text_ResultV7.Name = "text_ResultV7";
            this.text_ResultV7.Size = new System.Drawing.Size(100, 30);
            this.text_ResultV7.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gainsboro;
            this.label13.Location = new System.Drawing.Point(48, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 24);
            this.label13.TabIndex = 20;
            this.label13.Text = "V7";
            // 
            // text_ResultV6
            // 
            this.text_ResultV6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ResultV6.Location = new System.Drawing.Point(201, 137);
            this.text_ResultV6.Name = "text_ResultV6";
            this.text_ResultV6.Size = new System.Drawing.Size(100, 30);
            this.text_ResultV6.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gainsboro;
            this.label12.Location = new System.Drawing.Point(48, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "V6";
            // 
            // text_ResultV5
            // 
            this.text_ResultV5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ResultV5.Location = new System.Drawing.Point(201, 93);
            this.text_ResultV5.Name = "text_ResultV5";
            this.text_ResultV5.Size = new System.Drawing.Size(100, 30);
            this.text_ResultV5.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gainsboro;
            this.label11.Location = new System.Drawing.Point(48, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "V5";
            // 
            // text_ResultV4
            // 
            this.text_ResultV4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ResultV4.Location = new System.Drawing.Point(201, 49);
            this.text_ResultV4.Name = "text_ResultV4";
            this.text_ResultV4.Size = new System.Drawing.Size(100, 30);
            this.text_ResultV4.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(48, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "V4";
            // 
            // text_ResultV3
            // 
            this.text_ResultV3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ResultV3.Location = new System.Drawing.Point(201, 5);
            this.text_ResultV3.Name = "text_ResultV3";
            this.text_ResultV3.Size = new System.Drawing.Size(100, 30);
            this.text_ResultV3.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(48, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "V3";
            // 
            // text_V9
            // 
            this.text_V9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_V9.Location = new System.Drawing.Point(95, 269);
            this.text_V9.Name = "text_V9";
            this.text_V9.Size = new System.Drawing.Size(100, 30);
            this.text_V9.TabIndex = 8;
            // 
            // text_V8
            // 
            this.text_V8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_V8.Location = new System.Drawing.Point(95, 225);
            this.text_V8.Name = "text_V8";
            this.text_V8.Size = new System.Drawing.Size(100, 30);
            this.text_V8.TabIndex = 7;
            // 
            // text_V7
            // 
            this.text_V7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_V7.Location = new System.Drawing.Point(95, 181);
            this.text_V7.Name = "text_V7";
            this.text_V7.Size = new System.Drawing.Size(100, 30);
            this.text_V7.TabIndex = 6;
            // 
            // text_V6
            // 
            this.text_V6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_V6.Location = new System.Drawing.Point(95, 137);
            this.text_V6.Name = "text_V6";
            this.text_V6.Size = new System.Drawing.Size(100, 30);
            this.text_V6.TabIndex = 5;
            // 
            // text_V5
            // 
            this.text_V5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_V5.Location = new System.Drawing.Point(95, 93);
            this.text_V5.Name = "text_V5";
            this.text_V5.Size = new System.Drawing.Size(100, 30);
            this.text_V5.TabIndex = 4;
            // 
            // text_V4
            // 
            this.text_V4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_V4.Location = new System.Drawing.Point(95, 49);
            this.text_V4.Name = "text_V4";
            this.text_V4.Size = new System.Drawing.Size(100, 30);
            this.text_V4.TabIndex = 3;
            // 
            // text_V3
            // 
            this.text_V3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_V3.Location = new System.Drawing.Point(95, 5);
            this.text_V3.Name = "text_V3";
            this.text_V3.Size = new System.Drawing.Size(100, 30);
            this.text_V3.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Gainsboro;
            this.label21.Location = new System.Drawing.Point(324, 668);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(135, 29);
            this.label21.TabIndex = 28;
            this.label21.Text = "Test Result";
            // 
            // text_TestResult
            // 
            this.text_TestResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_TestResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_TestResult.Location = new System.Drawing.Point(497, 663);
            this.text_TestResult.Name = "text_TestResult";
            this.text_TestResult.Size = new System.Drawing.Size(284, 38);
            this.text_TestResult.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.text_ResultV9);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.text_V3);
            this.panel6.Controls.Add(this.text_ResultV8);
            this.panel6.Controls.Add(this.text_V4);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.text_V5);
            this.panel6.Controls.Add(this.text_ResultV7);
            this.panel6.Controls.Add(this.text_V6);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.text_V7);
            this.panel6.Controls.Add(this.text_ResultV6);
            this.panel6.Controls.Add(this.text_V8);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.text_V9);
            this.panel6.Controls.Add(this.text_ResultV5);
            this.panel6.Controls.Add(this.text_ResultV3);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.text_ResultV4);
            this.panel6.Location = new System.Drawing.Point(158, 312);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(325, 323);
            this.panel6.TabIndex = 29;
            // 
            // text_VOut3
            // 
            this.text_VOut3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_VOut3.Location = new System.Drawing.Point(112, 197);
            this.text_VOut3.Name = "text_VOut3";
            this.text_VOut3.Size = new System.Drawing.Size(100, 30);
            this.text_VOut3.TabIndex = 13;
            // 
            // text_VOut2
            // 
            this.text_VOut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_VOut2.Location = new System.Drawing.Point(112, 153);
            this.text_VOut2.Name = "text_VOut2";
            this.text_VOut2.Size = new System.Drawing.Size(100, 30);
            this.text_VOut2.TabIndex = 12;
            // 
            // text_VOut1
            // 
            this.text_VOut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_VOut1.Location = new System.Drawing.Point(112, 109);
            this.text_VOut1.Name = "text_VOut1";
            this.text_VOut1.Size = new System.Drawing.Size(100, 30);
            this.text_VOut1.TabIndex = 11;
            // 
            // text_VRef2
            // 
            this.text_VRef2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_VRef2.Location = new System.Drawing.Point(112, 65);
            this.text_VRef2.Name = "text_VRef2";
            this.text_VRef2.Size = new System.Drawing.Size(100, 30);
            this.text_VRef2.TabIndex = 10;
            // 
            // text_VRef1
            // 
            this.text_VRef1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_VRef1.Location = new System.Drawing.Point(112, 21);
            this.text_VRef1.Name = "text_VRef1";
            this.text_VRef1.Size = new System.Drawing.Size(100, 30);
            this.text_VRef1.TabIndex = 9;
            // 
            // text_ResultVRef1
            // 
            this.text_ResultVRef1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ResultVRef1.Location = new System.Drawing.Point(217, 21);
            this.text_ResultVRef1.Name = "text_ResultVRef1";
            this.text_ResultVRef1.Size = new System.Drawing.Size(100, 30);
            this.text_ResultVRef1.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Gainsboro;
            this.label16.Location = new System.Drawing.Point(43, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 24);
            this.label16.TabIndex = 23;
            this.label16.Text = "VRef1";
            // 
            // text_ResultVRef2
            // 
            this.text_ResultVRef2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ResultVRef2.Location = new System.Drawing.Point(217, 65);
            this.text_ResultVRef2.Name = "text_ResultVRef2";
            this.text_ResultVRef2.Size = new System.Drawing.Size(100, 30);
            this.text_ResultVRef2.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Gainsboro;
            this.label17.Location = new System.Drawing.Point(43, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 24);
            this.label17.TabIndex = 24;
            this.label17.Text = "VRef2";
            // 
            // text_ResultVOut1
            // 
            this.text_ResultVOut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ResultVOut1.Location = new System.Drawing.Point(217, 109);
            this.text_ResultVOut1.Name = "text_ResultVOut1";
            this.text_ResultVOut1.Size = new System.Drawing.Size(100, 30);
            this.text_ResultVOut1.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(42, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 24);
            this.label18.TabIndex = 25;
            this.label18.Text = "VOut1";
            // 
            // text_ResultVOut2
            // 
            this.text_ResultVOut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ResultVOut2.Location = new System.Drawing.Point(217, 153);
            this.text_ResultVOut2.Name = "text_ResultVOut2";
            this.text_ResultVOut2.Size = new System.Drawing.Size(100, 30);
            this.text_ResultVOut2.TabIndex = 12;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gainsboro;
            this.label19.Location = new System.Drawing.Point(42, 156);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 24);
            this.label19.TabIndex = 26;
            this.label19.Text = "VOut2";
            // 
            // text_ResultVOut3
            // 
            this.text_ResultVOut3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ResultVOut3.Location = new System.Drawing.Point(217, 197);
            this.text_ResultVOut3.Name = "text_ResultVOut3";
            this.text_ResultVOut3.Size = new System.Drawing.Size(100, 30);
            this.text_ResultVOut3.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Gainsboro;
            this.label20.Location = new System.Drawing.Point(42, 200);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 24);
            this.label20.TabIndex = 27;
            this.label20.Text = "VOut3";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.text_ResultVOut3);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.text_ResultVOut2);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.text_ResultVOut1);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.text_ResultVRef2);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.text_ResultVRef1);
            this.panel5.Controls.Add(this.text_VRef1);
            this.panel5.Controls.Add(this.text_VRef2);
            this.panel5.Controls.Add(this.text_VOut1);
            this.panel5.Controls.Add(this.text_VOut2);
            this.panel5.Controls.Add(this.text_VOut3);
            this.panel5.Location = new System.Drawing.Point(494, 210);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(342, 242);
            this.panel5.TabIndex = 14;
            // 
            // ProductTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1162, 784);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.text_TestResult);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ProductTest";
            this.Text = "ProductTest";
            this.Load += new System.EventHandler(this.ProductTest_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox text_Temp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTanggal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textOperatorID;
        private System.Windows.Forms.TextBox textModuleID;
        private System.Windows.Forms.TextBox text_Humid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox text_V9;
        private System.Windows.Forms.TextBox text_V8;
        private System.Windows.Forms.TextBox text_V7;
        private System.Windows.Forms.TextBox text_V6;
        private System.Windows.Forms.TextBox text_V5;
        private System.Windows.Forms.TextBox text_V4;
        private System.Windows.Forms.TextBox text_V3;
        private System.Windows.Forms.TextBox text_V2;
        private System.Windows.Forms.TextBox text_V1;
        private System.Windows.Forms.TextBox text_ResultV9;
        private System.Windows.Forms.TextBox text_ResultV8;
        private System.Windows.Forms.TextBox text_ResultV7;
        private System.Windows.Forms.TextBox text_ResultV6;
        private System.Windows.Forms.TextBox text_ResultV5;
        private System.Windows.Forms.TextBox text_ResultV4;
        private System.Windows.Forms.TextBox text_ResultV3;
        private System.Windows.Forms.TextBox text_ResultV2;
        private System.Windows.Forms.TextBox text_ResultV1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox text_TestResult;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cbLampTypes;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox text_VOut3;
        private System.Windows.Forms.TextBox text_VOut2;
        private System.Windows.Forms.TextBox text_VOut1;
        private System.Windows.Forms.TextBox text_VRef2;
        private System.Windows.Forms.TextBox text_VRef1;
        private System.Windows.Forms.TextBox text_ResultVRef1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox text_ResultVRef2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox text_ResultVOut1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox text_ResultVOut2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox text_ResultVOut3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel5;
    }
}