﻿
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelShadow = new System.Windows.Forms.Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panel_clock = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.btnRealTime = new FontAwesome.Sharp.IconButton();
            this.btnProductionTest = new FontAwesome.Sharp.IconButton();
            this.btnLoadData = new FontAwesome.Sharp.IconButton();
            this.BtnDevice = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUjiCoba = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panel_clock.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1195, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 50;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 30);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(51, 50);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Montserrat Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(72, 36);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(94, 35);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(3, 30);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(55, 27);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "Jam";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.panel_clock);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1195, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // panel_clock
            // 
            this.panel_clock.Controls.Add(this.lbTime);
            this.panel_clock.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_clock.Location = new System.Drawing.Point(1050, 0);
            this.panel_clock.Margin = new System.Windows.Forms.Padding(4);
            this.panel_clock.Name = "panel_clock";
            this.panel_clock.Size = new System.Drawing.Size(145, 80);
            this.panel_clock.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnHome.Location = new System.Drawing.Point(12, 46);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(203, 64);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "LED Handheld";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRealTime
            // 
            this.btnRealTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRealTime.FlatAppearance.BorderSize = 0;
            this.btnRealTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealTime.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRealTime.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btnRealTime.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRealTime.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRealTime.IconSize = 32;
            this.btnRealTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealTime.Location = new System.Drawing.Point(0, 140);
            this.btnRealTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRealTime.Name = "btnRealTime";
            this.btnRealTime.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnRealTime.Size = new System.Drawing.Size(220, 60);
            this.btnRealTime.TabIndex = 1;
            this.btnRealTime.Text = "Real Time";
            this.btnRealTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealTime.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRealTime.UseVisualStyleBackColor = true;
            this.btnRealTime.Click += new System.EventHandler(this.btnRealTime_Click);
            // 
            // btnProductionTest
            // 
            this.btnProductionTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductionTest.FlatAppearance.BorderSize = 0;
            this.btnProductionTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductionTest.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductionTest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductionTest.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnProductionTest.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProductionTest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductionTest.IconSize = 32;
            this.btnProductionTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductionTest.Location = new System.Drawing.Point(0, 200);
            this.btnProductionTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductionTest.Name = "btnProductionTest";
            this.btnProductionTest.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnProductionTest.Size = new System.Drawing.Size(220, 60);
            this.btnProductionTest.TabIndex = 2;
            this.btnProductionTest.Text = "Production Test";
            this.btnProductionTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductionTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductionTest.UseVisualStyleBackColor = true;
            this.btnProductionTest.Click += new System.EventHandler(this.btnProductionTest_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadData.FlatAppearance.BorderSize = 0;
            this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadData.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLoadData.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            this.btnLoadData.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLoadData.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoadData.IconSize = 32;
            this.btnLoadData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadData.Location = new System.Drawing.Point(0, 260);
            this.btnLoadData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnLoadData.Size = new System.Drawing.Size(220, 60);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "Load Data";
            this.btnLoadData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // BtnDevice
            // 
            this.BtnDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDevice.FlatAppearance.BorderSize = 0;
            this.BtnDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDevice.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDevice.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnDevice.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.BtnDevice.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnDevice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDevice.IconSize = 32;
            this.BtnDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDevice.Location = new System.Drawing.Point(0, 320);
            this.BtnDevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDevice.Name = "BtnDevice";
            this.BtnDevice.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.BtnDevice.Size = new System.Drawing.Size(220, 60);
            this.BtnDevice.TabIndex = 4;
            this.BtnDevice.Text = "Device";
            this.BtnDevice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDevice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDevice.UseVisualStyleBackColor = true;
            this.BtnDevice.Click += new System.EventHandler(this.BtnDevice_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 380);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnSettings.Size = new System.Drawing.Size(220, 60);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnAbout);
            this.panelMenu.Controls.Add(this.btnUjiCoba);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.BtnDevice);
            this.panelMenu.Controls.Add(this.btnLoadData);
            this.panelMenu.Controls.Add(this.btnProductionTest);
            this.panelMenu.Controls.Add(this.btnRealTime);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 802);
            this.panelMenu.TabIndex = 0;
            // 
            // btnUjiCoba
            // 
            this.btnUjiCoba.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUjiCoba.FlatAppearance.BorderSize = 0;
            this.btnUjiCoba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUjiCoba.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUjiCoba.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUjiCoba.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnUjiCoba.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUjiCoba.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUjiCoba.IconSize = 32;
            this.btnUjiCoba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUjiCoba.Location = new System.Drawing.Point(0, 440);
            this.btnUjiCoba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUjiCoba.Name = "btnUjiCoba";
            this.btnUjiCoba.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnUjiCoba.Size = new System.Drawing.Size(220, 60);
            this.btnUjiCoba.TabIndex = 6;
            this.btnUjiCoba.Text = "Uji Coba Login";
            this.btnUjiCoba.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUjiCoba.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUjiCoba.UseVisualStyleBackColor = true;
            this.btnUjiCoba.Click += new System.EventHandler(this.btnUjiCoba_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 89);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1195, 713);
            this.panelDesktop.TabIndex = 3;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Montserrat Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnAbout.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.IconSize = 32;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 500);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnAbout.Size = new System.Drawing.Size(220, 60);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "About";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(1044, 648);
            this.ClientSize = new System.Drawing.Size(1415, 802);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LED Handheld";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel_clock.ResumeLayout(false);
            this.panel_clock.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelShadow;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnRealTime;
        private FontAwesome.Sharp.IconButton btnProductionTest;
        private FontAwesome.Sharp.IconButton btnLoadData;
        private FontAwesome.Sharp.IconButton BtnDevice;
        private FontAwesome.Sharp.IconButton btnSettings;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel_clock;
        private FontAwesome.Sharp.IconButton btnUjiCoba;
        private FontAwesome.Sharp.IconButton btnAbout;
    }
}

