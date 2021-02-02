using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LED_Handheld_Project.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //tbUsername.Clear();
            //tbPassword.Clear();

        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
                tbUsername.Clear();
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
                tbPassword.Clear();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Mahasiswa UGM\Kerja Praktik\Visual Studio\GitHub LED Handheld Project\Data Connection\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from LoginTable where username = '" + tbUsername.Text.Trim() + "' and password = '" + tbPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                UjicobaLogin UL = new UjicobaLogin();
                this.Hide();
                UL.Show();
            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            FormSignUp fs = new FormSignUp();
            this.Close();
            fs.ShowDialog();
        }
    }
}
