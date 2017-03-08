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
    public partial class AddInstructor : Form
    {
        public AddInstructor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Service1Client obj = new Service1Client();
            MessageBox.Show(obj.addIns(comboBox1.SelectedValue.ToString(),textBox9.Text));
        }

        private void AddInstructor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resourceAllocationDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.resourceAllocationDataSet.Students);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service1Client obj = new Service1Client();
            dataGridView1.DataSource = obj.viewIns();
            //dataGridView1.d
            
        }
    }
}
