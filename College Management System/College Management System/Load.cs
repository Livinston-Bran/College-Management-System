using System.Windows.Forms;
using System;

namespace College_Management_System
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void Load_Load(object sender, EventArgs e)
        {
           
        }

        private void Load_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int startpos = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startpos += 1;
            MyProgressBar.Value= startpos;
            if(MyProgressBar.Value == 60 )
            {
                MyProgressBar.Value = 0;
                timer1.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }
        }

        private void MyProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}