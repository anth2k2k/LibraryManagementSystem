using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibraryManagement_Group2_Project.DTL
{
    class Member
    {
        private int memberNumber;
        private string name;
        private bool sex;
        private string address;
        private string telephone;
        private string email;

        public int MemberNumber { get => memberNumber; set => memberNumber = value; }
        public string Name { get => name; set => name = value; }
        public bool Sex { get => sex; set => sex = value; }
        public string Address { get => address; set => address = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }
    }
}
