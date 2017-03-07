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
            this.btLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLogOut
            // 
            this.btLogOut.Location = new System.Drawing.Point(507, 30);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(75, 23);
            this.btLogOut.TabIndex = 8;
            this.btLogOut.Text = "LogOut";
            this.btLogOut.UseVisualStyleBackColor = true;
            // 
            // AppointmentForm
            // 
            this.ClientSize = new System.Drawing.Size(594, 453);
            this.Controls.Add(this.btLogOut);
            this.Name = "AppointmentForm";
            this.Text = "SomeWorkHere";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btLogOut;
    }
}