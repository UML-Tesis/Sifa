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
    public partial class Form1nicio : Form
    {
        public int? Id_Trabajador = null;
        public string Nombre;
        public string Apellido;
        public string TipoAcceso;
        int contar = 0;

        public Form1nicio()
        {
            InitializeComponent();
            LimpiarSeleccion();
        }
        
        private void GestionUsuarios()
        {
            //Controlar los Accesos
            if (TipoAcceso == "ADMINISTRADOR")
            {
                this.gradientColor3.Enabled = false;
            }
        }

        private void Mostrar()
        {
            this.DataListado.DataSource = NDetalleCompra.MostrarBajoStock();
        }

        private void AbrirFormEnMDI<MiForm>() where MiForm : Form, new()
        {
            Form Formulario;
            Formulario = ParentForm.MdiChildren.OfType<MiForm>().FirstOrDefault();
            //Si el formulario no existe
            if (Formulario == null)
            {
                Formulario = new MiForm();
                Formulario.Show();
                Formulario.MdiParent = this.ParentForm;
                Formulario.Dock = DockStyle.Fill;
            }
            else
            //Si el formulario existe
            {
                Formulario.Activate();
            }
        }

        private void gradientColor1_Click(object sender, EventArgs e)
        {
            AbrirFormEnMDI<FormVenta>();
        }

        private void gradientColor2_Click(object sender, EventArgs e)
        {
            Form Formulario;
            int lx = 140, ly = 10;
            Formulario = ParentForm.MdiChildren.OfType<FormProducto>().FirstOrDefault();
            //Si el formulario no existe
            if (Formulario == null)
            {
                Formulario = FormProducto.GetInstancia();
                Formulario.Show();
                Formulario.MdiParent = this.ParentForm;
                Formulario.Dock = DockStyle.Fill;
            }
            else
            //Si el formulario existe
            {
                Formulario.Activate();
            }
        }

        private void gradientColor3_Click(object sender, EventArgs e)
        {
            AbrirFormEnMDI<FormCliente>();
        }

        private void gradientColor4_Click(object sender, EventArgs e)
        {
            FormCompra Formulario;
            Formulario = ParentForm.MdiChildren.OfType<FormCompra>().FirstOrDefault();
            //Si el formulario no existe
            if (Formulario == null)
            {
                Formulario = FormCompra.GetInstancia();
                Formulario.Show();
                Formulario.MdiParent = this.ParentForm;
                Formulario.Dock = DockStyle.Fill;
                Formulario.Id_Trabajador = Convert.ToInt32(this.Id_Trabajador);
            }
            else
            //Si el formulario existe
            {
                Formulario.Activate();
            }
        }

        private void gradientColor5_Click(object sender, EventArgs e)
        {
            AbrirFormEnMDI<FormProveedor>();
        }

        private void gradientColor6_Click(object sender, EventArgs e)
        {

        }

        private void Form1nicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sIFADataSet1.spBajoStock' Puede moverla o quitarla según sea necesario.
            this.spBajoStockTableAdapter1.Fill(this.sIFADataSet1.spBajoStock);
            this.Mostrar();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            this.lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void Form1nicio_Shown(object sender, EventArgs e)
        {
            this.DataListado.Enabled = false;
            this.LimpiarSeleccion();
        }

        private void LimpiarSeleccion()
        {
            this.DataListado.EndEdit();
        }
    }
}
