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
    public partial class BorrowGUI : Form
    {
        private static int check = 0;
        public BorrowGUI()
        {
            InitializeComponent();
            dtpBorrowed.Value = DateTime.Now;
            dtpDue.Value = dtpBorrowed.Value.AddDays(14);
        }

        private void display(int i)
        {
            switch (i)
            {
                case 0:
                    txtEmail.Text = "";
                    txtMemberName.Text = "";
                    txtMemberCode.Text = "";
                    txtCopyNumber.Enabled = false;
                    btnCheckCondition.Enabled = false;
                    btnBorrow.Enabled = false;
                    dgvBorrowedBooks.DataSource = new DataTable();
                    numBorrowedBooks.Text = "0";
                    break;
                case 1:
                    btnCheckCondition.Enabled = true;
                    txtCopyNumber.Enabled = true;
                    break;
                case 2:
                    txtCopyNumber.Text = "";
                    btnBorrow.Enabled = false;
                    break;
            }
        }

        private void view(int memberNumber)
        {
            dgvBorrowedBooks.DataSource = MemberDAO.GetBorrowedBooks(memberNumber);
            numBorrowedBooks.Text = dgvBorrowedBooks.Rows.Count.ToString();
        }

        private void btnCheckMember_Click(object sender, EventArgs e)
        {
            if (txtMemberCode.Text != "")
            {
                btnBorrow.Enabled = false;
                txtCopyNumber.Text = "";
                if (MemberDAO.CheckMember(int.Parse(txtMemberCode.Text)))
                {
                    Member m = MemberDAO.GetMember(int.Parse(txtMemberCode.Text));

                    if (MemberDAO.GetBorrowedBooks(m.MemberNumber).Rows.Count < 5)
                    {
                        view(m.MemberNumber);
                        display(1);
                        txtMemberName.Text = m.Name;
                        txtEmail.Text = m.Email;
                    }
                    else
                    {
                        display(0);
                        MessageBox.Show("The number of borrowed books is 5. You can not borrow anymore book.");
                    }
                }
                else
                {
                    display(0);
                    MessageBox.Show("Member Code is invalid.");
                }
            } else
            {
                MessageBox.Show("Member Code can not be blank.");
            }
        }

        private void btnCheckCondition_Click(object sender, EventArgs e)
        {
            if (txtCopyNumber.Text != "")
            {
                if (CopyDAO.CheckCondition(int.Parse(txtCopyNumber.Text)) == 0)
                {
                    MessageBox.Show("This book is available.");
                    btnBorrow.Enabled = true;
                }
                else if (CopyDAO.CheckCondition(int.Parse(txtCopyNumber.Text)) == 2)
                {
                    if (ReservationDAO.GetFirstReservation(CopyDAO.GetCopy(int.Parse(txtCopyNumber.Text)).BookNumber).MemberNumber
                        == int.Parse(txtMemberCode.Text))
                    {
                        check = 1;
                        MessageBox.Show("This copy is available.");
                        btnBorrow.Enabled = true;
                    } else
                    {
                        MessageBox.Show("This copy is not available.");
                    }
                }
                else
                {
                    display(2);
                    MessageBox.Show("Copy Number is invalid or This book is not available.");
                }
            }
            else
            {
                MessageBox.Show("Copy Code can not be blank.");
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if(dtpBorrowed.Value < dtpDue.Value)
            {
                CirculatedCopy cc = new CirculatedCopy();
                cc.CopyNumber = int.Parse(txtCopyNumber.Text);
                cc.MemberNumber = int.Parse(txtMemberCode.Text);
                cc.BorrowedDate = dtpBorrowed.Value;
                cc.DueDate = dtpDue.Value;

                if (CirculatedCopyDAO.Add(cc))
                {
                    Copy c = CopyDAO.GetCopy(int.Parse(txtCopyNumber.Text));
                    c.Type = 1;
                    CopyDAO.UpdateType(c);
                    display(2);
                    view(int.Parse(txtMemberCode.Text));
                    MessageBox.Show("Add Successful.");

                    if (check == 1)
                    {
                        Reservation r = ReservationDAO.GetFirstReservation(c.BookNumber);
                        r.Status = true;
                        ReservationDAO.UpdateStatus(r);
                    }

                    if (dgvBorrowedBooks.Rows.Count >= 5)
                    {
                        display(0);
                        MessageBox.Show("The number of borrowed books is 5. You can not borrow anymore book.");
                    }
                }
                else
                {
                    MessageBox.Show("Error.");
                }
            }
            else
            {
                MessageBox.Show("Borrowed date has to be smaller than Due date.");
            }
        }
    }
}
