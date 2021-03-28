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
    public partial class Statistics_cd : Form
    {
        String path = "Data Source=LAPTOP-5D763AI2\\CHAMODISQL;Initial Catalog=TimeTableManagementApp;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;

        public Statistics_cd()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            Loadchart();
        }

        public void Loadchart() {

            //chart1.DataSource = GetData();
            chart1.DataBindCrossTable(GetData().DefaultView, "RoomType", "BuildingName", "RN","");


        }

        private DataTable GetData()
        {
            DataTable dtChartData = new DataTable();

            con.Open();
            cmd = new SqlCommand("getlocationBC", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            dtChartData.Load(reader);

            return dtChartData;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
          

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
