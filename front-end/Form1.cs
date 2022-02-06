using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROB
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 170;
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            a++;
            progressBar1.Increment(a);
            if(a==18)
            {
                timer1.Stop();
                EnterUserName obj = new EnterUserName();
                //Form3 obj = new Form3();
                obj.Show();
                this.Hide();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
