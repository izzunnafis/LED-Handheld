using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            tbUsername.Clear();
            tbPass.Clear();
            tbEmail.Clear();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin mm = new FormLogin();
            mm.Show();
        }
    }
}
