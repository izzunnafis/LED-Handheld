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
using LED_Handheld_Project.Class;

namespace LED_Handheld_Project.Forms
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Mahasiswa UGM\Kerja Praktik\Visual Studio\GitHub LED Handheld Project\Data Connection\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
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
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Mahasiswa UGM\Kerja Praktik\Visual Studio\GitHub LED Handheld Project\Data Connection\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            if (tbConfirmPass.Text != string.Empty || tbPassword.Text != string.Empty || tbUsername.Text != string.Empty)
            {
                if (tbPassword.Text == tbConfirmPass.Text)
                {
                    SqlCommand cmd = new SqlCommand("select * from LoginTable where username = '" + tbUsername.Text + "'", conn);
                    dr = cmd.ExecuteReader();
                }
            }
        }
    }
}
