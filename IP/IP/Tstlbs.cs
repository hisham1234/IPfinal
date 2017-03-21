using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP
{
    class Tstlbs
    {


        //public DataTable viewLabs()
        //{
        //    DataTable dt = new DataTable();
        //    string vwlbs = "select prac_id,module_id from practical_sessions where prac_id=@d";


        //    SqlCommand cmd = new SqlCommand(vwlbs, con);
        //    con.Open();

        //    cmd.Parameters.AddWithValue("@day", _day);
        //    cmd.Parameters.AddWithValue("@time", _time);
        //    cmd.Parameters.AddWithValue("@gid", _gid);

        //    cmd.Parameters.AddWithValue("@d", 2);

        //    SqlDataAdapter adp = new SqlDataAdapter(cmd);
        //    con.Close();
        //    adp.Fill(dt);

        //    dt.TableName = "Practical_Sessions";
        //    return dt;
        //}

    }
}
