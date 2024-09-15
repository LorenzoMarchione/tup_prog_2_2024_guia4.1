using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4._1.Models
{
    public class Fijo:Costo
    {
        public Fijo (string concepto, double valorFinal):base(concepto)
        {
            Concepto = concepto;
            ValorFinal = valorFinal;
        }
        public override string ToString()
        {
            return $"{Concepto} {ValorFinal}";
        }
    }
}
