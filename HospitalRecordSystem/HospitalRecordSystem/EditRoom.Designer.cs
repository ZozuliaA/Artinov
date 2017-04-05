namespace HospitalApointmentSystem.Client
{
    partial class EditRoom
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
            this.labelEditRoom = new System.Windows.Forms.Label();
            this.tbNewRoomNumber = new System.Windows.Forms.TextBox();
            this.btEditRoom = new System.Windows.Forms.Button();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewRoomType = new System.Windows.Forms.TextBox();
            this.labelNewRoomType = new System.Windows.Forms.Label();
            this.labelEditError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEditRoom
            // 
            this.labelEditRoom.AutoSize = true;
            this.labelEditRoom.Location = new System.Drawing.Point(12, 9);
            this.labelEditRoom.Name = "labelEditRoom";
            this.labelEditRoom.Size = new System.Drawing.Size(55, 26);
            this.labelEditRoom.TabIndex = 0;
            this.labelEditRoom.Text = "New room\r\nnumber";
            // 
            // tbNewRoomNumber
            // 
            this.tbNewRoomNumber.Location = new System.Drawing.Point(73, 13);
            this.tbNewRoomNumber.Name = "tbNewRoomNumber";
            this.tbNewRoomNumber.Size = new System.Drawing.Size(100, 20);
            this.tbNewRoomNumber.TabIndex = 1;
            this.tbNewRoomNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNewRoomNumber_KeyPress);
            // 
            // btEditRoom
            // 
            this.btEditRoom.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btEditRoom.Location = new System.Drawing.Point(205, 99);
            this.btEditRoom.Name = "btEditRoom";
            this.btEditRoom.Size = new System.Drawing.Size(75, 23);
            this.btEditRoom.TabIndex = 2;
            this.btEditRoom.Text = "Edit";
            this.btEditRoom.UseVisualStyleBackColor = true;
            this.btEditRoom.Click += new System.EventHandler(this.btEditRoom_Click);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(134, 88);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(39, 17);
            this.rbNo.TabIndex = 10;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Location = new System.Drawing.Point(85, 88);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(43, 17);
            this.rbYes.TabIndex = 9;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Room \r\nunavailable";
            // 
            // tbNewRoomType
            // 
            this.tbNewRoomType.Location = new System.Drawing.Point(73, 46);
            this.tbNewRoomType.Name = "tbNewRoomType";
            this.tbNewRoomType.Size = new System.Drawing.Size(100, 20);
            this.tbNewRoomType.TabIndex = 12;
            // 
            // labelNewRoomType
            // 
            this.labelNewRoomType.AutoSize = true;
            this.labelNewRoomType.Location = new System.Drawing.Point(12, 42);
            this.labelNewRoomType.Name = "labelNewRoomType";
            this.labelNewRoomType.Size = new System.Drawing.Size(58, 26);
            this.labelNewRoomType.TabIndex = 11;
            this.labelNewRoomType.Text = "New room \r\ntype";
            // 
            // labelEditError
            // 
            this.labelEditError.AutoSize = true;
            this.labelEditError.Location = new System.Drawing.Point(204, 15);
            this.labelEditError.Name = "labelEditError";
            this.labelEditError.Size = new System.Drawing.Size(47, 13);
            this.labelEditError.TabIndex = 13;
            this.labelEditError.Text = "EditError";
            // 
            // EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 134);
            this.Controls.Add(this.labelEditError);
            this.Controls.Add(this.tbNewRoomType);
            this.Controls.Add(this.labelNewRoomType);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btEditRoom);
            this.Controls.Add(this.tbNewRoomNumber);
            this.Controls.Add(this.labelEditRoom);
            this.Name = "EditRoom";
            this.Text = "Edit Room";
            this.Load += new System.EventHandler(this.EditRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditRoom;
        private System.Windows.Forms.TextBox tbNewRoomNumber;
        private System.Windows.Forms.Button btEditRoom;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewRoomType;
        private System.Windows.Forms.Label labelNewRoomType;
        private System.Windows.Forms.Label labelEditError;
    }
}