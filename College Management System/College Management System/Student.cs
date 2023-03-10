using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Management_System
{
    public partial class Student : Form
    {
        DataTable StdTB = new DataTable("StdTB");
        int index;
        public Student()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainForm Mform = new MainForm();
            Mform.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StdTB.Rows.Add(textBox1.Text, textBox2.Text, comboBox1.Text, dateTimePicker1.Text, comboBox2.Text, textBox5.Text, textBox3.Text);
        }

        private void Student_Load(object sender, EventArgs e)
        {
            StdTB.Columns.Add("ID", Type.GetType("System.String"));
            StdTB.Columns.Add("Name", Type.GetType("System.String"));
            StdTB.Columns.Add("Gender", Type.GetType("System.String"));
            StdTB.Columns.Add("DOB", Type.GetType("System.String"));
            StdTB.Columns.Add("Department", Type.GetType("System.String"));
            StdTB.Columns.Add("Phone", Type.GetType("System.Int32"));
            StdTB.Columns.Add("Fees", Type.GetType("System.Int32"));
            dataGridView1.DataSource = StdTB;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = textBox1.Text;
            newdata.Cells[1].Value = textBox2.Text;
            newdata.Cells[2].Value = comboBox1.Text;
            newdata.Cells[3].Value = dateTimePicker1.Text;
            newdata.Cells[4].Value = comboBox2.Text;
            newdata.Cells[5].Value = textBox5.Text;
            newdata.Cells[6].Value = textBox3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            comboBox1.Text = String.Empty;
            dateTimePicker1.Text = String.Empty;
            comboBox2.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox3.Text = String.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            comboBox1.Text = row.Cells[2].Value.ToString();
            dateTimePicker1.Text = row.Cells[3].Value.ToString();
            comboBox2.Text = row.Cells[4].Value.ToString();
            textBox5.Text = row.Cells[5].Value.ToString(); 
            textBox3.Text = row.Cells[6].Value.ToString();
           
        }
    }
}
