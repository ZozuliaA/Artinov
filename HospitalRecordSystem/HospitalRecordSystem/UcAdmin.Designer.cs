﻿namespace HospitalApointmentSystem.Client
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
            this.mcThisMonth = new System.Windows.Forms.MonthCalendar();
            this.cbChoseSpesialty = new System.Windows.Forms.ComboBox();
            this.labelSelectSpesialty = new System.Windows.Forms.Label();
            this.cbChoseDoctor = new System.Windows.Forms.ComboBox();
            this.labelSelectDoctor = new System.Windows.Forms.Label();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // mcThisMonth
            // 
            this.mcThisMonth.Location = new System.Drawing.Point(21, 118);
            this.mcThisMonth.MaxDate = new System.DateTime(2017, 3, 31, 0, 0, 0, 0);
            this.mcThisMonth.MinDate = new System.DateTime(2017, 3, 5, 0, 0, 0, 0);
            this.mcThisMonth.Name = "mcThisMonth";
            this.mcThisMonth.TabIndex = 8;
            this.mcThisMonth.TrailingForeColor = System.Drawing.SystemColors.Highlight;
            // 
            // cbChoseSpesialty
            // 
            this.cbChoseSpesialty.FormattingEnabled = true;
            this.cbChoseSpesialty.Location = new System.Drawing.Point(21, 28);
            this.cbChoseSpesialty.Name = "cbChoseSpesialty";
            this.cbChoseSpesialty.Size = new System.Drawing.Size(164, 21);
            this.cbChoseSpesialty.TabIndex = 10;
            // 
            // labelSelectSpesialty
            // 
            this.labelSelectSpesialty.AutoSize = true;
            this.labelSelectSpesialty.Location = new System.Drawing.Point(18, 12);
            this.labelSelectSpesialty.Name = "labelSelectSpesialty";
            this.labelSelectSpesialty.Size = new System.Drawing.Size(83, 13);
            this.labelSelectSpesialty.TabIndex = 11;
            this.labelSelectSpesialty.Text = "Select Specialty";
            // 
            // cbChoseDoctor
            // 
            this.cbChoseDoctor.FormattingEnabled = true;
            this.cbChoseDoctor.Location = new System.Drawing.Point(21, 92);
            this.cbChoseDoctor.Name = "cbChoseDoctor";
            this.cbChoseDoctor.Size = new System.Drawing.Size(164, 21);
            this.cbChoseDoctor.TabIndex = 12;
            // 
            // labelSelectDoctor
            // 
            this.labelSelectDoctor.AutoSize = true;
            this.labelSelectDoctor.Location = new System.Drawing.Point(18, 76);
            this.labelSelectDoctor.Name = "labelSelectDoctor";
            this.labelSelectDoctor.Size = new System.Drawing.Size(72, 13);
            this.labelSelectDoctor.TabIndex = 13;
            this.labelSelectDoctor.Text = "Select Doctor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 27);
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
            this.clbTime.Location = new System.Drawing.Point(211, 43);
            this.clbTime.Name = "clbTime";
            this.clbTime.Size = new System.Drawing.Size(120, 109);
            this.clbTime.TabIndex = 24;
            // 
            // tbDocName
            // 
            this.tbDocName.Location = new System.Drawing.Point(433, 20);
            this.tbDocName.Name = "tbDocName";
            this.tbDocName.Size = new System.Drawing.Size(100, 20);
            this.tbDocName.TabIndex = 26;
            // 
            // labelDocName
            // 
            this.labelDocName.AutoSize = true;
            this.labelDocName.Location = new System.Drawing.Point(373, 23);
            this.labelDocName.Name = "labelDocName";
            this.labelDocName.Size = new System.Drawing.Size(35, 13);
            this.labelDocName.TabIndex = 27;
            this.labelDocName.Text = "Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(433, 46);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 28;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(373, 49);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 29;
            this.labelLastName.Text = "Last Name";
            // 
            // labelSecName
            // 
            this.labelSecName.AutoSize = true;
            this.labelSecName.Location = new System.Drawing.Point(373, 76);
            this.labelSecName.Name = "labelSecName";
            this.labelSecName.Size = new System.Drawing.Size(57, 13);
            this.labelSecName.TabIndex = 31;
            this.labelSecName.Text = "Sec Name";
            // 
            // tbSecondName
            // 
            this.tbSecondName.Location = new System.Drawing.Point(433, 73);
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(100, 20);
            this.tbSecondName.TabIndex = 30;
            // 
            // btAddDoc
            // 
            this.btAddDoc.Location = new System.Drawing.Point(458, 129);
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
            this.clbDay.Location = new System.Drawing.Point(357, 186);
            this.clbDay.Name = "clbDay";
            this.clbDay.Size = new System.Drawing.Size(120, 94);
            this.clbDay.TabIndex = 34;
            // 
            // UcAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Controls.Add(this.labelSelectDoctor);
            this.Controls.Add(this.cbChoseDoctor);
            this.Controls.Add(this.labelSelectSpesialty);
            this.Controls.Add(this.cbChoseSpesialty);
            this.Controls.Add(this.mcThisMonth);
            this.Name = "UcAdmin";
            this.Size = new System.Drawing.Size(716, 348);
            this.Load += new System.EventHandler(this.UcAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcThisMonth;
        private System.Windows.Forms.ComboBox cbChoseSpesialty;
        private System.Windows.Forms.Label labelSelectSpesialty;
        private System.Windows.Forms.ComboBox cbChoseDoctor;
        private System.Windows.Forms.Label labelSelectDoctor;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
