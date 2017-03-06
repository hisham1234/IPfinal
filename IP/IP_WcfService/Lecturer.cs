using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace IP_WcfService
{
    [DataContract]
    public class Lecturer
    {



        private string nic;
        private string lid;
        private string fname;
        private string lname;
        private string cont_number;

        public string _nic
        {

            set
            {
                this.nic = value;
            }
            get
            {
                return nic;
            }
        }

        public string _lid
        {

            set
            {
                this.lid = value;
            }
            get
            {
                return lid;
            }
        }

        public string _fname
        {

            set
            {
                this.fname = value;
            }
            get
            {
                return fname;
            }
        }

        public string _lname
        {

            set
            {
                this.lname = value;
            }
            get
            {
                return lname;
            }
        }

        public string _cont_number
        {

            set
            {
                this.cont_number = value;
            }
            get
            {
                return cont_number;
            }
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["resourceAlloc"].ToString());

        public string addLec()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["resourceAlloc"].ToString());
            string inst = "insert into lecturers(nic,fname,lname,contact_no,lec_id) values(@nic,@fname,@lname,@contact_no,@lec_id)";

            SqlCommand cmd = new SqlCommand(inst, con);
            cmd.Parameters.AddWithValue("@nic", _nic);
            cmd.Parameters.AddWithValue("@fname", _fname);
            cmd.Parameters.AddWithValue("@lname", _lname);
            cmd.Parameters.AddWithValue("@contact_no", _cont_number);
            cmd.Parameters.AddWithValue("@lec_id", _nic);



            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return "Lecturer added successfully";

            }
            catch (SqlException ex)
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
            string vw = "select * from lecturers";

            SqlCommand cmd = new SqlCommand(vw, con);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            dt.TableName = "lecturers";

            return dt;

        }

        //public List<Lecturer> GetAll()
        //{
        //    List<Lecturer> lecl = new List<Lecturer>();

        //    SqlCommand cmd = new SqlCommand("select * from lecturers", con);
        //    con.Open();

        //    SqlDataReader rd = cmd.ExecuteReader();
        //    while (rd.Read())
        //    {
        //        Lecturer lc = new Lecturer()
        //        {
        //            nic = rd[0].ToString(),
        //            fname = rd[1].ToString(),
        //            lname = rd[2].ToString(),
        //            cont_number = rd[3].ToString(),
        //            lid = rd[4].ToString()
        //        };


        //        lecl.Add(lc);
        //    }
        //    return lecl;
        //}

    }
}
    
