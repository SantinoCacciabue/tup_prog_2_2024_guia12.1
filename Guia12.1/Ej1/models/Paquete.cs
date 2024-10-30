using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.models
{
    internal class Paquete
    {
        public int DNIRemitente { get; private set; }
        public string NombreRemitente { get; private set; }
        public string Direccion { get; private set; }
        public Paquete(int dNIRemitente, string nombreRemitente, string direccion)
        {
            DNIRemitente = dNIRemitente;
            NombreRemitente = nombreRemitente;
            Direccion = direccion;
        }
        public override string ToString()
        {
            return $"{Direccion}:{NombreRemitente}({DNIRemitente})";
        }

    }
}
