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
    public partial class AddSubject : Form
    {
        //string connection
        string path = @"Data Source=DESKTOP-KN9V1CU\SQLEXPRESS;Initial Catalog=TimeTableManagementApp;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;//this is use for run the sql queries
        public AddSubject()
        {
            InitializeComponent();
            con = new SqlConnection(path);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (offeredyear.SelectedItem==""||txtsubject_name.Text==""||txtsubcode.Text==""||txtlechours.Text==""||txtlecmins.Text==""||txttutehours.Text==""||txttutemins.Text==""||txtlabhours.Text==""||txtlabmins.Text==""||txtevaluhours.Text==""||txtevalumins.Text=="")
            {
                MessageBox.Show("Please fill in the blanks");
            }
            else
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
                    cmd = new SqlCommand("insert into Add_Subject (offered_year,offered_semester,subject_name,subject_code,lec_hours,lec_mins,tute_hours,tute_mins,lab_hours,lab_mins,evaluation_hours,evaluation_mins)values('" + offeredyear.SelectedItem + "','" + semester + "','" + txtsubject_name.Text + "','" + txtsubcode.Text + "','" + txtlechours.Text + "','" + txtlecmins.Text + "','" + txttutehours.Text + "','" + txttutemins.Text + "','" + txtlabhours.Text + "','" + txtlabmins.Text + "','" + txtevaluhours.Text + "','" + txtevalumins.Text + "')", con);
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

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            offeredyear.SelectedItem = "";
            txtsubject_name.Text = "";
            txtsubcode.Text = "";
            txtlechours.Text = "";
            txtlecmins.Text = "";
            txttutehours.Text = "";
            txttutemins.Text = "";
            txtlabhours.Text = "";
            txtlabmins.Text = "";
            txtevaluhours.Text = "";
            txtevalumins.Text = "";
        }

        private void AddSubject_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
