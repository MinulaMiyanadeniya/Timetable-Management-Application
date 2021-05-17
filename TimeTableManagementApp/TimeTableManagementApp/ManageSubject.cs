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
    public partial class ManageSubject : Form


    {
        //string connection
        string path = @"Data Source=DESKTOP-KN9V1CU\SQLEXPRESS;Initial Catalog=TimeTableManagementApp;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;//this is use for run the sql queries
        SqlDataAdapter adpt;
        DataTable dt;
        int ID;
        public ManageSubject()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();

        }

        private void ManageSubject_Load(object sender, EventArgs e)
        {

        }

        //update
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string semester;
                if (rbtnsemester1.Checked)
                {
                    semester = "semester1";
                }
                else
                {
                    semester = "semester2";
                }
                con.Open();
                cmd = new SqlCommand("update Add_Subject set offered_year='" + offeredyear.SelectedItem + "',offered_semester='" + semester + "',subject_name='" + txtsubject_name.Text + "',subject_code='" + txtsubcode.Text + "',lec_hours='" + txtlechours.Text + "',lec_mins='" + txtlecmins.Text + "',tute_hours='" + txttutehours.Text + "',tute_mins='" + txttutemins.Text + "',lab_hours='" + txtlabhours.Text + "',lab_mins='" + txtlabmins.Text + "',evaluation_hours='" + txtevaluhours.Text + "',evaluation_mins='" + txtevalumins.Text + "'where ID='"+ ID + "'",con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Data Updated Sucessfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //retrieve data
        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from Add_Subject", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            offeredyear.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            rbtnsemester1.Checked = true;
            rbtnsemester2.Checked = false;

            if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "semester2")
            {
                rbtnsemester1.Checked = false;
                rbtnsemester2.Checked = true;
            }
            txtsubject_name.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtsubcode.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtlechours.Text= dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtlecmins.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txttutehours.Text= dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txttutemins.Text= dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtlabhours.Text= dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtlabmins.Text= dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtevaluhours.Text= dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtevalumins.Text= dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        //refreash
        private void button4_Click(object sender, EventArgs e)
        {
            display();
        }


        //delete
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from Add_Subject where ID='" + ID + "'",con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
