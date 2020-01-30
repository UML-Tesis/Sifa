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
    public partial class FormProveedor : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

         public FormProveedor()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txt1Nombre, "Ingrese falta este dato");
      
        }

         private void Mostrar()
         {
             this.DataListado.DataSource = NProveedor.Mostrar();
         }

         private void Buscar()
         {
             this.DataListado.DataSource = NProveedor.Buscar(txtBuscar.Text);
         }

         public void MensajeOK(string mensaje)
         {
             MessageBox.Show(mensaje, "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }

         public void MensajeError(string mensaje)
         {
             MessageBox.Show(mensaje, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }

         public void Limpiar()
         {
             this.txtIdProveedor.Text = string.Empty;
             this.txt1Nombre.Text = string.Empty;
             this.txt2Nombre.Text = string.Empty;
             this.txt1Apellido.Text = string.Empty;
             this.txt2Apellido.Text = string.Empty;
             this.txtTelefono.Text = string.Empty;
             this.txttipodocumento.Text = string.Empty;
             this.txtsectorcomercial.Text = string.Empty;
             this.txtempresa.Text = string.Empty;
             this.txtDireccion.Text = string.Empty;
             this.txtcorreo.Text = string.Empty;
             this.txtruc.Text = string.Empty;
             
         }

         public void Habilitar(bool valor)
         {
             this.txtIdProveedor.ReadOnly = !valor;
             this.txt1Nombre.ReadOnly = !valor;
             this.txt2Nombre.ReadOnly = !valor;
             this.txt1Apellido.ReadOnly = !valor;
             this.txt2Apellido.ReadOnly = !valor;
             this.txtTelefono.ReadOnly = !valor;
             this.txttipodocumento.ReadOnly = !valor;
             this.txtsectorcomercial.ReadOnly = !valor;
             this.txtempresa.ReadOnly = !valor;
             this.txtDireccion.ReadOnly = !valor;
             this.txtcorreo.ReadOnly = !valor;
             this.txtruc.ReadOnly = !valor;

         }

         public void Botones()
         {
             if (this.IsNuevo || this.IsEditar)
             {
                 this.Habilitar(true);
                 this.btnNuevo.Enabled = false;
                 this.btnGuardar.Enabled = true;
                 this.btnEditar.Enabled = false;
                 this.btnCancelar.Enabled = true;
             }
             else
             {
                 this.Habilitar(false);
                 this.btnNuevo.Enabled = true;
                 this.btnGuardar.Enabled = false;
                 this.btnEditar.Enabled = true;
                 this.btnCancelar.Enabled = false;
             }
         }

         private void btnNuevo_Click(object sender, EventArgs e)
         {
             IsNuevo = true;
             this.Botones();
             this.Limpiar();
             this.Habilitar(true);
             this.Mostrar();
         }

         private void DataListado_DoubleClick(object sender, EventArgs e)
         {

             this.txtIdProveedor.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Id_Proveedor"].Value);
             this.txt1Nombre.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Primer_Nombre"].Value);
             this.txt2Nombre.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Segundo_Nombre"].Value);
             this.txt1Apellido.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Primer_Apellido"].Value);
             this.txt2Apellido.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Segundo_Apellido"].Value);
             this.txtTelefono.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Telefono"].Value);
             this.txttipodocumento.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Tipo_Documento"].Value);
             this.txtsectorcomercial.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Sector_Comercial"].Value);
             this.txtempresa.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Empresa"].Value);
             this.txtDireccion.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Direccion"].Value);
             this.txtcorreo.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Correo"].Value);
             this.txtruc.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["RUC"].Value);


             this.tabcliente.SelectedIndex = 1;

         }

         private void txtBuscar_TextChanged(object sender, EventArgs e)
         {
             this.Buscar();
         }

         private void btnGuardar_Click(object sender, EventArgs e)
         {
             try
             {
                 string rpta = "";
                 if (this.txt1Nombre.Text == string.Empty)
                 {
                     MensajeError("Falta el Nombre");
                     errorProvider1.SetError(txt1Nombre, "Ingrese el Nombre");
                 }
                 else
                 {
                     if (this.IsNuevo)
                     {

                         rpta = NProveedor.Insertar(this.txt1Nombre.Text.Trim().ToUpper(), this.txt2Nombre.Text.Trim().ToUpper(), this.txt1Apellido.Text.Trim().ToUpper(), this.txt2Apellido.Text.Trim().ToUpper(), Convert.ToInt32(this.txtTelefono.Text), this.txttipodocumento.Text.Trim().ToUpper()
                             , this.txtsectorcomercial.Text.Trim().ToUpper(), this.txtempresa.Text.Trim().ToUpper(), this.txtDireccion.Text.Trim().ToUpper(), this.txtcorreo.Text.Trim().ToUpper(), this.txtruc.Text.Trim().ToUpper());
                     }
                     else
                     {
                         rpta = NProveedor.Editar(Convert.ToInt32(txtIdProveedor.Text),
                         this.txt1Nombre.Text.Trim().ToUpper(), this.txt2Nombre.Text.Trim().ToUpper(), this.txt1Apellido.Text.Trim().ToUpper(), this.txt2Apellido.Text.Trim().ToUpper(), Convert.ToInt32(this.txtTelefono.Text), this.txttipodocumento.Text.Trim().ToUpper()
                             , this.txtsectorcomercial.Text.Trim().ToUpper(), this.txtempresa.Text.Trim().ToUpper(), this.txtDireccion.Text.Trim().ToUpper(), this.txtcorreo.Text.Trim().ToUpper(), this.txtruc.Text.Trim().ToUpper());
                     }

                     if (rpta.Equals("OK"))
                     {
                         if (this.IsNuevo)
                         {
                             this.MensajeOK("Guardado Correctamente");
                         }
                         else
                         {
                             this.MensajeOK("Editado Correctamente");
                         }
                     }
                     else
                     {
                         this.MensajeError(rpta);
                     }
                     this.Mostrar();
                 }
             }
             catch (Exception ex)
             {

             }

         }

         private void btnEditar_Click(object sender, EventArgs e)
         {
             if (!this.txtIdProveedor.Text.Equals(""))
             {
                 this.IsEditar = true;
                 this.Botones();
                 this.Habilitar(true);
             }
             else
             {
                 MessageBox.Show("Selccione un Proveedor de la lista");
             }

         }

         private void FormProveedor_Load(object sender, EventArgs e)
         {
             this.Mostrar();
             this.Habilitar(false);
             this.Botones();
         }

         private void btnCancelar_Click(object sender, EventArgs e)
         {
             this.Habilitar(false);
             this.btnNuevo.Enabled = true;
             this.btnGuardar.Enabled = false;
             this.btnEditar.Enabled = true;
             this.btnCancelar.Enabled = false;
             this.Limpiar();
             errorProvider1.Clear();
         }
    }
}
    
