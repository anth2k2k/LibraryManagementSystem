using LibraryManagement_Group2_Project.DAL;
using LibraryManagement_Group2_Project.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement_Group2_Project.GUI
{
    public partial class RegisterBook : Form
    {
        //1:Add, 2:Edit, 3:Search
        public static int check = 0;
        //1:Add, 2:Edit
        public static int check1 = 0;

        public RegisterBook()
        {
            InitializeComponent();
            display(0);
            check = 0;
            check1 = 0;
            dgvBooks.DataSource = BookDAO.GetDataTable();
        }

        private void display(int i)
        {
            switch (i)
            {
                case 0:
                    check = 0;
                    btnFilter.Text = "Filter";
                    txtBookNumber.Enabled = false;
                    txtTitle.Enabled = false;
                    txtAuthors.Enabled = false;
                    txtPublisher.Enabled = false;
                    btnAddBook.Enabled = true;
                    btnEditBook.Enabled = false;
                    btnDeleteBook.Enabled = false;
                    txtBookNumber.Text = "";
                    txtTitle.Text = "";
                    txtAuthors.Text = "";
                    txtPublisher.Text = "";

                    txtBookNumber1.Text = "";
                    txtCopyNumber.Text = "";
                    txtSequenceNumber.Text = "";
                    txtType.Text = "";
                    txtPrice.Text = "";
                    dgvCopies.DataSource = new DataTable();
                    dgvBooks.DataSource = BookDAO.GetDataTable();
                    txtBookNumber1.Enabled = false;
                    txtCopyNumber.Enabled = false;
                    txtSequenceNumber.Enabled = false;
                    txtType.Enabled = false;
                    txtPrice.Enabled = false;
                    btnAddCopy.Enabled = false;
                    btnEditCopy.Enabled = false;
                    btnDeleteCopy.Enabled = false;
                    btnFilter.Text = "Filter";
                    break;
                case 1://Choose Book
                    txtBookNumber.Enabled = false;
                    txtTitle.Enabled = false;
                    txtAuthors.Enabled = false;
                    txtPublisher.Enabled = false;
                    btnEditBook.Enabled = true;
                    btnDeleteBook.Enabled = true;

                    txtBookNumber1.Enabled = false;
                    txtCopyNumber.Enabled = false;
                    txtSequenceNumber.Enabled = false;
                    txtType.Enabled = false;
                    txtPrice.Enabled = false;
                    btnAddCopy.Enabled = true;
                    btnEditCopy.Enabled = false;
                    btnDeleteCopy.Enabled = false;
                    break;
                case 2://Add
                    btnFilter.Text = "Save";
                    txtBookNumber.Enabled = false;
                    txtBookNumber.Text = "";
                    txtTitle.Enabled = true;
                    txtTitle.Text = "";
                    txtAuthors.Enabled = true;
                    txtAuthors.Text = "";
                    txtPublisher.Enabled = true;
                    txtPublisher.Text = "";
                    btnAddBook.Enabled = false;
                    btnEditBook.Enabled = false;
                    btnDeleteBook.Enabled = false;
                    break;
                case 3://Edit
                    btnFilter.Text = "Save";
                    txtBookNumber.Enabled = false;
                    txtTitle.Enabled = true;
                    txtAuthors.Enabled = true;
                    txtPublisher.Enabled = true;
                    btnAddBook.Enabled = false;
                    btnEditBook.Enabled = false;
                    btnDeleteBook.Enabled = false;
                    break;
                case 4:
                    txtBookNumber1.Enabled = false;
                    txtCopyNumber.Enabled = false;
                    txtSequenceNumber.Enabled = false;
                    txtType.Enabled = false;
                    txtPrice.Enabled = false;
                    btnAddCopy.Enabled = true;
                    btnEditCopy.Enabled = true;
                    btnDeleteCopy.Enabled = true;
                    break;
                case 5:
                    check1 = 0;
                    txtCopyNumber.Text = "";
                    txtSequenceNumber.Text = "";
                    txtType.Text = "";
                    txtPrice.Text = "";
                    txtBookNumber1.Enabled = false;
                    txtCopyNumber.Enabled = false;
                    txtSequenceNumber.Enabled = false;
                    txtType.Enabled = false;
                    txtPrice.Enabled = false;
                    btnAddCopy.Enabled = true;
                    btnEditCopy.Enabled = false;
                    btnDeleteCopy.Enabled = false;
                    break;
                case 6:
                    txtCopyNumber.Text = "";
                    txtSequenceNumber.Text = "";
                    txtType.Text = "0";
                    txtPrice.Text = "";
                    txtBookNumber1.Enabled = false;
                    txtCopyNumber.Enabled = false;
                    txtSequenceNumber.Enabled = true;
                    txtType.Enabled = false;
                    txtPrice.Enabled = true;
                    btnAddCopy.Enabled = false;
                    btnEditCopy.Enabled = false;
                    btnDeleteCopy.Enabled = false;
                    break;
                case 7:
                    txtBookNumber1.Enabled = false;
                    txtCopyNumber.Enabled = false;
                    txtSequenceNumber.Enabled = true;
                    txtType.Enabled = false;
                    txtPrice.Enabled = true;
                    btnAddCopy.Enabled = false;
                    btnEditCopy.Enabled = false;
                    btnDeleteCopy.Enabled = false;
                    break;
                case 8:
                    txtBookNumber.Enabled = true;
                    txtBookNumber.Text = "";
                    txtTitle.Enabled = true;
                    txtTitle.Text = "";
                    txtAuthors.Enabled = true;
                    txtAuthors.Text = "";
                    txtPublisher.Enabled = true;
                    txtPublisher.Text = "";
                    btnAddBook.Enabled = false;
                    btnEditBook.Enabled = false;
                    btnDeleteBook.Enabled = false;
                    btnFilter.Enabled = true;
                    btnFilter.Text = "Search";

                    txtBookNumber1.Text = "";
                    txtCopyNumber.Text = "";
                    txtSequenceNumber.Text = "";
                    txtType.Text = "";
                    txtPrice.Text = "";
                    dgvCopies.DataSource = new DataTable();
                    txtBookNumber1.Enabled = false;
                    txtCopyNumber.Enabled = false;
                    txtSequenceNumber.Enabled = false;
                    txtType.Enabled = false;
                    txtPrice.Enabled = false;
                    btnAddCopy.Enabled = false;
                    btnEditCopy.Enabled = false;
                    btnDeleteCopy.Enabled = false;
                    break;
            }
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            display(1);
            Book b = BookDAO.GetBook(Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells["bookNumber"].Value));
            txtBookNumber.Text = b.BookNumber.ToString();
            txtTitle.Text = b.Title;
            txtAuthors.Text = b.Authors;
            txtPublisher.Text = b.Publisher;
            dgvCopies.DataSource = CopyDAO.GetDataTable(b.BookNumber);
            txtBookNumber1.Text = b.BookNumber.ToString();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            check = 1;
            display(2);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (check == 1)//Add
            {
                Book b = new Book();
                b.Title = txtTitle.Text;
                b.Authors = txtAuthors.Text;
                b.Publisher = txtPublisher.Text;
                if (BookDAO.ValidateBook(b))
                {
                    BookDAO.Add(b);
                    dgvBooks.DataSource = BookDAO.GetDataTable();
                    MessageBox.Show("Add Successful");
                    display(0);
                    check = 0;
                }
            } else if (check == 2)//Edit
            {
                Book b = new Book();
                b.BookNumber = Convert.ToInt32(txtBookNumber.Text);
                b.Title = txtTitle.Text;
                b.Authors = txtAuthors.Text;
                b.Publisher = txtPublisher.Text;
                if (BookDAO.ValidateBook(b))
                {
                    BookDAO.Edit(b);
                    dgvBooks.DataSource = BookDAO.GetDataTable();
                    MessageBox.Show("Edit Successful");
                    display(0);
                    check = 0;
                }
            }
            else if (check == 0)
            {
                check = 3;
                display(8);
            }
            else if (check == 3)
            {
                Book b = new Book();
                b.BookNumber = (txtBookNumber.Text != "") ? Convert.ToInt32(txtBookNumber.Text) : -1;
                b.Title = txtTitle.Text;
                b.Authors = txtAuthors.Text;
                b.Publisher = txtPublisher.Text;
                dgvBooks.DataSource = BookDAO.SearchBook(b);
                btnAddBook.Enabled = true;
            }
        }

        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            display(0);
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            Book b = new Book();
            b.BookNumber = Convert.ToInt32(txtBookNumber.Text);
            BookDAO.Delete(b);
            dgvBooks.DataSource = BookDAO.GetDataTable();
            MessageBox.Show("Delete Successful");
            display(0);
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            check = 2;
            display(3);
        }

        private void dgvCopies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            display(4);
            Copy c = CopyDAO.GetCopy(Convert.ToInt32(dgvCopies.Rows[e.RowIndex].Cells["copyNumber"].Value));
            txtCopyNumber.Text = c.CopyNumber.ToString();
            txtSequenceNumber.Text = c.SequenceNumber.ToString();
            txtType.Text = c.Type.ToString();
            txtPrice.Text = c.Price.ToString();
        }

        private void btnCancelCopy_Click(object sender, EventArgs e)
        {
            display(5);
        }

        private void btnAddCopy_Click(object sender, EventArgs e)
        {
            display(6);
            check1 = 1;
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(check1 == 1)
            {
                if (CopyDAO.ValidateCopy(txtSequenceNumber.Text, txtPrice.Text))
                {
                    Copy c = new Copy();
                    c.BookNumber = Convert.ToInt32(txtBookNumber1.Text);
                    c.SequenceNumber = Convert.ToInt32(txtSequenceNumber.Text);
                    c.Type = Convert.ToInt32(txtType.Text);
                    c.Price = Convert.ToDouble(txtPrice.Text);
                    CopyDAO.Add(c);
                    dgvCopies.DataSource = CopyDAO.GetDataTable(c.BookNumber);
                    MessageBox.Show("Add Successful");
                    display(5);
                    btnSave.Visible = false;
                    check1 = 0;
                }
            } else if (check1 == 2)
            {
                if (CopyDAO.ValidateCopy(txtSequenceNumber.Text, txtPrice.Text))
                {
                    Copy c = new Copy();
                    c.CopyNumber = Convert.ToInt32(txtCopyNumber.Text);
                    c.BookNumber = Convert.ToInt32(txtBookNumber1.Text);
                    c.SequenceNumber = Convert.ToInt32(txtSequenceNumber.Text);
                    c.Type = Convert.ToInt32(txtType.Text);
                    c.Price = Convert.ToDouble(txtPrice.Text);
                    CopyDAO.Edit(c);
                    dgvCopies.DataSource = CopyDAO.GetDataTable(c.BookNumber);
                    MessageBox.Show("Edit Successful");
                    display(5);
                    btnSave.Visible = false;
                    check1 = 0;
                }
            }
        }

        private void btnEditCopy_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            check1 = 2;
            display(7);
        }

        private void btnDeleteCopy_Click(object sender, EventArgs e)
        {
            Copy c = new Copy();
            c.CopyNumber = Convert.ToInt32(txtCopyNumber.Text);
            CopyDAO.Delete(c);
            dgvCopies.DataSource = CopyDAO.GetDataTable(Convert.ToInt32(txtBookNumber1.Text));
            MessageBox.Show("Delete Successful");
            display(5);
        }
    }
}
