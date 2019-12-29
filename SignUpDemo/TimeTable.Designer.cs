namespace SignUpDemo
{
    partial class TimeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTable));
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_next = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.combo_section = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.combo_dept = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.totalstudents_tv = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.combo_campus = new Bunifu.Framework.UI.BunifuDropdown();
            this.cross_label = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_createtable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_record = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(139, 48);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(202, 29);
            this.bunifuCustomLabel7.TabIndex = 14;
            this.bunifuCustomLabel7.Text = "* * Time Table * *";
            // 
            // btn_next
            // 
            this.btn_next.ActiveBorderThickness = 1;
            this.btn_next.ActiveCornerRadius = 20;
            this.btn_next.ActiveFillColor = System.Drawing.Color.Navy;
            this.btn_next.ActiveForecolor = System.Drawing.Color.White;
            this.btn_next.ActiveLineColor = System.Drawing.Color.Navy;
            this.btn_next.BackColor = System.Drawing.SystemColors.Control;
            this.btn_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_next.BackgroundImage")));
            this.btn_next.ButtonText = "Next";
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.Navy;
            this.btn_next.IdleBorderThickness = 1;
            this.btn_next.IdleCornerRadius = 20;
            this.btn_next.IdleFillColor = System.Drawing.Color.White;
            this.btn_next.IdleForecolor = System.Drawing.Color.Navy;
            this.btn_next.IdleLineColor = System.Drawing.Color.Navy;
            this.btn_next.Location = new System.Drawing.Point(90, 417);
            this.btn_next.Margin = new System.Windows.Forms.Padding(5);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(289, 48);
            this.btn_next.TabIndex = 13;
            this.btn_next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.combo_section);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.combo_dept);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.totalstudents_tv);
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.btn_next);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.combo_campus);
            this.panel2.Controls.Add(this.cross_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(169, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 543);
            this.panel2.TabIndex = 3;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(87, 298);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(103, 18);
            this.bunifuCustomLabel5.TabIndex = 20;
            this.bunifuCustomLabel5.Text = "Select Section";
            // 
            // combo_section
            // 
            this.combo_section.BackColor = System.Drawing.Color.Transparent;
            this.combo_section.BorderRadius = 3;
            this.combo_section.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_section.ForeColor = System.Drawing.Color.White;
            this.combo_section.Items = new string[] {
        "All",
        "A",
        "B",
        "C",
        "D"};
            this.combo_section.Location = new System.Drawing.Point(215, 290);
            this.combo_section.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_section.Name = "combo_section";
            this.combo_section.NomalColor = System.Drawing.Color.Navy;
            this.combo_section.onHoverColor = System.Drawing.Color.Navy;
            this.combo_section.selectedIndex = -1;
            this.combo_section.Size = new System.Drawing.Size(164, 36);
            this.combo_section.TabIndex = 19;
            this.combo_section.onItemSelected += new System.EventHandler(this.onsectionselected);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(87, 239);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(97, 18);
            this.bunifuCustomLabel3.TabIndex = 18;
            this.bunifuCustomLabel3.Text = "Select Depart";
            // 
            // combo_dept
            // 
            this.combo_dept.BackColor = System.Drawing.Color.Transparent;
            this.combo_dept.BorderRadius = 3;
            this.combo_dept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_dept.ForeColor = System.Drawing.Color.White;
            this.combo_dept.Items = new string[] {
        "BSCS",
        "BSIT",
        "BSSE",
        "MSCS"};
            this.combo_dept.Location = new System.Drawing.Point(215, 231);
            this.combo_dept.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_dept.Name = "combo_dept";
            this.combo_dept.NomalColor = System.Drawing.Color.Navy;
            this.combo_dept.onHoverColor = System.Drawing.Color.Navy;
            this.combo_dept.selectedIndex = -1;
            this.combo_dept.Size = new System.Drawing.Size(164, 36);
            this.combo_dept.TabIndex = 17;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(87, 356);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(103, 18);
            this.bunifuCustomLabel4.TabIndex = 16;
            this.bunifuCustomLabel4.Text = "Total Students";
            // 
            // totalstudents_tv
            // 
            this.totalstudents_tv.BorderColorFocused = System.Drawing.Color.Blue;
            this.totalstudents_tv.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalstudents_tv.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.totalstudents_tv.BorderThickness = 3;
            this.totalstudents_tv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalstudents_tv.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.totalstudents_tv.ForeColor = System.Drawing.Color.Navy;
            this.totalstudents_tv.isPassword = false;
            this.totalstudents_tv.Location = new System.Drawing.Point(215, 344);
            this.totalstudents_tv.Margin = new System.Windows.Forms.Padding(4);
            this.totalstudents_tv.Name = "totalstudents_tv";
            this.totalstudents_tv.Size = new System.Drawing.Size(164, 39);
            this.totalstudents_tv.TabIndex = 15;
            this.totalstudents_tv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(87, 181);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(109, 18);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Select Campus";
            // 
            // combo_campus
            // 
            this.combo_campus.BackColor = System.Drawing.Color.Transparent;
            this.combo_campus.BorderRadius = 3;
            this.combo_campus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_campus.ForeColor = System.Drawing.Color.White;
            this.combo_campus.Items = new string[] {
        "Islamabad",
        "Lahore",
        "Karachi"};
            this.combo_campus.Location = new System.Drawing.Point(215, 173);
            this.combo_campus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_campus.Name = "combo_campus";
            this.combo_campus.NomalColor = System.Drawing.Color.Navy;
            this.combo_campus.onHoverColor = System.Drawing.Color.Navy;
            this.combo_campus.selectedIndex = -1;
            this.combo_campus.Size = new System.Drawing.Size(164, 36);
            this.combo_campus.TabIndex = 2;
            // 
            // cross_label
            // 
            this.cross_label.AutoSize = true;
            this.cross_label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cross_label.ForeColor = System.Drawing.Color.Navy;
            this.cross_label.Location = new System.Drawing.Point(453, 6);
            this.cross_label.Name = "cross_label";
            this.cross_label.Size = new System.Drawing.Size(25, 30);
            this.cross_label.TabIndex = 1;
            this.cross_label.Text = "x";
            this.cross_label.Click += new System.EventHandler(this.cross_label_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Navy;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(23, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(81, 18);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Dashboard";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 50);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_createtable);
            this.panel1.Controls.Add(this.btn_record);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 543);
            this.panel1.TabIndex = 2;
            // 
            // btn_logout
            // 
            this.btn_logout.AutoSize = true;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_logout.Location = new System.Drawing.Point(25, 222);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(54, 18);
            this.btn_logout.TabIndex = 20;
            this.btn_logout.Text = "Logout";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_createtable
            // 
            this.btn_createtable.AutoSize = true;
            this.btn_createtable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createtable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_createtable.Location = new System.Drawing.Point(23, 173);
            this.btn_createtable.Name = "btn_createtable";
            this.btn_createtable.Size = new System.Drawing.Size(92, 18);
            this.btn_createtable.TabIndex = 19;
            this.btn_createtable.Text = "Create Table";
            this.btn_createtable.Click += new System.EventHandler(this.btn_createtable_Click);
            // 
            // btn_record
            // 
            this.btn_record.AutoSize = true;
            this.btn_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_record.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_record.Location = new System.Drawing.Point(23, 124);
            this.btn_record.Name = "btn_record";
            this.btn_record.Size = new System.Drawing.Size(92, 18);
            this.btn_record.TabIndex = 18;
            this.btn_record.Text = "View Record";
            this.btn_record.Click += new System.EventHandler(this.btn_record_Click);
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 543);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_next;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDropdown combo_campus;
        private System.Windows.Forms.Label cross_label;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox totalstudents_tv;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDropdown combo_dept;
        private Bunifu.Framework.UI.BunifuCustomLabel btn_createtable;
        private Bunifu.Framework.UI.BunifuCustomLabel btn_record;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuDropdown combo_section;
        private Bunifu.Framework.UI.BunifuCustomLabel btn_logout;
    }
}