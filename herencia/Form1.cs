using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void suma_Click(object sender, EventArgs e)
        {
            //voy a darle comportamiento a mi boton voy a utilizar mi clase hija sumar
            Sumar suma = new Sumar();//instancie, o hice un nuevo objeto suma llamar al metodo clase sumar operar
            textBox3.Text = suma.operar (float.Parse(textBox1.Text),float.Parse(textBox2.Text)).ToString();
        }

        private void resta_Click(object sender, EventArgs e)
        {
            {
                Restar restar = new Restar();
                textBox3.Text = restar.operar(float.Parse(textBox1.Text), float.Parse(textBox2.Text)).ToString();
            }
        }

        private void Mulriplicar_Click(object sender, EventArgs e)
        {
            {
                Multiplicar multiplica = new Multiplicar();
                textBox3.Text = multiplica.operar(float.Parse(textBox1.Text), float.Parse(textBox2.Text)).ToString();
            }
        }

        private void Limpa_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            {
                Dividir divide = new Dividir();
                textBox3.Text = divide.operar(float.Parse(textBox1.Text), float.Parse(textBox2.Text)).ToString();
            }
        }
    }
}
