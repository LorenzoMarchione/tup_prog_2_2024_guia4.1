using Guia_4._1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Logistica log = new Logistica();
        Envio editar;
        private void Form1_Load(object sender, EventArgs e)
        {
            cbCostos.Items.Add(new Fijo("Peaje puente Zárate", 300));
            cbCostos.Items.Add(new Variable("Combustible", 1300.5, 500));
            cbCostos.Items.Add(new Fijo("Peaje túnel", 300));
            cbCostos.Items.Add(new Variable("Horas de conducción", 500, 10));
            gbEdicion.Enabled = false;
        }

        private void btAgregarCosto_Click(object sender, EventArgs e)
        {
            Costo costo = cbCostos.SelectedItem as Costo;
            editar.AgregarCosto(costo);
            lbDetalleCosto.Items.Add(costo.ToString());
        }

        private void btVerAlta_Click(object sender, EventArgs e)
        {
            int idx = log.VerEnvioPorCodigo(Convert.ToInt32(tbCodigoAduanero.Text));
            if (idx < 0)
            {
                DatosEnvio datosEnvio = new DatosEnvio();
                datosEnvio.tbAduanero.Enabled = false;
                datosEnvio.tbAduanero.Text = tbCodigoAduanero.Text;
                if (datosEnvio.ShowDialog() == DialogResult.OK)
                {
                    int cod = Convert.ToInt32(datosEnvio.tbAduanero.Text);
                    string nombre = datosEnvio.tbEmpresa.Text;
                    editar = new Envio(cod, nombre);
                    laNombreEmpresa.Text = nombre;  
                    gbEdicion.Enabled = true;
                }
            }
            else
            {
                laNombreEmpresa.Text = log.VerEnvio(idx).Empresa;
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            log.AgregarEnvio(editar);
            lbDetalleCosto.Items.Clear();
            gbEdicion.Enabled=false;
        }

        private void btListaEnvios_Click(object sender, EventArgs e)
        {
            lbEnvios.Items.Clear();
            int cont = log.CantidadEnvios;
            for (int i = 0; i < cont; i++)
            {
                Envio a = log.VerEnvio(i);
                lbEnvios.Items.Add($"Envío:        {a.CodigoAduanero}");
                lbEnvios.Items.Add($"Empresa: {a.Empresa}");
                lbEnvios.Items.Add($"Total: {a.ValorTotal}");
            }
        }
    }
}
