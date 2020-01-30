using System;
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
    public partial class ListarProveedor : Form
    {
        public ListarProveedor()
        {
            InitializeComponent();
        }

        private void ListarProveedor_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void Mostrar()
        {
            this.DataListado.DataSource = NProveedor.Mostrar();
        }

        private void Buscar()
        {
            this.DataListado.DataSource = NProveedor.Buscar(txtBuscar.Text);
        }

        private void OcultarColumnas()
        {
            this.DataListado.Columns[0].Visible = false;
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            FormCompra form = FormCompra.GetInstancia();
            string par1, par2;

            par1 = Convert.ToString(this.DataListado.CurrentRow.Cells["Id_Proveedor"].Value);
            par2 = Convert.ToString(this.DataListado.CurrentRow.Cells["Primer_Nombre"].Value);
            form.setProveedor(par1, par2);
            this.Close();
        }
    }
}
