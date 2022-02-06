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
namespace PROB
{
    public partial class EnterUserName : Form
    {
        public static String str;
        public EnterUserName()
        {
            InitializeComponent();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (!File.Exists("operator.txt"))
            {
                using (StreamWriter sw = File.CreateText("operator.txt"))
                {

                }
            }

            using (StreamWriter file = File.AppendText("operator.txt"))
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("PLEASE ENTER YOUR NAME");
                }
                else
                {
                    file.WriteLine();
                    file.Write(textBox1.Text);
                    MessageBox.Show("Name Entered, Setting Up Things for You. :)");
                    flag = true;
                }
                file.Close();
            }
            if (flag)
            {
                this.Hide();
                Form3 obj = new Form3();
                obj.Show();
            }
            str = textBox1.Text;
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm obj=new WelcomeForm();
            obj.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
