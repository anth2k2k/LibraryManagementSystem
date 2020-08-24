using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement_Group2_Project.DTL
{
    class CirculatedCopy
    {
        private int circulatedCopyId;
        private int copyNumber;
        private int memberNumber;
        private DateTime borrowedDate;
        private DateTime dueDate;
        private DateTime returnedDate;
        private double fineAmount;

        public int CirculatedCopyId { get => circulatedCopyId; set => circulatedCopyId = value; }
        public int CopyNumber { get => copyNumber; set => copyNumber = value; }
        public int MemberNumber { get => memberNumber; set => memberNumber = value; }
        public DateTime BorrowedDate { get => borrowedDate; set => borrowedDate = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
        public DateTime ReturnedDate { get => returnedDate; set => returnedDate = value; }
        public double FineAmount { get => fineAmount; set => fineAmount = value; }
    }
}
