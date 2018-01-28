using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class updateclass
    {
        private string connstring = ConfigurationManager.ConnectionStrings["TESTDB"].ConnectionString;

        public string update_record(student s)
        {
            string msg = " ";
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                SqlCommand cmd = new SqlCommand("update_student", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@std_id", SqlDbType.Int).Value = s.s_id;
                cmd.Parameters.Add("@std_name", SqlDbType.NVarChar, 20).Value = s.sname;
                cmd.Parameters.Add("@std_fname", SqlDbType.NVarChar, 20).Value = s.sfname;
                cmd.Parameters.Add("@std_gender", SqlDbType.NVarChar, 20).Value = s.sgender;
                cmd.Parameters.Add("@std_address", SqlDbType.NVarChar, 70).Value = s.saddress;
                cmd.Parameters.Add("@std_age", SqlDbType.NVarChar, 6).Value = s.sage;
                cmd.Parameters.Add("@std_phone", SqlDbType.NVarChar, 20).Value = s.sphone;
                


                conn.Open();
                cmd.ExecuteNonQuery();

                msg = "Data successfully update!";


            }
            catch (Exception)
            {

                msg = "ERROR!  Data is not successfully update!";
            }
            finally
            {

                conn.Close();

            }

            return msg;

        }


        
    }
}
