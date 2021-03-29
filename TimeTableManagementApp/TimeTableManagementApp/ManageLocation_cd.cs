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
    public partial class ManageLocation_cd : Form
    {

        //String connection
        String path = "Data Source=LAPTOP-5D763AI2\\CHAMODISQL;Initial Catalog=TimeTableManagementApp;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int RID;

        public ManageLocation_cd()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        public void display() {
            try {

                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("select * from LocationDetails", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }

        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtBname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtRname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            

            rbtnLectureHall.Checked = true;
            rbtnLaboratory.Checked = false;

            if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Laboratory") {

                rbtnLectureHall.Checked = false;
                rbtnLaboratory.Checked = true;
            }

            txtCapacity.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();


        }



        private void Button4_Click(object sender, EventArgs e)
        {
            clear();
        }



        public void clear()
        {


            txtBname.Text = "";
            txtRname.Text = "";
            txtCapacity.Text = "";
            rbtnLectureHall.Checked = false;
            rbtnLaboratory.Checked = false;


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                String roomType;
                if (rbtnLectureHall.Checked)
                {

                    roomType = "LectureHall";
                }
                else
                {
                    roomType = "Laboratory";

                }



                con.Open();
                cmd = new SqlCommand("update LocationDetails set BuildingName='"+txtBname.Text+ "',RoomName='"+txtRname.Text+ "',RoomType='"+roomType+ "',Capacity='"+txtCapacity.Text+ "' where RoomID = '"+RID+"' ",con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Details has been Updated Successfully");
                display();

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Are you sure you want to Delete this record?");
                con.Open();
                cmd = new SqlCommand("delete from LocationDetails where RoomID = '" + RID + "'",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record has been Deleted from the database");

                con.Close();
                display();

            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
