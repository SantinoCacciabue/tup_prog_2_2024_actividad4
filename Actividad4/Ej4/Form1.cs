using Ej1.models;
using Ej4.models;
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

namespace Ej4
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
            IFigura c = new Cuadrado(6);
            figuras.Add(c);
            IFigura c2 = new Cuadrado(3.2);
            figuras.Add(c2);
            IFigura r = new Rectangulo(5, 3);
            figuras.Add(r);
            IFigura r2 = new Rectangulo(5.2, 1.3);
            figuras.Add(r2);
            IFigura cir = new Circulo(7.7);
            figuras.Add(cir);
            IFigura cir2 = new Circulo(0.4);
            figuras.Add(cir2);
            textBox1.Text = "Lista sin ordenar\r\n";
            foreach (IFigura f in figuras)
            {
                textBox1.Text += $"{f}\r\n";
            }
            figuras.Sort();
            textBox1.Text += "Lista ordenada\r\n";
            foreach (IFigura f in figuras)
            {
                textBox1.Text += $"{f}\r\n";
            }
        }
    }
}
