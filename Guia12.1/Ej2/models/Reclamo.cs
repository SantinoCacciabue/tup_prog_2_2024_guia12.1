using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.models
{
    internal class Reclamo
    {
        public int Numero { get; private set; }
        public string Nombre { get; private set; }
        public string Motivo { get; private set; }
        public Reclamo(string nom,string mot,int num)
        {
            Numero = num;
            Nombre = nom;
            Motivo = mot;
        }
        public override string ToString()
        {
            return $"{Numero}-{Nombre}: {Motivo}";
        }
    }
}
