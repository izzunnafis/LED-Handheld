using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.IO.Ports;

namespace LED_Handheld_Project
{
    public partial class MainMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private SerialPort myport; // untuk ports

        //Form real_time_form = new Forms.FormReal();
        //Form product_test_form = new Forms.ProductTest();

        //Constructor
        public MainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            //this.Text = string.Empty;
            //this.ControlBox = false;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); //untuk ports
            myport = new SerialPort();
            myport.Close();
            timer1.Start();
            //myport.BaudRate = 9600;
        }

        //Struct
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Method
        private void ActivatedButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //LeftBorder button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                myport.Close();//Tambahan
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnRealTime_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormReal());
            //OpenChildForm(real_time_form);
        }

        private void btnProductionTest_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.ProductTest());
            //OpenChildForm(product_test_form);
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color3);
            OpenChildForm(new Forms.FormRealTime());
        }

        private void BtnDevice_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color4);
            OpenChildForm(new Forms.FormRealTime());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, RGBColors.color5);
            OpenChildForm(new Forms.FormProduct());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
            //panelDesktop.Controls.Add(new MainMenu());
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("T");
        }
    }
}


