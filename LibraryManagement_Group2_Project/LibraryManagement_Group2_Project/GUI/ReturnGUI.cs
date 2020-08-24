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
    public partial class ReturnGUI : Form
    {
        public static int rowIndex = 0;
        public ReturnGUI()
        {
            InitializeComponent();
        }

        private void view(int memberNumber)
        {
            rowIndex = 0;
            dgvBorrowedBooks.DataSource = MemberDAO.GetBorrowedBooks(memberNumber);
            numBorrowedBooks.Text = dgvBorrowedBooks.Rows.Count.ToString();
        }

        private void btnCheckMember_Click(object sender, EventArgs e)
        {
            if (txtMemberCode.Text != "")
            {
                if (MemberDAO.CheckMember(int.Parse(txtMemberCode.Text)))
                {
                    Member m = MemberDAO.GetMember(int.Parse(txtMemberCode.Text));

                    view(m.MemberNumber);
                    txtPhone.Text = m.Telephone;
                    txtName.Text = m.Name;
                    txtEmail.Text = m.Email;
                }
                else
                {
                    txtName.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                    txtMemberCode.Text = "";
                    dgvBorrowedBooks.DataSource = new DataTable();
                    numBorrowedBooks.Text = "0";
                    MessageBox.Show("Member Code is invalid.");
                }
            }
            else
            {
                MessageBox.Show("Member Code can not be blank.");
            }
        }

        public double CalculateFineAmount(DateTime returnedDate, DateTime dueDate)
        {
            return (returnedDate - dueDate).TotalDays;
        }

        private void dgvBorrowedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            btnConfirmFine.Enabled = true;
            DateTime dueDate = Convert.ToDateTime(dgvBorrowedBooks.Rows[e.RowIndex].Cells["dueDate"].Value);
            if (dueDate < dtpReturnedDate.Value)
            {
                txtFineAmount.Text = Math.Floor(CalculateFineAmount(dtpReturnedDate.Value, dueDate)).ToString();
            } else
            {
                txtFineAmount.Text = "0";
                btnConfirmFine.Enabled = false;
                btnReturn.Enabled = true;
            }

        }

        private void btnConfirmFine_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirm fine successful.");
            btnReturn.Enabled = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            CirculatedCopy cc = new CirculatedCopy();
            cc.CirculatedCopyId = Convert.ToInt32(dgvBorrowedBooks.Rows[rowIndex].Cells["circulatedCopyId"].Value);
            cc.ReturnedDate = dtpReturnedDate.Value;
            cc.FineAmount = double.Parse(txtFineAmount.Text);
            CirculatedCopyDAO.Update(cc);

            Copy c = CopyDAO.GetCopy(Convert.ToInt32(dgvBorrowedBooks.Rows[rowIndex].Cells["copyNumber"].Value));
            if(ReservationDAO.GetFirstReservation(c.BookNumber) != null)
            {
                c.Type = 2;
            } else {
                c.Type = 0;
            }
            CopyDAO.UpdateType(c);

            view(int.Parse(txtMemberCode.Text));
            MessageBox.Show("Return Successful.");
            btnReturn.Enabled = false;
            txtFineAmount.Text = "";
            btnConfirmFine.Enabled = false;
        }

        private void dgvBorrowedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpReturnedDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dueDate = Convert.ToDateTime(dgvBorrowedBooks.Rows[rowIndex].Cells["dueDate"].Value);
            if (dueDate < dtpReturnedDate.Value)
            {
                txtFineAmount.Text = Math.Floor(CalculateFineAmount(dtpReturnedDate.Value, dueDate)).ToString();
                btnReturn.Enabled = false;
                btnConfirmFine.Enabled = true;
            }
            else
            {
                txtFineAmount.Text = "0";
                btnConfirmFine.Enabled = false;
                btnReturn.Enabled = true;
            }
        }
    }
}
