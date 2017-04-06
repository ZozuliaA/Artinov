namespace HospitalApointmentSystem.Client
{
    partial class EditDocPassword
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
            this.labelRepeatPass = new System.Windows.Forms.Label();
            this.labelNewPass = new System.Windows.Forms.Label();
            this.labelCurrentPassword = new System.Windows.Forms.Label();
            this.tbEditDocCurrentPassword = new System.Windows.Forms.TextBox();
            this.tbEditDocPasswordRepeat = new System.Windows.Forms.TextBox();
            this.tbEditDocPassword = new System.Windows.Forms.TextBox();
            this.btEditDocPasConfirm = new System.Windows.Forms.Button();
            this.btEditDocPasSave = new System.Windows.Forms.Button();
            this.btEditCotPasCancel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslEditDocPas = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRepeatPass
            // 
            this.labelRepeatPass.AutoSize = true;
            this.labelRepeatPass.Location = new System.Drawing.Point(159, 73);
            this.labelRepeatPass.Name = "labelRepeatPass";
            this.labelRepeatPass.Size = new System.Drawing.Size(91, 13);
            this.labelRepeatPass.TabIndex = 51;
            this.labelRepeatPass.Text = "Repeat Password";
            // 
            // labelNewPass
            // 
            this.labelNewPass.AutoSize = true;
            this.labelNewPass.Location = new System.Drawing.Point(12, 73);
            this.labelNewPass.Name = "labelNewPass";
            this.labelNewPass.Size = new System.Drawing.Size(78, 13);
            this.labelNewPass.TabIndex = 50;
            this.labelNewPass.Text = "New Password";
            // 
            // labelCurrentPassword
            // 
            this.labelCurrentPassword.AutoSize = true;
            this.labelCurrentPassword.Location = new System.Drawing.Point(12, 13);
            this.labelCurrentPassword.Name = "labelCurrentPassword";
            this.labelCurrentPassword.Size = new System.Drawing.Size(53, 26);
            this.labelCurrentPassword.TabIndex = 49;
            this.labelCurrentPassword.Text = "Current\r\nPassword";
            // 
            // tbEditDocCurrentPassword
            // 
            this.tbEditDocCurrentPassword.Location = new System.Drawing.Point(71, 19);
            this.tbEditDocCurrentPassword.Name = "tbEditDocCurrentPassword";
            this.tbEditDocCurrentPassword.Size = new System.Drawing.Size(100, 20);
            this.tbEditDocCurrentPassword.TabIndex = 48;
            this.tbEditDocCurrentPassword.UseSystemPasswordChar = true;
            this.tbEditDocCurrentPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEditDocCurrentPassword_KeyDown);
            // 
            // tbEditDocPasswordRepeat
            // 
            this.tbEditDocPasswordRepeat.Location = new System.Drawing.Point(162, 89);
            this.tbEditDocPasswordRepeat.Name = "tbEditDocPasswordRepeat";
            this.tbEditDocPasswordRepeat.Size = new System.Drawing.Size(100, 20);
            this.tbEditDocPasswordRepeat.TabIndex = 47;
            this.tbEditDocPasswordRepeat.UseSystemPasswordChar = true;
            this.tbEditDocPasswordRepeat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEditDocPasswordRepeat_KeyDown);
            // 
            // tbEditDocPassword
            // 
            this.tbEditDocPassword.Location = new System.Drawing.Point(14, 89);
            this.tbEditDocPassword.Name = "tbEditDocPassword";
            this.tbEditDocPassword.Size = new System.Drawing.Size(100, 20);
            this.tbEditDocPassword.TabIndex = 46;
            this.tbEditDocPassword.UseSystemPasswordChar = true;
            // 
            // btEditDocPasConfirm
            // 
            this.btEditDocPasConfirm.Location = new System.Drawing.Point(189, 17);
            this.btEditDocPasConfirm.Name = "btEditDocPasConfirm";
            this.btEditDocPasConfirm.Size = new System.Drawing.Size(75, 23);
            this.btEditDocPasConfirm.TabIndex = 52;
            this.btEditDocPasConfirm.Text = "Confirm";
            this.btEditDocPasConfirm.UseVisualStyleBackColor = true;
            this.btEditDocPasConfirm.Click += new System.EventHandler(this.btEditDocPasConfirm_Click);
            // 
            // btEditDocPasSave
            // 
            this.btEditDocPasSave.Location = new System.Drawing.Point(189, 126);
            this.btEditDocPasSave.Name = "btEditDocPasSave";
            this.btEditDocPasSave.Size = new System.Drawing.Size(75, 23);
            this.btEditDocPasSave.TabIndex = 53;
            this.btEditDocPasSave.Text = "Save";
            this.btEditDocPasSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEditDocPasSave.UseVisualStyleBackColor = true;
            this.btEditDocPasSave.Click += new System.EventHandler(this.btEditDocPasSave_Click);
            // 
            // btEditCotPasCancel
            // 
            this.btEditCotPasCancel.Location = new System.Drawing.Point(15, 126);
            this.btEditCotPasCancel.Name = "btEditCotPasCancel";
            this.btEditCotPasCancel.Size = new System.Drawing.Size(75, 23);
            this.btEditCotPasCancel.TabIndex = 54;
            this.btEditCotPasCancel.Text = "Cancel";
            this.btEditCotPasCancel.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslEditDocPas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 160);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 55;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslEditDocPas
            // 
            this.tsslEditDocPas.Name = "tsslEditDocPas";
            this.tsslEditDocPas.Size = new System.Drawing.Size(112, 17);
            this.tsslEditDocPas.Text = "Changing Password";
            // 
            // EditDocPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 182);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btEditCotPasCancel);
            this.Controls.Add(this.btEditDocPasSave);
            this.Controls.Add(this.btEditDocPasConfirm);
            this.Controls.Add(this.labelRepeatPass);
            this.Controls.Add(this.labelNewPass);
            this.Controls.Add(this.labelCurrentPassword);
            this.Controls.Add(this.tbEditDocCurrentPassword);
            this.Controls.Add(this.tbEditDocPasswordRepeat);
            this.Controls.Add(this.tbEditDocPassword);
            this.Name = "EditDocPassword";
            this.Text = "EditDocPassword";
            this.Load += new System.EventHandler(this.EditDocPassword_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRepeatPass;
        private System.Windows.Forms.Label labelNewPass;
        private System.Windows.Forms.Label labelCurrentPassword;
        private System.Windows.Forms.TextBox tbEditDocCurrentPassword;
        private System.Windows.Forms.TextBox tbEditDocPasswordRepeat;
        private System.Windows.Forms.TextBox tbEditDocPassword;
        private System.Windows.Forms.Button btEditDocPasConfirm;
        private System.Windows.Forms.Button btEditDocPasSave;
        private System.Windows.Forms.Button btEditCotPasCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslEditDocPas;
    }
}