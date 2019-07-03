using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sipdotnet;

namespace linphoneFinal3
{
    public partial class Login : Form
    {
        public Account cuenta;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cuenta = new Account(textBox1.Text, textBox2.Text, textBox3.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
