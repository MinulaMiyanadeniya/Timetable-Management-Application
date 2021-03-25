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
    public partial class AddLocations_cd : Form
    {
        //String connection
        String path = "Data Source=LAPTOP-5D763AI2\\CHAMODISQL;Initial Catalog=TimeTableManagementApp;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        public AddLocations_cd()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void AddLocationbox_Enter(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtBname.Text =="" || txtBname.Text ==""|| txtCapacity.Text == "") {

                MessageBox.Show("Please fill all fields");

            }
            else {


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
                    cmd = new SqlCommand("insert into LocationDetails (BuildingName,RoomName,RoomType,Capacity) values('" + txtBname.Text + "','" + txtRname.Text + "','" + roomType + "','" + txtCapacity.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Location Details have been added successfully");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtBname.Text = "";
            txtRname.Text = "";
            txtCapacity.Text = "";
            rbtnLectureHall.Checked = false;
            rbtnLaboratory.Checked = false;
        }
    }
}
