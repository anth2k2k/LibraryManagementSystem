namespace LibraryManagement_Group2_Project.GUI
{
    partial class ReturnGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBorrowedBooks = new System.Windows.Forms.DataGridView();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.btnCheckMember = new System.Windows.Forms.Button();
            this.dtpReturnedDate = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFineAmount = new System.Windows.Forms.TextBox();
            this.btnConfirmFine = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numBorrowedBooks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member code:";
            // 
            // dgvBorrowedBooks
            // 
            this.dgvBorrowedBooks.AllowUserToAddRows = false;
            this.dgvBorrowedBooks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowedBooks.Location = new System.Drawing.Point(15, 143);
            this.dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            this.dgvBorrowedBooks.RowHeadersWidth = 51;
            this.dgvBorrowedBooks.RowTemplate.Height = 24;
            this.dgvBorrowedBooks.Size = new System.Drawing.Size(899, 278);
            this.dgvBorrowedBooks.TabIndex = 1;
            this.dgvBorrowedBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowedBooks_CellClick);
            this.dgvBorrowedBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrowedBooks_CellContentClick);
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.Location = new System.Drawing.Point(142, 32);
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.Size = new System.Drawing.Size(154, 22);
            this.txtMemberCode.TabIndex = 2;
            // 
            // btnCheckMember
            // 
            this.btnCheckMember.BackColor = System.Drawing.Color.LightCoral;
            this.btnCheckMember.Location = new System.Drawing.Point(325, 26);
            this.btnCheckMember.Name = "btnCheckMember";
            this.btnCheckMember.Size = new System.Drawing.Size(203, 35);
            this.btnCheckMember.TabIndex = 3;
            this.btnCheckMember.Text = "Check Member";
            this.btnCheckMember.UseVisualStyleBackColor = false;
            this.btnCheckMember.Click += new System.EventHandler(this.btnCheckMember_Click);
            // 
            // dtpReturnedDate
            // 
            this.dtpReturnedDate.Location = new System.Drawing.Point(142, 427);
            this.dtpReturnedDate.Name = "dtpReturnedDate";
            this.dtpReturnedDate.Size = new System.Drawing.Size(154, 22);
            this.dtpReturnedDate.TabIndex = 4;
            this.dtpReturnedDate.ValueChanged += new System.EventHandler(this.dtpReturnedDate_ValueChanged);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(142, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 22);
            this.txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(374, 73);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(154, 22);
            this.txtPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(610, 74);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(304, 22);
            this.txtEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Returned Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fine Amount:";
            // 
            // txtFineAmount
            // 
            this.txtFineAmount.Enabled = false;
            this.txtFineAmount.Location = new System.Drawing.Point(610, 427);
            this.txtFineAmount.Name = "txtFineAmount";
            this.txtFineAmount.Size = new System.Drawing.Size(154, 22);
            this.txtFineAmount.TabIndex = 13;
            // 
            // btnConfirmFine
            // 
            this.btnConfirmFine.BackColor = System.Drawing.Color.LightCoral;
            this.btnConfirmFine.Enabled = false;
            this.btnConfirmFine.Location = new System.Drawing.Point(37, 471);
            this.btnConfirmFine.Name = "btnConfirmFine";
            this.btnConfirmFine.Size = new System.Drawing.Size(102, 31);
            this.btnConfirmFine.TabIndex = 14;
            this.btnConfirmFine.Text = "Confirm Fine";
            this.btnConfirmFine.UseVisualStyleBackColor = false;
            this.btnConfirmFine.Click += new System.EventHandler(this.btnConfirmFine_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.LightCoral;
            this.btnReturn.Enabled = false;
            this.btnReturn.Location = new System.Drawing.Point(142, 471);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(86, 31);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "The number of borrowed books:";
            // 
            // numBorrowedBooks
            // 
            this.numBorrowedBooks.AutoSize = true;
            this.numBorrowedBooks.Location = new System.Drawing.Point(228, 123);
            this.numBorrowedBooks.Name = "numBorrowedBooks";
            this.numBorrowedBooks.Size = new System.Drawing.Size(16, 17);
            this.numBorrowedBooks.TabIndex = 17;
            this.numBorrowedBooks.Text = "0";
            // 
            // ReturnGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(926, 531);
            this.Controls.Add(this.numBorrowedBooks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnConfirmFine);
            this.Controls.Add(this.txtFineAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dtpReturnedDate);
            this.Controls.Add(this.btnCheckMember);
            this.Controls.Add(this.txtMemberCode);
            this.Controls.Add(this.dgvBorrowedBooks);
            this.Controls.Add(this.label1);
            this.Name = "ReturnGUI";
            this.Text = "Return";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBorrowedBooks;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.Button btnCheckMember;
        private System.Windows.Forms.DateTimePicker dtpReturnedDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFineAmount;
        private System.Windows.Forms.Button btnConfirmFine;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label numBorrowedBooks;
    }
}