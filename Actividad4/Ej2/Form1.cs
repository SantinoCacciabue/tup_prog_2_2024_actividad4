using Ej1.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList figuras = new ArrayList();
            Circulo circulo = new Circulo(2.2);
            figuras.Add(circulo);
            Rectangulo rectangulo = new Rectangulo(2, 7);
            figuras.Add(rectangulo);
            Rectangulo cuadrado = new Cuadrado(7);
            figuras.Add(cuadrado);
            foreach(Figura f in  figuras)
            {
                textBox1.Text += $"{f}\n\r";
            }
        }
    }
}
