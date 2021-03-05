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
using System.Configuration;

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
        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "Password")
                tbPassword.Clear();
        }
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == false)
                tbPassword.UseSystemPasswordChar = true;
            else
                tbPassword.UseSystemPasswordChar = false;
        }
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == false)
                tbPassword.UseSystemPasswordChar = true;
            else
                tbPassword.UseSystemPasswordChar = false;
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            //SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Mahasiswa UGM\Kerja Praktik\Visual Studio\GitHub LED Handheld Project\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            string mainconn = ConfigurationManager.ConnectionStrings["LED_Handheld_Project.Properties.Settings.cn"].ConnectionString;
            string query = "Select * from [dbo].[SignUpTable] where username = @username and password = @password";
            SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand(query, sqlconn);
            sqlcomm.Parameters.AddWithValue("@username", tbUsername.Text);
            sqlcomm.Parameters.AddWithValue("@password", tbPassword.Text);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            //SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            sqlcomm.ExecuteNonQuery();
            if (dtbl.Rows.Count > 0)
            {
                this.Close();
                DialogResult = DialogResult.OK;
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
