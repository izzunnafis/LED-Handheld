
namespace LED_Handheld_Project.Forms
{
    partial class FormProduct
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
            this.tbOperator = new System.Windows.Forms.TextBox();
            this.tbModule = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.lbOperator = new System.Windows.Forms.Label();
            this.lbModule = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.resV1 = new System.Windows.Forms.TextBox();
            this.valV1 = new System.Windows.Forms.TextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.rtbSerialData = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.resV2 = new System.Windows.Forms.TextBox();
            this.valV2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.resV4 = new System.Windows.Forms.TextBox();
            this.valV4 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.resV3 = new System.Windows.Forms.TextBox();
            this.valV3 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.resV6 = new System.Windows.Forms.TextBox();
            this.valV6 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.resV5 = new System.Windows.Forms.TextBox();
            this.valV5 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.resV7 = new System.Windows.Forms.TextBox();
            this.valV7 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.resV8 = new System.Windows.Forms.TextBox();
            this.valV8 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.resV9 = new System.Windows.Forms.TextBox();
            this.valV9 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.resVOut3 = new System.Windows.Forms.TextBox();
            this.valVOut3 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.resVOut2 = new System.Windows.Forms.TextBox();
            this.valVOut2 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.resVOut1 = new System.Windows.Forms.TextBox();
            this.valVOut1 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.resVRef2 = new System.Windows.Forms.TextBox();
            this.valVRef2 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.resVRef1 = new System.Windows.Forms.TextBox();
            this.valVRef1 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.valHumidity = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.valTemperature = new System.Windows.Forms.TextBox();
            this.tbError = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tbFinalResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbOperator
            // 
            this.tbOperator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOperator.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOperator.Location = new System.Drawing.Point(246, 139);
            this.tbOperator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOperator.Multiline = true;
            this.tbOperator.Name = "tbOperator";
            this.tbOperator.Size = new System.Drawing.Size(189, 27);
            this.tbOperator.TabIndex = 115;
            this.tbOperator.TextChanged += new System.EventHandler(this.tbOperator_TextChanged);
            // 
            // tbModule
            // 
            this.tbModule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbModule.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModule.Location = new System.Drawing.Point(246, 101);
            this.tbModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbModule.Multiline = true;
            this.tbModule.Name = "tbModule";
            this.tbModule.Size = new System.Drawing.Size(189, 27);
            this.tbModule.TabIndex = 114;
            this.tbModule.TextChanged += new System.EventHandler(this.tbModule_TextChanged);
            // 
            // tbDate
            // 
            this.tbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDate.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDate.Location = new System.Drawing.Point(986, 30);
            this.tbDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDate.Multiline = true;
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(129, 27);
            this.tbDate.TabIndex = 107;
            // 
            // lbOperator
            // 
            this.lbOperator.AutoSize = true;
            this.lbOperator.BackColor = System.Drawing.SystemColors.Control;
            this.lbOperator.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperator.ForeColor = System.Drawing.Color.Black;
            this.lbOperator.Location = new System.Drawing.Point(34, 139);
            this.lbOperator.Name = "lbOperator";
            this.lbOperator.Size = new System.Drawing.Size(137, 27);
            this.lbOperator.TabIndex = 106;
            this.lbOperator.Text = "Operator ID ";
            this.lbOperator.Click += new System.EventHandler(this.lbOperator_Click);
            // 
            // lbModule
            // 
            this.lbModule.AutoSize = true;
            this.lbModule.BackColor = System.Drawing.SystemColors.Control;
            this.lbModule.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModule.ForeColor = System.Drawing.Color.Black;
            this.lbModule.Location = new System.Drawing.Point(34, 101);
            this.lbModule.Name = "lbModule";
            this.lbModule.Size = new System.Drawing.Size(123, 27);
            this.lbModule.TabIndex = 105;
            this.lbModule.Text = "Module ID ";
            this.lbModule.Click += new System.EventHandler(this.lbModule_Click);
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbDate.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Black;
            this.lbDate.Location = new System.Drawing.Point(890, 30);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(66, 27);
            this.lbDate.TabIndex = 104;
            this.lbDate.Text = "Date ";
            // 
            // cbPort
            // 
            this.cbPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPort.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(246, 175);
            this.cbPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(189, 32);
            this.cbPort.TabIndex = 103;
            this.cbPort.SelectedIndexChanged += new System.EventHandler(this.cbPort_SelectedIndexChanged);
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.BackColor = System.Drawing.SystemColors.Control;
            this.lbPort.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.ForeColor = System.Drawing.Color.Black;
            this.lbPort.Location = new System.Drawing.Point(34, 177);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(126, 27);
            this.lbPort.TabIndex = 102;
            this.lbPort.Text = "Port Name ";
            this.lbPort.Click += new System.EventHandler(this.lbPort_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // resV1
            // 
            this.resV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV1.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV1.Location = new System.Drawing.Point(219, 294);
            this.resV1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV1.Multiline = true;
            this.resV1.Name = "resV1";
            this.resV1.Size = new System.Drawing.Size(98, 41);
            this.resV1.TabIndex = 184;
            this.resV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resV1.TextChanged += new System.EventHandler(this.resV1_TextChanged);
            // 
            // valV1
            // 
            this.valV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV1.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV1.Location = new System.Drawing.Point(108, 294);
            this.valV1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV1.Multiline = true;
            this.valV1.Name = "valV1";
            this.valV1.Size = new System.Drawing.Size(105, 41);
            this.valV1.TabIndex = 175;
            this.valV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valV1.TextChanged += new System.EventHandler(this.valV1_TextChanged);
            // 
            // btnStop
            // 
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(873, 480);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(200, 80);
            this.btnStop.TabIndex = 168;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Location = new System.Drawing.Point(873, 396);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(200, 80);
            this.btnCheck.TabIndex = 167;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // rtbSerialData
            // 
            this.rtbSerialData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSerialData.Location = new System.Drawing.Point(36, 768);
            this.rtbSerialData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbSerialData.Name = "rtbSerialData";
            this.rtbSerialData.Size = new System.Drawing.Size(961, 34);
            this.rtbSerialData.TabIndex = 212;
            this.rtbSerialData.Text = "";
            this.rtbSerialData.TextChanged += new System.EventHandler(this.rtbSerialData_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(873, 564);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 80);
            this.btnSave.TabIndex = 211;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(36, 294);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 41);
            this.textBox1.TabIndex = 227;
            this.textBox1.Text = "V1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(36, 339);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 41);
            this.textBox2.TabIndex = 230;
            this.textBox2.Text = "V2";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // resV2
            // 
            this.resV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV2.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV2.Location = new System.Drawing.Point(219, 339);
            this.resV2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV2.Multiline = true;
            this.resV2.Name = "resV2";
            this.resV2.Size = new System.Drawing.Size(98, 41);
            this.resV2.TabIndex = 229;
            this.resV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resV2.TextChanged += new System.EventHandler(this.resV2_TextChanged);
            // 
            // valV2
            // 
            this.valV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV2.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV2.Location = new System.Drawing.Point(108, 339);
            this.valV2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV2.Multiline = true;
            this.valV2.Name = "valV2";
            this.valV2.Size = new System.Drawing.Size(105, 41);
            this.valV2.TabIndex = 228;
            this.valV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valV2.TextChanged += new System.EventHandler(this.valV2_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(36, 429);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(66, 41);
            this.textBox5.TabIndex = 236;
            this.textBox5.Text = "V4";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // resV4
            // 
            this.resV4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV4.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV4.Location = new System.Drawing.Point(219, 429);
            this.resV4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV4.Multiline = true;
            this.resV4.Name = "resV4";
            this.resV4.Size = new System.Drawing.Size(98, 41);
            this.resV4.TabIndex = 235;
            this.resV4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resV4.TextChanged += new System.EventHandler(this.resV4_TextChanged);
            // 
            // valV4
            // 
            this.valV4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV4.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV4.Location = new System.Drawing.Point(108, 429);
            this.valV4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV4.Multiline = true;
            this.valV4.Name = "valV4";
            this.valV4.Size = new System.Drawing.Size(105, 41);
            this.valV4.TabIndex = 234;
            this.valV4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valV4.TextChanged += new System.EventHandler(this.valV4_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(36, 384);
            this.textBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(66, 41);
            this.textBox8.TabIndex = 233;
            this.textBox8.Text = "V3";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // resV3
            // 
            this.resV3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV3.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV3.Location = new System.Drawing.Point(219, 384);
            this.resV3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV3.Multiline = true;
            this.resV3.Name = "resV3";
            this.resV3.Size = new System.Drawing.Size(98, 41);
            this.resV3.TabIndex = 232;
            this.resV3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resV3.TextChanged += new System.EventHandler(this.resV3_TextChanged);
            // 
            // valV3
            // 
            this.valV3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV3.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV3.Location = new System.Drawing.Point(108, 384);
            this.valV3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV3.Multiline = true;
            this.valV3.Name = "valV3";
            this.valV3.Size = new System.Drawing.Size(105, 41);
            this.valV3.TabIndex = 231;
            this.valV3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valV3.TextChanged += new System.EventHandler(this.valV3_TextChanged);
            // 
            // textBox11
            // 
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(36, 519);
            this.textBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(66, 41);
            this.textBox11.TabIndex = 242;
            this.textBox11.Text = "V6";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // resV6
            // 
            this.resV6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV6.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV6.Location = new System.Drawing.Point(219, 519);
            this.resV6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV6.Multiline = true;
            this.resV6.Name = "resV6";
            this.resV6.Size = new System.Drawing.Size(98, 41);
            this.resV6.TabIndex = 241;
            this.resV6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resV6.TextChanged += new System.EventHandler(this.resV6_TextChanged);
            // 
            // valV6
            // 
            this.valV6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV6.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV6.Location = new System.Drawing.Point(108, 519);
            this.valV6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV6.Multiline = true;
            this.valV6.Name = "valV6";
            this.valV6.Size = new System.Drawing.Size(105, 41);
            this.valV6.TabIndex = 240;
            this.valV6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valV6.TextChanged += new System.EventHandler(this.valV6_TextChanged);
            // 
            // textBox14
            // 
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(36, 474);
            this.textBox14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(66, 41);
            this.textBox14.TabIndex = 239;
            this.textBox14.Text = "V5";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // resV5
            // 
            this.resV5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV5.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV5.Location = new System.Drawing.Point(219, 474);
            this.resV5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV5.Multiline = true;
            this.resV5.Name = "resV5";
            this.resV5.Size = new System.Drawing.Size(98, 41);
            this.resV5.TabIndex = 238;
            this.resV5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resV5.TextChanged += new System.EventHandler(this.resV5_TextChanged);
            // 
            // valV5
            // 
            this.valV5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV5.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV5.Location = new System.Drawing.Point(108, 474);
            this.valV5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV5.Multiline = true;
            this.valV5.Name = "valV5";
            this.valV5.Size = new System.Drawing.Size(105, 41);
            this.valV5.TabIndex = 237;
            this.valV5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valV5.TextChanged += new System.EventHandler(this.valV5_TextChanged);
            // 
            // textBox17
            // 
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(36, 564);
            this.textBox17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(66, 41);
            this.textBox17.TabIndex = 251;
            this.textBox17.Text = "V7";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox17.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // resV7
            // 
            this.resV7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV7.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV7.Location = new System.Drawing.Point(219, 564);
            this.resV7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV7.Multiline = true;
            this.resV7.Name = "resV7";
            this.resV7.Size = new System.Drawing.Size(98, 41);
            this.resV7.TabIndex = 250;
            this.resV7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resV7.TextChanged += new System.EventHandler(this.resV7_TextChanged);
            // 
            // valV7
            // 
            this.valV7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV7.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV7.Location = new System.Drawing.Point(108, 564);
            this.valV7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV7.Multiline = true;
            this.valV7.Name = "valV7";
            this.valV7.Size = new System.Drawing.Size(105, 41);
            this.valV7.TabIndex = 249;
            this.valV7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valV7.TextChanged += new System.EventHandler(this.valV7_TextChanged);
            // 
            // textBox20
            // 
            this.textBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox20.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.Location = new System.Drawing.Point(36, 609);
            this.textBox20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(66, 41);
            this.textBox20.TabIndex = 248;
            this.textBox20.Text = "V8";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox20.TextChanged += new System.EventHandler(this.textBox20_TextChanged);
            // 
            // resV8
            // 
            this.resV8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV8.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV8.Location = new System.Drawing.Point(219, 609);
            this.resV8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV8.Multiline = true;
            this.resV8.Name = "resV8";
            this.resV8.Size = new System.Drawing.Size(98, 41);
            this.resV8.TabIndex = 247;
            this.resV8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resV8.TextChanged += new System.EventHandler(this.resV8_TextChanged);
            // 
            // valV8
            // 
            this.valV8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV8.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV8.Location = new System.Drawing.Point(108, 609);
            this.valV8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV8.Multiline = true;
            this.valV8.Name = "valV8";
            this.valV8.Size = new System.Drawing.Size(105, 41);
            this.valV8.TabIndex = 246;
            this.valV8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valV8.TextChanged += new System.EventHandler(this.valV8_TextChanged);
            // 
            // textBox23
            // 
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox23.Location = new System.Drawing.Point(36, 654);
            this.textBox23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox23.Multiline = true;
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(66, 41);
            this.textBox23.TabIndex = 245;
            this.textBox23.Text = "V9";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox23.TextChanged += new System.EventHandler(this.textBox23_TextChanged);
            // 
            // resV9
            // 
            this.resV9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resV9.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resV9.Location = new System.Drawing.Point(219, 654);
            this.resV9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resV9.Multiline = true;
            this.resV9.Name = "resV9";
            this.resV9.Size = new System.Drawing.Size(98, 41);
            this.resV9.TabIndex = 244;
            this.resV9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resV9.TextChanged += new System.EventHandler(this.resV9_TextChanged);
            // 
            // valV9
            // 
            this.valV9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valV9.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valV9.Location = new System.Drawing.Point(108, 654);
            this.valV9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valV9.Multiline = true;
            this.valV9.Name = "valV9";
            this.valV9.Size = new System.Drawing.Size(105, 41);
            this.valV9.TabIndex = 243;
            this.valV9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valV9.TextChanged += new System.EventHandler(this.valV9_TextChanged);
            // 
            // textBox26
            // 
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox26.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox26.Location = new System.Drawing.Point(409, 474);
            this.textBox26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox26.Multiline = true;
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(109, 41);
            this.textBox26.TabIndex = 266;
            this.textBox26.Text = "VOut3";
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox26.TextChanged += new System.EventHandler(this.textBox26_TextChanged);
            // 
            // resVOut3
            // 
            this.resVOut3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resVOut3.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resVOut3.Location = new System.Drawing.Point(635, 474);
            this.resVOut3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resVOut3.Multiline = true;
            this.resVOut3.Name = "resVOut3";
            this.resVOut3.Size = new System.Drawing.Size(98, 41);
            this.resVOut3.TabIndex = 265;
            this.resVOut3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resVOut3.TextChanged += new System.EventHandler(this.resVOut3_TextChanged);
            // 
            // valVOut3
            // 
            this.valVOut3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valVOut3.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valVOut3.Location = new System.Drawing.Point(524, 474);
            this.valVOut3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valVOut3.Multiline = true;
            this.valVOut3.Name = "valVOut3";
            this.valVOut3.Size = new System.Drawing.Size(105, 41);
            this.valVOut3.TabIndex = 264;
            this.valVOut3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valVOut3.TextChanged += new System.EventHandler(this.valVOut3_TextChanged);
            // 
            // textBox29
            // 
            this.textBox29.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox29.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox29.Location = new System.Drawing.Point(409, 429);
            this.textBox29.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox29.Multiline = true;
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(109, 41);
            this.textBox29.TabIndex = 263;
            this.textBox29.Text = "VOut2";
            this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox29.TextChanged += new System.EventHandler(this.textBox29_TextChanged);
            // 
            // resVOut2
            // 
            this.resVOut2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resVOut2.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resVOut2.Location = new System.Drawing.Point(635, 429);
            this.resVOut2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resVOut2.Multiline = true;
            this.resVOut2.Name = "resVOut2";
            this.resVOut2.Size = new System.Drawing.Size(98, 41);
            this.resVOut2.TabIndex = 262;
            this.resVOut2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resVOut2.TextChanged += new System.EventHandler(this.resVOut2_TextChanged);
            // 
            // valVOut2
            // 
            this.valVOut2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valVOut2.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valVOut2.Location = new System.Drawing.Point(524, 429);
            this.valVOut2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valVOut2.Multiline = true;
            this.valVOut2.Name = "valVOut2";
            this.valVOut2.Size = new System.Drawing.Size(105, 41);
            this.valVOut2.TabIndex = 261;
            this.valVOut2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valVOut2.TextChanged += new System.EventHandler(this.valVOut2_TextChanged);
            // 
            // textBox32
            // 
            this.textBox32.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox32.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox32.Location = new System.Drawing.Point(409, 384);
            this.textBox32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox32.Multiline = true;
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(109, 41);
            this.textBox32.TabIndex = 260;
            this.textBox32.Text = "VOut1";
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox32.TextChanged += new System.EventHandler(this.textBox32_TextChanged);
            // 
            // resVOut1
            // 
            this.resVOut1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resVOut1.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resVOut1.Location = new System.Drawing.Point(635, 384);
            this.resVOut1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resVOut1.Multiline = true;
            this.resVOut1.Name = "resVOut1";
            this.resVOut1.Size = new System.Drawing.Size(98, 41);
            this.resVOut1.TabIndex = 259;
            this.resVOut1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resVOut1.TextChanged += new System.EventHandler(this.resVOut1_TextChanged);
            // 
            // valVOut1
            // 
            this.valVOut1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valVOut1.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valVOut1.Location = new System.Drawing.Point(524, 384);
            this.valVOut1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valVOut1.Multiline = true;
            this.valVOut1.Name = "valVOut1";
            this.valVOut1.Size = new System.Drawing.Size(105, 41);
            this.valVOut1.TabIndex = 258;
            this.valVOut1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valVOut1.TextChanged += new System.EventHandler(this.valVOut1_TextChanged);
            // 
            // textBox35
            // 
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox35.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox35.Location = new System.Drawing.Point(409, 339);
            this.textBox35.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox35.Multiline = true;
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(109, 41);
            this.textBox35.TabIndex = 257;
            this.textBox35.Text = "VRef2";
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox35.TextChanged += new System.EventHandler(this.textBox35_TextChanged);
            // 
            // resVRef2
            // 
            this.resVRef2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resVRef2.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resVRef2.Location = new System.Drawing.Point(635, 339);
            this.resVRef2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resVRef2.Multiline = true;
            this.resVRef2.Name = "resVRef2";
            this.resVRef2.Size = new System.Drawing.Size(98, 41);
            this.resVRef2.TabIndex = 256;
            this.resVRef2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resVRef2.TextChanged += new System.EventHandler(this.resVRef2_TextChanged);
            // 
            // valVRef2
            // 
            this.valVRef2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valVRef2.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valVRef2.Location = new System.Drawing.Point(524, 339);
            this.valVRef2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valVRef2.Multiline = true;
            this.valVRef2.Name = "valVRef2";
            this.valVRef2.Size = new System.Drawing.Size(105, 41);
            this.valVRef2.TabIndex = 255;
            this.valVRef2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valVRef2.TextChanged += new System.EventHandler(this.valVRef2_TextChanged);
            // 
            // textBox38
            // 
            this.textBox38.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox38.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox38.Location = new System.Drawing.Point(409, 294);
            this.textBox38.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox38.Multiline = true;
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(109, 41);
            this.textBox38.TabIndex = 254;
            this.textBox38.Text = "VRef1";
            this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox38.TextChanged += new System.EventHandler(this.textBox38_TextChanged);
            // 
            // resVRef1
            // 
            this.resVRef1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resVRef1.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resVRef1.Location = new System.Drawing.Point(635, 294);
            this.resVRef1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resVRef1.Multiline = true;
            this.resVRef1.Name = "resVRef1";
            this.resVRef1.Size = new System.Drawing.Size(98, 41);
            this.resVRef1.TabIndex = 253;
            this.resVRef1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.resVRef1.TextChanged += new System.EventHandler(this.resVRef1_TextChanged);
            // 
            // valVRef1
            // 
            this.valVRef1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valVRef1.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valVRef1.Location = new System.Drawing.Point(524, 294);
            this.valVRef1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valVRef1.Multiline = true;
            this.valVRef1.Name = "valVRef1";
            this.valVRef1.Size = new System.Drawing.Size(105, 41);
            this.valVRef1.TabIndex = 252;
            this.valVRef1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valVRef1.TextChanged += new System.EventHandler(this.valVRef1_TextChanged);
            // 
            // textBox41
            // 
            this.textBox41.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox41.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox41.Location = new System.Drawing.Point(409, 609);
            this.textBox41.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox41.Multiline = true;
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(186, 41);
            this.textBox41.TabIndex = 272;
            this.textBox41.Text = "Humidity";
            this.textBox41.TextChanged += new System.EventHandler(this.textBox41_TextChanged);
            // 
            // valHumidity
            // 
            this.valHumidity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valHumidity.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valHumidity.Location = new System.Drawing.Point(601, 609);
            this.valHumidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valHumidity.Multiline = true;
            this.valHumidity.Name = "valHumidity";
            this.valHumidity.Size = new System.Drawing.Size(132, 41);
            this.valHumidity.TabIndex = 270;
            this.valHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valHumidity.TextChanged += new System.EventHandler(this.valHumidity_TextChanged);
            // 
            // textBox44
            // 
            this.textBox44.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox44.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox44.Location = new System.Drawing.Point(409, 564);
            this.textBox44.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox44.Multiline = true;
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(186, 41);
            this.textBox44.TabIndex = 269;
            this.textBox44.Text = "Temperature";
            this.textBox44.TextChanged += new System.EventHandler(this.textBox44_TextChanged);
            // 
            // valTemperature
            // 
            this.valTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valTemperature.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valTemperature.Location = new System.Drawing.Point(601, 564);
            this.valTemperature.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valTemperature.Multiline = true;
            this.valTemperature.Name = "valTemperature";
            this.valTemperature.Size = new System.Drawing.Size(132, 41);
            this.valTemperature.TabIndex = 267;
            this.valTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valTemperature.TextChanged += new System.EventHandler(this.valTemperature_TextChanged);
            // 
            // tbError
            // 
            this.tbError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbError.Font = new System.Drawing.Font("Montserrat Medium", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbError.Location = new System.Drawing.Point(246, 215);
            this.tbError.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbError.Name = "tbError";
            this.tbError.Size = new System.Drawing.Size(71, 27);
            this.tbError.TabIndex = 276;
            this.tbError.Text = "0.2";
            this.tbError.TextChanged += new System.EventHandler(this.tbError_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 275;
            this.label1.Text = "Error Acceptable";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(791, 294);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 41);
            this.textBox3.TabIndex = 278;
            this.textBox3.Text = "Final Result";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbFinalResult
            // 
            this.tbFinalResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFinalResult.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFinalResult.Location = new System.Drawing.Point(983, 294);
            this.tbFinalResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFinalResult.Multiline = true;
            this.tbFinalResult.Name = "tbFinalResult";
            this.tbFinalResult.Size = new System.Drawing.Size(132, 41);
            this.tbFinalResult.TabIndex = 277;
            this.tbFinalResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFinalResult.TextChanged += new System.EventHandler(this.tbFinalResult_TextChanged);
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1160, 813);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.tbFinalResult);
            this.Controls.Add(this.tbError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox41);
            this.Controls.Add(this.valHumidity);
            this.Controls.Add(this.textBox44);
            this.Controls.Add(this.valTemperature);
            this.Controls.Add(this.textBox26);
            this.Controls.Add(this.resVOut3);
            this.Controls.Add(this.valVOut3);
            this.Controls.Add(this.textBox29);
            this.Controls.Add(this.resVOut2);
            this.Controls.Add(this.valVOut2);
            this.Controls.Add(this.textBox32);
            this.Controls.Add(this.resVOut1);
            this.Controls.Add(this.valVOut1);
            this.Controls.Add(this.textBox35);
            this.Controls.Add(this.resVRef2);
            this.Controls.Add(this.valVRef2);
            this.Controls.Add(this.textBox38);
            this.Controls.Add(this.resVRef1);
            this.Controls.Add(this.valVRef1);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.resV7);
            this.Controls.Add(this.valV7);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.resV8);
            this.Controls.Add(this.valV8);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.resV9);
            this.Controls.Add(this.valV9);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.resV6);
            this.Controls.Add(this.valV6);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.resV5);
            this.Controls.Add(this.valV5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.resV4);
            this.Controls.Add(this.valV4);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.resV3);
            this.Controls.Add(this.valV3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.resV2);
            this.Controls.Add(this.valV2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtbSerialData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.resV1);
            this.Controls.Add(this.valV1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbOperator);
            this.Controls.Add(this.tbModule);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.lbOperator);
            this.Controls.Add(this.lbModule);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.lbPort);
            this.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProduct";
            this.Text = "Production Test";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOperator;
        private System.Windows.Forms.TextBox tbModule;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label lbOperator;
        private System.Windows.Forms.Label lbModule;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label lbPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox resV1;
        private System.Windows.Forms.TextBox valV1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.RichTextBox rtbSerialData;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox resV2;
        private System.Windows.Forms.TextBox valV2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox resV4;
        private System.Windows.Forms.TextBox valV4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox resV3;
        private System.Windows.Forms.TextBox valV3;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox resV6;
        private System.Windows.Forms.TextBox valV6;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox resV5;
        private System.Windows.Forms.TextBox valV5;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox resV7;
        private System.Windows.Forms.TextBox valV7;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox resV8;
        private System.Windows.Forms.TextBox valV8;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox resV9;
        private System.Windows.Forms.TextBox valV9;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox resVOut3;
        private System.Windows.Forms.TextBox valVOut3;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox resVOut2;
        private System.Windows.Forms.TextBox valVOut2;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox resVOut1;
        private System.Windows.Forms.TextBox valVOut1;
        private System.Windows.Forms.TextBox textBox35;
        private System.Windows.Forms.TextBox resVRef2;
        private System.Windows.Forms.TextBox valVRef2;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox resVRef1;
        private System.Windows.Forms.TextBox valVRef1;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.TextBox valHumidity;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox valTemperature;
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tbFinalResult;
    }
}