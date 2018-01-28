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
    class insert
    {
        private string connstring = ConfigurationManager.ConnectionStrings["TESTDB"].ConnectionString;


        public string insert_record(student s)
        {
            string msg = " ";
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                SqlCommand cmd = new SqlCommand("insert_student", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@std_name", SqlDbType.NVarChar, 20).Value = s.sname;
                cmd.Parameters.Add("@std_fname", SqlDbType.NVarChar, 20).Value = s.sfname;
                cmd.Parameters.Add("@std_gender", SqlDbType.NVarChar, 20).Value = s.sgender;
                cmd.Parameters.Add("@std_address", SqlDbType.NVarChar, 70).Value = s.saddress;
                cmd.Parameters.Add("@std_age", SqlDbType.NVarChar, 6).Value = s.sage;
                cmd.Parameters.Add("@std_phone", SqlDbType.NVarChar, 20).Value = s.sphone;
                cmd.Parameters.Add("@std_admissiondate", SqlDbType.NVarChar, 20).Value = s.sdate;
                cmd.Parameters.Add("@std_ad_fk_id", SqlDbType.NVarChar, 20).Value = s.sfk;


                conn.Open();
                cmd.ExecuteNonQuery();

                msg = "Data successfully insert!";


            }
            catch (Exception)
            {

                msg = "ERROR!  Data is not successfully insert!";
            }
            finally
            {

                conn.Close();

            }

            return msg;

        }



    }
}
