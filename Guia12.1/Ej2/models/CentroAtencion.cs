using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.models
{
    internal class CentroAtencion
    {
        private Queue<Reclamo> reclamosPendientes = new Queue<Reclamo>();
        private Queue<OrdenReparacion> trabajosPendientes = new Queue<OrdenReparacion> ();
        private int numeroReclamoGen;
        public Reclamo RecibirReclamo(string nom, string mot)
        {
            Reclamo r = new Reclamo(nom, mot,numeroReclamoGen++);
            reclamosPendientes.Enqueue(r);
            return r;
        }
        public OrdenReparacion ResolverReclamo()
        {
            Reclamo r = reclamosPendientes.Dequeue();
            OrdenReparacion o = new OrdenReparacion(r);
            trabajosPendientes.Enqueue(o);
            return o;
        }
        public OrdenReparacion EjecutarOrdenDeTrabajo()
        {
            if(trabajosPendientes.Count() > 0)
            {
                OrdenReparacion o = trabajosPendientes.Dequeue();
                return o;
            }          
            return null;
        }

    }
}
