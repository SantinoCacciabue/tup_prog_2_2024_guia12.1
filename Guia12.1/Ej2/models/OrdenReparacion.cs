using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.models
{
    internal class OrdenReparacion
    {
        public Reclamo reclamo;
        public DateTime Fecha { get; private set; }
        public bool Solucionado { get; private set; }
        public OrdenReparacion(Reclamo r)
        {
            reclamo = r;
            Fecha = DateTime.Now;
        }
        public override string ToString()
        {
            return reclamo.ToString();
        }
    }
}
