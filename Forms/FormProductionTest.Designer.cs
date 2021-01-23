
namespace LED_Handheld_Project.Forms
{
    partial class FormProductionTest
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
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.tbTemperature = new System.Windows.Forms.TextBox();
            this.lbHumidity = new System.Windows.Forms.Label();
            this.lbTemperature = new System.Windows.Forms.Label();
            this.tbOperator = new System.Windows.Forms.TextBox();
            this.tbModule = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.lbOperator = new System.Windows.Forms.Label();
            this.lbModule = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.rtbSerialData = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.error = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.valV3 = new System.Windows.Forms.TextBox();
            this.valV2 = new System.Windows.Forms.TextBox();
            this.valV1 = new System.Windows.Forms.TextBox();
            this.valV9 = new System.Windows.Forms.TextBox();
            this.valV8 = new System.Windows.Forms.TextBox();
            this.valV7 = new System.Windows.Forms.TextBox();
            this.valV6 = new System.Windows.Forms.TextBox();
            this.valV5 = new System.Windows.Forms.TextBox();
            this.valV4 = new System.Windows.Forms.TextBox();
            this.resV3 = new System.Windows.Forms.TextBox();
            this.resV2 = new System.Windows.Forms.TextBox();
            this.resV1 = new System.Windows.Forms.TextBox();
            this.resV9 = new System.Windows.Forms.TextBox();
            this.resV8 = new System.Windows.Forms.TextBox();
            this.resV7 = new System.Windows.Forms.TextBox();
            this.resV6 = new System.Windows.Forms.TextBox();
            this.resV5 = new System.Windows.Forms.TextBox();
            this.resV4 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.resVOut1 = new System.Windows.Forms.TextBox();
            this.resVRef2 = new System.Windows.Forms.TextBox();
            this.resVRef1 = new System.Windows.Forms.TextBox();
            this.resVOut3 = new System.Windows.Forms.TextBox();
            this.resVOut2 = new System.Windows.Forms.TextBox();
            this.valVOut1 = new System.Windows.Forms.TextBox();
            this.valVRes2 = new System.Windows.Forms.TextBox();
            this.valVRes1 = new System.Windows.Forms.TextBox();
            this.valVOut3 = new System.Windows.Forms.TextBox();
            this.valVOut2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbHumidity
            // 
            this.tbHumidity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHumidity.Location = new System.Drawing.Point(940, 211);
            this.tbHumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHumidity.Multiline = true;
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.Size = new System.Drawing.Size(91, 22);
            this.tbHumidity.TabIndex = 101;
            // 
            // tbTemperature
            // 
            this.tbTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemperature.Location = new System.Drawing.Point(940, 183);
            this.tbTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTemperature.Multiline = true;
            this.tbTemperature.Name = "tbTemperature";
            this.tbTemperature.Size = new System.Drawing.Size(91, 22);
            this.tbTemperature.TabIndex = 100;
            // 
            // lbHumidity
            // 
            this.lbHumidity.AutoSize = true;
            this.lbHumidity.BackColor = System.Drawing.SystemColors.Control;
            this.lbHumidity.ForeColor = System.Drawing.Color.Black;
            this.lbHumidity.Location = new System.Drawing.Point(820, 210);
            this.lbHumidity.Name = "lbHumidity";
            this.lbHumidity.Size = new System.Drawing.Size(62, 17);
            this.lbHumidity.TabIndex = 99;
            this.lbHumidity.Text = "Humidity";
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.BackColor = System.Drawing.SystemColors.Control;
            this.lbTemperature.ForeColor = System.Drawing.Color.Black;
            this.lbTemperature.Location = new System.Drawing.Point(820, 182);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(90, 17);
            this.lbTemperature.TabIndex = 98;
            this.lbTemperature.Text = "Temperature";
            this.lbTemperature.Click += new System.EventHandler(this.lbTemperature_Click);
            // 
            // tbOperator
            // 
            this.tbOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOperator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOperator.Location = new System.Drawing.Point(-333, 91);
            this.tbOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOperator.Name = "tbOperator";
            this.tbOperator.Size = new System.Drawing.Size(123, 25);
            this.tbOperator.TabIndex = 96;
            this.tbOperator.Text = " ";
            // 
            // tbModule
            // 
            this.tbModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModule.Location = new System.Drawing.Point(-333, 57);
            this.tbModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbModule.Name = "tbModule";
            this.tbModule.Size = new System.Drawing.Size(123, 25);
            this.tbModule.TabIndex = 95;
            this.tbModule.Text = " ";
            // 
            // tbDate
            // 
            this.tbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDate.Location = new System.Drawing.Point(-333, 21);
            this.tbDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(123, 25);
            this.tbDate.TabIndex = 94;
            // 
            // lbOperator
            // 
            this.lbOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOperator.AutoSize = true;
            this.lbOperator.BackColor = System.Drawing.SystemColors.Control;
            this.lbOperator.ForeColor = System.Drawing.Color.Black;
            this.lbOperator.Location = new System.Drawing.Point(-452, 91);
            this.lbOperator.Name = "lbOperator";
            this.lbOperator.Size = new System.Drawing.Size(82, 17);
            this.lbOperator.TabIndex = 93;
            this.lbOperator.Text = "Operator ID";
            // 
            // lbModule
            // 
            this.lbModule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbModule.AutoSize = true;
            this.lbModule.BackColor = System.Drawing.SystemColors.Control;
            this.lbModule.ForeColor = System.Drawing.Color.Black;
            this.lbModule.Location = new System.Drawing.Point(-452, 57);
            this.lbModule.Name = "lbModule";
            this.lbModule.Size = new System.Drawing.Size(71, 17);
            this.lbModule.TabIndex = 92;
            this.lbModule.Text = "Module ID";
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbDate.ForeColor = System.Drawing.Color.Black;
            this.lbDate.Location = new System.Drawing.Point(-452, 21);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(38, 17);
            this.lbDate.TabIndex = 91;
            this.lbDate.Text = "Date";
            // 
            // rtbSerialData
            // 
            this.rtbSerialData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSerialData.Location = new System.Drawing.Point(89, 782);
            this.rtbSerialData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbSerialData.Name = "rtbSerialData";
            this.rtbSerialData.Size = new System.Drawing.Size(645, 34);
            this.rtbSerialData.TabIndex = 90;
            this.rtbSerialData.Text = "";
            this.rtbSerialData.TextChanged += new System.EventHandler(this.rtbSerialData_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(-267, 1104);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 34);
            this.btnSave.TabIndex = 89;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // cbPort
            // 
            this.cbPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(940, 242);
            this.cbPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 24);
            this.cbPort.TabIndex = 87;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.BackColor = System.Drawing.SystemColors.Control;
            this.lbPort.ForeColor = System.Drawing.Color.Black;
            this.lbPort.Location = new System.Drawing.Point(820, 246);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(75, 17);
            this.lbPort.TabIndex = 86;
            this.lbPort.Text = "Port Name";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived_1);
            // 
            // error
            // 
            this.error.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.Location = new System.Drawing.Point(656, 130);
            this.error.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(123, 25);
            this.error.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(537, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 105;
            this.label2.Text = "Error Allowed :";
            // 
            // btnCheck
            // 
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Location = new System.Drawing.Point(349, 199);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(89, 34);
            this.btnCheck.TabIndex = 107;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(473, 199);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(89, 34);
            this.btnStop.TabIndex = 108;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // valV3
            // 
            this.valV3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV3.Location = new System.Drawing.Point(163, 350);
            this.valV3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV3.Name = "valV3";
            this.valV3.Size = new System.Drawing.Size(73, 29);
            this.valV3.TabIndex = 133;
            this.valV3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valV2
            // 
            this.valV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV2.Location = new System.Drawing.Point(163, 319);
            this.valV2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV2.Name = "valV2";
            this.valV2.Size = new System.Drawing.Size(73, 29);
            this.valV2.TabIndex = 132;
            this.valV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valV1
            // 
            this.valV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV1.Location = new System.Drawing.Point(163, 288);
            this.valV1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV1.Name = "valV1";
            this.valV1.Size = new System.Drawing.Size(73, 29);
            this.valV1.TabIndex = 131;
            this.valV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valV9
            // 
            this.valV9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV9.Location = new System.Drawing.Point(163, 537);
            this.valV9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV9.Name = "valV9";
            this.valV9.Size = new System.Drawing.Size(73, 29);
            this.valV9.TabIndex = 130;
            this.valV9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valV8
            // 
            this.valV8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV8.Location = new System.Drawing.Point(163, 505);
            this.valV8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV8.Name = "valV8";
            this.valV8.Size = new System.Drawing.Size(73, 29);
            this.valV8.TabIndex = 129;
            this.valV8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valV7
            // 
            this.valV7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV7.Location = new System.Drawing.Point(163, 474);
            this.valV7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV7.Name = "valV7";
            this.valV7.Size = new System.Drawing.Size(73, 29);
            this.valV7.TabIndex = 128;
            this.valV7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valV6
            // 
            this.valV6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV6.Location = new System.Drawing.Point(163, 443);
            this.valV6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV6.Name = "valV6";
            this.valV6.Size = new System.Drawing.Size(73, 29);
            this.valV6.TabIndex = 127;
            this.valV6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valV5
            // 
            this.valV5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV5.Location = new System.Drawing.Point(163, 412);
            this.valV5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV5.Name = "valV5";
            this.valV5.Size = new System.Drawing.Size(73, 29);
            this.valV5.TabIndex = 126;
            this.valV5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valV4
            // 
            this.valV4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV4.Location = new System.Drawing.Point(163, 382);
            this.valV4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV4.Name = "valV4";
            this.valV4.Size = new System.Drawing.Size(73, 29);
            this.valV4.TabIndex = 125;
            this.valV4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resV3
            // 
            this.resV3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV3.Location = new System.Drawing.Point(236, 350);
            this.resV3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV3.Name = "resV3";
            this.resV3.Size = new System.Drawing.Size(73, 29);
            this.resV3.TabIndex = 142;
            this.resV3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resV2
            // 
            this.resV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV2.Location = new System.Drawing.Point(236, 319);
            this.resV2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV2.Name = "resV2";
            this.resV2.Size = new System.Drawing.Size(73, 29);
            this.resV2.TabIndex = 141;
            this.resV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resV1
            // 
            this.resV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV1.Location = new System.Drawing.Point(236, 288);
            this.resV1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV1.Name = "resV1";
            this.resV1.Size = new System.Drawing.Size(73, 29);
            this.resV1.TabIndex = 140;
            this.resV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resV9
            // 
            this.resV9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV9.Location = new System.Drawing.Point(236, 537);
            this.resV9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV9.Name = "resV9";
            this.resV9.Size = new System.Drawing.Size(73, 29);
            this.resV9.TabIndex = 139;
            this.resV9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resV8
            // 
            this.resV8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV8.Location = new System.Drawing.Point(236, 505);
            this.resV8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV8.Name = "resV8";
            this.resV8.Size = new System.Drawing.Size(73, 29);
            this.resV8.TabIndex = 138;
            this.resV8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resV7
            // 
            this.resV7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV7.Location = new System.Drawing.Point(236, 474);
            this.resV7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV7.Name = "resV7";
            this.resV7.Size = new System.Drawing.Size(73, 29);
            this.resV7.TabIndex = 137;
            this.resV7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resV6
            // 
            this.resV6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV6.Location = new System.Drawing.Point(236, 443);
            this.resV6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV6.Name = "resV6";
            this.resV6.Size = new System.Drawing.Size(73, 29);
            this.resV6.TabIndex = 136;
            this.resV6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resV5
            // 
            this.resV5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV5.Location = new System.Drawing.Point(236, 412);
            this.resV5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV5.Name = "resV5";
            this.resV5.Size = new System.Drawing.Size(73, 29);
            this.resV5.TabIndex = 135;
            this.resV5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resV4
            // 
            this.resV4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV4.Location = new System.Drawing.Point(236, 382);
            this.resV4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV4.Name = "resV4";
            this.resV4.Size = new System.Drawing.Size(73, 29);
            this.resV4.TabIndex = 134;
            this.resV4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.Location = new System.Drawing.Point(112, 350);
            this.textBox20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(51, 29);
            this.textBox20.TabIndex = 151;
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox21
            // 
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.Location = new System.Drawing.Point(112, 319);
            this.textBox21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(51, 29);
            this.textBox21.TabIndex = 150;
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox22
            // 
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.Location = new System.Drawing.Point(112, 288);
            this.textBox22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(51, 29);
            this.textBox22.TabIndex = 149;
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.Location = new System.Drawing.Point(112, 537);
            this.textBox23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(51, 29);
            this.textBox23.TabIndex = 148;
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox24
            // 
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox24.Location = new System.Drawing.Point(112, 505);
            this.textBox24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(51, 29);
            this.textBox24.TabIndex = 147;
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox25.Location = new System.Drawing.Point(112, 474);
            this.textBox25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(51, 29);
            this.textBox25.TabIndex = 146;
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox26
            // 
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox26.Location = new System.Drawing.Point(112, 443);
            this.textBox26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(51, 29);
            this.textBox26.TabIndex = 145;
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox27
            // 
            this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox27.Location = new System.Drawing.Point(112, 412);
            this.textBox27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(51, 29);
            this.textBox27.TabIndex = 144;
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox28
            // 
            this.textBox28.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox28.Location = new System.Drawing.Point(112, 382);
            this.textBox28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(51, 29);
            this.textBox28.TabIndex = 143;
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(397, 350);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 29);
            this.textBox2.TabIndex = 166;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(397, 319);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(51, 29);
            this.textBox3.TabIndex = 165;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(397, 288);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(51, 29);
            this.textBox4.TabIndex = 164;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(397, 412);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(51, 29);
            this.textBox5.TabIndex = 163;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(397, 382);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(51, 29);
            this.textBox6.TabIndex = 162;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resVOut1
            // 
            this.resVOut1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resVOut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resVOut1.Location = new System.Drawing.Point(521, 350);
            this.resVOut1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resVOut1.Name = "resVOut1";
            this.resVOut1.Size = new System.Drawing.Size(73, 29);
            this.resVOut1.TabIndex = 161;
            this.resVOut1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resVRef2
            // 
            this.resVRef2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resVRef2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resVRef2.Location = new System.Drawing.Point(521, 319);
            this.resVRef2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resVRef2.Name = "resVRef2";
            this.resVRef2.Size = new System.Drawing.Size(73, 29);
            this.resVRef2.TabIndex = 160;
            this.resVRef2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resVRef1
            // 
            this.resVRef1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resVRef1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resVRef1.Location = new System.Drawing.Point(521, 288);
            this.resVRef1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resVRef1.Name = "resVRef1";
            this.resVRef1.Size = new System.Drawing.Size(73, 29);
            this.resVRef1.TabIndex = 159;
            this.resVRef1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resVOut3
            // 
            this.resVOut3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resVOut3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resVOut3.Location = new System.Drawing.Point(521, 412);
            this.resVOut3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resVOut3.Name = "resVOut3";
            this.resVOut3.Size = new System.Drawing.Size(73, 29);
            this.resVOut3.TabIndex = 158;
            this.resVOut3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resVOut2
            // 
            this.resVOut2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resVOut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resVOut2.Location = new System.Drawing.Point(521, 382);
            this.resVOut2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resVOut2.Name = "resVOut2";
            this.resVOut2.Size = new System.Drawing.Size(73, 29);
            this.resVOut2.TabIndex = 157;
            this.resVOut2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valVOut1
            // 
            this.valVOut1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valVOut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valVOut1.Location = new System.Drawing.Point(448, 350);
            this.valVOut1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valVOut1.Name = "valVOut1";
            this.valVOut1.Size = new System.Drawing.Size(73, 29);
            this.valVOut1.TabIndex = 156;
            this.valVOut1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valVRes2
            // 
            this.valVRes2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valVRes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valVRes2.Location = new System.Drawing.Point(448, 319);
            this.valVRes2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valVRes2.Name = "valVRes2";
            this.valVRes2.Size = new System.Drawing.Size(73, 29);
            this.valVRes2.TabIndex = 155;
            this.valVRes2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valVRes1
            // 
            this.valVRes1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valVRes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valVRes1.Location = new System.Drawing.Point(448, 288);
            this.valVRes1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valVRes1.Name = "valVRes1";
            this.valVRes1.Size = new System.Drawing.Size(73, 29);
            this.valVRes1.TabIndex = 154;
            this.valVRes1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valVOut3
            // 
            this.valVOut3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valVOut3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valVOut3.Location = new System.Drawing.Point(448, 412);
            this.valVOut3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valVOut3.Name = "valVOut3";
            this.valVOut3.Size = new System.Drawing.Size(73, 29);
            this.valVOut3.TabIndex = 153;
            this.valVOut3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // valVOut2
            // 
            this.valVOut2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valVOut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valVOut2.Location = new System.Drawing.Point(448, 382);
            this.valVOut2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valVOut2.Name = "valVOut2";
            this.valVOut2.Size = new System.Drawing.Size(73, 29);
            this.valVOut2.TabIndex = 152;
            this.valVOut2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormProductionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1160, 813);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.resVOut1);
            this.Controls.Add(this.resVRef2);
            this.Controls.Add(this.resVRef1);
            this.Controls.Add(this.resVOut3);
            this.Controls.Add(this.resVOut2);
            this.Controls.Add(this.valVOut1);
            this.Controls.Add(this.valVRes2);
            this.Controls.Add(this.valVRes1);
            this.Controls.Add(this.valVOut3);
            this.Controls.Add(this.valVOut2);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.textBox27);
            this.Controls.Add(this.textBox28);
            this.Controls.Add(this.resV3);
            this.Controls.Add(this.resV2);
            this.Controls.Add(this.resV1);
            this.Controls.Add(this.resV9);
            this.Controls.Add(this.resV8);
            this.Controls.Add(this.resV7);
            this.Controls.Add(this.resV6);
            this.Controls.Add(this.resV5);
            this.Controls.Add(this.resV4);
            this.Controls.Add(this.valV3);
            this.Controls.Add(this.valV2);
            this.Controls.Add(this.valV1);
            this.Controls.Add(this.valV9);
            this.Controls.Add(this.valV8);
            this.Controls.Add(this.valV7);
            this.Controls.Add(this.valV6);
            this.Controls.Add(this.valV5);
            this.Controls.Add(this.valV4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.error);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHumidity);
            this.Controls.Add(this.tbTemperature);
            this.Controls.Add(this.lbHumidity);
            this.Controls.Add(this.lbTemperature);
            this.Controls.Add(this.tbOperator);
            this.Controls.Add(this.tbModule);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.lbOperator);
            this.Controls.Add(this.lbModule);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.rtbSerialData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.lbPort);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProductionTest";
            this.Text = "Production Test";
            this.Load += new System.EventHandler(this.FormProductionTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbHumidity;
        private System.Windows.Forms.TextBox tbTemperature;
        private System.Windows.Forms.Label lbHumidity;
        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.TextBox tbOperator;
        private System.Windows.Forms.TextBox tbModule;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label lbOperator;
        private System.Windows.Forms.Label lbModule;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.RichTextBox rtbSerialData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label lbPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox error;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox valV3;
        private System.Windows.Forms.TextBox valV2;
        private System.Windows.Forms.TextBox valV1;
        private System.Windows.Forms.TextBox valV9;
        private System.Windows.Forms.TextBox valV8;
        private System.Windows.Forms.TextBox valV7;
        private System.Windows.Forms.TextBox valV6;
        private System.Windows.Forms.TextBox valV5;
        private System.Windows.Forms.TextBox valV4;
        private System.Windows.Forms.TextBox resV3;
        private System.Windows.Forms.TextBox resV2;
        private System.Windows.Forms.TextBox resV1;
        private System.Windows.Forms.TextBox resV9;
        private System.Windows.Forms.TextBox resV8;
        private System.Windows.Forms.TextBox resV7;
        private System.Windows.Forms.TextBox resV6;
        private System.Windows.Forms.TextBox resV5;
        private System.Windows.Forms.TextBox resV4;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox resVOut1;
        private System.Windows.Forms.TextBox resVRef2;
        private System.Windows.Forms.TextBox resVRef1;
        private System.Windows.Forms.TextBox resVOut3;
        private System.Windows.Forms.TextBox resVOut2;
        private System.Windows.Forms.TextBox valVOut1;
        private System.Windows.Forms.TextBox valVRes2;
        private System.Windows.Forms.TextBox valVRes1;
        private System.Windows.Forms.TextBox valVOut3;
        private System.Windows.Forms.TextBox valVOut2;
    }
}