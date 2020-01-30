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
    public partial class ListarCategoria : Form
    {
        public ListarCategoria()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            this.DataListado.DataSource = NCategoria.Mostrar();
        }

        private void Buscar()
        {
            this.DataListado.DataSource = NCategoria.Buscar(txtBuscar.Text);
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void ListarCategoria_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            FormProducto form = FormProducto.GetInstancia();
            string par1, par2;

            par1 = Convert.ToString(this.DataListado.CurrentRow.Cells["Id_Categoria"].Value);
            par2 = Convert.ToString(this.DataListado.CurrentRow.Cells["Nombre"].Value);
            form.setCategoria(par1, par2);
            this.Close();
        }
    }
}
