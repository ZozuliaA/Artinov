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
            this.mcThisMonth = new System.Windows.Forms.MonthCalendar();
            this.mcNextMonth = new System.Windows.Forms.MonthCalendar();
            this.cbChoseSpesialty = new System.Windows.Forms.ComboBox();
            this.labelSelectSpesialty = new System.Windows.Forms.Label();
            this.cbChoseDoctor = new System.Windows.Forms.ComboBox();
            this.labelSelectDoctor = new System.Windows.Forms.Label();
            this.labelSelectTime = new System.Windows.Forms.Label();
            this.rb1000 = new System.Windows.Forms.RadioButton();
            this.rb1020 = new System.Windows.Forms.RadioButton();
            this.rb1040 = new System.Windows.Forms.RadioButton();
            this.rb1100 = new System.Windows.Forms.RadioButton();
            this.rb1200 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // mcThisMonth
            // 
            this.mcThisMonth.Location = new System.Drawing.Point(21, 79);
            this.mcThisMonth.MaxDate = new System.DateTime(2017, 3, 31, 0, 0, 0, 0);
            this.mcThisMonth.MinDate = new System.DateTime(2017, 3, 5, 0, 0, 0, 0);
            this.mcThisMonth.Name = "mcThisMonth";
            this.mcThisMonth.TabIndex = 8;
            this.mcThisMonth.TrailingForeColor = System.Drawing.SystemColors.Highlight;
            // 
            // mcNextMonth
            // 
            this.mcNextMonth.Location = new System.Drawing.Point(21, 259);
            this.mcNextMonth.Name = "mcNextMonth";
            this.mcNextMonth.TabIndex = 9;
            // 
            // cbChoseSpesialty
            // 
            this.cbChoseSpesialty.FormattingEnabled = true;
            this.cbChoseSpesialty.Location = new System.Drawing.Point(47, 28);
            this.cbChoseSpesialty.Name = "cbChoseSpesialty";
            this.cbChoseSpesialty.Size = new System.Drawing.Size(138, 21);
            this.cbChoseSpesialty.TabIndex = 10;
            // 
            // labelSelectSpesialty
            // 
            this.labelSelectSpesialty.AutoSize = true;
            this.labelSelectSpesialty.Location = new System.Drawing.Point(44, 12);
            this.labelSelectSpesialty.Name = "labelSelectSpesialty";
            this.labelSelectSpesialty.Size = new System.Drawing.Size(83, 13);
            this.labelSelectSpesialty.TabIndex = 11;
            this.labelSelectSpesialty.Text = "Select Specialty";
            // 
            // cbChoseDoctor
            // 
            this.cbChoseDoctor.FormattingEnabled = true;
            this.cbChoseDoctor.Location = new System.Drawing.Point(212, 28);
            this.cbChoseDoctor.Name = "cbChoseDoctor";
            this.cbChoseDoctor.Size = new System.Drawing.Size(138, 21);
            this.cbChoseDoctor.TabIndex = 12;
            // 
            // labelSelectDoctor
            // 
            this.labelSelectDoctor.AutoSize = true;
            this.labelSelectDoctor.Location = new System.Drawing.Point(209, 12);
            this.labelSelectDoctor.Name = "labelSelectDoctor";
            this.labelSelectDoctor.Size = new System.Drawing.Size(72, 13);
            this.labelSelectDoctor.TabIndex = 13;
            this.labelSelectDoctor.Text = "Select Doctor";
            // 
            // labelSelectTime
            // 
            this.labelSelectTime.AutoSize = true;
            this.labelSelectTime.Location = new System.Drawing.Point(278, 79);
            this.labelSelectTime.Name = "labelSelectTime";
            this.labelSelectTime.Size = new System.Drawing.Size(63, 13);
            this.labelSelectTime.TabIndex = 15;
            this.labelSelectTime.Text = "Select Time";
            // 
            // rb1000
            // 
            this.rb1000.AutoSize = true;
            this.rb1000.Location = new System.Drawing.Point(281, 105);
            this.rb1000.Name = "rb1000";
            this.rb1000.Size = new System.Drawing.Size(52, 17);
            this.rb1000.TabIndex = 16;
            this.rb1000.TabStop = true;
            this.rb1000.Text = "10:00";
            this.rb1000.UseVisualStyleBackColor = true;
            // 
            // rb1020
            // 
            this.rb1020.AutoSize = true;
            this.rb1020.Location = new System.Drawing.Point(281, 128);
            this.rb1020.Name = "rb1020";
            this.rb1020.Size = new System.Drawing.Size(52, 17);
            this.rb1020.TabIndex = 17;
            this.rb1020.TabStop = true;
            this.rb1020.Text = "10:20";
            this.rb1020.UseVisualStyleBackColor = true;
            // 
            // rb1040
            // 
            this.rb1040.AutoSize = true;
            this.rb1040.Location = new System.Drawing.Point(281, 151);
            this.rb1040.Name = "rb1040";
            this.rb1040.Size = new System.Drawing.Size(52, 17);
            this.rb1040.TabIndex = 18;
            this.rb1040.TabStop = true;
            this.rb1040.Text = "10:40";
            this.rb1040.UseVisualStyleBackColor = true;
            // 
            // rb1100
            // 
            this.rb1100.AutoSize = true;
            this.rb1100.Location = new System.Drawing.Point(281, 174);
            this.rb1100.Name = "rb1100";
            this.rb1100.Size = new System.Drawing.Size(52, 17);
            this.rb1100.TabIndex = 19;
            this.rb1100.TabStop = true;
            this.rb1100.Text = "11:00";
            this.rb1100.UseVisualStyleBackColor = true;
            // 
            // rb1200
            // 
            this.rb1200.AutoSize = true;
            this.rb1200.Location = new System.Drawing.Point(281, 197);
            this.rb1200.Name = "rb1200";
            this.rb1200.Size = new System.Drawing.Size(52, 17);
            this.rb1200.TabIndex = 20;
            this.rb1200.TabStop = true;
            this.rb1200.Text = "12:00";
            this.rb1200.UseVisualStyleBackColor = true;
            // 
            // UcAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rb1200);
            this.Controls.Add(this.rb1100);
            this.Controls.Add(this.rb1040);
            this.Controls.Add(this.rb1020);
            this.Controls.Add(this.rb1000);
            this.Controls.Add(this.labelSelectTime);
            this.Controls.Add(this.labelSelectDoctor);
            this.Controls.Add(this.cbChoseDoctor);
            this.Controls.Add(this.labelSelectSpesialty);
            this.Controls.Add(this.cbChoseSpesialty);
            this.Controls.Add(this.mcNextMonth);
            this.Controls.Add(this.mcThisMonth);
            this.Name = "UcAdmin";
            this.Size = new System.Drawing.Size(716, 460);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcThisMonth;
        private System.Windows.Forms.MonthCalendar mcNextMonth;
        private System.Windows.Forms.ComboBox cbChoseSpesialty;
        private System.Windows.Forms.Label labelSelectSpesialty;
        private System.Windows.Forms.ComboBox cbChoseDoctor;
        private System.Windows.Forms.Label labelSelectDoctor;
        private System.Windows.Forms.Label labelSelectTime;
        private System.Windows.Forms.RadioButton rb1000;
        private System.Windows.Forms.RadioButton rb1020;
        private System.Windows.Forms.RadioButton rb1040;
        private System.Windows.Forms.RadioButton rb1100;
        private System.Windows.Forms.RadioButton rb1200;
    }
}
