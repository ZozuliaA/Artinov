namespace HospitalApointmentSystem.Client
{
    partial class UсPatient
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
            this.labelSelectTime = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.labelSelectDoctor = new System.Windows.Forms.Label();
            this.cbChoseDoctor = new System.Windows.Forms.ComboBox();
            this.labelSelectSpesialty = new System.Windows.Forms.Label();
            this.cbChoseSpesialty = new System.Windows.Forms.ComboBox();
            this.mcNextMonth = new System.Windows.Forms.MonthCalendar();
            this.mcThisMonth = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // labelSelectTime
            // 
            this.labelSelectTime.AutoSize = true;
            this.labelSelectTime.Location = new System.Drawing.Point(280, 75);
            this.labelSelectTime.Name = "labelSelectTime";
            this.labelSelectTime.Size = new System.Drawing.Size(63, 13);
            this.labelSelectTime.TabIndex = 23;
            this.labelSelectTime.Text = "Select Time";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "10:00",
            "10:20",
            "10:40",
            "11:00",
            "11:20",
            "12:00",
            "",
            ""});
            this.checkedListBox1.Location = new System.Drawing.Point(283, 91);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 109);
            this.checkedListBox1.TabIndex = 22;
            // 
            // labelSelectDoctor
            // 
            this.labelSelectDoctor.AutoSize = true;
            this.labelSelectDoctor.Location = new System.Drawing.Point(211, 8);
            this.labelSelectDoctor.Name = "labelSelectDoctor";
            this.labelSelectDoctor.Size = new System.Drawing.Size(72, 13);
            this.labelSelectDoctor.TabIndex = 21;
            this.labelSelectDoctor.Text = "Select Doctor";
            // 
            // cbChoseDoctor
            // 
            this.cbChoseDoctor.FormattingEnabled = true;
            this.cbChoseDoctor.Location = new System.Drawing.Point(214, 24);
            this.cbChoseDoctor.Name = "cbChoseDoctor";
            this.cbChoseDoctor.Size = new System.Drawing.Size(138, 21);
            this.cbChoseDoctor.TabIndex = 20;
            // 
            // labelSelectSpesialty
            // 
            this.labelSelectSpesialty.AutoSize = true;
            this.labelSelectSpesialty.Location = new System.Drawing.Point(46, 8);
            this.labelSelectSpesialty.Name = "labelSelectSpesialty";
            this.labelSelectSpesialty.Size = new System.Drawing.Size(83, 13);
            this.labelSelectSpesialty.TabIndex = 19;
            this.labelSelectSpesialty.Text = "Select Specialty";
            // 
            // cbChoseSpesialty
            // 
            this.cbChoseSpesialty.FormattingEnabled = true;
            this.cbChoseSpesialty.Location = new System.Drawing.Point(49, 24);
            this.cbChoseSpesialty.Name = "cbChoseSpesialty";
            this.cbChoseSpesialty.Size = new System.Drawing.Size(138, 21);
            this.cbChoseSpesialty.TabIndex = 18;
            // 
            // mcNextMonth
            // 
            this.mcNextMonth.Location = new System.Drawing.Point(23, 255);
            this.mcNextMonth.Name = "mcNextMonth";
            this.mcNextMonth.TabIndex = 17;
            // 
            // mcThisMonth
            // 
            this.mcThisMonth.Location = new System.Drawing.Point(23, 75);
            this.mcThisMonth.MaxDate = new System.DateTime(2017, 3, 31, 0, 0, 0, 0);
            this.mcThisMonth.Name = "mcThisMonth";
            this.mcThisMonth.TabIndex = 16;
            this.mcThisMonth.TrailingForeColor = System.Drawing.SystemColors.Highlight;
            // 
            // UсPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSelectTime);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.labelSelectDoctor);
            this.Controls.Add(this.cbChoseDoctor);
            this.Controls.Add(this.labelSelectSpesialty);
            this.Controls.Add(this.cbChoseSpesialty);
            this.Controls.Add(this.mcNextMonth);
            this.Controls.Add(this.mcThisMonth);
            this.Name = "UсPatient";
            this.Size = new System.Drawing.Size(670, 472);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectTime;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label labelSelectDoctor;
        private System.Windows.Forms.ComboBox cbChoseDoctor;
        private System.Windows.Forms.Label labelSelectSpesialty;
        private System.Windows.Forms.ComboBox cbChoseSpesialty;
        private System.Windows.Forms.MonthCalendar mcNextMonth;
        private System.Windows.Forms.MonthCalendar mcThisMonth;
    }
}
