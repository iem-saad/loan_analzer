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
    public partial class ShowRecords : Form
    {
        public ShowRecords()
        {
            InitializeComponent();
            fillData();
        }

        public void fillData()
        {
            DataTable dt = new DataTable();
            string path = @"C:\Users\Saad Mughal\PycharmProjects\agri_lyzer\train.csv";
            string[] lines = System.IO.File.ReadAllLines(path);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(',');
                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                //For Data
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                csvView.DataSource = dt;
            }
        }
        private void EXIT_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 obj = new Form3();
            obj.Show();
        }

        private void Deleterecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteRecord obj = new DeleteRecord();    
            obj.Show();
        }

        private void csvView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddData obj = new AddData();
            obj.Show();
        }
    }
}
