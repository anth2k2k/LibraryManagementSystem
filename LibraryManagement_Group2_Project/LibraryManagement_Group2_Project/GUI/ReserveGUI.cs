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
    public partial class ReserveGUI : Form
    {
        public ReserveGUI()
        {
            InitializeComponent();
            dtpDate.Value = DateTime.Now;
        }

        private void view(int memberNumber)
        {
            dgvReservedBooks.DataSource = ReservationDAO.GetReservedBooks(memberNumber);
            numReservedBooks.Text = dgvReservedBooks.Rows.Count.ToString();
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
                    if (dgvReservedBooks.Rows.Count < 1)
                    {
                        txtBookNumber.Enabled = true;
                        btnCRC.Enabled = true;
                    }
                }
                else
                {
                    txtBookNumber.Enabled = false;
                    btnCRC.Enabled = false;
                    txtName.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                    txtMemberCode.Text = "";
                    dgvReservedBooks.DataSource = new DataTable();
                    numReservedBooks.Text = "0";
                    MessageBox.Show("Member Code is invalid.");
                }
            }
            else
            {
                MessageBox.Show("Member Code can not be blank.");
            }
        }

        private void btnCRC_Click(object sender, EventArgs e)
        {
            if (txtBookNumber.Text != "")
            {
                if (!CopyDAO.CheckAvailableCopy(int.Parse(txtBookNumber.Text)))
                {
                    MessageBox.Show("You can reserve this book.");
                    btnReserve.Enabled = true;
                }
                else
                {
                    txtBookNumber.Text = "";
                    btnReserve.Enabled = false;
                    MessageBox.Show("This book still have available copy.");
                }
            }
            else
            {
                MessageBox.Show("Book Code can not be blank.");
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            Reservation r = new Reservation();
            r.MemberNumber = int.Parse(txtMemberCode.Text);
            r.BookNumber = int.Parse(txtBookNumber.Text);
            r.Date = dtpDate.Value;
            r.Status = false;
            ReservationDAO.Insert(r);
            view(int.Parse(txtMemberCode.Text));
            txtBookNumber.Text = "";
            txtBookNumber.Enabled = false;
            btnCRC.Enabled = false;
            btnReserve.Enabled = false;
        }
    }
}
