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
    class CopyDAO
    {
        static public int CheckCondition(int copyNumber)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("Select * from Copy where copyNumber = @copyNum");
            cmd.Parameters.AddWithValue("@copyNum", copyNumber);
            DataTable dt = DAO.GetDataTable(cmd);
            if(dt.Rows.Count != 0)
            {
                return int.Parse(dt.Rows[0]["type"].ToString());
            }
            return -1;
        }

        static public Copy GetCopy(int copyNumber)
        {
            Copy c = new Copy();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("Select * from Copy where copyNumber = @copyNum");
            cmd.Parameters.AddWithValue("@copyNum", copyNumber);
            DataTable dt = DAO.GetDataTable(cmd);
            c.CopyNumber = copyNumber;
            c.BookNumber = int.Parse(dt.Rows[0]["bookNumber"].ToString());
            c.SequenceNumber = int.Parse(dt.Rows[0]["sequenceNumber"].ToString());
            c.Type = int.Parse(dt.Rows[0]["type"].ToString());
            c.Price = double.Parse(dt.Rows[0]["price"].ToString());
            return c;
        }

        static public bool UpdateType(Copy c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("update Copy " +
                   "set type = @type " +
                   "where copyNumber = @copyNum");
            cmd.Parameters.AddWithValue("@type", c.Type);
            cmd.Parameters.AddWithValue("@copyNum", c.CopyNumber);
            return DAO.UpdateTable(cmd);
        }

        static public bool CheckAvailableCopy(int bookNumber)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("Select * from Copy where bookNumber = @bookNumber and type = 0");
            cmd.Parameters.AddWithValue("@bookNumber", bookNumber);
            DataTable dt = DAO.GetDataTable(cmd);
            if(dt.Rows.Count == 0)
            {
                return false;
            } else
            {
                return true;
            }
        }

        static public bool CheckReferencedCopy(int bookNumber)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("Select * from Copy where bookNumber = @bookNumber and type = 1");
            cmd.Parameters.AddWithValue("@bookNumber", bookNumber);
            DataTable dt = DAO.GetDataTable(cmd);
            //true: still have copy not be referenced
            return dt.Rows[0] != null;
        }

        public static DataTable GetDataTable(int bookNumber)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("select copyNumber, bookNumber, sequenceNumber, type, price from Copy where bookNumber = @bookNumber");
            cmd.Parameters.AddWithValue("@bookNumber", bookNumber);
            return DAO.GetDataTable(cmd);
        }

        public static bool Add(Copy c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("insert into Copy (bookNumber, sequenceNumber, type, price) " +
                                    " values (@bookNumber, @sequenceNumber, @type, @price) ");
            cmd.Parameters.AddWithValue("@bookNumber", c.BookNumber);
            cmd.Parameters.AddWithValue("@sequenceNumber", c.SequenceNumber);
            cmd.Parameters.AddWithValue("@type", c.Type);
            cmd.Parameters.AddWithValue("@price", c.Price);
            return DAO.UpdateTable(cmd);
        }

        public static bool Edit(Copy c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("update Copy " +
                   " set bookNumber = @bookNumber, sequenceNumber = @sequenceNumber, " +
                   " type = @type,  price = @price " +
                   " where copyNumber = @copyNumber");
            cmd.Parameters.AddWithValue("@bookNumber", c.BookNumber);
            cmd.Parameters.AddWithValue("@sequenceNumber", c.SequenceNumber);
            cmd.Parameters.AddWithValue("@type", c.Type);
            cmd.Parameters.AddWithValue("@price", c.Price);
            cmd.Parameters.AddWithValue("@copyNumber", c.CopyNumber);
            return DAO.UpdateTable(cmd);
        }

        public static bool Delete(Copy c)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("delete from Copy " +
                           " where copyNumber = @copyNumber");
            cmd.Parameters.AddWithValue("@copyNumber", c.CopyNumber);
            return DAO.UpdateTable(cmd);
        }

        public static bool ValidateCopy(string sn, string price)
        {
            if (sn != "" && sn != "0")
            {
                if (price != "" && price != "0")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Price can not be blank or zero.");
                }
            }
            else
            {
                MessageBox.Show("Sequence number can not be blank or zero.");
            }
            return false;
        }
    }
}
