using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignUpDemo
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignupLabel_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
            
        }

        private void signup_Btn_Click(object sender, EventArgs e)
        {
            RecordMainPage rmp = new RecordMainPage();
            this.Hide();
            rmp.Show();
        }
    }
}
