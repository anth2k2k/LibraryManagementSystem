using LibraryManagement_Group2_Project.DTL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace LibraryManagement_Group2_Project.DAL
{
    class CirculatedCopyDAO
    {
        public static bool Add(CirculatedCopy cc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("insert into CirculatedCopy(copyNumber, memberNumber, borrowedDate, dueDate, numberRenew) " +
                                    "values(@copyNum, @memNum, @borDate, @dueDate, 0)");
            cmd.Parameters.AddWithValue("@copyNum", cc.CopyNumber);
            cmd.Parameters.AddWithValue("@memNum", cc.MemberNumber);
            cmd.Parameters.AddWithValue("@borDate", cc.BorrowedDate);
            cmd.Parameters.AddWithValue("@dueDate", cc.DueDate);
            return DAO.UpdateTable(cmd);
        }

        public static bool Update(CirculatedCopy cc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("update CirculatedCopy " +
                   "set returnedDate = @rd, fineAmount = @fa " +
                   "where circulatedCopyId = @cid");
            cmd.Parameters.AddWithValue("@rd", cc.ReturnedDate);
            cmd.Parameters.AddWithValue("@fa", cc.FineAmount);
            cmd.Parameters.AddWithValue("@cid", cc.CirculatedCopyId);
            return DAO.UpdateTable(cmd);
        }

        public static bool Renew(CirculatedCopy cc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("update CirculatedCopy " +
                   " set dueDate = @dd, numberRenew = numberRenew + 1 " +
                   " where circulatedCopyId = @cid");
            cmd.Parameters.AddWithValue("@dd", cc.DueDate);
            cmd.Parameters.AddWithValue("@cid", cc.CirculatedCopyId);
            return DAO.UpdateTable(cmd);
        }
    }
}
