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
        AddLocations_cd addLocation_cd = new AddLocations_cd();
        ManageLocation_cd manageLocation_cd = new ManageLocation_cd();

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

        private void Button14_Click(object sender, EventArgs e)
        {
            addLocation_cd.Show();
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            manageLocation_cd.Show();
        }
    }
}
