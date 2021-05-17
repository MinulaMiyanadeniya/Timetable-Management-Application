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
    public partial class ManageLecturer : Form
    {
        //string connection
        string path = @"Data Source=DESKTOP-KN9V1CU\SQLEXPRESS;Initial Catalog=TimeTableManagementApp;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;//this is use for run the sql queries
        SqlDataAdapter adpt;
        DataTable dt;
        int ID;
        public ManageLecturer()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ManageLecturer_Load(object sender, EventArgs e)
        {

        }

        //retrieve data
        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from Add_Lecturer", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtlecname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtempid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            faculty.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dept.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            center.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            building.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            level.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            rank.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                con.Open();
                cmd = new SqlCommand("update Add_Lecturer set lec_name='" + txtlecname.Text + "',emp_ID='" + txtempid.Text + "',faculty='" + faculty.SelectedItem + "',department='" + dept.SelectedItem + "',center='" + center.SelectedItem + "',building='" + building.SelectedItem + "',lec_level='" + level.SelectedItem + "',lec_rank='" + rank.Text + "'where LecID='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Data Updated Sucessfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from Add_Lecturer where LecID='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
