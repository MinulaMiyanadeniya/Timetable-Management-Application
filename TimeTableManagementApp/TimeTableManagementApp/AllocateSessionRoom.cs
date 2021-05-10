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
    public partial class AllocateSessionRoom : Form
    {
        //String connection
        String path = "Data Source=LAPTOP-5D763AI2\\CHAMODISQL;Initial Catalog=TimeTableManagementApp;Integrated Security=True";
        SqlConnection con;
        SqlConnection con1;
        SqlConnection con2;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        SqlDataAdapter adpt1;
        SqlDataAdapter adpt2;
        DataTable dt;
        DataTable dt1;
        DataTable dt2;
        public AllocateSessionRoom()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            con1 = new SqlConnection(path);
            con2 = new SqlConnection(path);
            display();
            display1();
            display2();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        public void display() {

            try
            {

                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from session_status WHERE (status = 'consecative')", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);

            }
        }

        public void display1() {

            try
            {

                dt1 = new DataTable();
                con1.Open();
                adpt1 = new SqlDataAdapter("select * from session_status WHERE (status = 'nonoverlap')", con1);
                adpt1.Fill(dt1);
                dataGridView2.DataSource = dt1;
                con1.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }


        public void display2()
        {

            try
            {

                dt2 = new DataTable();
                con2.Open();
                adpt2 = new SqlDataAdapter("select * from session_status WHERE (status = 'notavailable')", con2);
                adpt2.Fill(dt2);
                dataGridView3.DataSource = dt2;
                con2.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }


        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
