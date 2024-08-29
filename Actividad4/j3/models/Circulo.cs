using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Circulo : IFigura,IComparable
    {
        public double Radio { get;private set; }
        public Circulo(double radio)
        {
            Radio = radio;
        }
        public double CalcularArea()
        {
            return (Math.PI) * Math.Pow(Radio, 2);
        }
        public double CalcularPerimetro()
        {
            return (Math.PI) * (Radio * 2);
        }
        public override string ToString()
        {
            return $"Circulo: Area({CalcularArea()} Perimetro({CalcularPerimetro()})";
        }

        public int CompareTo(object obj)
        {
            IFigura f = obj as IFigura;
            if (f != null )
            {
                return this.CalcularArea().CompareTo(f.CalcularArea());
            }
            return 1;
        }
    }
}
