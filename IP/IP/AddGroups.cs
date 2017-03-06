using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP.ServiceReference1;

namespace IP
{
    public partial class AddGroups : Form
    {
        public AddGroups()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client obj = new Service1Client();
            MessageBox.Show(obj.addGrp(textBox1.Text, textBox2.Text, textBox3.Text,textBox4.Text));
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();

            textBox2.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service1Client obj = new Service1Client();
           dataGridView1.DataSource=obj.viewGroup();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
