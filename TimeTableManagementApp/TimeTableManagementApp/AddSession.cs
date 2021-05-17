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
    public partial class AddSession : Form
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
        public AddSession()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            getLec1();
            getLec2();
            getSubCode();
            getSubName();
            getTag();
            getGroupid();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void faculty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddSession_Load(object sender, EventArgs e)
        {

        }

        public void getLec1() {
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

            string id = groupid.SelectedValue.ToString();
            
            Console.WriteLine(id);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            if (lec1.SelectedItem == "" || lec2.SelectedItem == "" || code.SelectedItem == "" || subject.SelectedItem == "" || groupid.SelectedItem == "" || tag.SelectedItem == "" || students.Text == "" || txthours.Text == "" || txtmins.Text == "")
            {
                MessageBox.Show("Please fill in the blanks");
            }
            else
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
                    cmd = new SqlCommand("insert into Add_Session (Lecture1,Lecture2,Subject_code,Subject_name,Group_id,Tag,Student_count,Hrs,Mins)values('" + lecture1 + "','" + lecture2 + "','" + subjcode + "','" + subj + "','" + id+ "','" + Tag + "','" + students.Text + "','" + txthours.Text + "','" + txtmins.Text + "')", con);
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

        public void clear()
        {
            lec1.SelectedItem = "";
            lec2.SelectedItem = "";
            code.SelectedItem = "";
            subject.SelectedItem = "";
            groupid.SelectedItem = "";
            tag.SelectedItem = "";
            students.Text = "";
            txthours.Text = "";
            txtmins.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        public void rankdisplay()
        {

            String a = lec1.SelectedValue.ToString();
            String b = code.SelectedValue.ToString();
            String c = subject.SelectedValue.ToString();
            String d = tag.SelectedValue.ToString();
            String e = groupid.SelectedValue.ToString();
            String f = txthours.Text;
            String g = txtmins.Text;
            String i = (a + "-" + b +"-"+c+"-"+d+"-"+e+"-"+f+"-"+g);
            generate.Text = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rankdisplay();
        }
    }
}
