namespace LibraryManagement_Group2_Project.GUI
{
    partial class ReserveGUI
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
            this.dgvReservedBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.btnCheckMember = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtBookNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCRC = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numReservedBooks = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservedBooks
            // 
            this.dgvReservedBooks.AllowUserToAddRows = false;
            this.dgvReservedBooks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvReservedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservedBooks.Location = new System.Drawing.Point(12, 219);
            this.dgvReservedBooks.Name = "dgvReservedBooks";
            this.dgvReservedBooks.RowHeadersWidth = 51;
            this.dgvReservedBooks.RowTemplate.Height = 24;
            this.dgvReservedBooks.Size = new System.Drawing.Size(869, 295);
            this.dgvReservedBooks.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Member code:";
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.Location = new System.Drawing.Point(116, 28);
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.Size = new System.Drawing.Size(172, 22);
            this.txtMemberCode.TabIndex = 2;
            // 
            // btnCheckMember
            // 
            this.btnCheckMember.BackColor = System.Drawing.Color.LightCoral;
            this.btnCheckMember.Location = new System.Drawing.Point(312, 22);
            this.btnCheckMember.Name = "btnCheckMember";
            this.btnCheckMember.Size = new System.Drawing.Size(221, 32);
            this.btnCheckMember.TabIndex = 3;
            this.btnCheckMember.Text = "Check Member";
            this.btnCheckMember.UseVisualStyleBackColor = false;
            this.btnCheckMember.Click += new System.EventHandler(this.btnCheckMember_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Enabled = false;
            this.dtpDate.Location = new System.Drawing.Point(88, 526);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(172, 22);
            this.dtpDate.TabIndex = 4;
            // 
            // txtBookNumber
            // 
            this.txtBookNumber.Enabled = false;
            this.txtBookNumber.Location = new System.Drawing.Point(116, 131);
            this.txtBookNumber.Name = "txtBookNumber";
            this.txtBookNumber.Size = new System.Drawing.Size(172, 22);
            this.txtBookNumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "BookNum:";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(116, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 22);
            this.txtName.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(361, 72);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(172, 22);
            this.txtPhone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(626, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(574, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email:";
            // 
            // btnCRC
            // 
            this.btnCRC.BackColor = System.Drawing.Color.LightCoral;
            this.btnCRC.Enabled = false;
            this.btnCRC.Location = new System.Drawing.Point(312, 126);
            this.btnCRC.Name = "btnCRC";
            this.btnCRC.Size = new System.Drawing.Size(221, 32);
            this.btnCRC.TabIndex = 13;
            this.btnCRC.Text = "Check Reservation Condition";
            this.btnCRC.UseVisualStyleBackColor = false;
            this.btnCRC.Click += new System.EventHandler(this.btnCRC_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "The number of reserved books:";
            // 
            // numReservedBooks
            // 
            this.numReservedBooks.AutoSize = true;
            this.numReservedBooks.Location = new System.Drawing.Point(225, 199);
            this.numReservedBooks.Name = "numReservedBooks";
            this.numReservedBooks.Size = new System.Drawing.Size(16, 17);
            this.numReservedBooks.TabIndex = 15;
            this.numReservedBooks.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 531);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Date:";
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.LightCoral;
            this.btnReserve.Enabled = false;
            this.btnReserve.Location = new System.Drawing.Point(312, 520);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(221, 32);
            this.btnReserve.TabIndex = 17;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // ReserveGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(894, 603);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numReservedBooks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCRC);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookNumber);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnCheckMember);
            this.Controls.Add(this.txtMemberCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReservedBooks);
            this.Name = "ReserveGUI";
            this.Text = "Reserve";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservedBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.Button btnCheckMember;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtBookNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCRC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label numReservedBooks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReserve;
    }
}