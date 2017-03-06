using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace IP_WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string addLecturer(string nic, string lid, string fname, string lname, string cont_num)
        {
            Lecturer lec = new Lecturer();
            lec._nic = nic;
            lec._fname = fname;
            lec._lname = lname;
            lec._cont_number = cont_num;
            lec._lid = lid;

            return lec.addLec();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["resourceAlloc"].ToString());

        public DataTable viewLecturer()
        {
            Lecturer lec = new Lecturer();
            return lec.viewLec();

        }

        public string addGrp(string gid,string sno,string eno)
        {
            Groups grp = new Groups();
            grp._grpId = gid;
            grp._startNo = sno;
            grp._endNo = eno;

           return grp.addGrp();
        }



        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
