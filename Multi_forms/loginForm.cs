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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        Form1 mainForm = new Form1();
        private void buttonOK_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(username == "zhd_12" && password == "12345")
            {
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("username or password is incorrect");
            }
        }
    }
}
