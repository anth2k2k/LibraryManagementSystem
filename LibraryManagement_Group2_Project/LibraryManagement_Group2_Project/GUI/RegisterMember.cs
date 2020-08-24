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
    public partial class RegisterMember : Form
    {
        //1:Add, 2:Edit, 3:Search
        public static int check = 0;
        public RegisterMember()
        {
            check = 0;
            InitializeComponent();
            dgvMember.DataSource = MemberDAO.GetDataTable();
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = "btnView";
            button.HeaderText = "View";
            button.Text = "View";
            button.UseColumnTextForButtonValue = true; //dont forget this line
            this.dgvMember.Columns.Add(button);
            dgvMember.Columns["btnView"].DisplayIndex = dgvMember.ColumnCount - 1;
            display(0);
        }

        private void display(int i)
        {
            switch (i)
            {
                case 0:
                    check = 0;
                    dgvMember.DataSource = MemberDAO.GetDataTable();
                    txtMemberCode.Text = "";
                    txtName.Text = "";
                    rbtnMale.Checked = false;
                    rbtnFemale.Checked = false;
                    txtAddress.Text = "";
                    txtTelephone.Text = "";
                    txtEmail.Text = "";
                    txtMemberCode.Enabled = false;
                    txtName.Enabled = false;
                    rbtnMale.Enabled = false;
                    rbtnFemale.Enabled = false;
                    txtAddress.Enabled = false;
                    txtTelephone.Enabled = false;
                    txtEmail.Enabled = false;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    btnFilter.Enabled = true;
                    btnFilter.Text = "Filter";
                    break;
                case 1:
                    txtMemberCode.Enabled = false;
                    txtName.Enabled = false;
                    rbtnMale.Enabled = false;
                    rbtnFemale.Enabled = false;
                    txtAddress.Enabled = false;
                    txtTelephone.Enabled = false;
                    txtEmail.Enabled = false;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = true;
                    btnFilter.Enabled = true;
                    break;
                case 2:
                    txtMemberCode.Text = "";
                    txtName.Text = "";
                    rbtnMale.Checked = false;
                    rbtnFemale.Checked = false;
                    txtAddress.Text = "";
                    txtTelephone.Text = "";
                    txtEmail.Text = "";
                    txtMemberCode.Enabled = false;
                    txtName.Enabled = true;
                    rbtnMale.Enabled = true;
                    rbtnFemale.Enabled = true;
                    txtAddress.Enabled = true;
                    txtTelephone.Enabled = true;
                    txtEmail.Enabled = true;
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    btnFilter.Text = "Save";
                    btnFilter.Enabled = true;
                    break;
                case 3:
                    txtMemberCode.Enabled = false;
                    txtName.Enabled = true;
                    rbtnMale.Enabled = true;
                    rbtnFemale.Enabled = true;
                    txtAddress.Enabled = true;
                    txtTelephone.Enabled = true;
                    txtEmail.Enabled = true;
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    btnFilter.Text = "Save";
                    btnFilter.Enabled = true;
                    break;
                case 4:
                    txtMemberCode.Enabled = true;
                    txtName.Enabled = true;
                    rbtnMale.Enabled = true;
                    rbtnFemale.Enabled = true;
                    txtAddress.Enabled = true;
                    txtTelephone.Enabled = true;
                    txtEmail.Enabled = true;
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    btnFilter.Text = "Search";
                    btnFilter.Enabled = true;
                    break;
                case 5:
                    check = 0;
                    txtMemberCode.Text = "";
                    txtName.Text = "";
                    rbtnMale.Checked = false;
                    rbtnFemale.Checked = false;
                    txtAddress.Text = "";
                    txtTelephone.Text = "";
                    txtEmail.Text = "";
                    txtMemberCode.Enabled = false;
                    txtName.Enabled = false;
                    rbtnMale.Enabled = false;
                    rbtnFemale.Enabled = false;
                    txtAddress.Enabled = false;
                    txtTelephone.Enabled = false;
                    txtEmail.Enabled = false;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    btnFilter.Enabled = true;
                    btnFilter.Text = "Filter";
                    break;
                case 6:
                    check = 0;
                    txtMemberCode.Text = "";
                    txtName.Text = "";
                    rbtnMale.Checked = false;
                    rbtnFemale.Checked = false;
                    txtAddress.Text = "";
                    txtTelephone.Text = "";
                    txtEmail.Text = "";
                    txtMemberCode.Enabled = false;
                    txtName.Enabled = false;
                    rbtnMale.Enabled = false;
                    rbtnFemale.Enabled = false;
                    txtAddress.Enabled = false;
                    txtTelephone.Enabled = false;
                    txtEmail.Enabled = false;
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    btnFilter.Enabled = true;
                    btnFilter.Text = "Filter";
                    break;
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if(check == 1)
            {
                Member m = new Member();
                m.Name = txtName.Text;
                if (rbtnMale.Checked || rbtnFemale.Checked)
                {
                    m.Sex = rbtnMale.Checked;
                    m.Address = txtAddress.Text;
                    m.Telephone = txtTelephone.Text;
                    m.Email = txtEmail.Text;
                    if (MemberDAO.ValidateMember(m))
                    {
                        MemberDAO.Add(m);
                        dgvMember.DataSource = MemberDAO.GetDataTable();
                        MessageBox.Show("Add Successful");
                        display(0);
                        check = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Sex can not be blank.");
                }
            } else if (check == 2)
            {
                Member m = new Member();
                m.Name = txtName.Text;
                if (rbtnMale.Checked || rbtnFemale.Checked)
                {
                    m.Sex = rbtnMale.Checked;
                    m.Address = txtAddress.Text;
                    m.Telephone = txtTelephone.Text;
                    m.Email = txtEmail.Text;
                    m.MemberNumber = Convert.ToInt32(txtMemberCode.Text);
                    if (MemberDAO.ValidateMember(m))
                    {
                        MemberDAO.Edit(m);
                        dgvMember.DataSource = MemberDAO.GetDataTable();
                        MessageBox.Show("Edit Successful");
                        display(0);
                        check = 0;
                    }
                }
            } else if (check == 0)
            {
                check = 3;
                display(4);
            } else if (check == 3)
            {
                int x = 0;
                Member m = new Member();
                m.Name = txtName.Text;
                if (rbtnFemale.Checked || rbtnMale.Checked) m.Sex = rbtnMale.Checked;
                else x = 1;
                m.Address = txtAddress.Text;
                m.Telephone = txtTelephone.Text;
                m.Email = txtEmail.Text;
                m.MemberNumber = (txtMemberCode.Text!="")?Convert.ToInt32(txtMemberCode.Text):-1;
                dgvMember.DataSource = MemberDAO.SearchMember(m, x);
                btnAdd.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            check = 1;
            display(2);
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            display(1);
            Member m = MemberDAO.GetMember(Convert.ToInt32(dgvMember.Rows[e.RowIndex].Cells["memberNumber"].Value));
            txtMemberCode.Text = m.MemberNumber.ToString();
            txtName.Text = m.Name;
            if (m.Sex) rbtnMale.Checked = true; 
            else rbtnFemale.Checked = true;
            txtAddress.Text = m.Address;
            txtTelephone.Text = m.Telephone;
            txtEmail.Text = m.Email;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            display(0);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Member m = new Member();
            m.MemberNumber = Convert.ToInt32(txtMemberCode.Text);
            MemberDAO.Delete(m);
            dgvMember.DataSource = MemberDAO.GetDataTable();
            MessageBox.Show("Delete Successful");
            display(0);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            check = 2;
            display(3);
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                RenewGUI f = new RenewGUI(int.Parse(dgvMember.Rows[e.RowIndex].Cells["memberNumber"].Value.ToString()));
                if (f.ShowDialog() == DialogResult.OK)
                {
                    dgvMember.DataSource = MemberDAO.GetDataTable();
                }
            }
        }
    }
}
