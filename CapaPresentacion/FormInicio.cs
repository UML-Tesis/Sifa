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
    public partial class Form1nicio : Form
    {
        public int Id_Trabajador;
        public string Nombre;
        public string Apellido;
        public string TipoAcceso;

        public Form1nicio()
        {
            InitializeComponent();
            this.label25.Text = Convert.ToString(Id_Trabajador);
        }
        
        private void GestionUsuarios()
        {
            //Controlar los Accesos
            if (TipoAcceso == "ADMINISTRADOR")
            {
                this.gradientColor3.Enabled = false;
            }
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
    }
}
