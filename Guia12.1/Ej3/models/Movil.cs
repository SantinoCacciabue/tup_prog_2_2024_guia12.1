using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3.models
{
    internal class Movil:IComparable
    {
        public Pedido Pasajero;
        public int Numero { get; private set; }
        public Movil(int num)
        {
            Numero = num;
        }
        public int CompareTo(Object o)
        {
            Movil m = o as Movil;
            if(m != null)
            {
                return Numero.CompareTo(m.Numero);
            }
            return -1;
        }
    }
}
