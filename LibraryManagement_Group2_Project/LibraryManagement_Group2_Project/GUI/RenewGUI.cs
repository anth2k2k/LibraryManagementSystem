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
    public partial class RenewGUI : Form
    {
        public RenewGUI(int memberNumber)
        {
            InitializeComponent();
            dgvBorrowedBooks.DataSource = MemberDAO.GetBorrowedBooks(memberNumber);
            Member m = MemberDAO.GetMember(memberNumber);

            txtMemberCode.Text = m.MemberNumber.ToString();
            txtName.Text = m.Name;
            numBorrowedBooks.Text = dgvBorrowedBooks.RowCount.ToString();

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "btnRenew";
            button.HeaderText = "Renew";
            button.Text = "Renew";
            button.UseColumnTextForButtonValue = true; //dont forget this line
            this.dgvBorrowedBooks.Columns.Add(button);
            dgvBorrowedBooks.Columns["btnRenew"].DisplayIndex = dgvBorrowedBooks.ColumnCount - 1;
        }

        private void dgvBorrowedBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if(Convert.ToInt32(dgvBorrowedBooks.Rows[e.RowIndex].Cells["numberRenew"].Value) < 3)
                {
                    CirculatedCopy cc = new CirculatedCopy();
                    cc.CirculatedCopyId = Convert.ToInt32(dgvBorrowedBooks.Rows[e.RowIndex].Cells["circulatedCopyId"].Value);
                    cc.DueDate = Convert.ToDateTime(dgvBorrowedBooks.Rows[e.RowIndex].Cells["dueDate"].Value).AddDays(14);
                    if (CirculatedCopyDAO.Renew(cc))
                    {
                        dgvBorrowedBooks.DataSource = MemberDAO.GetBorrowedBooks(Convert.ToInt32(txtMemberCode.Text));
                        MessageBox.Show("Renew Successful.");
                    }
                }
                else
                {
                    MessageBox.Show("You can not renew more than 3 times.");
                }
            }
        }
    }
}
