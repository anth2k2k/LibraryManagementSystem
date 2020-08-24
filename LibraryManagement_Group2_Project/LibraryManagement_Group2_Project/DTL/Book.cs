using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement_Group2_Project.DTL
{
    class Book
    {
        private int bookNumber;
        private string title;
        private string authors;
        private string publisher;

        public int BookNumber { get => bookNumber; set => bookNumber = value; }
        public string Title { get => title; set => title = value; }
        public string Authors { get => authors; set => authors = value; }
        public string Publisher { get => publisher; set => publisher = value; }
    }
}
