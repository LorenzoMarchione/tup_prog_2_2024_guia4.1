using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4._1.Models
{
    internal class Envio:IComparable
    {
        public int CodigoAduanero { get; private set; }
        public string Empresa { get; private set; } 
        public double ValorTotal 
        { 
            get 
            {
                double total = 0;
                foreach (Costo c in costos) 
                {
                    total += c.ValorFinal;
                }
                return total;

            }
        }  
        private ArrayList costos = new ArrayList();

        public Envio(int codigo, string empresa) 
        {
            CodigoAduanero = codigo;
            Empresa = empresa;
        }
        public void AgregarCosto (Costo nuevo)
        {
            costos.Add(nuevo);
        }
        public int CompareTo(object obj)
        {
            Envio c = obj as Envio;
            if (c == null) return -1;
            return CodigoAduanero.CompareTo(c.CodigoAduanero);
        }
    }
}
