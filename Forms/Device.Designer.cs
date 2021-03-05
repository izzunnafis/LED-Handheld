
namespace LED_Handheld_Project.Forms
{
    partial class Device
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
            this.label2 = new System.Windows.Forms.Label();
            this.SD_space_button = new System.Windows.Forms.Button();
            this.SD_space_progress_bar = new CircularProgressBar.CircularProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_port_select = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_import_clear = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.record_10s = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.SD_space_button);
            this.panel1.Controls.Add(this.SD_space_progress_bar);
            this.panel1.Location = new System.Drawing.Point(529, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 313);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(17, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available SD space";
            // 
            // SD_space_button
            // 
            this.SD_space_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SD_space_button.Location = new System.Drawing.Point(194, 283);
            this.SD_space_button.Margin = new System.Windows.Forms.Padding(4);
            this.SD_space_button.Name = "SD_space_button";
            this.SD_space_button.Size = new System.Drawing.Size(100, 28);
            this.SD_space_button.TabIndex = 1;
            this.SD_space_button.Text = "Check!";
            this.SD_space_button.UseVisualStyleBackColor = true;
            this.SD_space_button.Click += new System.EventHandler(this.SD_space_button_Click);
            // 
            // SD_space_progress_bar
            // 
            this.SD_space_progress_bar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.SD_space_progress_bar.AnimationSpeed = 500;
            this.SD_space_progress_bar.BackColor = System.Drawing.Color.Transparent;
            this.SD_space_progress_bar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SD_space_progress_bar.ForeColor = System.Drawing.Color.White;
            this.SD_space_progress_bar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.SD_space_progress_bar.InnerMargin = 2;
            this.SD_space_progress_bar.InnerWidth = -1;
            this.SD_space_progress_bar.Location = new System.Drawing.Point(124, 39);
            this.SD_space_progress_bar.Margin = new System.Windows.Forms.Padding(4);
            this.SD_space_progress_bar.MarqueeAnimationSpeed = 2000;
            this.SD_space_progress_bar.Name = "SD_space_progress_bar";
            this.SD_space_progress_bar.OuterColor = System.Drawing.Color.Black;
            this.SD_space_progress_bar.OuterMargin = -25;
            this.SD_space_progress_bar.OuterWidth = 26;
            this.SD_space_progress_bar.ProgressColor = System.Drawing.Color.Navy;
            this.SD_space_progress_bar.ProgressWidth = 25;
            this.SD_space_progress_bar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SD_space_progress_bar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SD_space_progress_bar.Size = new System.Drawing.Size(240, 240);
            this.SD_space_progress_bar.StartAngle = 270;
            this.SD_space_progress_bar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SD_space_progress_bar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.SD_space_progress_bar.SubscriptText = "10/";
            this.SD_space_progress_bar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SD_space_progress_bar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.SD_space_progress_bar.SuperscriptText = "11 GB";
            this.SD_space_progress_bar.TabIndex = 1;
            this.SD_space_progress_bar.Text = " ";
            this.SD_space_progress_bar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.SD_space_progress_bar.Value = 68;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb_port_select);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(55, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 76);
            this.panel2.TabIndex = 2;
            // 
            // cb_port_select
            // 
            this.cb_port_select.FormattingEnabled = true;
            this.cb_port_select.Location = new System.Drawing.Point(253, 27);
            this.cb_port_select.Margin = new System.Windows.Forms.Padding(4);
            this.cb_port_select.Name = "cb_port_select";
            this.cb_port_select.Size = new System.Drawing.Size(160, 24);
            this.cb_port_select.TabIndex = 1;
            this.cb_port_select.DropDown += new System.EventHandler(this.cb_port_select_DropDown);
            this.cb_port_select.SelectedIndexChanged += new System.EventHandler(this.cb_port_select_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(74)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Port Select :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_import_clear);
            this.panel3.Controls.Add(this.button_clear);
            this.panel3.Controls.Add(this.button_import);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(55, 206);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(441, 206);
            this.panel3.TabIndex = 3;
            // 
            // button_import_clear
            // 
            this.button_import_clear.Location = new System.Drawing.Point(295, 85);
            this.button_import_clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_import_clear.Name = "button_import_clear";
            this.button_import_clear.Size = new System.Drawing.Size(147, 86);
            this.button_import_clear.TabIndex = 6;
            this.button_import_clear.Text = "Eksport and Clear";
            this.button_import_clear.UseVisualStyleBackColor = true;
            this.button_import_clear.Click += new System.EventHandler(this.button_import_clear_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(143, 85);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(147, 86);
            this.button_clear.TabIndex = 5;
            this.button_clear.Text = "Clear data";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_import
            // 
            this.button_import.Location = new System.Drawing.Point(4, 84);
            this.button_import.Margin = new System.Windows.Forms.Padding(4);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(133, 87);
            this.button_import.TabIndex = 4;
            this.button_import.Text = "Eksport Data";
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Action :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(31, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Arduino SD Card Action";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.record_10s);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(529, 458);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(472, 101);
            this.panel4.TabIndex = 10;
            // 
            // record_10s
            // 
            this.record_10s.Location = new System.Drawing.Point(124, 10);
            this.record_10s.Margin = new System.Windows.Forms.Padding(4);
            this.record_10s.Name = "record_10s";
            this.record_10s.Size = new System.Drawing.Size(267, 87);
            this.record_10s.TabIndex = 5;
            this.record_10s.Text = "Record 10 s";
            this.record_10s.UseVisualStyleBackColor = true;
            this.record_10s.Click += new System.EventHandler(this.record_10s_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(17, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Testing";
            // 
            // Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1083, 574);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Device";
            this.Text = "Device";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Device_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CircularProgressBar.CircularProgressBar SD_space_progress_bar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SD_space_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_port_select;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_import_clear;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button record_10s;
        private System.Windows.Forms.Label label5;
    }
}