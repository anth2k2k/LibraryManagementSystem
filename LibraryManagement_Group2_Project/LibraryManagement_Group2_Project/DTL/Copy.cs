using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement_Group2_Project.DTL
{
    class Copy
    {
        private int copyNumber;
        private int bookNumber;
        private int sequenceNumber;
        private int type;
        private double price;

        public int CopyNumber { get => copyNumber; set => copyNumber = value; }
        public int BookNumber { get => bookNumber; set => bookNumber = value; }
        public int SequenceNumber { get => sequenceNumber; set => sequenceNumber = value; }
        public int Type { get => type; set => type = value; }
        public double Price { get => price; set => price = value; }
    }
}
