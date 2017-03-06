using System;
using System.Collections.Generic;
using System.Configuration;
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

        public string addGrp()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["resourceAlloc"].ToString());
            string add = "insert into groups(group_id,startNo,endNo) values(@gid,@sno,@eno)";

            SqlCommand cmd = new SqlCommand(add, con);
            cmd.Parameters.AddWithValue("@gid", _grpId);

            cmd.Parameters.AddWithValue("@sno", _startNo);

            cmd.Parameters.AddWithValue("@eno", _endNo);

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









        }
    }