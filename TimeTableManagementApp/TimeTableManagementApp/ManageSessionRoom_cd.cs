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
    public partial class ManageSessionRoom_cd : Form

    {

        String path = "Data Source=LAPTOP-5D763AI2\\CHAMODISQL;Initial Catalog=TimeTableManagementApp;Integrated Security=True";
        SqlConnection con;
        SqlConnection con1;
        SqlConnection con2;
        SqlCommand cmd;
        //AllocateSessionRoom al = new AllocateSessionRoom();

        public String sid;
        public String lec1;
        public String lec2;
        public String subcode;
        public String subname;
        public String grpid;
        public String tag;
        public String status;
        String cbx;


        public ManageSessionRoom_cd(String sid, String lec1, String lec2, String subcode, String subname, String grpid, String tag, String status)
        {
            //textBox1.Text = al.sid;
            InitializeComponent();
            con = new SqlConnection(path);
            textBox1.Text = sid;
            this.sid = sid;
            this.lec1 = lec1;
            this.lec2 = lec2;
            this.subcode = subcode;
            this.subname = subname;
            this.grpid = grpid;
            this.tag = tag;
            this.status = status;
            getroom();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void getroom() {

            DataRow dr;

            con.Open();
            SqlCommand cmd = new SqlCommand("select * from LocationDetails", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select Room--" };
            dt.Rows.InsertAt(dr, 0);

            comboBox1.ValueMember = "RoomID";

            comboBox1.DisplayMember = "RoomName";
            comboBox1.DataSource = dt;

            
            con.Close();

            




        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbx = comboBox1.SelectedItem.ToString();
            richTextBox1.Text = ("Session id:" + sid + " lecturer1:" + lec1 + " lecturer2:" + lec2 + " subject code:" + subcode + " subject name" + subname + " groupID" + grpid + " tag" + tag);



        }
    }
}
