using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static string fk_ad;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            string userdb, passworddb;

            returnClass rc = new returnClass();
            userdb = rc.scalarReturn("select count(ad_id) from administrator where ad_name='" + user + "'");

            {
                if (userdb.Equals("0"))
                {
                    MessageBox.Show("Invalid user name!");
                }

                else
                {
                    passworddb = rc.scalarReturn("select ad_password from administrator where ad_name= '" + user + "'");

                    if (passworddb.Equals(password))
                    {
                        fk_ad = rc.scalarReturn("select ad_id from administrator where ad_name = '" + user + "'");

                        Form2 f = new Form2();
                        f.Show();
                    }

                    else
                    {
                        MessageBox.Show("Invalid user password!");

                    }
                }



            }
        }
    }
}
    

