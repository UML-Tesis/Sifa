﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class ListarPresentacion : Form
    {
        public ListarPresentacion()
        {
            InitializeComponent();
        }

        private void ListarPresentacion_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void Mostrar()
        {
            this.DataListado.DataSource = NPresentacion.Mostrar();
        }

        private void Buscar()
        {
            this.DataListado.DataSource = NPresentacion.Buscar(txtBuscar.Text);
        }

        private void OcultarColumnas()
        {
            this.DataListado.Columns[0].Visible = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            FormProducto form = FormProducto.GetInstancia();
            string par1, par2;

            par1 = Convert.ToString(this.DataListado.CurrentRow.Cells["Id_Presentacion"].Value);
            par2 = Convert.ToString(this.DataListado.CurrentRow.Cells["Nombre"].Value);
            form.setPresentacion(par1, par2);
            this.Close();
        }

    }
}
