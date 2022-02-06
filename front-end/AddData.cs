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
using Microsoft.VisualBasic;

namespace PROB
{
    public partial class AddData : Form
    {
        public AddData()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 obj = new Form3();
            obj.Show();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (gender.Text!= "" && martial.Text != "" && dependents.Text != "" && area.Text != "" && loan_status.Text != "")
                {
                    string path = @"C:\Users\Saad Mughal\PycharmProjects\agri_lyzer\train.csv";
                    using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(fs))
                        {
                            Random r = new Random();
                            int rInt = r.Next(3000, 5000);
                            string num = "LP00" + rInt.ToString();
                            string row = num+","+gender.Text.ToString()+","+ martial.Text.ToString() + "," + dependents.Text.ToString() + "," + education.Text.ToString() + "," + income.Text.ToString() + "," + loan_amount.Text.ToString() + "," + term.Text.ToString() + "," + area.Text.ToString() + "," + loan_status.Text.ToString();
                            sw.WriteLine(row);
                            MessageBox.Show("Successfully Inserted Data");
                        }
                    }

                }
                else
                    MessageBox.Show("Please Fill Out Required Fields");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
