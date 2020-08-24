using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement_Group2_Project.DTL
{
    class Reservation
    {
        private int reservationID;
        private int memberNumber;
        private int bookNumber;
        private DateTime date;
        private bool status;

        public int ReservationID { get => reservationID; set => reservationID = value; }
        public int MemberNumber { get => memberNumber; set => memberNumber = value; }
        public int BookNumber { get => bookNumber; set => bookNumber = value; }
        public DateTime Date { get => date; set => date = value; }
        public bool Status { get => status; set => status = value; }
    }
}
