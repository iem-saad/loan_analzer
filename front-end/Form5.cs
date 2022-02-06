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
    public partial class DeleteRecord : Form
    {
        public DeleteRecord()
        {
            InitializeComponent();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowRecords obj = new ShowRecords();
            obj.Show();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Saad Mughal\PycharmProjects\agri_lyzer\train.csv";
            string temp_path = @"C:\Users\Saad Mughal\PycharmProjects\agri_lyzer\temp_train.csv";
            if (textBox2.Text == "")
            {
                MessageBox.Show("PLEASE ENTER CSV ID NO");
            }
            else
            {
                string[] lines = System.IO.File.ReadAllLines(path);
                StreamWriter writer = new StreamWriter(temp_path);
                bool isDelete = false;
                
                if (lines.Length > 0)
                {
                    //For Data
                    for (int i = 0; i < lines.Length; i++)
                    {
                        string[] dataWords = lines[i].Split(',');
                        if (lines[i].Split(',')[0] == textBox2.Text)
                        {
                            isDelete = true;
                            continue;
                        }
                        else
                        {
                            writer.Write(lines[i]);
                            writer.WriteLine();
                        }
                        
                    }
                }
                writer.Close();
                File.Delete(path);
                System.IO.File.Move(temp_path, path);
                if (isDelete)
                {
                    MessageBox.Show("Successfully Deleted Record");
                    this.Hide();
                    ShowRecords obj = new ShowRecords();
                    obj.Show();
                }
                else
                    MessageBox.Show("Ops! No Record Found with this ID.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
