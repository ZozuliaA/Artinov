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
            this.labelSelectDoctor = new System.Windows.Forms.Label();
            this.cbChoseDoctor = new System.Windows.Forms.ComboBox();
            this.labelSelectSpesialty = new System.Windows.Forms.Label();
            this.cbChoseSpesialty = new System.Windows.Forms.ComboBox();
            this.mcThisMonth = new System.Windows.Forms.MonthCalendar();
            this.rb1200 = new System.Windows.Forms.RadioButton();
            this.rb1100 = new System.Windows.Forms.RadioButton();
            this.rb1040 = new System.Windows.Forms.RadioButton();
            this.rb1020 = new System.Windows.Forms.RadioButton();
            this.rb1000 = new System.Windows.Forms.RadioButton();
            this.labelSelectTime = new System.Windows.Forms.Label();
            this.tbSelectedData = new System.Windows.Forms.TextBox();
            this.labelSD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSelectDoctor
            // 
            this.labelSelectDoctor.AutoSize = true;
            this.labelSelectDoctor.Location = new System.Drawing.Point(20, 62);
            this.labelSelectDoctor.Name = "labelSelectDoctor";
            this.labelSelectDoctor.Size = new System.Drawing.Size(72, 13);
            this.labelSelectDoctor.TabIndex = 21;
            this.labelSelectDoctor.Text = "Select Doctor";
            // 
            // cbChoseDoctor
            // 
            this.cbChoseDoctor.FormattingEnabled = true;
            this.cbChoseDoctor.Location = new System.Drawing.Point(23, 78);
            this.cbChoseDoctor.Name = "cbChoseDoctor";
            this.cbChoseDoctor.Size = new System.Drawing.Size(164, 21);
            this.cbChoseDoctor.TabIndex = 20;
            this.cbChoseDoctor.SelectedIndexChanged += new System.EventHandler(this.cbChoseDoctor_SelectedIndexChanged);
            // 
            // labelSelectSpesialty
            // 
            this.labelSelectSpesialty.AutoSize = true;
            this.labelSelectSpesialty.Location = new System.Drawing.Point(20, 8);
            this.labelSelectSpesialty.Name = "labelSelectSpesialty";
            this.labelSelectSpesialty.Size = new System.Drawing.Size(83, 13);
            this.labelSelectSpesialty.TabIndex = 19;
            this.labelSelectSpesialty.Text = "Select Specialty";
            // 
            // cbChoseSpesialty
            // 
            this.cbChoseSpesialty.FormattingEnabled = true;
            this.cbChoseSpesialty.Location = new System.Drawing.Point(23, 24);
            this.cbChoseSpesialty.Name = "cbChoseSpesialty";
            this.cbChoseSpesialty.Size = new System.Drawing.Size(164, 21);
            this.cbChoseSpesialty.TabIndex = 18;
            this.cbChoseSpesialty.SelectedIndexChanged += new System.EventHandler(this.cbChoseSpesialty_SelectedIndexChanged);
            // 
            // mcThisMonth
            // 
            this.mcThisMonth.Location = new System.Drawing.Point(23, 111);
            this.mcThisMonth.MaxDate = new System.DateTime(2017, 3, 31, 0, 0, 0, 0);
            this.mcThisMonth.MinDate = new System.DateTime(2017, 3, 16, 0, 0, 0, 0);
            this.mcThisMonth.Name = "mcThisMonth";
            this.mcThisMonth.TabIndex = 16;
            this.mcThisMonth.TrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.mcThisMonth.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcThisMonth_DateSelected);
            // 
            // rb1200
            // 
            this.rb1200.AutoSize = true;
            this.rb1200.Location = new System.Drawing.Point(262, 259);
            this.rb1200.Name = "rb1200";
            this.rb1200.Size = new System.Drawing.Size(52, 17);
            this.rb1200.TabIndex = 27;
            this.rb1200.TabStop = true;
            this.rb1200.Text = "12:00";
            this.rb1200.UseVisualStyleBackColor = true;
            // 
            // rb1100
            // 
            this.rb1100.AutoSize = true;
            this.rb1100.Location = new System.Drawing.Point(262, 236);
            this.rb1100.Name = "rb1100";
            this.rb1100.Size = new System.Drawing.Size(52, 17);
            this.rb1100.TabIndex = 26;
            this.rb1100.TabStop = true;
            this.rb1100.Text = "11:00";
            this.rb1100.UseVisualStyleBackColor = true;
            // 
            // rb1040
            // 
            this.rb1040.AutoSize = true;
            this.rb1040.Location = new System.Drawing.Point(262, 213);
            this.rb1040.Name = "rb1040";
            this.rb1040.Size = new System.Drawing.Size(52, 17);
            this.rb1040.TabIndex = 25;
            this.rb1040.TabStop = true;
            this.rb1040.Text = "10:40";
            this.rb1040.UseVisualStyleBackColor = true;
            // 
            // rb1020
            // 
            this.rb1020.AutoSize = true;
            this.rb1020.Location = new System.Drawing.Point(262, 190);
            this.rb1020.Name = "rb1020";
            this.rb1020.Size = new System.Drawing.Size(52, 17);
            this.rb1020.TabIndex = 24;
            this.rb1020.TabStop = true;
            this.rb1020.Text = "10:20";
            this.rb1020.UseVisualStyleBackColor = true;
            // 
            // rb1000
            // 
            this.rb1000.AutoSize = true;
            this.rb1000.Location = new System.Drawing.Point(262, 167);
            this.rb1000.Name = "rb1000";
            this.rb1000.Size = new System.Drawing.Size(52, 17);
            this.rb1000.TabIndex = 23;
            this.rb1000.TabStop = true;
            this.rb1000.Text = "10:00";
            this.rb1000.UseVisualStyleBackColor = true;
            // 
            // labelSelectTime
            // 
            this.labelSelectTime.AutoSize = true;
            this.labelSelectTime.Location = new System.Drawing.Point(259, 141);
            this.labelSelectTime.Name = "labelSelectTime";
            this.labelSelectTime.Size = new System.Drawing.Size(63, 13);
            this.labelSelectTime.TabIndex = 22;
            this.labelSelectTime.Text = "Select Time";
            // 
            // tbSelectedData
            // 
            this.tbSelectedData.Location = new System.Drawing.Point(222, 111);
            this.tbSelectedData.Name = "tbSelectedData";
            this.tbSelectedData.Size = new System.Drawing.Size(100, 20);
            this.tbSelectedData.TabIndex = 28;
            // 
            // labelSD
            // 
            this.labelSD.AutoSize = true;
            this.labelSD.Location = new System.Drawing.Point(222, 92);
            this.labelSD.Name = "labelSD";
            this.labelSD.Size = new System.Drawing.Size(100, 13);
            this.labelSD.TabIndex = 29;
            this.labelSD.Text = "Your Selected Data";
            // 
            // UсPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSD);
            this.Controls.Add(this.tbSelectedData);
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
            this.Controls.Add(this.mcThisMonth);
            this.Name = "UсPatient";
            this.Size = new System.Drawing.Size(670, 345);
            this.Load += new System.EventHandler(this.UсPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSelectDoctor;
        private System.Windows.Forms.ComboBox cbChoseDoctor;
        private System.Windows.Forms.Label labelSelectSpesialty;
        private System.Windows.Forms.ComboBox cbChoseSpesialty;
        private System.Windows.Forms.MonthCalendar mcThisMonth;
        private System.Windows.Forms.RadioButton rb1200;
        private System.Windows.Forms.RadioButton rb1100;
        private System.Windows.Forms.RadioButton rb1040;
        private System.Windows.Forms.RadioButton rb1020;
        private System.Windows.Forms.RadioButton rb1000;
        private System.Windows.Forms.Label labelSelectTime;
        private System.Windows.Forms.TextBox tbSelectedData;
        private System.Windows.Forms.Label labelSD;
    }
}
