using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormReporteFactura : Form
    {
        private int _IdVenta;

        public int IdVenta
        {
            get { return _IdVenta; }
            set { _IdVenta = value; }
        }

        public FormReporteFactura()
        {
            InitializeComponent();
        }

        private void FormReporteFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsPrincipal.spReporteFactura' Puede moverla o quitarla según sea necesario.
            try
            {
                this.spReporteFacturaTableAdapter.Fill(this.dsPrincipal.spReporteFactura, IdVenta);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
