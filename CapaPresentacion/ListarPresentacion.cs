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

    }
}
