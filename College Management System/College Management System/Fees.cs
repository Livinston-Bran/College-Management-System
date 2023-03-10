using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace College_Management_System
{
    public partial class Fees : Form
    {
        DataTable FeeTB = new DataTable("FeeTB");
        int index;
        public Fees()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void Fees_Load(object sender, EventArgs e)
        {
            FeeTB.Columns.Add("Number", Type.GetType("System.Int32"));
            FeeTB.Columns.Add("StdID", Type.GetType("System.String"));
            FeeTB.Columns.Add("Name", Type.GetType("System.String"));
            FeeTB.Columns.Add("Period", Type.GetType("System.String"));
            FeeTB.Columns.Add("Amount", Type.GetType("System.Int32"));
            dataGridView1.DataSource = FeeTB;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainForm Mform = new MainForm();
            Mform.Show();
            this.Hide();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeeTB.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Text, textBox4.Text);
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
            newdata.Cells[2].Value = textBox3.Text;
            newdata.Cells[3].Value = dateTimePicker1.Text;
            newdata.Cells[4].Value = textBox4.Text;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            dateTimePicker1.Text = String.Empty;
            textBox4.Text = String.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            dateTimePicker1.Text = row.Cells[3].Value.ToString();
            textBox4.Text = row.Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("********************************", new Font("Century Schoolbook", 15, FontStyle.Bold), Brushes.Black, new Point(250, 40));
            e.Graphics.DrawString("*****       Fees  Receipt       *****", new Font("Century Schoolbook", 15,FontStyle.Bold),Brushes.Black,new Point(250,80));
            e.Graphics.DrawString("********************************", new Font("Century Schoolbook", 15, FontStyle.Bold), Brushes.Black, new Point(250, 120));

            e.Graphics.DrawString("Name : ", new Font("Century Schoolbook", 15, FontStyle.Bold), Brushes.Black, new Point(250, 170));
            e.Graphics.DrawString(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Schoolbook", 15, FontStyle.Bold), Brushes.Black, new Point(400, 170));

            e.Graphics.DrawString("Student ID : ", new Font("Century Schoolbook", 15, FontStyle.Bold), Brushes.Black, new Point(250, 200));
            e.Graphics.DrawString(dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Schoolbook", 15, FontStyle.Bold), Brushes.Black, new Point(400, 200));

            e.Graphics.DrawString("Name : ", new Font("Century Schoolbook", 15, FontStyle.Bold), Brushes.Black, new Point(250, 230));
            e.Graphics.DrawString(dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Schoolbook", 15, FontStyle.Bold), Brushes.Black, new Point(400, 230));

            e.Graphics.DrawString("Period : ", new Font("Century Schoolbook", 15, FontStyle.Bold), Brushes.Black, new Point(250, 260));
            e.Graphics.DrawString(dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Schoolbook", 15, FontStyle.Bold), Brushes.Black, new Point(400, 260));

            e.Graphics.DrawString("Amount : ", new Font("Century Schoolbook", 15, FontStyle.Bold), Brushes.Black, new Point(250, 290));
            e.Graphics.DrawString(dataGridView1.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century Schoolbook", 15, FontStyle.Bold), Brushes.Black, new Point(400, 290));

            e.Graphics.DrawString("********************************", new Font("Century Schoolbook", 15, FontStyle.Bold), Brushes.Black, new Point(250, 360));
            e.Graphics.DrawString("SLIATE - Batticaloa", new Font("Century Schoolbook", 15, FontStyle.Bold), Brushes.Black, new Point(320, 400));

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
