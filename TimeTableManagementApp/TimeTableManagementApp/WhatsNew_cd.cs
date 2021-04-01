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
    public partial class WhatsNew_cd : Form
    {
        
        //String connection
        String path = "Data Source=LAPTOP-5D763AI2\\CHAMODISQL;Initial Catalog=TimeTableManagementApp;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;

        

        public WhatsNew_cd()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            LoadText();
        }

        public void LoadText() {

            con.Open();
            cmd = new SqlCommand("SELECT TOP 1 * FROM Lecturers ORDER BY ID DESC", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            lecturer.Text = sdr["Name"].ToString();
            con.Close();

            con.Open();
            cmd = new SqlCommand("SELECT TOP 1 * FROM StudentGroups ORDER BY ID DESC", con);
            sdr = cmd.ExecuteReader();
            sdr.Read();
            group.Text = sdr["GroupID"].ToString();
            con.Close();

            con.Open();
            cmd = new SqlCommand("SELECT TOP 1 * FROM Subjects ORDER BY ID DESC", con);
            sdr = cmd.ExecuteReader();
            sdr.Read();
            subject.Text = sdr["Name"].ToString();
            con.Close();

            con.Open();
            cmd = new SqlCommand("SELECT TOP 1 * FROM LocationDetails ORDER BY RoomID DESC", con);
            sdr = cmd.ExecuteReader();
            sdr.Read();
            room.Text = sdr["RoomName"].ToString();
            con.Close();

           

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
            
        }
    }
}
