namespace SignUpDemo
{
    partial class RecordMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordMainPage));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_createtable = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_record = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.clear_all_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tv_labs = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tv_rooms = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tv_floor = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.combo_block = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.combo_campus = new Bunifu.Framework.UI.BunifuDropdown();
            this.cross_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
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
            this.panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.AutoSize = true;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_logout.Location = new System.Drawing.Point(26, 222);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(54, 18);
            this.btn_logout.TabIndex = 21;
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
            this.btn_createtable.TabIndex = 17;
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
            this.btn_record.TabIndex = 16;
            this.btn_record.Text = "View Record";
            this.btn_record.Click += new System.EventHandler(this.btn_record_Click);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuCustomLabel7);
            this.panel2.Controls.Add(this.clear_all_btn);
            this.panel2.Controls.Add(this.bunifuCustomLabel6);
            this.panel2.Controls.Add(this.tv_labs);
            this.panel2.Controls.Add(this.bunifuCustomLabel5);
            this.panel2.Controls.Add(this.tv_rooms);
            this.panel2.Controls.Add(this.bunifuCustomLabel4);
            this.panel2.Controls.Add(this.tv_floor);
            this.panel2.Controls.Add(this.combo_block);
            this.panel2.Controls.Add(this.bunifuCustomLabel3);
            this.panel2.Controls.Add(this.bunifuCustomLabel2);
            this.panel2.Controls.Add(this.combo_campus);
            this.panel2.Controls.Add(this.cross_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(169, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(496, 543);
            this.panel2.TabIndex = 1;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(171, 43);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(156, 29);
            this.bunifuCustomLabel7.TabIndex = 14;
            this.bunifuCustomLabel7.Text = "* * Record * *";
            // 
            // clear_all_btn
            // 
            this.clear_all_btn.ActiveBorderThickness = 1;
            this.clear_all_btn.ActiveCornerRadius = 20;
            this.clear_all_btn.ActiveFillColor = System.Drawing.Color.Navy;
            this.clear_all_btn.ActiveForecolor = System.Drawing.Color.White;
            this.clear_all_btn.ActiveLineColor = System.Drawing.Color.Navy;
            this.clear_all_btn.BackColor = System.Drawing.SystemColors.Control;
            this.clear_all_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear_all_btn.BackgroundImage")));
            this.clear_all_btn.ButtonText = "Clear All";
            this.clear_all_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_all_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_all_btn.ForeColor = System.Drawing.Color.Navy;
            this.clear_all_btn.IdleBorderThickness = 1;
            this.clear_all_btn.IdleCornerRadius = 20;
            this.clear_all_btn.IdleFillColor = System.Drawing.Color.White;
            this.clear_all_btn.IdleForecolor = System.Drawing.Color.Navy;
            this.clear_all_btn.IdleLineColor = System.Drawing.Color.Navy;
            this.clear_all_btn.Location = new System.Drawing.Point(184, 431);
            this.clear_all_btn.Margin = new System.Windows.Forms.Padding(5);
            this.clear_all_btn.Name = "clear_all_btn";
            this.clear_all_btn.Size = new System.Drawing.Size(187, 41);
            this.clear_all_btn.TabIndex = 13;
            this.clear_all_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clear_all_btn.Click += new System.EventHandler(this.clear_all_btn_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(76, 371);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(77, 18);
            this.bunifuCustomLabel6.TabIndex = 12;
            this.bunifuCustomLabel6.Text = "Total Labs";
            // 
            // tv_labs
            // 
            this.tv_labs.BorderColorFocused = System.Drawing.Color.Blue;
            this.tv_labs.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tv_labs.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tv_labs.BorderThickness = 3;
            this.tv_labs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tv_labs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tv_labs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tv_labs.isPassword = false;
            this.tv_labs.Location = new System.Drawing.Point(184, 360);
            this.tv_labs.Margin = new System.Windows.Forms.Padding(4);
            this.tv_labs.Name = "tv_labs";
            this.tv_labs.Size = new System.Drawing.Size(191, 39);
            this.tv_labs.TabIndex = 11;
            this.tv_labs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(76, 312);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(95, 18);
            this.bunifuCustomLabel5.TabIndex = 10;
            this.bunifuCustomLabel5.Text = "Total Rooms";
            // 
            // tv_rooms
            // 
            this.tv_rooms.BorderColorFocused = System.Drawing.Color.Blue;
            this.tv_rooms.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tv_rooms.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tv_rooms.BorderThickness = 3;
            this.tv_rooms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tv_rooms.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tv_rooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tv_rooms.isPassword = false;
            this.tv_rooms.Location = new System.Drawing.Point(184, 301);
            this.tv_rooms.Margin = new System.Windows.Forms.Padding(4);
            this.tv_rooms.Name = "tv_rooms";
            this.tv_rooms.Size = new System.Drawing.Size(191, 39);
            this.tv_rooms.TabIndex = 9;
            this.tv_rooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(76, 258);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(80, 18);
            this.bunifuCustomLabel4.TabIndex = 8;
            this.bunifuCustomLabel4.Text = "Total Floor";
            // 
            // tv_floor
            // 
            this.tv_floor.BorderColorFocused = System.Drawing.Color.Blue;
            this.tv_floor.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tv_floor.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.tv_floor.BorderThickness = 3;
            this.tv_floor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tv_floor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tv_floor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tv_floor.isPassword = false;
            this.tv_floor.Location = new System.Drawing.Point(184, 247);
            this.tv_floor.Margin = new System.Windows.Forms.Padding(4);
            this.tv_floor.Name = "tv_floor";
            this.tv_floor.Size = new System.Drawing.Size(191, 39);
            this.tv_floor.TabIndex = 7;
            this.tv_floor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // combo_block
            // 
            this.combo_block.BackColor = System.Drawing.Color.Transparent;
            this.combo_block.BorderRadius = 3;
            this.combo_block.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_block.ForeColor = System.Drawing.Color.White;
            this.combo_block.Items = new string[0];
            this.combo_block.Location = new System.Drawing.Point(188, 198);
            this.combo_block.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_block.Name = "combo_block";
            this.combo_block.NomalColor = System.Drawing.Color.Navy;
            this.combo_block.onHoverColor = System.Drawing.Color.Navy;
            this.combo_block.selectedIndex = -1;
            this.combo_block.Size = new System.Drawing.Size(187, 36);
            this.combo_block.TabIndex = 6;
            this.combo_block.onItemSelected += new System.EventHandler(this.selectedblock);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(75, 207);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(91, 18);
            this.bunifuCustomLabel3.TabIndex = 5;
            this.bunifuCustomLabel3.Text = "Select Block";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(73, 149);
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
            this.combo_campus.Items = new string[0];
            this.combo_campus.Location = new System.Drawing.Point(188, 143);
            this.combo_campus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_campus.Name = "combo_campus";
            this.combo_campus.NomalColor = System.Drawing.Color.Navy;
            this.combo_campus.onHoverColor = System.Drawing.Color.Navy;
            this.combo_campus.selectedIndex = -1;
            this.combo_campus.Size = new System.Drawing.Size(187, 36);
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
            this.cross_label.MouseLeave += new System.EventHandler(this.Crossbtnleave);
            this.cross_label.MouseHover += new System.EventHandler(this.CrossBtn);
            // 
            // RecordMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 543);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecordMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label cross_label;
        private Bunifu.Framework.UI.BunifuDropdown combo_campus;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDropdown combo_block;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMetroTextbox tv_labs;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMetroTextbox tv_rooms;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuMetroTextbox tv_floor;
        private Bunifu.Framework.UI.BunifuThinButton2 clear_all_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel btn_record;
        private Bunifu.Framework.UI.BunifuCustomLabel btn_createtable;
        private Bunifu.Framework.UI.BunifuCustomLabel btn_logout;
    }
}