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
    public partial class createTable : Form
    {

        public static string section_view = "";
   
        public createTable()
        {
            InitializeComponent();
            section_tv.Text = section_view;
            fillAllData();

        }

        private void cross_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void fillAllData()
        {
            int n = datagrid_table.Rows.Add();
            string newline = Environment.NewLine;
            datagrid_table.RowTemplate.Height = 50;

            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    datagrid_table.Rows[n].Cells[0].Value = "Monday";
                    datagrid_table.Rows[n].Cells[1].Value = "";
                    datagrid_table.Rows[n].Cells[2].Value = "Compiler" + newline + "I-101";
                    datagrid_table.Rows[n].Cells[3].Value = "Compiler" + newline + "I-101";
                    datagrid_table.Rows[n].Cells[4].Value = "Vp" + newline + "I-101";
                    datagrid_table.Rows[n].Cells[5].Value = "LA" + newline + "I-101";
                    datagrid_table.Rows[n].Cells[6].Value = "";
                    datagrid_table.Rows[n].Cells[7].Value = "Algorithm" + newline + "Q-301";
                    datagrid_table.Rows[n].Cells[8].Value = "Communication" + newline + "E-303";
                    datagrid_table.Rows[n].Cells[9].Value = "Communication" + newline + "E-303";
                }
                else if (i == 1)
                {
                    datagrid_table.Rows[n].Cells[0].Value = "Tuesday";
                    datagrid_table.Rows[n].Cells[1].Value = "";
                    datagrid_table.Rows[n].Cells[2].Value = "";
                    datagrid_table.Rows[n].Cells[3].Value = "";
                    datagrid_table.Rows[n].Cells[4].Value = "Algorithm" + newline + "I-101";
                    datagrid_table.Rows[n].Cells[5].Value = "Algorithm" + newline + "I-101";
                    datagrid_table.Rows[n].Cells[6].Value = "DCN" + newline + "Q-301";
                    datagrid_table.Rows[n].Cells[7].Value = "DCN" + newline + "Q-301";
                    datagrid_table.Rows[n].Cells[8].Value = "";
                    datagrid_table.Rows[n].Cells[9].Value = "";
                }
                else if (i == 2)
                {
                    datagrid_table.Rows[n].Cells[0].Value = "Wednesday";
                    datagrid_table.Rows[n].Cells[1].Value = "Compiler" + newline + "I-101";
                    datagrid_table.Rows[n].Cells[2].Value = "Compiler" + newline + "I-101";
                    datagrid_table.Rows[n].Cells[3].Value = "Vp" + newline + "I-203";
                    datagrid_table.Rows[n].Cells[4].Value = "Vp" + newline + "I-203";
                    datagrid_table.Rows[n].Cells[5].Value = "Techniqal Writing" + newline + "I-203";
                    datagrid_table.Rows[n].Cells[6].Value = "Linear" + newline + "I-105B";
                    datagrid_table.Rows[n].Cells[7].Value = "VP LAB" + newline + "I-Lab-6";
                    datagrid_table.Rows[n].Cells[8].Value = "VP LAB" + newline + "I-Lab-6";
                    datagrid_table.Rows[n].Cells[9].Value = "";
                }
                else if (i == 3)
                {
                    datagrid_table.Rows[n].Cells[0].Value = "Thursday";
                    datagrid_table.Rows[n].Cells[1].Value = "Compiler LAB" + newline + "Q-LAB-1";
                    datagrid_table.Rows[n].Cells[2].Value = "Compiler LAB" + newline + "Q-LAB-1";
                    datagrid_table.Rows[n].Cells[3].Value = "Compiler LAB" + newline + "Q-LAB-1";
                    datagrid_table.Rows[n].Cells[4].Value = "LA" + newline + "I-101";
                    datagrid_table.Rows[n].Cells[5].Value = "LA" + newline + "I-101";
                    datagrid_table.Rows[n].Cells[6].Value = "DCN" + newline + "Q-304";
                    datagrid_table.Rows[n].Cells[7].Value = "Algorithm" + newline + "I-202";
                    datagrid_table.Rows[n].Cells[8].Value = "Algorithm" + newline + "I-202";
                    datagrid_table.Rows[n].Cells[9].Value = "";
                }
                else if (i == 4)
                {
                    datagrid_table.Rows[n].Cells[0].Value = "Friday";
                    datagrid_table.Rows[n].Cells[1].Value = "DCN LAB" + newline + "A-101";
                    datagrid_table.Rows[n].Cells[2].Value = "DCN LAB" + newline + "A-101";
                    datagrid_table.Rows[n].Cells[3].Value = "DCN LAB" + newline + "I101";
                    datagrid_table.Rows[n].Cells[4].Value = "LA" + newline + "D-203";
                    datagrid_table.Rows[n].Cells[5].Value = "LA" + newline + "D-203";
                    datagrid_table.Rows[n].Cells[6].Value = "";
                    datagrid_table.Rows[n].Cells[7].Value = "Techniqal" + newline + "I-105";
                    datagrid_table.Rows[n].Cells[8].Value = "Techniqal" + newline + "I-105";
                    datagrid_table.Rows[n].Cells[9].Value = "";
                }
                n = datagrid_table.Rows.Add();
            }

            //for (int i = 0; i<=5; i++)
            //{
            //    datagrid_table.RowTemplate.Height = 50;
            //    datagrid_table.Rows[n].Cells[0].Value = "Monday";
            //    datagrid_table.Rows[n].Cells[1].Value = "Algorith"+newline+"I101";
            //    datagrid_table.Rows[n].Cells[2].Value = "Compiler";
            //    datagrid_table.Rows[n].Cells[3].Value = "Vp";
            //    datagrid_table.Rows[n].Cells[4].Value = "Vp";
            //    datagrid_table.Rows[n].Cells[5].Value = "LA";
            //    datagrid_table.Rows[n].Cells[6].Value = "d";
            //    datagrid_table.Rows[n].Cells[7].Value = "Algorith";
            //    datagrid_table.Rows[n].Cells[8].Value = "Algorith";
            //    datagrid_table.Rows[n].Cells[9].Value = "Algorith";
            //}



        }

    }
}
