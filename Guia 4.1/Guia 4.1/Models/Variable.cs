using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4._1.Models
{
    public class Variable:Costo
    {
        public double PrecioPorUnidad { get; private set; }
        public double Unidades {  get; private set; }
        public override double ValorFinal 
        {
            get
            {
               return PrecioPorUnidad * Unidades;
            }
        }
        
        public Variable (string concepto, double unidades, double precioPorUnidad) : base(concepto)
        {
            Unidades = unidades;
            Concepto = concepto;
            PrecioPorUnidad = precioPorUnidad; 
        }
        public override string ToString()
        {
            return $"{Concepto} {ValorFinal}";
        }
    }
}
