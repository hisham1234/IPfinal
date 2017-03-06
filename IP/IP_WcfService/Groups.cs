using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IP_WcfService
{
    public class Groups
    {
        private string grpId;
        private string startNo;
        private string endNo;
        private int no;

       public string  _grpId
        {
            set
            {
                this.grpId = value;

            }
            get
            {
                return this.grpId;
            }
       }

        public int _no
        {
            set
            {
                this.no = value;

            }
            get
            {
                return this.no;
            }
        }
        public string _startNo
        {
            set
            {
                this.startNo = value;

            }
            get
            {
                return this.startNo;
            }
        }


        public string _endNo
        {
            set
            {
                this.endNo = value;

            }
            get
            {
                return this.endNo;
            }
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["resourceAlloc"].ToString());

        public string addGrp()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["resourceAlloc"].ToString());
            string add = "insert into groups values(@gid,@no,@sno,@eno)";

            SqlCommand cmd = new SqlCommand(add, con);
            cmd.Parameters.AddWithValue("@gid", _grpId);

            cmd.Parameters.AddWithValue("@sno", _startNo);

            cmd.Parameters.AddWithValue("@eno", _endNo);

            cmd.Parameters.AddWithValue("@no", _no);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "group created succefully";
            }
            catch(SqlException ex)
            {
                return ex.Message;
            }
          
        }
        public DataTable viewGroup()
        {
            DataTable dt = new DataTable();
            string vw = "select * from groups";

            SqlCommand cmd = new SqlCommand(vw, con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            sd.Fill(dt);

            dt.TableName = "groups";
            return dt;

        }









        }
    }