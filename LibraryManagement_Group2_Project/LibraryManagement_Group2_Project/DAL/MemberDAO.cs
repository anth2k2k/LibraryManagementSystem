using LibraryManagement_Group2_Project.DTL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement_Group2_Project.DAL
{
    class MemberDAO
    {
        public static DataTable GetBorrowedBooks(int memberNUmber)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("Select circulatedCopyId, copyNumber, memberNumber, borrowedDate, dueDate, numberRenew  from CirculatedCopy where memberNumber = @memNum and returnedDate is NULL");
            cmd.Parameters.AddWithValue("@memNum", memberNUmber);
            return DAO.GetDataTable(cmd);
        }

        static public bool CheckMember(int memberNumber)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("Select * from Member where memberNumber = @memNum");
            cmd.Parameters.AddWithValue("@memNum", memberNumber);
            DataTable dt = DAO.GetDataTable(cmd);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static public Member GetMember(int memberNumber)
        {
            Member m = new Member();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("Select * from Member where memberNumber = @memNum");
            cmd.Parameters.AddWithValue("@memNum", memberNumber);
            DataTable dt = DAO.GetDataTable(cmd);
            m.MemberNumber = memberNumber;
            m.Name = dt.Rows[0]["name"].ToString();
            m.Sex = bool.Parse(dt.Rows[0]["sex"].ToString());
            m.Address = dt.Rows[0]["address"].ToString();
            m.Telephone = dt.Rows[0]["telephone"].ToString();
            m.Email = dt.Rows[0]["email"].ToString();
            return m;
        }

        public static DataTable GetDataTable()
        {
            string sql = "select memberNumber, name, sex, address, telephone, email from Member";
            return DAO.GetDataTable(sql);
        }

        public static bool Add(Member m)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("insert into Member (name, sex, address, telephone, email) " +
                                    " values (@name, @sex, @address, @telephone, @email) ");
            cmd.Parameters.AddWithValue("@name", m.Name);
            cmd.Parameters.AddWithValue("@sex", m.Sex);
            cmd.Parameters.AddWithValue("@address", m.Address);
            cmd.Parameters.AddWithValue("@telephone", m.Telephone);
            cmd.Parameters.AddWithValue("@email", m.Email);
            return DAO.UpdateTable(cmd);
        }

        public static bool Edit(Member m)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("update Member " +
                   " set name = @name, sex = @sex, " +
                   " address = @address,  telephone = @telephone, email = @email " +
                   " where memberNumber = @memberNumber");
            cmd.Parameters.AddWithValue("@name", m.Name);
            cmd.Parameters.AddWithValue("@sex", m.Sex);
            cmd.Parameters.AddWithValue("@address", m.Address);
            cmd.Parameters.AddWithValue("@telephone", m.Telephone);
            cmd.Parameters.AddWithValue("@email", m.Email);
            cmd.Parameters.AddWithValue("@memberNumber", m.MemberNumber);
            return DAO.UpdateTable(cmd);
        }

        public static bool Delete(Member m)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("delete from Member " +
                           " where memberNumber = @memberNumber");
            cmd.Parameters.AddWithValue("@memberNumber", m.MemberNumber);
            return DAO.UpdateTable(cmd);
        }

        public static DataView SearchMember(Member m, int x)
        {
            string sql = "select memberNumber, name, sex, address, telephone, email from Member";
            DataView dv = new DataView(DAO.GetDataTable(sql));
            string filter = " 1 = 1 ";
            if (m.MemberNumber != -1)
            {
                filter = filter + " and memberNumber = " + m.MemberNumber.ToString();
            }
            if (m.Name != "")
            {
                filter = filter + " and name like '%" + m.Name + "%' ";
            }
            if (m.Address != "")
            {
                filter = filter + " and address like '%" + m.Address + "%' ";
            }
            if (m.Telephone != "")
            {
                filter = filter + " and telephone like '%" + m.Telephone + "%' ";
            }
            if (m.Email != "")
            {
                filter = filter + " and email like '%" + m.Email + "%' ";
            }
            if (x == 0)
            {
                string y = m.Sex ? "1" : "0";
                filter = filter + " and sex = " + y;
            }
            dv.RowFilter = filter;
            return dv;
        }
        public static bool ValidateMember(Member m)
        {
            if (m.Name != "")
            {
                if (m.Address != "")
                {
                    if (m.Telephone != "")
                    {
                        if (m.Email != "")
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Email can not be blank.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Telephone can not be blank.");
                    }
                }
                else
                {
                    MessageBox.Show("Address can not be blank.");
                }
            }
            else
            {
                MessageBox.Show("Name can not be blank.");
            }
            return false;
        }
    }
}
