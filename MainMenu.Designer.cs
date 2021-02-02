
namespace LED_Handheld_Project
{
    partial class MainMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.BtnDevice = new FontAwesome.Sharp.IconButton();
            this.btnLoadData = new FontAwesome.Sharp.IconButton();
            this.btnProductionTest = new FontAwesome.Sharp.IconButton();
            this.btnRealTime = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.BtnDevice);
            this.panelMenu.Controls.Add(this.btnLoadData);
            this.panelMenu.Controls.Add(this.btnProductionTest);
            this.panelMenu.Controls.Add(this.btnRealTime);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 873);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 380);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSettings.Size = new System.Drawing.Size(220, 60);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // BtnDevice
            // 
            this.BtnDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDevice.FlatAppearance.BorderSize = 0;
            this.BtnDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDevice.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnDevice.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.BtnDevice.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnDevice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDevice.IconSize = 32;
            this.BtnDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDevice.Location = new System.Drawing.Point(0, 320);
            this.BtnDevice.Name = "BtnDevice";
            this.BtnDevice.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnDevice.Size = new System.Drawing.Size(220, 60);
            this.BtnDevice.TabIndex = 4;
            this.BtnDevice.Text = "Device";
            this.BtnDevice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDevice.UseVisualStyleBackColor = true;
            this.BtnDevice.Click += new System.EventHandler(this.BtnDevice_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadData.FlatAppearance.BorderSize = 0;
            this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLoadData.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            this.btnLoadData.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLoadData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadData.IconSize = 32;
            this.btnLoadData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadData.Location = new System.Drawing.Point(0, 260);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLoadData.Size = new System.Drawing.Size(220, 60);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnProductionTest
            // 
            this.btnProductionTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductionTest.FlatAppearance.BorderSize = 0;
            this.btnProductionTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductionTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductionTest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductionTest.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnProductionTest.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProductionTest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductionTest.IconSize = 32;
            this.btnProductionTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductionTest.Location = new System.Drawing.Point(0, 200);
            this.btnProductionTest.Name = "btnProductionTest";
            this.btnProductionTest.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProductionTest.Size = new System.Drawing.Size(220, 60);
            this.btnProductionTest.TabIndex = 2;
            this.btnProductionTest.Text = "Production Test";
            this.btnProductionTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductionTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductionTest.UseVisualStyleBackColor = true;
            this.btnProductionTest.Click += new System.EventHandler(this.btnProductionTest_Click);
            // 
            // btnRealTime
            // 
            this.btnRealTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRealTime.FlatAppearance.BorderSize = 0;
            this.btnRealTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRealTime.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnRealTime.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRealTime.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRealTime.IconSize = 32;
            this.btnRealTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealTime.Location = new System.Drawing.Point(0, 140);
            this.btnRealTime.Name = "btnRealTime";
            this.btnRealTime.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRealTime.Size = new System.Drawing.Size(220, 60);
            this.btnRealTime.TabIndex = 1;
            this.btnRealTime.Text = "Real Time";
            this.btnRealTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRealTime.UseVisualStyleBackColor = true;
            this.btnRealTime.Click += new System.EventHandler(this.btnRealTime_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.LaptopCode;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 45);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(202, 64);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "LED Handheld";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.lbTime);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1162, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Montserrat ExtraBold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(1002, 29);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(57, 27);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Jam";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Montserrat ExtraBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(72, 36);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(94, 35);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 50;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 29);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(50, 50);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1162, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1162, 784);
            this.panelDesktop.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 873);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainMenu";
            this.Text = "LED Handheld";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton BtnDevice;
        private FontAwesome.Sharp.IconButton btnLoadData;
        private FontAwesome.Sharp.IconButton btnProductionTest;
        private FontAwesome.Sharp.IconButton btnRealTime;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

