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
    public partial class Form1 : Form
    {
        
        PayForm pf = new PayForm();
        public Form1()
        {
            InitializeComponent();
            pf.f1 = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pf.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}