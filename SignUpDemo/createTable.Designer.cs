namespace SignUpDemo
{
    partial class createTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createTable));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_print = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cross_label = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagrid_table = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.section_tv = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_table)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(309, 21);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(156, 29);
            this.bunifuCustomLabel7.TabIndex = 14;
            this.bunifuCustomLabel7.Text = "* * Record * *";
            // 
            // btn_print
            // 
            this.btn_print.ActiveBorderThickness = 1;
            this.btn_print.ActiveCornerRadius = 20;
            this.btn_print.ActiveFillColor = System.Drawing.Color.Navy;
            this.btn_print.ActiveForecolor = System.Drawing.Color.White;
            this.btn_print.ActiveLineColor = System.Drawing.Color.Navy;
            this.btn_print.BackColor = System.Drawing.SystemColors.Control;
            this.btn_print.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_print.BackgroundImage")));
            this.btn_print.ButtonText = "Print All";
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.Navy;
            this.btn_print.IdleBorderThickness = 1;
            this.btn_print.IdleCornerRadius = 20;
            this.btn_print.IdleFillColor = System.Drawing.Color.White;
            this.btn_print.IdleForecolor = System.Drawing.Color.Navy;
            this.btn_print.IdleLineColor = System.Drawing.Color.Navy;
            this.btn_print.Location = new System.Drawing.Point(344, 446);
            this.btn_print.Margin = new System.Windows.Forms.Padding(5);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(187, 41);
            this.btn_print.TabIndex = 13;
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cross_label
            // 
            this.cross_label.AutoSize = true;
            this.cross_label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cross_label.ForeColor = System.Drawing.Color.Navy;
            this.cross_label.Location = new System.Drawing.Point(809, 9);
            this.cross_label.Name = "cross_label";
            this.cross_label.Size = new System.Drawing.Size(25, 30);
            this.cross_label.TabIndex = 1;
            this.cross_label.Text = "x";
            this.cross_label.Click += new System.EventHandler(this.cross_label_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.section_tv);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.datagrid_table);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.btn_print);
            this.panel2.Controls.Add(this.cross_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 543);
            this.panel2.TabIndex = 3;
            // 
            // datagrid_table
            // 
            this.datagrid_table.AllowUserToAddRows = false;
            this.datagrid_table.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid_table.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.datagrid_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.shift1,
            this.shift2,
            this.shift3,
            this.shift4,
            this.shift5,
            this.shift6,
            this.shift7,
            this.shift8,
            this.shift9});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_table.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_table.DoubleBuffered = true;
            this.datagrid_table.EnableHeadersVisualStyles = false;
            this.datagrid_table.HeaderBgColor = System.Drawing.Color.Navy;
            this.datagrid_table.HeaderForeColor = System.Drawing.Color.White;
            this.datagrid_table.Location = new System.Drawing.Point(7, 103);
            this.datagrid_table.Name = "datagrid_table";
            this.datagrid_table.ReadOnly = true;
            this.datagrid_table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid_table.Size = new System.Drawing.Size(832, 298);
            this.datagrid_table.StandardTab = true;
            this.datagrid_table.TabIndex = 15;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(341, 70);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(70, 18);
            this.bunifuCustomLabel4.TabIndex = 17;
            this.bunifuCustomLabel4.Text = "Section : ";
            // 
            // section_tv
            // 
            this.section_tv.AutoSize = true;
            this.section_tv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section_tv.Location = new System.Drawing.Point(417, 70);
            this.section_tv.Name = "section_tv";
            this.section_tv.Size = new System.Drawing.Size(12, 18);
            this.section_tv.TabIndex = 18;
            this.section_tv.Text = ".";
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            this.Day.Width = 70;
            // 
            // shift1
            // 
            this.shift1.HeaderText = "08:30-09:30";
            this.shift1.Name = "shift1";
            this.shift1.ReadOnly = true;
            this.shift1.Width = 80;
            // 
            // shift2
            // 
            this.shift2.HeaderText = "09:30-10:30";
            this.shift2.Name = "shift2";
            this.shift2.ReadOnly = true;
            this.shift2.Width = 80;
            // 
            // shift3
            // 
            this.shift3.HeaderText = "10:30-11:30";
            this.shift3.Name = "shift3";
            this.shift3.ReadOnly = true;
            this.shift3.Width = 80;
            // 
            // shift4
            // 
            this.shift4.HeaderText = "11:30-12:30";
            this.shift4.Name = "shift4";
            this.shift4.ReadOnly = true;
            this.shift4.Width = 80;
            // 
            // shift5
            // 
            this.shift5.HeaderText = "12:30-01:30";
            this.shift5.Name = "shift5";
            this.shift5.ReadOnly = true;
            this.shift5.Width = 80;
            // 
            // shift6
            // 
            this.shift6.HeaderText = "01:30-02:30";
            this.shift6.Name = "shift6";
            this.shift6.ReadOnly = true;
            this.shift6.Width = 80;
            // 
            // shift7
            // 
            this.shift7.HeaderText = "02:30-03:30";
            this.shift7.Name = "shift7";
            this.shift7.ReadOnly = true;
            this.shift7.Width = 80;
            // 
            // shift8
            // 
            this.shift8.HeaderText = "03:30-04:30";
            this.shift8.Name = "shift8";
            this.shift8.ReadOnly = true;
            this.shift8.Width = 80;
            // 
            // shift9
            // 
            this.shift9.HeaderText = "04:30-05:30";
            this.shift9.Name = "shift9";
            this.shift9.ReadOnly = true;
            this.shift9.Width = 80;
            // 
            // createTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 543);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "createTable";
            this.Text = "createTable";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_print;
        private System.Windows.Forms.Label cross_label;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagrid_table;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel section_tv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift2;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift3;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift4;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift5;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift6;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift7;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift8;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift9;
    }
}