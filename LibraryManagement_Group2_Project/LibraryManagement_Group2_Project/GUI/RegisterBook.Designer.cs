namespace LibraryManagement_Group2_Project.GUI
{
    partial class RegisterBook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtAuthors = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.txtBookNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancelCopy = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteCopy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCopies = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditCopy = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnAddCopy = new System.Windows.Forms.Button();
            this.txtSequenceNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCopyNumber = new System.Windows.Forms.TextBox();
            this.txtBookNumber1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelBook);
            this.groupBox1.Controls.Add(this.btnDeleteBook);
            this.groupBox1.Controls.Add(this.btnEditBook);
            this.groupBox1.Controls.Add(this.btnAddBook);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPublisher);
            this.groupBox1.Controls.Add(this.txtAuthors);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.dgvBooks);
            this.groupBox1.Controls.Add(this.txtBookNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book";
            // 
            // btnCancelBook
            // 
            this.btnCancelBook.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelBook.Location = new System.Drawing.Point(726, 244);
            this.btnCancelBook.Name = "btnCancelBook";
            this.btnCancelBook.Size = new System.Drawing.Size(95, 24);
            this.btnCancelBook.TabIndex = 13;
            this.btnCancelBook.Text = "Cancel";
            this.btnCancelBook.UseVisualStyleBackColor = false;
            this.btnCancelBook.Click += new System.EventHandler(this.btnCancelBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteBook.Enabled = false;
            this.btnDeleteBook.Location = new System.Drawing.Point(625, 244);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(95, 24);
            this.btnDeleteBook.TabIndex = 12;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.BackColor = System.Drawing.Color.LightCoral;
            this.btnEditBook.Enabled = false;
            this.btnEditBook.Location = new System.Drawing.Point(524, 244);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(95, 24);
            this.btnEditBook.TabIndex = 11;
            this.btnEditBook.Text = "Edit";
            this.btnEditBook.UseVisualStyleBackColor = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.LightCoral;
            this.btnAddBook.Location = new System.Drawing.Point(423, 244);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(95, 24);
            this.btnAddBook.TabIndex = 10;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Publisher:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Authors:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Title:";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Enabled = false;
            this.txtPublisher.Location = new System.Drawing.Point(120, 142);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(147, 22);
            this.txtPublisher.TabIndex = 6;
            // 
            // txtAuthors
            // 
            this.txtAuthors.Enabled = false;
            this.txtAuthors.Location = new System.Drawing.Point(120, 114);
            this.txtAuthors.Name = "txtAuthors";
            this.txtAuthors.Size = new System.Drawing.Size(147, 22);
            this.txtAuthors.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(120, 86);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(147, 22);
            this.txtTitle.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.LightCoral;
            this.btnFilter.Location = new System.Drawing.Point(100, 192);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(95, 37);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(310, 21);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(613, 208);
            this.dgvBooks.TabIndex = 2;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // txtBookNumber
            // 
            this.txtBookNumber.Enabled = false;
            this.txtBookNumber.Location = new System.Drawing.Point(120, 58);
            this.txtBookNumber.Name = "txtBookNumber";
            this.txtBookNumber.Size = new System.Drawing.Size(147, 22);
            this.txtBookNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnCancelCopy);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnDeleteCopy);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgvCopies);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnEditCopy);
            this.groupBox2.Controls.Add(this.txtType);
            this.groupBox2.Controls.Add(this.btnAddCopy);
            this.groupBox2.Controls.Add(this.txtSequenceNumber);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCopyNumber);
            this.groupBox2.Controls.Add(this.txtBookNumber1);
            this.groupBox2.Location = new System.Drawing.Point(13, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(929, 296);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Copy";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightCoral;
            this.btnSave.Location = new System.Drawing.Point(100, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 37);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancelCopy
            // 
            this.btnCancelCopy.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancelCopy.Location = new System.Drawing.Point(726, 244);
            this.btnCancelCopy.Name = "btnCancelCopy";
            this.btnCancelCopy.Size = new System.Drawing.Size(95, 24);
            this.btnCancelCopy.TabIndex = 14;
            this.btnCancelCopy.Text = "Cancel";
            this.btnCancelCopy.UseVisualStyleBackColor = false;
            this.btnCancelCopy.Click += new System.EventHandler(this.btnCancelCopy_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(120, 171);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(147, 22);
            this.txtPrice.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Type:";
            // 
            // btnDeleteCopy
            // 
            this.btnDeleteCopy.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteCopy.Enabled = false;
            this.btnDeleteCopy.Location = new System.Drawing.Point(625, 244);
            this.btnDeleteCopy.Name = "btnDeleteCopy";
            this.btnDeleteCopy.Size = new System.Drawing.Size(95, 24);
            this.btnDeleteCopy.TabIndex = 16;
            this.btnDeleteCopy.Text = "Delete";
            this.btnDeleteCopy.UseVisualStyleBackColor = false;
            this.btnDeleteCopy.Click += new System.EventHandler(this.btnDeleteCopy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sequence num:";
            // 
            // dgvCopies
            // 
            this.dgvCopies.AllowUserToAddRows = false;
            this.dgvCopies.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCopies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCopies.Location = new System.Drawing.Point(310, 21);
            this.dgvCopies.Name = "dgvCopies";
            this.dgvCopies.RowHeadersWidth = 51;
            this.dgvCopies.RowTemplate.Height = 24;
            this.dgvCopies.Size = new System.Drawing.Size(613, 208);
            this.dgvCopies.TabIndex = 13;
            this.dgvCopies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCopies_CellClick);
            this.dgvCopies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Copy number:";
            // 
            // btnEditCopy
            // 
            this.btnEditCopy.BackColor = System.Drawing.Color.LightCoral;
            this.btnEditCopy.Enabled = false;
            this.btnEditCopy.Location = new System.Drawing.Point(524, 244);
            this.btnEditCopy.Name = "btnEditCopy";
            this.btnEditCopy.Size = new System.Drawing.Size(95, 24);
            this.btnEditCopy.TabIndex = 15;
            this.btnEditCopy.Text = "Edit";
            this.btnEditCopy.UseVisualStyleBackColor = false;
            this.btnEditCopy.Click += new System.EventHandler(this.btnEditCopy_Click);
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(120, 143);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(39, 22);
            this.txtType.TabIndex = 17;
            // 
            // btnAddCopy
            // 
            this.btnAddCopy.BackColor = System.Drawing.Color.LightCoral;
            this.btnAddCopy.Location = new System.Drawing.Point(423, 244);
            this.btnAddCopy.Name = "btnAddCopy";
            this.btnAddCopy.Size = new System.Drawing.Size(95, 24);
            this.btnAddCopy.TabIndex = 14;
            this.btnAddCopy.Text = "Add";
            this.btnAddCopy.UseVisualStyleBackColor = false;
            this.btnAddCopy.Click += new System.EventHandler(this.btnAddCopy_Click);
            // 
            // txtSequenceNumber
            // 
            this.txtSequenceNumber.Enabled = false;
            this.txtSequenceNumber.Location = new System.Drawing.Point(120, 115);
            this.txtSequenceNumber.Name = "txtSequenceNumber";
            this.txtSequenceNumber.Size = new System.Drawing.Size(147, 22);
            this.txtSequenceNumber.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Book number:";
            // 
            // txtCopyNumber
            // 
            this.txtCopyNumber.Enabled = false;
            this.txtCopyNumber.Location = new System.Drawing.Point(120, 87);
            this.txtCopyNumber.Name = "txtCopyNumber";
            this.txtCopyNumber.Size = new System.Drawing.Size(147, 22);
            this.txtCopyNumber.TabIndex = 15;
            // 
            // txtBookNumber1
            // 
            this.txtBookNumber1.Enabled = false;
            this.txtBookNumber1.Location = new System.Drawing.Point(120, 59);
            this.txtBookNumber1.Name = "txtBookNumber1";
            this.txtBookNumber1.Size = new System.Drawing.Size(147, 22);
            this.txtBookNumber1.TabIndex = 14;
            // 
            // RegisterBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(954, 632);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterBook";
            this.Text = "Book";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCopies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtAuthors;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtBookNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteCopy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCopies;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditCopy;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button btnAddCopy;
        private System.Windows.Forms.TextBox txtSequenceNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCopyNumber;
        private System.Windows.Forms.TextBox txtBookNumber1;
        private System.Windows.Forms.Button btnCancelBook;
        private System.Windows.Forms.Button btnCancelCopy;
        private System.Windows.Forms.Button btnSave;
    }
}