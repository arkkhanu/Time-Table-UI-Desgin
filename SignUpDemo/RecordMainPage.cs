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
    public partial class RecordMainPage : Form
    {
        public RecordMainPage()
        {
            InitializeComponent();
            btn_record.ForeColor = Color.Navy;
            btn_createtable.ForeColor = Color.FromArgb(64, 64, 64);
            addBlock();
            addCampus();
        }

        private void CrossBtn(object sender, EventArgs e)
        {
            cross_label.ForeColor = Color.Red;
        }

        private void Crossbtnleave(object sender, EventArgs e)
        {
            cross_label.ForeColor = Color.Navy;
        }

        private void cross_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_record_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btn_createtable_Click(object sender, EventArgs e)
        {
            TimeTable tt = new TimeTable();
            this.Hide();
            tt.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginForm rf = new LoginForm();
            this.Hide();
            rf.Show();
        }

        private void selectedblock(object sender, EventArgs e)
        {
            if(combo_block.selectedValue == "Quaid")
            {
                tv_floor.Text = "3";
                tv_labs.Text = "5";
                tv_rooms.Text = "60";
            }
            else if(combo_block.selectedValue == "Sir Syed")
            {
                tv_floor.Text = "5";
                tv_labs.Text = "10";
                tv_rooms.Text = "75";
            }
            else if (combo_block.selectedValue == "Iqbal")
            {
                tv_floor.Text = "3";
                tv_labs.Text = "7";
                tv_rooms.Text = "54";
            }
            else if (combo_block.selectedValue == "IIP")
            {
                tv_floor.Text = "6";
                tv_labs.Text = "0";
                tv_rooms.Text = "60";
            }
        }

        private void clear_all_btn_Click(object sender, EventArgs e)
        {
            combo_block.Clear();
            combo_campus.Clear();
            tv_floor.Text = "";
            tv_labs.Text = "";
            tv_rooms.Text = "";
            addBlock();
        }
        
        private void addBlock()
        {
            combo_block.AddItem("Quaid");
            combo_block.AddItem("Sir Syed");
            combo_block.AddItem("Iqbal");
            combo_block.AddItem("IIP");
        }

        private void addCampus()
        {
            combo_campus.AddItem("Islamabad");
            combo_campus.AddItem("Lahore");
            combo_campus.AddItem("Karachi");
        }
    }
}
