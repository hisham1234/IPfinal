using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IP_WcfService
{

 
    public class PracSession
    {
        private string day;
        private string time;
        private string gid;


        public string  _day
        {
            set
            {
                this.day = value;
            }
            get
            {
                return day;
            }
        }


        public string _time
        {
            set
            {
                this.time = value;
            }
            get
            {
                return time;
            }
        }


        public string _gid
        {
            set
            {
                this.gid = value;
            }
            get
            {
                return gid;
            }
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["resourceAlloc"].ToString());

        public DataTable   viewLabs()
        {
            DataTable dt = new DataTable();
            string vwlbs = "exec viewLabs @day,@time,@gid";


            SqlCommand cmd = new SqlCommand(vwlbs, con);
            con.Open();
          
            cmd.Parameters.AddWithValue("@day", _day);
            cmd.Parameters.AddWithValue("@time", _time);
           cmd.Parameters.AddWithValue("@gid", _gid);

            cmd.Parameters.AddWithValue("@d",2);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            con.Close();
            adp.Fill(dt);

            dt.TableName = "Practical_Sessions";
            return dt;
        }
    }
}