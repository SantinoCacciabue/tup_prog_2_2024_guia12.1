using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3.models
{
    internal class CentralTaxis
    {
        private Queue<Pedido> pedidos = new Queue<Pedido>();
        private Queue<Movil> movilesDisponibles = new Queue<Movil>();
        private List<Movil> movilesOcupados = new List<Movil>();
        
        public CentralTaxis()
        {
            for(int  i = 0; i < 3; i++)
            {
                movilesDisponibles.Enqueue(new Movil(i));
            }
        }

        public Pedido RecibirSolicitud(string tel, string dir)
        {
            Pedido p = new Pedido(tel, dir);
            pedidos.Enqueue(p);
            return p;

        }
        public Movil AsignarCoche()
        {
            pedidos.Dequeue();
            Movil m = movilesDisponibles.Dequeue();
            movilesOcupados.Add(m);
            return m;
        }
        public Movil LiberarVehiculo(int num)
        {
            movilesOcupados.Sort();
            int i = movilesOcupados.BinarySearch(new Movil(num));
            if (i >= 0)
            {
                Movil m = movilesOcupados[i];
                movilesOcupados.Remove(m);
                movilesDisponibles.Enqueue(m);
            }
            return null;            
        }
        //me perdí con el tema de la linkedList
    }
}
