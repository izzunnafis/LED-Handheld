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
using LED_Handheld_Project.Class;

namespace LED_Handheld_Project.Forms
{
    public partial class FormSignUp : Form
    {
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Mahasiswa UGM\Kerja Praktik\Visual Studio\GitHub LED Handheld Project\Data Connection\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {

        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private /*async*/ void btnSignup_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(tbUsername.Text))
            //{
            //    MessageBox.Show("Please enter your username!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tbUsername.Focus();
            //    return;
            //}
            //if (tbPassword.Text != tbConfirmPass.Text)
            //{
            //    MessageBox.Show("Password and Confirm Password don't match!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //IUserRepository repository = new UserRepository();
            //bool result = await repository.Insert(new User() { username = tbUsername.Text, password = tbPassword.Text });
            //if (result)
            //    MessageBox.Show("You have successfully signed up!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //else
            //    MessageBox.Show("Error !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (tbUsername.Text == "" || tbPassword.Text == "")
                MessageBox.Show("please fill username and/or password");
            else if (tbPassword.Text != tbConfirmPass.Text)
                MessageBox.Show("Please enter the same password");
            else
            {
                string mainconn = ConfigurationManager.ConnectionStrings["LED_Handheld_Project.Properties.Settings.cn"].ConnectionString;
                //string mainconn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Mahasiswa UGM\Kerja Praktik\Visual Studio\GitHub LED Handheld Project\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection sqlconn = new SqlConnection(mainconn);
                string queary = "Insert into [dbo].[SignUpTable] values (@username, @password, @email)";
                sqlconn.Open();
                SqlCommand sqlcomm = new SqlCommand(queary, sqlconn);
                sqlcomm.Parameters.AddWithValue("@username", tbUsername.Text);
                sqlcomm.Parameters.AddWithValue("@password", tbPassword.Text);
                sqlcomm.Parameters.AddWithValue("@email", tbEmail.Text);
                sqlcomm.ExecuteNonQuery();
                MessageBox.Show("User " + tbUsername.Text + " is successfully registered");
                sqlconn.Close();
                this.Close();
                FormLogin FL = new FormLogin();
                FL.Show();
                
                //using (SqlConnection sqlcon = new SqlConnection(connection))
                //{
                //    sqlcon.Open();
                //    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlcon);
                //    sqlCmd.CommandType = CommandType.StoredProcedure;
                //    sqlCmd.Parameters.AddWithValue("@username", tbUsername.Text.Trim());
                //    sqlCmd.Parameters.AddWithValue("@password", tbPassword.Text.Trim());
                //    sqlCmd.Parameters.AddWithValue("@email", tbEmail.Text.Trim());
                //    sqlCmd.ExecuteNonQuery();
                //    MessageBox.Show("Successfully registered");
                //    Clear();
                //}
            }
        }

        private void Clear()
        {
            tbUsername.Text = tbPassword.Text = tbConfirmPass.Text = tbEmail.Text = "";
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
                tbUsername.Clear();
        }

        private void tbEmail_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Email")
                tbEmail.Clear();
        }
        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmail.Text == "Email")
                tbEmail.Clear();
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
            if (cbShowPassword.Checked == true)
                tbPassword.UseSystemPasswordChar = false;
            else
                tbPassword.UseSystemPasswordChar = true;
        }
        private void tbConfirmPass_Enter(object sender, EventArgs e)
        {
            if (tbConfirmPass.Text == "Confirm Password")
                tbConfirmPass.Clear();
        }

        private void tbConfirmPass_TextChanged_1(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
                tbConfirmPass.UseSystemPasswordChar = false;
            else
                tbConfirmPass.UseSystemPasswordChar = true;
        }
        private void tbConfirmPass_Click(object sender, EventArgs e)
        {
            if (tbConfirmPass.Text == "Confirm Password")
                tbConfirmPass.Clear();
        }


        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
            {
                tbPassword.UseSystemPasswordChar = false;
                tbConfirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;
                tbConfirmPass.UseSystemPasswordChar = true;
            }

        }

        
    }
}
