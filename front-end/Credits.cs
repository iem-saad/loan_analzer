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
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 obj = new Form3();
            obj.Show();
        }
    }
}
