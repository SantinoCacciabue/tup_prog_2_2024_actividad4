using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Cuadrado : Rectangulo
    {
        public Cuadrado(double lado) : base(lado, lado)
        {

        }
        public override string ToString()
        {
            return $"Cuadrado: Area({CalcularArea()} Perimetro({CalcularPerimetro()})";
        }
    }
}
