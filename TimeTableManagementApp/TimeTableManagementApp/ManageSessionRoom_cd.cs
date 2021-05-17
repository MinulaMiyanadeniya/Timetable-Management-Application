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
        ViewSessionRoom_cd vs;


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
            con.Close();

            dr = dt.NewRow();
            //dr.ItemArray = new object[] { 0, "--Select Room--" };
            //dt.Rows.InsertAt(dr, 0);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "RoomName";

            comboBox1.DisplayMember = "RoomName";
            

            
            


            
            richTextBox1.Text = ("Session id:" + sid + " lecturer1:" + lec1 + " lecturer2:" + lec2 + " subject code: " + subcode + " subject name: " + subname + " groupID: " + grpid + " tag" + tag);


        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //submit

            try {

                cbx = comboBox1.SelectedValue.ToString();
                con.Open();
                // cmd = new SqlCommand("insert into session_status_room set id='" + sid + "',lec1='" + lec1 + "',lec2='" + lec2 + "',subcode='" + subcode + "',subname='" + subname + "',grpid='" + grpid + "',tag='" + tag + "',status='" + status + "',room='" + cbx + "'", con);
                cmd = new SqlCommand("insert into session_status_room (id,lec1,lec2,subcode,subname,grpid,tag,status,room) values('" + sid + "','" + lec1 + "','" + lec2 + "','" + subcode + "','" + subname + "','" + grpid + "','" + tag + "','" + status + "','" + cbx + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Details has been Submited Successfully");
                clear();
                



            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);

            }
        }


        public void clear() {

            textBox1.Text = "";
            richTextBox1.Text = "";

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            vs = new ViewSessionRoom_cd();
            vs.ShowDialog();
        }
    }
}
