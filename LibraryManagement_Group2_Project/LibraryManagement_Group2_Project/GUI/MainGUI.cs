using LibraryManagement_Group2_Project.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagement_Group2_Project.GUI
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
            
        }

        private void addForm(Form f)
        {
            this.Text = f.Text;
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            this.Width = f.Size.Width + 20;
            this.toolStripContainer1.Width = f.Size.Width;
            this.Height = f.Size.Height + 65;
            this.toolStripContainer1.Height = f.Size.Height + 30;
            f.Show();
            this.toolStripContainer1.ContentPanel.Controls.Clear();
            this.toolStripContainer1.ContentPanel.Controls.Add(f);
        }

        private void tsbBook_Click(object sender, EventArgs e)
        {
            addForm(new RegisterBook());
        }

        private void tsbMember_Click(object sender, EventArgs e)
        {
            addForm(new RegisterMember());
        }

        private void tsbBorrow_Click(object sender, EventArgs e)
        {
            addForm(new BorrowGUI());
        }

        private void tsbReturn_Click(object sender, EventArgs e)
        {
            addForm(new ReturnGUI());
        }

        private void tsbReserve_Click(object sender, EventArgs e)
        {
            addForm(new ReserveGUI());
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
