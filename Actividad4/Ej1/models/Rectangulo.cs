using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Rectangulo : IFigura
    {
        public double Largo {  get; private set; }
        public double Ancho {  get; private set; }
        public Rectangulo(double largo, double ancho)
        {
            Largo = largo;
            Ancho = ancho;
        }
        public double CalcularArea()
        {
            return Largo*Ancho;
        }
        public double CalcularPerimetro()
        {
            return (Ancho * 2) + (Largo * 2);
        }
        public override string ToString()
        {
            return $"Rectángulo: Area({CalcularArea()} Perimetro({CalcularPerimetro()})";
        }
    }
}
