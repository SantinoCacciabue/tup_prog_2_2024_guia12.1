using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Despachador
    {
        Queue<Paquete> depositos = new Queue<Paquete>();
        private Repartidor camion;
        public Paquete RecibirCorrespondencia(int dni, string nombre, string dir)
        {
            Paquete p = new Paquete(dni, nombre, dir);
            depositos.Enqueue(p);
            return p;
        }
        public Repartidor PrepararCamion(int cap)
        {
            camion = new Repartidor(cap);
            return camion;
        }
        public Paquete CargarPaquete()
        {
            Paquete p = null;
            if (depositos.Count > 0)
            {
                p = depositos.Dequeue();
                camion.Cargar(p);
                return p;
            }
            return p;
        }
    }
}
