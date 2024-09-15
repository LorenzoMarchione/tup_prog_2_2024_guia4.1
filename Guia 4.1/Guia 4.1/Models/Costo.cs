using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4._1.Models
{
    abstract public class Costo
    {
        public string Concepto { get; protected set; }
        public virtual double ValorFinal { get; protected set; } 
        
        public Costo (string concepto)
        {
            Concepto = concepto;
        }
    }
}
