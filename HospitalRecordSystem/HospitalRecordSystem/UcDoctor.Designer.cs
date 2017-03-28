namespace HospitalApointmentSystem.Client
{
    partial class UcDoctor
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
            this.labelHD = new System.Windows.Forms.Label();
            this.labelDocName = new System.Windows.Forms.Label();
            this.labelDaysOfWork = new System.Windows.Forms.Label();
            this.lvDoc = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSecName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHisBNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTableName = new System.Windows.Forms.Label();
            this.labelWorkDays = new System.Windows.Forms.Label();
            this.labelWorkTime = new System.Windows.Forms.Label();
            this.labelTimeDoc = new System.Windows.Forms.Label();
            this.btEditDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHD
            // 
            this.labelHD.AutoSize = true;
            this.labelHD.Font = new System.Drawing.Font("Mistral", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHD.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelHD.Location = new System.Drawing.Point(23, 33);
            this.labelHD.Name = "labelHD";
            this.labelHD.Size = new System.Drawing.Size(126, 42);
            this.labelHD.TabIndex = 0;
            this.labelHD.Text = "Hello Doc";
            // 
            // labelDocName
            // 
            this.labelDocName.AutoSize = true;
            this.labelDocName.Font = new System.Drawing.Font("Mistral", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDocName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelDocName.Location = new System.Drawing.Point(155, 33);
            this.labelDocName.Name = "labelDocName";
            this.labelDocName.Size = new System.Drawing.Size(80, 42);
            this.labelDocName.TabIndex = 1;
            this.labelDocName.Text = "Name";
            // 
            // labelDaysOfWork
            // 
            this.labelDaysOfWork.AutoSize = true;
            this.labelDaysOfWork.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDaysOfWork.Location = new System.Drawing.Point(29, 94);
            this.labelDaysOfWork.Name = "labelDaysOfWork";
            this.labelDaysOfWork.Size = new System.Drawing.Size(116, 22);
            this.labelDaysOfWork.TabIndex = 2;
            this.labelDaysOfWork.Text = "My work days: ";
            // 
            // lvDoc
            // 
            this.lvDoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chLastName,
            this.chSecName,
            this.chHisBNum});
            this.lvDoc.GridLines = true;
            this.lvDoc.Location = new System.Drawing.Point(30, 291);
            this.lvDoc.Name = "lvDoc";
            this.lvDoc.Size = new System.Drawing.Size(486, 114);
            this.lvDoc.TabIndex = 3;
            this.lvDoc.UseCompatibleStateImageBehavior = false;
            this.lvDoc.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 101;
            // 
            // chLastName
            // 
            this.chLastName.Text = "Soname";
            this.chLastName.Width = 113;
            // 
            // chSecName
            // 
            this.chSecName.Text = "SecName";
            this.chSecName.Width = 139;
            // 
            // chHisBNum
            // 
            this.chHisBNum.Text = "Historybook Number";
            this.chHisBNum.Width = 125;
            // 
            // labelTableName
            // 
            this.labelTableName.AutoSize = true;
            this.labelTableName.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTableName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.labelTableName.Location = new System.Drawing.Point(29, 266);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(158, 22);
            this.labelTableName.TabIndex = 4;
            this.labelTableName.Text = "My patients for today";
            // 
            // labelWorkDays
            // 
            this.labelWorkDays.AutoSize = true;
            this.labelWorkDays.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorkDays.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelWorkDays.Location = new System.Drawing.Point(136, 94);
            this.labelWorkDays.Name = "labelWorkDays";
            this.labelWorkDays.Size = new System.Drawing.Size(40, 22);
            this.labelWorkDays.TabIndex = 5;
            this.labelWorkDays.Text = "days";
            // 
            // labelWorkTime
            // 
            this.labelWorkTime.AutoSize = true;
            this.labelWorkTime.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorkTime.Location = new System.Drawing.Point(26, 126);
            this.labelWorkTime.Name = "labelWorkTime";
            this.labelWorkTime.Size = new System.Drawing.Size(116, 22);
            this.labelWorkTime.TabIndex = 6;
            this.labelWorkTime.Text = "My work time: ";
            // 
            // labelTimeDoc
            // 
            this.labelTimeDoc.AutoSize = true;
            this.labelTimeDoc.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeDoc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTimeDoc.Location = new System.Drawing.Point(136, 126);
            this.labelTimeDoc.Name = "labelTimeDoc";
            this.labelTimeDoc.Size = new System.Drawing.Size(40, 22);
            this.labelTimeDoc.TabIndex = 7;
            this.labelTimeDoc.Text = "time";
            // 
            // btEditDoc
            // 
            this.btEditDoc.Location = new System.Drawing.Point(520, 51);
            this.btEditDoc.Name = "btEditDoc";
            this.btEditDoc.Size = new System.Drawing.Size(75, 23);
            this.btEditDoc.TabIndex = 8;
            this.btEditDoc.Text = "Edit";
            this.btEditDoc.UseVisualStyleBackColor = true;
            this.btEditDoc.Click += new System.EventHandler(this.btEditDoc_Click);
            // 
            // UcDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btEditDoc);
            this.Controls.Add(this.labelTimeDoc);
            this.Controls.Add(this.labelWorkTime);
            this.Controls.Add(this.labelWorkDays);
            this.Controls.Add(this.labelTableName);
            this.Controls.Add(this.lvDoc);
            this.Controls.Add(this.labelDaysOfWork);
            this.Controls.Add(this.labelDocName);
            this.Controls.Add(this.labelHD);
            this.Name = "UcDoctor";
            this.Size = new System.Drawing.Size(642, 428);
            this.Load += new System.EventHandler(this.UcDoctor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHD;
        private System.Windows.Forms.Label labelDocName;
        private System.Windows.Forms.Label labelDaysOfWork;
        private System.Windows.Forms.ListView lvDoc;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chLastName;
        private System.Windows.Forms.ColumnHeader chSecName;
        private System.Windows.Forms.ColumnHeader chHisBNum;
        private System.Windows.Forms.Label labelTableName;
        private System.Windows.Forms.Label labelWorkDays;
        private System.Windows.Forms.Label labelWorkTime;
        private System.Windows.Forms.Label labelTimeDoc;
        private System.Windows.Forms.Button btEditDoc;
    }
}
