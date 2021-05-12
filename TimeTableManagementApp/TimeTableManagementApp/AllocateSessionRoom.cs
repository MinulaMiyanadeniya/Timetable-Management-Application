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

        public String sid;
        public String lec1;
        public String lec2;
        public String subcode;
        public String subname;
        public String grpid;
        public String tag;
        public String status;

        public String sid1;
        public String lec11;
        public String lec21;
        public String subcode1;
        public String subname1;
        public String grpid1;
        public String tag1;
        public String status1;

        public String sid2;
        public String lec12;
        public String lec22;
        public String subcode2;
        public String subname2;
        public String grpid2;
        public String tag2;
        public String status2;

        ManageSessionRoom_cd ms; 

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

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sid = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            lec1 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            lec2 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            subcode = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            subname = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            grpid = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            tag = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            status = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

            
        }


        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void DataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

            //ManageSessionRoom_cd msg = new ManageSessionRoom_cd(sid, lec1, lec2, subcode, subname, grpid, tag, status);
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ms = new ManageSessionRoom_cd(sid, lec1, lec2, subcode, subname, grpid, tag, status);
            //ms.getData();
            ms.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ms = new ManageSessionRoom_cd(sid1, lec11, lec21, subcode1, subname1, grpid1, tag1, status1);
            //ms.getData();
            ms.ShowDialog();
        }

        private void DataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView2_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            sid1 = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            lec11 = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            lec21 = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            subcode1 = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            subname1 = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            grpid1 = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            tag1 = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            status1 = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();

            //label6.Text = sid1;
        }

        private void DataGridView3_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            sid2 = dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString();
            lec12 = dataGridView3.Rows[e.RowIndex].Cells[1].Value.ToString();
            lec22 = dataGridView3.Rows[e.RowIndex].Cells[2].Value.ToString();
            subcode2 = dataGridView3.Rows[e.RowIndex].Cells[3].Value.ToString();
            subname2 = dataGridView3.Rows[e.RowIndex].Cells[4].Value.ToString();
            grpid2 = dataGridView3.Rows[e.RowIndex].Cells[5].Value.ToString();
            tag2 = dataGridView3.Rows[e.RowIndex].Cells[6].Value.ToString();
            status2 = dataGridView3.Rows[e.RowIndex].Cells[7].Value.ToString();


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ms = new ManageSessionRoom_cd(sid2, lec12, lec22, subcode2, subname2, grpid2, tag2, status2);
            //ms.getData();
            ms.ShowDialog();
        }
    }
}
