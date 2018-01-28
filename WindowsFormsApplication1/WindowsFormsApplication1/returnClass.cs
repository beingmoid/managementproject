using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WindowsFormsApplication1
{
    class returnClass
    {
        private string connstring = ConfigurationManager.ConnectionStrings["TESTDB"].ConnectionString;

        public string scalarReturn(string q)
        {
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand(q, conn);
            string s = cmd.ExecuteScalar().ToString();
            return s;

        }
    }
}
