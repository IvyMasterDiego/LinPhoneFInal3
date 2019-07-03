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
        bool textonumero = true;
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
            if (conectado)
            {
                try
                {
                    telefono.MakeCall(this.Panel.Text);
                }catch(Exception){
                    this.textBox1.Text = "Error de dependencias.";
                }
            }
            else
            {
                this.textBox1.Text = "No hay una conexion establecida."; 
            }
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

            telefono.PhoneConnectedEvent += delegate ()
            {
                this.textBox1.Text = "Connectado!";
                try
                {
                    telefono.Connect();
                    conectado = true;
                }
                catch (Exception)
                {
                    this.textBox1.Text = "Error de conexion!";
                }
            };

            telefono.CallActiveEvent += delegate (Call call)
            {
                this.textBox1.Text = "En llamada!";
            };
            /*if (!conectado)
            {
                this.textBox1.Text = "Error de conexion!";
            }*/
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Colgar_Click(object sender, EventArgs e)
        {
            if (conectado)
            {
                
            }
            else
            {
                this.textBox1.Text = "No hay una llamada establecida.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                Panel.Text = "";
                Panel.Text = "1";
                textonumero = false;
            }
            else
            {
                Panel.Text = Panel.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                Panel.Text = "";
                Panel.Text = "2";
                textonumero = false;
            }
            else
            {
                Panel.Text = Panel.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                Panel.Text = "";
                Panel.Text = "3";
                textonumero = false;
            }
            else
            {
                Panel.Text = Panel.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                Panel.Text = "";
                Panel.Text = "4";
                textonumero = false;
            }
            else
            {
                Panel.Text = Panel.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                Panel.Text = "";
                Panel.Text = "5";
                textonumero = false;
            }
            else
            {
                Panel.Text = Panel.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                Panel.Text = "";
                Panel.Text = "6";
                textonumero = false;
            }
            else
            {
                Panel.Text = Panel.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                Panel.Text = "";
                Panel.Text = "7";
                textonumero = false;
            }
            else
            {
                Panel.Text = Panel.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                Panel.Text = "";
                Panel.Text = "8";
                textonumero = false;
            }
            else
            {
                Panel.Text = Panel.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                Panel.Text = "";
                Panel.Text = "9";
                textonumero = false;
            }
            else
            {
                Panel.Text = Panel.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                Panel.Text = "";
                Panel.Text = "*";
                textonumero = false;
            }
            else
            {
                Panel.Text = Panel.Text + "*";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                Panel.Text = "";
                Panel.Text = "0";
                textonumero = false;
            }
            else
            {
                Panel.Text = Panel.Text + "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textonumero)
            {
                Panel.Text = "";
                Panel.Text = "#";
                textonumero = false;
            }
            else
            {
                Panel.Text = Panel.Text + "#";
            }
        }

        private void SoloNumero(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void Borrar(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Panel.Clear();
        }
    }
}


    