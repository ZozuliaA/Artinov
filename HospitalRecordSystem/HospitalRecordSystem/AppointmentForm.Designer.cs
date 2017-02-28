namespace HospitalApointmentSystem.Client
{
    partial class AppointmentForm
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
            this.mcThisMonth = new System.Windows.Forms.MonthCalendar();
            this.mcNextMonth = new System.Windows.Forms.MonthCalendar();
            this.cbChoseSpesialty = new System.Windows.Forms.ComboBox();
            this.labelChoseSpesialty = new System.Windows.Forms.Label();
            this.labelChoseDoctor = new System.Windows.Forms.Label();
            this.cbChoseDoctor = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // mcThisMonth
            // 
            this.mcThisMonth.Location = new System.Drawing.Point(7, 83);
            this.mcThisMonth.MaxDate = new System.DateTime(2017, 3, 31, 0, 0, 0, 0);
            this.mcThisMonth.Name = "mcThisMonth";
            this.mcThisMonth.TabIndex = 0;
            this.mcThisMonth.TrailingForeColor = System.Drawing.SystemColors.Highlight;
            // 
            // mcNextMonth
            // 
            this.mcNextMonth.Location = new System.Drawing.Point(7, 263);
            this.mcNextMonth.Name = "mcNextMonth";
            this.mcNextMonth.TabIndex = 1;
            // 
            // cbChoseSpesialty
            // 
            this.cbChoseSpesialty.FormattingEnabled = true;
            this.cbChoseSpesialty.Location = new System.Drawing.Point(33, 32);
            this.cbChoseSpesialty.Name = "cbChoseSpesialty";
            this.cbChoseSpesialty.Size = new System.Drawing.Size(138, 21);
            this.cbChoseSpesialty.TabIndex = 2;
            // 
            // labelChoseSpesialty
            // 
            this.labelChoseSpesialty.AutoSize = true;
            this.labelChoseSpesialty.Location = new System.Drawing.Point(30, 16);
            this.labelChoseSpesialty.Name = "labelChoseSpesialty";
            this.labelChoseSpesialty.Size = new System.Drawing.Size(83, 13);
            this.labelChoseSpesialty.TabIndex = 3;
            this.labelChoseSpesialty.Text = "Chose Specialty";
            // 
            // labelChoseDoctor
            // 
            this.labelChoseDoctor.AutoSize = true;
            this.labelChoseDoctor.Location = new System.Drawing.Point(195, 16);
            this.labelChoseDoctor.Name = "labelChoseDoctor";
            this.labelChoseDoctor.Size = new System.Drawing.Size(72, 13);
            this.labelChoseDoctor.TabIndex = 5;
            this.labelChoseDoctor.Text = "Chose Doctor";
            // 
            // cbChoseDoctor
            // 
            this.cbChoseDoctor.FormattingEnabled = true;
            this.cbChoseDoctor.Location = new System.Drawing.Point(198, 32);
            this.cbChoseDoctor.Name = "cbChoseDoctor";
            this.cbChoseDoctor.Size = new System.Drawing.Size(138, 21);
            this.cbChoseDoctor.TabIndex = 4;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(281, 140);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 6;
            // 
            // AppointmentForm
            // 
            this.ClientSize = new System.Drawing.Size(594, 453);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.labelChoseDoctor);
            this.Controls.Add(this.cbChoseDoctor);
            this.Controls.Add(this.labelChoseSpesialty);
            this.Controls.Add(this.cbChoseSpesialty);
            this.Controls.Add(this.mcNextMonth);
            this.Controls.Add(this.mcThisMonth);
            this.Name = "AppointmentForm";
            this.Text = "SomeWorkHere";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcThisMonth;
        private System.Windows.Forms.MonthCalendar mcNextMonth;
        private System.Windows.Forms.ComboBox cbChoseSpesialty;
        private System.Windows.Forms.Label labelChoseSpesialty;
        private System.Windows.Forms.Label labelChoseDoctor;
        private System.Windows.Forms.ComboBox cbChoseDoctor;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}