using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IP_WcfService
{
    public class Instructors
    {
        private string  instr_id;
        private string nic;

        public string _instr_id
        {
            set
            {
                this.instr_id = value;
            }

            get
            {
                return this.instr_id;
            }
        }

        public string _nic
        {
            set
            {
                this.nic = value;
            }

            get
            {
                return this.nic;
            }
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["resourceAlloc"].ToString());
        public string  add()
        {
            string ad = "exec addIns @nic,@ins";

            SqlCommand cmd = new SqlCommand(ad,con);
            cmd.Parameters.AddWithValue("@nic", _nic);
            cmd.Parameters.AddWithValue("@ins", _instr_id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "instructor added ";
            }
            catch(SqlException ex)
            {
                return ex.Message;
            }
            finally
            {
                con.Close();
                
            }


        }
        public DataTable viewLec()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["resourceAlloc"].ToString());

            DataTable dt = new DataTable();
            string vw = "select * from instructors";

            SqlCommand cmd = new SqlCommand(vw, con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            dt.TableName = "instructors";

            return dt;

        }

    }
}