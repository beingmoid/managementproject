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
    public partial class viewform : Form
    {
        
        
        
        public viewform()
        {
            InitializeComponent();
        }

        

        private void viewform_Load(object sender, EventArgs e)
        {

            string q = "select s.std_id as 'ID', s.std_name as 'Name',s.std_fname as 'Father Name',s.std_gender as 'Gender',s.std_address as 'Address',s.std_age as'Age',s.std_phone as'Phone NO',s.std_admissiondate as 'Admission Date',a.ad_name as 'Admin Name' from student s inner join administrator a on a.ad_id=s.std_ad_fk_id";
            view_class vc = new view_class(q);
          
            dataGridView1.DataSource = vc.showrecord();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string q = "select s.std_id as 'ID', s.std_name as 'Name',s.std_fname as 'Father Name',s.std_gender as 'Gender',s.std_address as 'Address',s.std_age as'Age',s.std_phone as'Phone NO',s.std_admissiondate as 'Admission Date',a.ad_name as 'Admin Name' from student s inner join administrator a on a.ad_id=s.std_ad_fk_id where s.std_name like '" + textBox1.Text + "%'";
           view_class vc = new view_class(q);    
            dataGridView1.DataSource = vc.showrecord(); 
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            string q = "select s.std_id as 'ID', s.std_name as 'Name',s.std_fname as 'Father Name',s.std_gender as 'Gender',s.std_address as 'Address',s.std_age as 'Age', s.std_phone as 'Phone NO',s.std_admissiondate as 'Admission Date',a.ad_name as 'Admin ID' from student s inner join administrator a on a.ad_id=s.std_ad_fk_id where s.std_id like '"+textBox2.Text+"%'";
            view_class vc = new view_class(q);
            dataGridView1.DataSource = vc.showrecord(); 
        }
    }
}
