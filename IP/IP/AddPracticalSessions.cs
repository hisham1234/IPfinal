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
    public partial class AddPracticalSessions : Form
    {
        public AddPracticalSessions()
        {
            InitializeComponent();
        }

        private void AddPracticalSessions_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resourceAllocationDataSet6.Batches' table. You can move, or remove it, as needed.
            this.batchesTableAdapter1.Fill(this.resourceAllocationDataSet6.Batches);
            // TODO: This line of code loads data into the 'resourceAllocationDataSet5.Batches' table. You can move, or remove it, as needed.
            this.batchesTableAdapter.Fill(this.resourceAllocationDataSet5.Batches);
            // TODO: This line of code loads data into the 'resourceAllocationDataSet4.Labs' table. You can move, or remove it, as needed.
            this.labsTableAdapter.Fill(this.resourceAllocationDataSet4.Labs);
            // TODO: This line of code loads data into the 'resourceAllocationDataSet3.Modules' table. You can move, or remove it, as needed.
            this.modulesTableAdapter.Fill(this.resourceAllocationDataSet3.Modules);
            // TODO: This line of code loads data into the 'resourceAllocationDataSet2.groups' table. You can move, or remove it, as needed.
            this.groupsTableAdapter.Fill(this.resourceAllocationDataSet2.groups);
            // TODO: This line of code loads data into the 'resourceAllocationDataSet1.instructors' table. You can move, or remove it, as needed.
            this.instructorsTableAdapter.Fill(this.resourceAllocationDataSet1.instructors);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          DateTime d1=  dateTimePicker1.Value.Date;
          DateTime d2= dateTimePicker2.Value.Date;

            label13.Text = d2.ToString().Substring(0,9);

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string day = comboBox1.SelectedItem.ToString();
            string time = comboBox5.SelectedItem.ToString();

            DataRowView drow = (DataRowView)comboBox2.SelectedItem;
            string gid = drow.Row.ItemArray[0].ToString();

                      
            Service1Client obj = new Service1Client();
            DataTable ds= obj.viewLabs(day,time, gid);
            dataGridView1.DataSource = ds;

            






        }
    }
}
