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
<<<<<<< HEAD
        testhashini th = new testhashini();
        AddLecturer Lec = new AddLecturer();
        AddSubject Sub = new AddSubject();
        ManageLecturer manlec = new ManageLecturer();
        ManageSubject mansub = new ManageSubject();
        AddSession session = new AddSession();
        ManageSession session1 = new ManageSession();
=======
        AddLocations_cd addLocation_cd = new AddLocations_cd();
        ManageLocation_cd manageLocation_cd = new ManageLocation_cd();
        Statistics_cd statistics_cd = new Statistics_cd();
        AllocateSessionRoom allocatesr = new AllocateSessionRoom();
>>>>>>> 3ceba1663176311f0f9ad3c884bc902240b815f7

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

<<<<<<< HEAD
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
=======
        private void Button14_Click(object sender, EventArgs e)
        {
            addLocation_cd.ShowDialog();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            manageLocation_cd.display();
            manageLocation_cd.ShowDialog();
        }

        private void Button16_Click(object sender, EventArgs e)
        {

            statistics_cd.clearpie();
            statistics_cd.LoadPieChart();
            statistics_cd.Loadchart();
            statistics_cd.ShowDialog();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            allocatesr.ShowDialog();

>>>>>>> 3ceba1663176311f0f9ad3c884bc902240b815f7
        }
    }
}
