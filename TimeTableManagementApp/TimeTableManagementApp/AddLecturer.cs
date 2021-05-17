using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagementApp
{
    public partial class AddLecturer : Form
    {
        //string connection
        string path = @"Data Source=DESKTOP-KN9V1CU\SQLEXPRESS;Initial Catalog=TimeTableManagementApp;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;//this is use for run the sql queries
        public AddLecturer()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtlecname.Text == "" || txtempid.Text == "" || faculty.SelectedItem == "" || dept.SelectedItem == "" || center.SelectedItem == "" || building.SelectedItem == "" || level.SelectedItem == ""||rank.Text=="") 
            {
                MessageBox.Show("Please fill in the blanks");
            }
            else
            {
                try
                {

                    con.Open();
                    cmd = new SqlCommand("insert into Add_Lecturer (lec_name,emp_ID,faculty,department,center,building,lec_level,lec_rank)values('" + txtlecname.Text + "','" + txtempid.Text + "','" + faculty.SelectedItem + "','" + dept.SelectedItem + "','" + center.SelectedItem + "','" + building.SelectedItem + "','" + level.SelectedItem + "','"+rank.Text+"')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Saved Successfully!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rankdisplay();
            
        }
        public void rankdisplay() {

            String a = txtempid.Text;
            String b = level.SelectedItem.ToString();
            String c = (b +"."+ a);
            rank.Text = c;
        }

        public void clear()
        {
            txtlecname.Text = "";
            txtempid.Text = "";
            faculty.SelectedItem = "";
            dept.SelectedItem = "";
            center.SelectedItem = "";
            building.SelectedItem = "";
            level.SelectedItem = "";
            rank.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void AddLecturer_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
