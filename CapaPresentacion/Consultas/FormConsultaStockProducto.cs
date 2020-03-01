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

namespace CapaPresentacion.Consultas
{
    public partial class FormConsultaStockProducto : Form
    {
        public FormConsultaStockProducto()
        {
            InitializeComponent();
        }

        private void Mostrar()
        {
            this.DataListado.DataSource = NProducto.Stock_Producto();
            lblRegistros.Text = "Total de Registros : " + Convert.ToString(DataListado.Rows.Count);
        }

        private void FormConsultaStockProducto_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }
    }
}
