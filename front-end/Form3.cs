using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;

namespace PROB
{
    public partial class Form3 : Form
    {
        public static string name;
        public Form3()
        {
            InitializeComponent();
            loadName();
        }

        public void loadName()
        {
            string line;
            using (StreamReader reader = new StreamReader("operator.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    line = reader.ReadLine();
                    label3.Text = line;
                }
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            name = EnterUserName.str;
           // label3.Text = name;
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnterUserName obj = new EnterUserName();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //HERE
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void csvbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
           ShowRecords obj = new ShowRecords();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Credits obj = new Credits();
            obj.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\Saad Mughal\PycharmProjects\agri_lyzer\summary_stat.exe";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            using (var process = Process.Start(psi))
            {
                process.StandardError.ReadToEnd();
                process.StandardOutput.ReadToEnd();
            }
            MessageBox.Show("Please Wait Your Action is being Processed.");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\Saad Mughal\PycharmProjects\agri_lyzer\Histogram.exe";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            using (var process = Process.Start(psi))
            {
                process.StandardError.ReadToEnd();
                process.StandardOutput.ReadToEnd();
            }
            MessageBox.Show("Please Wait Your Action is being Processed.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\Saad Mughal\PycharmProjects\agri_lyzer\barcharts.exe";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            using (var process = Process.Start(psi))
            {
                process.StandardError.ReadToEnd();
                process.StandardOutput.ReadToEnd();
            }
            MessageBox.Show("Please Wait Your Action is being Processed.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\Saad Mughal\PycharmProjects\agri_lyzer\AverageIncome.exe";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            using (var process = Process.Start(psi))
            {
                process.StandardError.ReadToEnd();
                process.StandardOutput.ReadToEnd();
            }
            MessageBox.Show("Please Wait Your Action is being Processed.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\Saad Mughal\PycharmProjects\agri_lyzer\AreaIncome.exe";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            using (var process = Process.Start(psi))
            {
                process.StandardError.ReadToEnd();
                process.StandardOutput.ReadToEnd();
            }
            MessageBox.Show("Please Wait Your Action is being Processed.");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Prediction obj = new Prediction();
            obj.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\Saad Mughal\PycharmProjects\agri_lyzer\prob_dist.exe";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            using (var process = Process.Start(psi))
            {
                process.StandardError.ReadToEnd();
                process.StandardOutput.ReadToEnd();
            }
            MessageBox.Show("Please Wait Your Action is being Processed.");
        }
    }
}
