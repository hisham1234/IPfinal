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
    public partial class AddLecturer : Form
    {
        public AddLecturer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddLecturer_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client obj = new Service1Client();
          string ret=  obj.addLecturer(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox8.Text);
            MessageBox.Show(ret);
           // obj.addLecturer()
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service1Client obj = new Service1Client();
            //  List<Lecturer> lc = new List<Lecturer>();
           // dataGridView1.DataSource = obj.v
        
            dataGridView1.DataSource = obj.viewLecturer();


        
          
        }
    }
}
