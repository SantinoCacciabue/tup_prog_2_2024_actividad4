using Ej1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej4.models
{
    abstract class Figura :IFigura, IComparable
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
        public int CompareTo(object obj)
        {
            IFigura f = obj as IFigura;
            if (f != null)
            {
                return this.CalcularArea().CompareTo(f.CalcularArea());
            }
            return 1;
        }
    }
}
