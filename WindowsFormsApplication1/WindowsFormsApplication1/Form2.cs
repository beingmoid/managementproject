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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            insertform obj = new insertform();
            obj.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            deleteform df = new deleteform();
            df.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            viewform vf = new viewform();
            vf.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            updateform uf = new updateform();
            uf.Show();
        }
    }
}
