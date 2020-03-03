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
             this.lblRegistros.Text = "Total de Registros : " + Convert.ToString(DataListado.Rows.Count);
             this.OcultarColumnas();
             this.DiseñoColumnas();
         }

         private void Buscar()
         {
             this.DataListado.DataSource = NProveedor.Buscar(txtBuscar.Text);
             lblRegistros.Text = "Registros Encontrados : " + Convert.ToString(DataListado.Rows.Count);
             this.OcultarColumnas();
             this.DiseñoColumnas();
         }

         private void Eliminar()
         {
             this.checkEliminar.Checked = false;
         }
         // Metodo para Ocultar Columnas
         private void OcultarColumnas()
         {
             this.DataListado.Columns[0].Visible = false;
             this.DataListado.Columns[1].Visible = false;
         }

         private void DiseñoColumnas()
         {
             this.DataListado.Columns[7].HeaderText = "Tipo de Documento";
             this.DataListado.Columns[3].HeaderText = "Nombres del Contacto";
             this.DataListado.Columns[4].HeaderText = "Apellidos del Contacto";
             this.DataListado.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
             this.DataListado.Columns[7].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
             DataListado.Columns[0].Width = 60;
             DataListado.Columns[2].Width = 160;
             DataListado.Columns[3].Width = 140;
             DataListado.Columns[4].Width = 140;
             DataListado.Columns[5].Width = 80;
             DataListado.Columns[6].Width = 80;
             DataListado.Columns[7].Width = 90;
             DataListado.Columns[8].Width = 100;
             DataListado.Columns[9].Width = 120;
             DataListado.Columns[10].Width = 220;
             DataListado.Columns[11].Width = 120;
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
             this.cbDocumento.Text = string.Empty;
             this.txtsectorcomercial.Text = string.Empty;
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
             this.cbDocumento.Enabled = valor;
             this.txtsectorcomercial.ReadOnly = !valor;
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

                         rpta = NProveedor.Insertar(this.txt1Nombre.Text.Trim().ToUpper(), this.txt2Nombre.Text.Trim().ToUpper(), this.txt1Apellido.Text.Trim().ToUpper(), Convert.ToInt32(this.txt2Apellido.Text), Convert.ToInt32(this.txtTelefono.Text), this.cbDocumento.Text.Trim().ToUpper()
                             , this.txtsectorcomercial.Text.Trim().ToUpper(), this.txtDireccion.Text.Trim().ToUpper(), this.txtcorreo.Text.Trim().ToUpper(), this.txtruc.Text.Trim().ToUpper());
                     }
                     else
                     {
                         rpta = NProveedor.Editar(Convert.ToInt32(this.txtIdProveedor.Text),
                         this.txt1Nombre.Text.Trim().ToUpper(), this.txt2Nombre.Text.Trim().ToUpper(), this.txt1Apellido.Text.Trim().ToUpper(), Convert.ToInt32(this.txt2Apellido.Text), Convert.ToInt32(this.txtTelefono.Text), this.cbDocumento.Text.Trim().ToUpper()
                             , this.txtsectorcomercial.Text.Trim().ToUpper(), this.txtDireccion.Text.Trim().ToUpper(), this.txtcorreo.Text.Trim().ToUpper(), this.txtruc.Text.Trim().ToUpper());
                     }

                     if (rpta.Equals("Ok"))
                     {
                         if (this.IsNuevo)
                         {
                             this.MensajeOK("Guardado Correctamente");
                         }
                         else
                         {
                             this.MensajeOK("Actualizado Correctamente");
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
             this.Eliminar();
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

         private void checkEliminar_CheckedChanged(object sender, EventArgs e)
         {
             DataListado.EndEdit();
             if (checkEliminar.Checked)
             {
                 this.btnEliminar.Enabled = true;
                 this.DataListado.Columns[0].Visible = true;
             }
             else
             {
                 this.btnEliminar.Enabled = false;
                 this.DataListado.Columns[0].Visible = false;
                 this.DataListado.Rows[0].Cells["Eliminar1"].Selected = false;
                 foreach (DataGridViewRow row in DataListado.Rows)
                 {
                     DataGridViewCheckBoxCell checkBox = (row.Cells["Eliminar1"] as DataGridViewCheckBoxCell);
                     checkBox.Value = checkEliminar.Checked;
                     row.Selected = false;
                     row.DefaultCellStyle.BackColor = Color.White;
                 }
             }
         }

         private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
         }

         private void btnEliminar_Click(object sender, EventArgs e)
         {
             try
             {
                 DialogResult opcion;
                 opcion = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Inventario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                 if (opcion == DialogResult.OK)
                 {
                     string Codigo = "";
                     string rpta = "";

                     foreach (DataGridViewRow row in DataListado.Rows)
                     {
                         if (Convert.ToBoolean(row.Cells[0].Value))
                         {
                             Codigo = Convert.ToString(row.Cells[1].Value);
                             rpta = NEmpleado.Eliminar(Convert.ToInt32(Codigo));
                         }
                     }
                     if (rpta.Equals("Ok"))
                     {
                         this.MensajeOK("Eliminado Correctamente");
                         this.Mostrar();
                         this.Eliminar();
                     }
                     else
                     {
                         this.MensajeError("Error al eliminar el registro");
                     }
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message + ex.StackTrace);
             }
         }

         private void DataListado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             DataGridViewRow[] old;
             old = new DataGridViewRow[DataListado.SelectedRows.Count];
             DataListado.SelectedRows.CopyTo(old, 0);

             foreach (DataGridViewRow row in old)
             {
                 {
                     if (e.ColumnIndex == DataListado.Columns["Eliminar1"].Index)
                     {
                         DataGridViewCheckBoxCell chckEliminar = (DataGridViewCheckBoxCell)DataListado.Rows[e.RowIndex].Cells["Eliminar1"];
                         chckEliminar.Value = !Convert.ToBoolean(chckEliminar.Value);
                         if (Convert.ToBoolean(chckEliminar.Value))
                         {
                             row.Selected = true;
                             row.DefaultCellStyle.BackColor = Color.FromName("Highlight");
                             row.DefaultCellStyle.SelectionBackColor = Color.FromName("Highlight");
                         }
                         else
                         {
                             row.Selected = false;
                             row.DefaultCellStyle.BackColor = Color.White;
                         }
                     }
                     else
                     {

                     }
                 }
             }
         }

         private void btnCerrar_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void txtBuscar_Enter(object sender, EventArgs e)
         {
             this.lblBuscar.Visible = false;
             this.txtBuscar.Text = "";
         }

         private void txtBuscar_Leave(object sender, EventArgs e)
         {
             this.lblBuscar.Visible = true;
             lblRegistros.Text = "Total de Registros : " + Convert.ToString(DataListado.Rows.Count);
         }

         private void DataListado_DoubleClick(object sender, EventArgs e)
         {
             this.txtIdProveedor.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Id_Proveedor"].Value);
             this.txt1Nombre.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Empresa"].Value);
             this.txt2Nombre.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["ContactoNombre"].Value);
             this.txt1Apellido.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["ContactoApellido"].Value);
             this.txt2Apellido.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Telefono"].Value);
             this.txtTelefono.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Telefono2"].Value);
             this.cbDocumento.SelectedItem = Convert.ToString(this.DataListado.CurrentRow.Cells["Tipo_Documento"].Value);
             this.txtsectorcomercial.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Sector_Comercial"].Value);
             this.txtDireccion.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Direccion"].Value);
             this.txtcorreo.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Correo"].Value);
             this.txtruc.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Documento"].Value);
             this.tabcliente.SelectedIndex = 1;
             this.Eliminar();
             this.Mostrar();
         }
    }
}
    
