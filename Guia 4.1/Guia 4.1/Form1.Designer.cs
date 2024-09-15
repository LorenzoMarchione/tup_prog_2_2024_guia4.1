namespace Guia_4._1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.laNombreEmpresa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btVerAlta = new System.Windows.Forms.Button();
            this.tbCodigoAduanero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btListaEnvios = new System.Windows.Forms.Button();
            this.lbEnvios = new System.Windows.Forms.ListBox();
            this.gbEdicion = new System.Windows.Forms.GroupBox();
            this.lbDetalleCosto = new System.Windows.Forms.ListBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.Detalle = new System.Windows.Forms.Label();
            this.btAgregarCosto = new System.Windows.Forms.Button();
            this.cbCostos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.laNombreEmpresa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btVerAlta);
            this.groupBox1.Controls.Add(this.tbCodigoAduanero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 89);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver Alta de Envío";
            // 
            // laNombreEmpresa
            // 
            this.laNombreEmpresa.AutoSize = true;
            this.laNombreEmpresa.Location = new System.Drawing.Point(128, 65);
            this.laNombreEmpresa.Name = "laNombreEmpresa";
            this.laNombreEmpresa.Size = new System.Drawing.Size(0, 13);
            this.laNombreEmpresa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empresa de transporte:";
            // 
            // btVerAlta
            // 
            this.btVerAlta.Location = new System.Drawing.Point(174, 35);
            this.btVerAlta.Name = "btVerAlta";
            this.btVerAlta.Size = new System.Drawing.Size(85, 23);
            this.btVerAlta.TabIndex = 2;
            this.btVerAlta.Text = "Ver alta Envío";
            this.btVerAlta.UseVisualStyleBackColor = true;
            this.btVerAlta.Click += new System.EventHandler(this.btVerAlta_Click);
            // 
            // tbCodigoAduanero
            // 
            this.tbCodigoAduanero.Location = new System.Drawing.Point(7, 37);
            this.tbCodigoAduanero.Name = "tbCodigoAduanero";
            this.tbCodigoAduanero.Size = new System.Drawing.Size(161, 20);
            this.tbCodigoAduanero.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Aduanero";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btListaEnvios);
            this.groupBox2.Controls.Add(this.lbEnvios);
            this.groupBox2.Location = new System.Drawing.Point(12, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Envíos Cargados";
            // 
            // btListaEnvios
            // 
            this.btListaEnvios.Location = new System.Drawing.Point(184, 19);
            this.btListaEnvios.Name = "btListaEnvios";
            this.btListaEnvios.Size = new System.Drawing.Size(75, 48);
            this.btListaEnvios.TabIndex = 1;
            this.btListaEnvios.Text = "Listar Envíos existentes";
            this.btListaEnvios.UseVisualStyleBackColor = true;
            this.btListaEnvios.Click += new System.EventHandler(this.btListaEnvios_Click);
            // 
            // lbEnvios
            // 
            this.lbEnvios.FormattingEnabled = true;
            this.lbEnvios.Location = new System.Drawing.Point(6, 19);
            this.lbEnvios.Name = "lbEnvios";
            this.lbEnvios.Size = new System.Drawing.Size(172, 95);
            this.lbEnvios.TabIndex = 0;
            // 
            // gbEdicion
            // 
            this.gbEdicion.Controls.Add(this.lbDetalleCosto);
            this.gbEdicion.Controls.Add(this.btGuardar);
            this.gbEdicion.Controls.Add(this.Detalle);
            this.gbEdicion.Controls.Add(this.btAgregarCosto);
            this.gbEdicion.Controls.Add(this.cbCostos);
            this.gbEdicion.Controls.Add(this.label4);
            this.gbEdicion.Location = new System.Drawing.Point(12, 107);
            this.gbEdicion.Name = "gbEdicion";
            this.gbEdicion.Size = new System.Drawing.Size(265, 189);
            this.gbEdicion.TabIndex = 2;
            this.gbEdicion.TabStop = false;
            this.gbEdicion.Text = "Edición de costos";
            // 
            // lbDetalleCosto
            // 
            this.lbDetalleCosto.FormattingEnabled = true;
            this.lbDetalleCosto.Location = new System.Drawing.Point(6, 88);
            this.lbDetalleCosto.Name = "lbDetalleCosto";
            this.lbDetalleCosto.Size = new System.Drawing.Size(172, 95);
            this.lbDetalleCosto.TabIndex = 6;
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(184, 141);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 42);
            this.btGuardar.TabIndex = 5;
            this.btGuardar.Text = "Guardar Envío";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // Detalle
            // 
            this.Detalle.AutoSize = true;
            this.Detalle.Location = new System.Drawing.Point(6, 72);
            this.Detalle.Name = "Detalle";
            this.Detalle.Size = new System.Drawing.Size(40, 13);
            this.Detalle.TabIndex = 3;
            this.Detalle.Text = "Detalle";
            // 
            // btAgregarCosto
            // 
            this.btAgregarCosto.Location = new System.Drawing.Point(165, 24);
            this.btAgregarCosto.Name = "btAgregarCosto";
            this.btAgregarCosto.Size = new System.Drawing.Size(94, 34);
            this.btAgregarCosto.TabIndex = 2;
            this.btAgregarCosto.Text = "Seleccionar y Agregar Costos";
            this.btAgregarCosto.UseVisualStyleBackColor = true;
            this.btAgregarCosto.Click += new System.EventHandler(this.btAgregarCosto_Click);
            // 
            // cbCostos
            // 
            this.cbCostos.FormattingEnabled = true;
            this.cbCostos.Location = new System.Drawing.Point(6, 32);
            this.cbCostos.Name = "cbCostos";
            this.cbCostos.Size = new System.Drawing.Size(153, 21);
            this.cbCostos.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Costos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 450);
            this.Controls.Add(this.gbEdicion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbEdicion.ResumeLayout(false);
            this.gbEdicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label laNombreEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btVerAlta;
        private System.Windows.Forms.TextBox tbCodigoAduanero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbEdicion;
        private System.Windows.Forms.Label Detalle;
        private System.Windows.Forms.Button btAgregarCosto;
        private System.Windows.Forms.ComboBox cbCostos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btListaEnvios;
        private System.Windows.Forms.ListBox lbEnvios;
        private System.Windows.Forms.ListBox lbDetalleCosto;
        private System.Windows.Forms.Button btGuardar;
    }
}

