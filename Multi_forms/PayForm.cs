using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_forms
{
    public partial class PayForm : Form
    {
        SearchForm sf = new SearchForm();
        public Form1 f1;

        public PayForm()
        {
            InitializeComponent();
            sf.pf = this;
        }

        private void PayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            f1.resultLabel.Text = "زهرا دوزنده ";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            sf.textBox1.Text = "";
            sf.Show();
        }
    }
}
