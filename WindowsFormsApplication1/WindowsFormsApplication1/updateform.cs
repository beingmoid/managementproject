using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class updateform : Form
    {
        private string connstring = ConfigurationManager.ConnectionStrings["TESTDB"].ConnectionString;
        public updateform()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox5.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            richTextBox1.Text = " ";


            

            SqlConnection connection = new SqlConnection(connstring);
            string sql = "select std_name,std_fname,std_age,std_phone,std_gender,std_address from student where std_id= " + textBox1.Text + "";

            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBox2.Text = reader.GetValue(0).ToString();
                    textBox3.Text = reader.GetValue(1).ToString();
                    textBox4.Text = reader.GetValue(2).ToString();
                    textBox5.Text = reader.GetValue(3).ToString();
                    if (reader.GetValue(4).ToString().Equals("male"))
                    {
                        radioButton1.Checked = true;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                    }
                    richTextBox1.Text = reader.GetValue(5).ToString();
                }
                connection.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show("No record were found!");
            }

        }

        private void updateform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student s = new student();
            s.sname = textBox2.Text;
            s.sfname = textBox3.Text;
            s.sage = textBox4.Text;
            s.sphone = textBox5.Text;
            if(radioButton1.Checked==true)
            {
                s.sgender = "male";
            }
            else
            {
                s.sgender = "female";

            }
            s.saddress = richTextBox1.Text;
            s.s_id = Convert.ToInt32(textBox1.Text);

            updateclass u = new updateclass();
            string msg = u.update_record(s);
            MessageBox.Show(msg);
        }
    }
}
