using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Repartidor
    {
        Stack<Paquete> paquetes = new Stack<Paquete>();
        public int Capacidad { get; private set; }
        public int Ocupacion
        {
            get
            {
                return paquetes.Count;
            }
        }
        public Repartidor(int cap)
        {
            Capacidad = cap;
        }
        public Paquete Revisar()
        {
            if (Ocupacion > 0)
            {
                return paquetes.Peek();
            }
            return null;
        }
        public void Cargar(Paquete p)
        {
            if (TieneCapacidadDisponible())
            {
                paquetes.Push(p);
            }           
        }
        public Paquete Entrega()
        {
            if (paquetes.Count != 0)
            {
                return paquetes.Pop();
            }
            return null;
        }
        public bool TieneCapacidadDisponible()
        {
            return(Ocupacion<=Capacidad);
        }
    }
}
