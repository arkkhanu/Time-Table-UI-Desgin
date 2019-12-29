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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void SignupLabel_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm();
            this.Hide();
            signup.Show();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Btn_Click(object sender, EventArgs e)
        {
            RecordMainPage rmp = new RecordMainPage();
            this.Hide();
            rmp.Show();
        }
    }
}
