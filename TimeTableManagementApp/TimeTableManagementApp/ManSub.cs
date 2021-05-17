using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTableManagementApp
{
    class ManSub
    {
        private static string myConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
       public string offered_year { get; set; }
        public string offered_semester { get; set; }
        public string subject_name { get; set; }
        public string subject_code { get; set; }
        public string lec_hours { get; set; }
        public string lec_mins { get; set; }
        public string tute_hours { get; set; }
        public string tute_mins { get; set; }
        public string lab_hours { get; set; }
        public string lab_mins { get; set; }
        public string evaluation_hours { get; set; }
        public string evaluation_mins { get; set; }

        private const string SelectQuery = "Select * from Add_Subject";
        private const string InsertQuery = "Insert Into Add_Subject(offered_year, offered_semester, subject_name, subject_code, lec_hours,lec_mins,tute_hours,tute_mins,lab_hours,lab_mins,evaluation_hours,evaluation_mins) Values (@offered_year, @offered_semester, @subject_name, @subject_code, @lec_hours,@lec_mins,@tute_hours,@tute_mins,@lab_hours,@lab_mins,@evaluation_hours,@evaluation_mins)";
        private const string UpdateQuery = "Update Add_Subject set offered_year = @offered_year, offered_semester = @offered_semester , subject_name=@subject_name, subject_code=@subject_code, lec_hours=@lec_hours,lec_mins=@lec_mins,tute_hours=@tute_hours,tute_mins=@tute_mins,lab_hours=@lab_hours,lab_mins=@lab_mins,evaluation_hours=@evaluation_hours,evaluation_mins=@evaluation_mins";
        private const string DeleteQuery = "Delete from Add_Subject where subject_code=@subject_code";

        public DataTable GetSubject()
        {
            var datatable = new DataTable();
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(SelectQuery, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(com))
                    {
                        adapter.Fill(datatable);
                    }
                }
            }
            return datatable;
        }

        public bool InsertSubject(ManSub subject)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(InsertQuery, con))
                {
                    com.Parameters.AddWithValue("@offered_year", subject.offered_year);
                    com.Parameters.AddWithValue("@offered_semester", subject.offered_semester);
                    com.Parameters.AddWithValue("@subject_namee", subject.subject_name);
                    com.Parameters.AddWithValue("@subject_code", subject.subject_code);
                    com.Parameters.AddWithValue("@lec_hours", subject.lec_hours);
                    com.Parameters.AddWithValue("@lec_mins", subject.lec_mins);
                    com.Parameters.AddWithValue("@tute_hours", subject.tute_hours);
                    com.Parameters.AddWithValue("@tute_mins", subject.tute_mins);
                    com.Parameters.AddWithValue("@lab_hours", subject.lab_hours);
                    com.Parameters.AddWithValue("@lab_mins", subject.lab_mins);
                    com.Parameters.AddWithValue("@evaluation_hours", subject.evaluation_hours);
                    com.Parameters.AddWithValue("@evaluation_mins", subject.evaluation_mins);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
        public bool UpdateSubject(ManSub subject)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(UpdateQuery, con))
                {
                    com.Parameters.AddWithValue("@offered_year", subject.offered_year);
                    com.Parameters.AddWithValue("@offered_semester", subject.offered_semester);
                    com.Parameters.AddWithValue("@subject_namee", subject.subject_name);
                    com.Parameters.AddWithValue("@subject_code", subject.subject_code);
                    com.Parameters.AddWithValue("@lec_hours", subject.lec_hours);
                    com.Parameters.AddWithValue("@lec_mins", subject.lec_mins);
                    com.Parameters.AddWithValue("@tute_hours", subject.tute_hours);
                    com.Parameters.AddWithValue("@tute_mins", subject.tute_mins);
                    com.Parameters.AddWithValue("@lab_hours", subject.lab_hours);
                    com.Parameters.AddWithValue("@lab_mins", subject.lab_mins);
                    com.Parameters.AddWithValue("@evaluation_hours", subject.evaluation_hours);
                    com.Parameters.AddWithValue("@evaluation_mins", subject.evaluation_mins);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool DeleteSubject(ManSub subject)
        {
            int rows;
            using (SqlConnection con = new SqlConnection(myConn))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(DeleteQuery, con))
                {
                    com.Parameters.AddWithValue("@subject_code", subject.subject_code);
                    rows = com.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }
    }
}
