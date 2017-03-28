namespace HospitalApointmentSystem.Client
{
    partial class UcAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbChoseSpesialty = new System.Windows.Forms.ComboBox();
            this.labelSelectSpesialty = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clbTime = new System.Windows.Forms.CheckedListBox();
            this.tbDocName = new System.Windows.Forms.TextBox();
            this.labelDocName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelSecName = new System.Windows.Forms.Label();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.btAddDoc = new System.Windows.Forms.Button();
            this.clbDay = new System.Windows.Forms.CheckedListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.іToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialtyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDocPassword = new System.Windows.Forms.Label();
            this.tbDocPassword = new System.Windows.Forms.TextBox();
            this.labelDocLogin = new System.Windows.Forms.Label();
            this.tbDocLogin = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbChoseSpesialty
            // 
            this.cbChoseSpesialty.FormattingEnabled = true;
            this.cbChoseSpesialty.Location = new System.Drawing.Point(20, 48);
            this.cbChoseSpesialty.Name = "cbChoseSpesialty";
            this.cbChoseSpesialty.Size = new System.Drawing.Size(164, 21);
            this.cbChoseSpesialty.TabIndex = 10;
            // 
            // labelSelectSpesialty
            // 
            this.labelSelectSpesialty.AutoSize = true;
            this.labelSelectSpesialty.Location = new System.Drawing.Point(17, 32);
            this.labelSelectSpesialty.Name = "labelSelectSpesialty";
            this.labelSelectSpesialty.Size = new System.Drawing.Size(83, 13);
            this.labelSelectSpesialty.TabIndex = 11;
            this.labelSelectSpesialty.Text = "Select Specialty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Select Time";
            // 
            // clbTime
            // 
            this.clbTime.FormattingEnabled = true;
            this.clbTime.Items.AddRange(new object[] {
            "10:00",
            "10:20",
            "10:40",
            "11:00",
            "11:20",
            "12:00",
            "",
            ""});
            this.clbTime.Location = new System.Drawing.Point(23, 252);
            this.clbTime.Name = "clbTime";
            this.clbTime.Size = new System.Drawing.Size(120, 109);
            this.clbTime.TabIndex = 24;
            // 
            // tbDocName
            // 
            this.tbDocName.Location = new System.Drawing.Point(77, 83);
            this.tbDocName.Name = "tbDocName";
            this.tbDocName.Size = new System.Drawing.Size(100, 20);
            this.tbDocName.TabIndex = 26;
            // 
            // labelDocName
            // 
            this.labelDocName.AutoSize = true;
            this.labelDocName.Location = new System.Drawing.Point(17, 86);
            this.labelDocName.Name = "labelDocName";
            this.labelDocName.Size = new System.Drawing.Size(35, 13);
            this.labelDocName.TabIndex = 27;
            this.labelDocName.Text = "Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(77, 109);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 28;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(17, 112);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 29;
            this.labelLastName.Text = "Last Name";
            // 
            // labelSecName
            // 
            this.labelSecName.AutoSize = true;
            this.labelSecName.Location = new System.Drawing.Point(17, 139);
            this.labelSecName.Name = "labelSecName";
            this.labelSecName.Size = new System.Drawing.Size(57, 13);
            this.labelSecName.TabIndex = 31;
            this.labelSecName.Text = "Sec Name";
            // 
            // tbSecondName
            // 
            this.tbSecondName.Location = new System.Drawing.Point(77, 136);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(100, 20);
            this.tbSecondName.TabIndex = 30;
            // 
            // btAddDoc
            // 
            this.btAddDoc.Location = new System.Drawing.Point(275, 252);
            this.btAddDoc.Name = "btAddDoc";
            this.btAddDoc.Size = new System.Drawing.Size(75, 23);
            this.btAddDoc.TabIndex = 32;
            this.btAddDoc.Text = "AddDoc";
            this.btAddDoc.UseVisualStyleBackColor = true;
            this.btAddDoc.Click += new System.EventHandler(this.btAddDoc_Click);
            // 
            // clbDay
            // 
            this.clbDay.FormattingEnabled = true;
            this.clbDay.Items.AddRange(new object[] {
            "Mon",
            "tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat",
            "Sun"});
            this.clbDay.Location = new System.Drawing.Point(149, 252);
            this.clbDay.Name = "clbDay";
            this.clbDay.Size = new System.Drawing.Size(120, 94);
            this.clbDay.TabIndex = 34;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(716, 24);
            this.menuStrip.TabIndex = 35;
            this.menuStrip.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.іToolStripMenuItem,
            this.specialtyToolStripMenuItem,
            this.roomToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // patientToolStripMenuItem
            // 
            this.patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            this.patientToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.patientToolStripMenuItem.Text = "Patient";
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.doctorToolStripMenuItem.Text = "Doctor";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // іToolStripMenuItem
            // 
            this.іToolStripMenuItem.Name = "іToolStripMenuItem";
            this.іToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.іToolStripMenuItem.Text = "Appointment";
            // 
            // specialtyToolStripMenuItem
            // 
            this.specialtyToolStripMenuItem.Name = "specialtyToolStripMenuItem";
            this.specialtyToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.specialtyToolStripMenuItem.Text = "Specialty";
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.roomToolStripMenuItem.Text = "Room";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // labelDocPassword
            // 
            this.labelDocPassword.AutoSize = true;
            this.labelDocPassword.Location = new System.Drawing.Point(17, 192);
            this.labelDocPassword.Name = "labelDocPassword";
            this.labelDocPassword.Size = new System.Drawing.Size(53, 13);
            this.labelDocPassword.TabIndex = 39;
            this.labelDocPassword.Text = "Password";
            // 
            // tbDocPassword
            // 
            this.tbDocPassword.Location = new System.Drawing.Point(77, 189);
            this.tbDocPassword.Name = "tbDocPassword";
            this.tbDocPassword.Size = new System.Drawing.Size(100, 20);
            this.tbDocPassword.TabIndex = 38;
            // 
            // labelDocLogin
            // 
            this.labelDocLogin.AutoSize = true;
            this.labelDocLogin.Location = new System.Drawing.Point(17, 165);
            this.labelDocLogin.Name = "labelDocLogin";
            this.labelDocLogin.Size = new System.Drawing.Size(33, 13);
            this.labelDocLogin.TabIndex = 37;
            this.labelDocLogin.Text = "Login";
            // 
            // tbDocLogin
            // 
            this.tbDocLogin.Location = new System.Drawing.Point(77, 162);
            this.tbDocLogin.Name = "tbDocLogin";
            this.tbDocLogin.Size = new System.Drawing.Size(100, 20);
            this.tbDocLogin.TabIndex = 36;
            // 
            // UcAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDocPassword);
            this.Controls.Add(this.tbDocPassword);
            this.Controls.Add(this.labelDocLogin);
            this.Controls.Add(this.tbDocLogin);
            this.Controls.Add(this.clbDay);
            this.Controls.Add(this.btAddDoc);
            this.Controls.Add(this.labelSecName);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.labelDocName);
            this.Controls.Add(this.tbDocName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clbTime);
            this.Controls.Add(this.labelSelectSpesialty);
            this.Controls.Add(this.cbChoseSpesialty);
            this.Controls.Add(this.menuStrip);
            this.Name = "UcAdmin";
            this.Size = new System.Drawing.Size(716, 405);
            this.Load += new System.EventHandler(this.UcAdmin_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbChoseSpesialty;
        private System.Windows.Forms.Label labelSelectSpesialty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox clbTime;
        private System.Windows.Forms.TextBox tbDocName;
        private System.Windows.Forms.Label labelDocName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelSecName;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.Button btAddDoc;
        private System.Windows.Forms.CheckedListBox clbDay;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem іToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialtyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label labelDocPassword;
        private System.Windows.Forms.TextBox tbDocPassword;
        private System.Windows.Forms.Label labelDocLogin;
        private System.Windows.Forms.TextBox tbDocLogin;
    }
}
