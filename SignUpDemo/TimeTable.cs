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
    public partial class TimeTable : Form
    {
        public TimeTable()
        {
            InitializeComponent();
            btn_record.ForeColor = Color.FromArgb(64, 64, 64);
            btn_createtable.ForeColor = Color.Navy;
        }


        private void recordmouseclick(object sender, MouseEventArgs e)
        {
            RecordMainPage recordMainpage = new RecordMainPage();
            this.Hide();
            recordMainpage.Show();
        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            RecordMainPage rmp = new RecordMainPage();
            this.Hide();
            rmp.Show();
        }

        private void btn_createtable_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void cross_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void onsectionselected(object sender, EventArgs e)
        {
            if(combo_section.selectedValue == "All")
            {
                totalstudents_tv.Text = "150";
            }
            else
            {
                totalstudents_tv.Text = "35";
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginForm rf = new LoginForm();
            this.Hide();
            rf.Show();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(combo_section.selectedIndex == -1)
            {
                MessageBox.Show("Fields Can't be Empty...");
            }
            else if(combo_section.selectedValue == "All")
            {

            }
            else
            {
                createTable.section_view = combo_section.selectedValue.ToString();
                createTable ctable = new createTable();
                this.Hide();
                ctable.Show();
            }
        }
    }
}
