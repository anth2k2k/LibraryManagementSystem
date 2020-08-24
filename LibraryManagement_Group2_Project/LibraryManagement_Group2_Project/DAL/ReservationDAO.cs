using LibraryManagement_Group2_Project.DTL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LibraryManagement_Group2_Project.DAL
{
    class ReservationDAO
    {
        static public Reservation GetFirstReservation(int bookNumber)
        {
            Reservation r = new Reservation();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("SELECT * FROM Reservation " +
                "WHERE bookNumber = @bn1 " +
                "AND status = 0 " +
                "AND date = (SELECT MIN(date) FROM Reservation WHERE bookNumber = @bn2 AND status = 0)");
            cmd.Parameters.AddWithValue("@bn1", bookNumber);
            cmd.Parameters.AddWithValue("@bn2", bookNumber);
            DataTable dt = DAO.GetDataTable(cmd);
            if (dt.Rows.Count != 0)
            {
                r.ReservationID = int.Parse(dt.Rows[0]["reservationID"].ToString());
                r.MemberNumber = int.Parse(dt.Rows[0]["memberNumber"].ToString());
                r.BookNumber = bookNumber;
                r.Date = Convert.ToDateTime(dt.Rows[0]["date"]);
                r.Status = bool.Parse(dt.Rows[0]["status"].ToString());
                return r;
            }
            else return null;
        }

        static public bool UpdateStatus(Reservation r)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("update Reservation " +
                   "set status = @status " +
                   "where reservationID = @reservationID");
            cmd.Parameters.AddWithValue("@status", r.Status);
            cmd.Parameters.AddWithValue("@reservationID", r.ReservationID);
            return DAO.UpdateTable(cmd);
        }

        public static DataTable GetReservedBooks(int memberNUmber)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("Select * from Reservation where memberNumber = @memNum and status = 0");
            cmd.Parameters.AddWithValue("@memNum", memberNUmber);
            return DAO.GetDataTable(cmd);
        }

        public static bool Insert(Reservation r)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("insert into Reservation(memberNumber, bookNumber, date, status) " +
                                    "values(@memberNumber, @bookNumber, @date, @status)");
            cmd.Parameters.AddWithValue("@memberNumber", r.MemberNumber);
            cmd.Parameters.AddWithValue("@bookNumber", r.BookNumber);
            cmd.Parameters.AddWithValue("@date", r.Date);
            cmd.Parameters.AddWithValue("@status", r.Status);
            return DAO.UpdateTable(cmd);
        }
    }
}
