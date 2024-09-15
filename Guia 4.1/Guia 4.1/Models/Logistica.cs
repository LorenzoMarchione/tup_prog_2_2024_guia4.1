using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_4._1.Models
{
    internal class Logistica
    {
        private ArrayList envios = new ArrayList();
        public int CantidadEnvios 
        { 
            get 
            {
            if (envios != null) return envios.Count;
            return 0;
            }
        }
      
        public void AgregarEnvio(Envio envio)
        {
            envios.Add(envio);
        }
        public int VerEnvioPorCodigo (int codigo)
        {
            envios.Sort();
            Envio buscar = new Envio(codigo, "");
            return envios.BinarySearch(buscar);
        }
        public Envio VerEnvio(int idx)
        {
            return (Envio)envios[idx];
        }
    }
}
