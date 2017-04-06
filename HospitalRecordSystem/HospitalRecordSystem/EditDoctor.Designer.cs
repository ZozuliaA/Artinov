﻿namespace HospitalApointmentSystem.Client
{
    partial class EditDoctor
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
            this.labelEditDocName = new System.Windows.Forms.Label();
            this.tbEditDocName = new System.Windows.Forms.TextBox();
            this.tbEditDocLastName = new System.Windows.Forms.TextBox();
            this.labelEditDocLastName = new System.Windows.Forms.Label();
            this.tbEditDocSecName = new System.Windows.Forms.TextBox();
            this.labelEditDocSecName = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.clbTime = new System.Windows.Forms.CheckedListBox();
            this.clbDay = new System.Windows.Forms.CheckedListBox();
            this.btSaveChanges = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.labelNewDays = new System.Windows.Forms.Label();
            this.labelChangeTime = new System.Windows.Forms.Label();
            this.btEditDocChangePas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEditDocName
            // 
            this.labelEditDocName.AutoSize = true;
            this.labelEditDocName.Location = new System.Drawing.Point(15, 43);
            this.labelEditDocName.Name = "labelEditDocName";
            this.labelEditDocName.Size = new System.Drawing.Size(35, 13);
            this.labelEditDocName.TabIndex = 0;
            this.labelEditDocName.Text = "Name";
            // 
            // tbEditDocName
            // 
            this.tbEditDocName.Location = new System.Drawing.Point(76, 40);
            this.tbEditDocName.Name = "tbEditDocName";
            this.tbEditDocName.Size = new System.Drawing.Size(100, 20);
            this.tbEditDocName.TabIndex = 1;
            this.tbEditDocName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEditDocName_KeyPress);
            // 
            // tbEditDocLastName
            // 
            this.tbEditDocLastName.Location = new System.Drawing.Point(76, 66);
            this.tbEditDocLastName.Name = "tbEditDocLastName";
            this.tbEditDocLastName.Size = new System.Drawing.Size(100, 20);
            this.tbEditDocLastName.TabIndex = 3;
            this.tbEditDocLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEditDocLastName_KeyPress);
            // 
            // labelEditDocLastName
            // 
            this.labelEditDocLastName.AutoSize = true;
            this.labelEditDocLastName.Location = new System.Drawing.Point(15, 69);
            this.labelEditDocLastName.Name = "labelEditDocLastName";
            this.labelEditDocLastName.Size = new System.Drawing.Size(55, 13);
            this.labelEditDocLastName.TabIndex = 2;
            this.labelEditDocLastName.Text = "LastName";
            // 
            // tbEditDocSecName
            // 
            this.tbEditDocSecName.Location = new System.Drawing.Point(76, 92);
            this.tbEditDocSecName.Name = "tbEditDocSecName";
            this.tbEditDocSecName.Size = new System.Drawing.Size(100, 20);
            this.tbEditDocSecName.TabIndex = 5;
            this.tbEditDocSecName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEditDocSecName_KeyPress);
            // 
            // labelEditDocSecName
            // 
            this.labelEditDocSecName.AutoSize = true;
            this.labelEditDocSecName.Location = new System.Drawing.Point(15, 95);
            this.labelEditDocSecName.Name = "labelEditDocSecName";
            this.labelEditDocSecName.Size = new System.Drawing.Size(54, 13);
            this.labelEditDocSecName.TabIndex = 4;
            this.labelEditDocSecName.Text = "SecName";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(12, 9);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(267, 18);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "Change fields and press \"Save Changes\"";
            // 
            // clbTime
            // 
            this.clbTime.FormattingEnabled = true;
            this.clbTime.Items.AddRange(new object[] {
            "10:00",
            "10:20",
            "10:40",
            "11:00",
            "12:00"});
            this.clbTime.Location = new System.Drawing.Point(114, 148);
            this.clbTime.Name = "clbTime";
            this.clbTime.Size = new System.Drawing.Size(75, 109);
            this.clbTime.TabIndex = 25;
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
            this.clbDay.Location = new System.Drawing.Point(18, 148);
            this.clbDay.Name = "clbDay";
            this.clbDay.Size = new System.Drawing.Size(73, 109);
            this.clbDay.TabIndex = 35;
            // 
            // btSaveChanges
            // 
            this.btSaveChanges.Location = new System.Drawing.Point(114, 300);
            this.btSaveChanges.Name = "btSaveChanges";
            this.btSaveChanges.Size = new System.Drawing.Size(77, 23);
            this.btSaveChanges.TabIndex = 39;
            this.btSaveChanges.Text = "Save Changes";
            this.btSaveChanges.UseVisualStyleBackColor = true;
            this.btSaveChanges.Click += new System.EventHandler(this.btSaveChanges_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(197, 300);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(82, 23);
            this.btCancel.TabIndex = 40;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // labelNewDays
            // 
            this.labelNewDays.AutoSize = true;
            this.labelNewDays.Location = new System.Drawing.Point(16, 129);
            this.labelNewDays.Name = "labelNewDays";
            this.labelNewDays.Size = new System.Drawing.Size(64, 13);
            this.labelNewDays.TabIndex = 41;
            this.labelNewDays.Text = "Select Days";
            // 
            // labelChangeTime
            // 
            this.labelChangeTime.AutoSize = true;
            this.labelChangeTime.Location = new System.Drawing.Point(111, 129);
            this.labelChangeTime.Name = "labelChangeTime";
            this.labelChangeTime.Size = new System.Drawing.Size(63, 13);
            this.labelChangeTime.TabIndex = 42;
            this.labelChangeTime.Text = "Select Time";
            // 
            // btEditDocChangePas
            // 
            this.btEditDocChangePas.Location = new System.Drawing.Point(204, 222);
            this.btEditDocChangePas.Name = "btEditDocChangePas";
            this.btEditDocChangePas.Size = new System.Drawing.Size(75, 35);
            this.btEditDocChangePas.TabIndex = 43;
            this.btEditDocChangePas.Text = "Cange \r\nPassword";
            this.btEditDocChangePas.UseVisualStyleBackColor = true;
            this.btEditDocChangePas.Click += new System.EventHandler(this.btEditDocChangePas_Click);
            // 
            // EditDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(284, 333);
            this.Controls.Add(this.btEditDocChangePas);
            this.Controls.Add(this.labelChangeTime);
            this.Controls.Add(this.labelNewDays);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSaveChanges);
            this.Controls.Add(this.clbDay);
            this.Controls.Add(this.clbTime);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.tbEditDocSecName);
            this.Controls.Add(this.labelEditDocSecName);
            this.Controls.Add(this.tbEditDocLastName);
            this.Controls.Add(this.labelEditDocLastName);
            this.Controls.Add(this.tbEditDocName);
            this.Controls.Add(this.labelEditDocName);
            this.Name = "EditDoctor";
            this.Text = "EditDoctor";
            this.Load += new System.EventHandler(this.EditDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditDocName;
        private System.Windows.Forms.TextBox tbEditDocName;
        private System.Windows.Forms.TextBox tbEditDocLastName;
        private System.Windows.Forms.Label labelEditDocLastName;
        private System.Windows.Forms.TextBox tbEditDocSecName;
        private System.Windows.Forms.Label labelEditDocSecName;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.CheckedListBox clbTime;
        private System.Windows.Forms.CheckedListBox clbDay;
        private System.Windows.Forms.Button btSaveChanges;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label labelNewDays;
        private System.Windows.Forms.Label labelChangeTime;
        private System.Windows.Forms.Button btEditDocChangePas;
    }
}