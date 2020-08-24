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
    class BookDAO
    {
        public static DataTable GetDataTable()
        {
            string sql = "select bookNumber, title, authors, publisher from Book";
            return DAO.GetDataTable(sql);
        }

        static public Book GetBook(int bookNumber)
        {
            Book b = new Book();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("Select * from Book where bookNumber = @bookNumber");
            cmd.Parameters.AddWithValue("@bookNumber", bookNumber);
            DataTable dt = DAO.GetDataTable(cmd);
            b.BookNumber = bookNumber;
            b.Title = dt.Rows[0]["title"].ToString();
            b.Authors = dt.Rows[0]["authors"].ToString();
            b.Publisher = dt.Rows[0]["publisher"].ToString();
            return b;
        }

        public static bool Add(Book b)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("insert into Book (title, authors, publisher) " +
                                    " values (@title, @authors, @publisher) ");
            cmd.Parameters.AddWithValue("@title", b.Title);
            cmd.Parameters.AddWithValue("@authors", b.Authors);
            cmd.Parameters.AddWithValue("@publisher", b.Publisher);
            return DAO.UpdateTable(cmd);
        }

        public static bool Edit(Book b)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("update Book " +
                   " set title = @title, authors = @authors, " +
                   " publisher = @publisher " +
                   " where bookNumber = @bookNumber");
            cmd.Parameters.AddWithValue("@title", b.Title);
            cmd.Parameters.AddWithValue("@authors", b.Authors);
            cmd.Parameters.AddWithValue("@publisher", b.Publisher);
            cmd.Parameters.AddWithValue("@bookNumber", b.BookNumber);
            return DAO.UpdateTable(cmd);
        }

        public static bool Delete(Book b)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("delete from Book " +
                           " where bookNumber = @bookNumber");
            cmd.Parameters.AddWithValue("@bookNumber", b.BookNumber);
            return DAO.UpdateTable(cmd);
        }

        public static DataView SearchBook(Book b)
        {
            string sql = "select bookNumber, title, authors, publisher from Book ";
            DataView dv = new DataView(DAO.GetDataTable(sql));
            string filter = " 1 = 1 ";
            if (b.BookNumber != -1)
            {
                filter = filter + " and bookNumber = " + b.BookNumber.ToString();
            }
            if (b.Title != "")
            {
                filter = filter + " and title like '%" + b.Title + "%' ";
            }
            if (b.Authors != "")
            {
                filter = filter + " and authors like '%" + b.Authors + "%' ";
            }
            if (b.Publisher != "")
            {
                filter = filter + " and publisher like '%" + b.Publisher + "%' ";
            }
            dv.RowFilter = filter;
            return dv;
        }

        public static bool ValidateBook(Book b)
        {
            if (b.Title != "")
            {
                if(b.Authors != "")
                {
                    if(b.Publisher != "")
                    {
                        return true;
                    } else
                    {
                        MessageBox.Show("Publisher can not be blank.");
                    }
                }else
                {
                    MessageBox.Show("Authors can not be blank.");
                }
            } else
            {
                MessageBox.Show("Title can not be blank.");
            }
            return false;
        }
    }
}
