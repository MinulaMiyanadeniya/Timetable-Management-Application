using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagementApp
{
    public partial class Form1 : Form
    {
        testhashini th = new testhashini();
        AddLecturer Lec = new AddLecturer();
        AddSubject Sub = new AddSubject();
        ManageLecturer manlec = new ManageLecturer();
        ManageSubject mansub = new ManageSubject();
        AddSession session = new AddSession();
        ManageSession session1 = new ManageSession();

        public Form1()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
          mansub.ShowDialog();
          mansub.display();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lec.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sub.ShowDialog();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            manlec.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            session.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            session1.ShowDialog();
        }
    }
}
