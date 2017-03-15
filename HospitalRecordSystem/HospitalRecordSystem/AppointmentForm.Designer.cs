using System.Windows.Forms;

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
            this.splitContainerAppointment = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAppointment)).BeginInit();
            this.splitContainerAppointment.Panel2.SuspendLayout();
            this.splitContainerAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLogOut
            // 
            this.btLogOut.Location = new System.Drawing.Point(516, 3);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(75, 23);
            this.btLogOut.TabIndex = 8;
            this.btLogOut.Text = "LogOut";
            this.btLogOut.UseVisualStyleBackColor = true;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // splitContainerAppointment
            // 
            this.splitContainerAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAppointment.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAppointment.Name = "splitContainerAppointment";
            this.splitContainerAppointment.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerAppointment.Panel2
            // 
            this.splitContainerAppointment.Panel2.Controls.Add(this.btLogOut);
            this.splitContainerAppointment.Size = new System.Drawing.Size(594, 453);
            this.splitContainerAppointment.SplitterDistance = 411;
            this.splitContainerAppointment.TabIndex = 9;
            // 
            // AppointmentForm
            // 
            this.ClientSize = new System.Drawing.Size(594, 453);
            this.Controls.Add(this.splitContainerAppointment);
            this.Name = "AppointmentForm";
            this.Text = "SomeWorkHere";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppointmentForm_FormClosing);
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.splitContainerAppointment.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAppointment)).EndInit();
            this.splitContainerAppointment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btLogOut;
        private SplitContainer splitContainerAppointment;
    }
}