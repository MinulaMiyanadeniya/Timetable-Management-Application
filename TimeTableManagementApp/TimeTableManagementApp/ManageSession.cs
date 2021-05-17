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
    public partial class ManageSession : Form
    {
        //string connection
        string path = @"Data Source=DESKTOP-KN9V1CU\SQLEXPRESS;Initial Catalog=TimeTableManagementApp;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;//this is use for run the sql queries
        SqlDataAdapter adpt;
        DataTable dt;
        int ID;
        string id;
        string lecture1;
        string lecture2;
        string subjcode;
        string subj;
        string Tag;
        public ManageSession()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
            getLec1();
            getLec2();
            getSubCode();
            getSubName();
            getTag();
            getGroupid();
        }

        private void ManageSession_Load(object sender, EventArgs e)
        {

        }

        //update 
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = groupid.SelectedValue.ToString();
                string lecture1 = lec1.SelectedValue.ToString();
                string lecture2 = lec2.SelectedValue.ToString();
                string subjcode = code.SelectedValue.ToString();
                string subj = subject.SelectedValue.ToString();
                string Tag = tag.SelectedValue.ToString();
                con.Open();
                cmd = new SqlCommand("update Add_Session set Lecture1='" + lecture1 + "',Lecture2='" + lecture2 + "',Subject_code='" + subjcode + "',Subject_name='" + subj + "',Group_id='" + id + "',Tag='" + Tag + "',Student_count='" + students.Text + "',Hrs='" + txthours.Text + "',Mins='" + txtmins.Text + "'where session_id='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your Data Updated Sucessfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            lec1.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            lec2.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            code.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            subject.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            groupid.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            tag.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            students.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txthours.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtmins.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
        }

        //retrieve data
        public void display()
        {
            try
            {
                
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from Add_Session", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lec1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lec2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void getLec1()
        {
            DataRow dr;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Add_Lecturer", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            dr = dt.NewRow();
            lec1.DataSource = dt;
            lec1.ValueMember = "lec_name";
            lec1.DisplayMember = "lec_name";
            Console.WriteLine(lecture1);

        }

        public void getLec2()
        {
            DataRow dr;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Add_Lecturer", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            dr = dt.NewRow();
            lec2.DataSource = dt;
            lec2.ValueMember = "lec_name";
            lec2.DisplayMember = "lec_name";
            Console.WriteLine(lecture2);

        }
        public void getSubCode()
        {
            DataRow dr;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Add_Subject", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            dr = dt.NewRow();
            code.DataSource = dt;
            code.ValueMember = "subject_code";
            code.DisplayMember = "subject_code";
            Console.WriteLine(subjcode);

        }
        public void getSubName()
        {
            DataRow dr;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Add_Subject", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            dr = dt.NewRow();
            subject.DataSource = dt;
            subject.ValueMember = "subject_name";
            subject.DisplayMember = "subject_name";
            Console.WriteLine(subj);

        }

        public void getTag()
        {
            DataRow dr;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Add_Tag", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            dr = dt.NewRow();
            tag.DataSource = dt;
            tag.ValueMember = "Tag_Name";
            tag.DisplayMember = "Tag_Name";
            Console.WriteLine(Tag);

        }
        public void getGroupid()
        {
            DataRow dr;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Add_StudentGroup", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();

            dr = dt.NewRow();
            groupid.DataSource = dt;
            groupid.ValueMember = "Group_id";
            groupid.DisplayMember = "Group_id";

            

            Console.WriteLine(id);

        }

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
                cmd = new SqlCommand("delete from Add_Session where session_id='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
