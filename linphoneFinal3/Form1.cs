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
    public partial class Form1 : Form
    {
        Account cuenta;
        Phone telefono;
        bool conectado;
        public Form1()
        {
            InitializeComponent();
            conectado = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Llamar_Click(object sender, EventArgs e)
        {

        }

        private void Tres_Click(object sender, EventArgs e)
        {

        }

        private void Dos_Click(object sender, EventArgs e)
        {

        }

        private void Panel_TextChanged(object sender, EventArgs e)
        {

        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            Login logeo = new Login();
            if (logeo.ShowDialog(this) == DialogResult.OK)
            {
                this.cuenta = logeo.cuenta;
            }
            else
            {
                this.Panel.Text = "Error en ventana de dialogo.";
            }
            logeo.Dispose();

            telefono = new Phone(cuenta);
        }
    }
}

    