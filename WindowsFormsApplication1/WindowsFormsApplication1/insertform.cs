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
    
    public partial class insertform : Form
    {
        public insertform()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            student s = new student();
            s.sfk = Form1.fk_ad;
            s.sdate = System.DateTime.Now.ToShortDateString();
            s.sname = textBox2.Text;
            s.sfname = textBox1.Text;
            s.sage = textBox3.Text;
            s.sphone = textBox4.Text;
            if (radioButton1.Checked==true)
            {
                s.sgender = "male";
            }
            else if(radioButton2.Checked==true)
            {
                s.sgender = "female";
            }
            else
            {
                MessageBox.Show("Plese select gender!");
            }
            s.saddress = richTextBox1.Text;

            insert i = new insert();
            MessageBox.Show(i.insert_record(s));

        }

        private void insertform_Load(object sender, EventArgs e)
        {

        }
        
    }
}
