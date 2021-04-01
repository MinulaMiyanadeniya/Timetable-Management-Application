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
        SqlConnection con1;
        SqlCommand cmd;
        SqlDataAdapter adpt;

        WhatsNew_cd whatsNew_cd = new WhatsNew_cd();

        public Statistics_cd()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            con1 = new SqlConnection(path);
            //Loadchart();
            //LoadPieChart();
          
        }

        public void Loadchart() {
            chart1.Series.Clear();
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
            con.Close();
            return dtChartData;
            
            
        }

        public void LoadPieChart() {

           
            chart2.DataSource = GetData2();
            chart2.Series["Series1"].XValueMember = "RegistrationType";
            chart2.Series["Series1"].YValueMembers = "Number";

        }

        private object GetData2()
        {

            DataTable dtChartData = new DataTable();

            con1.Open();
            cmd = new SqlCommand("rdtest2", con1);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();
            dtChartData.Load(reader);
            con1.Close();
            return dtChartData;


           
            

        }

        public void clearpie() {

            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
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

        private void Statistics_cd_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            whatsNew_cd.LoadText();
            whatsNew_cd.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
            //chart2.Series.Add("Series1");
        }
    }
}
