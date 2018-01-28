using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class view_class
    {

        private string connstring = ConfigurationManager.ConnectionStrings["TESTDB"].ConnectionString;

        string querry;
        public view_class(string q)
        {
            this.querry = q;
        }

        public view_class()
        {
            // TODO: Complete member initialization
        }

        
        public DataTable showrecord()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(querry, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    dt.Load(dr);
                }
                else
                {
                    MessageBox.Show("No records were found!!");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("No records were found!!");
            }
            finally
            {
                conn.Close();
            }
            return dt;

        }

        
    }
}
