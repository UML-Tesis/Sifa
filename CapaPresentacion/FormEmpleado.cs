using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormEmpleado : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public FormEmpleado()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtNombre, "Ingrese falta este dato");
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Eliminar();
            this.Habilitar(false);
            this.Botones();
        }

        private void Mostrar()
        {
            this.DataListado.DataSource = NEmpleado.Mostrar();
            this.lblRegistros.Text = "Total de Registros : " + Convert.ToString(DataListado.Rows.Count);
            this.OcultarColumnas();
            this.DiseñoColumnas();
            this.DataListado.ClearSelection();
        }

        public void Buscar()
        {
            this.DataListado.DataSource = NEmpleado.Buscar(this.txtBuscar.Text);
            lblRegistros.Text = "Registros Encontrados : " + Convert.ToString(DataListado.Rows.Count);
            this.OcultarColumnas();
            this.DiseñoColumnas();
        }

        private void Eliminar()
        {
            this.checkEliminar.Checked = false;
            this.btnEliminar.Enabled = false;
        }

        private Boolean VerificarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Limpiar()
        {
            this.txtIdEmpleado.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtApellido.Text = string.Empty;
            this.txtAlias.Text = string.Empty;
            this.txtCedula.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
            this.txtSalario.Text = string.Empty;
            this.txtCorreo.Text = string.Empty;
            this.txtUsuario.Text = string.Empty;
            this.txtContrasena.Text = string.Empty;
        }

        public void Habilitar(bool valor)
        {
            this.txtIdEmpleado.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtApellido.ReadOnly = !valor;
            this.txtAlias.ReadOnly = !valor;
            this.txtCedula.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            this.txtSalario.ReadOnly = !valor;
            this.txtCorreo.ReadOnly = !valor;
            this.txtUsuario.ReadOnly = !valor;
            this.txtContrasena.ReadOnly = !valor;
            this.cbSexo.Enabled = valor;
            this.cbAcceso.Enabled = valor;
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

        #region Keypress

        // Metodo para Ocultar Columnas
        private void OcultarColumnas()
        {
            this.DataListado.Columns[0].Visible = false;
            this.DataListado.Columns[1].Visible = false;
        }

        private void txt1Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.sololetras(e);
        }

        private void txt2Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.sololetras(e);
        }

        private void txt1Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.sololetras(e);
        }

        private void txt2Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.sololetras(e);
        }

        private void DiseñoColumnas()
        {
            this.DataListado.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.DataListado.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns[9].DefaultCellStyle.Format = "C$ 0.00";
            DataListado.Columns[0].Width = 65;
            DataListado.Columns[2].Width = 120;
            DataListado.Columns[3].Width = 120;
            DataListado.Columns[4].Width = 100;
            DataListado.Columns[5].Width = 200;
            DataListado.Columns[6].Width = 65;
            DataListado.Columns[7].Width = 120;
            DataListado.Columns[8].Width = 45;
            DataListado.Columns[9].Width = 65;
            DataListado.Columns[10].Width = 120;
        }
        #endregion

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdEmpleado.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Id_Empleado"].Value);
            this.txtNombre.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Nombres"].Value);
            this.txtApellido.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Apellidos"].Value);
            this.txtAlias.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Alias"].Value);
            this.txtCedula.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Cedula"].Value);
            this.txtDireccion.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Direccion"].Value);
            this.cbSexo.SelectedItem = Convert.ToString(this.DataListado.CurrentRow.Cells["Sexo"].Value);
            this.txtTelefono.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Telefono"].Value);
            this.txtSalario.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Salario"].Value);
            this.txtCorreo.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Correo"].Value);
            this.txtUsuario.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Usuario"].Value);
            this.txtContrasena.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Contraseña"].Value);
            this.cbAcceso.SelectedItem = Convert.ToString(this.DataListado.CurrentRow.Cells["Tipo_Acceso"].Value);
            this.tabempleado.SelectedIndex = 1;
            this.Eliminar();
            this.Mostrar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == "              " || this.txtNombre.Text == "")
                {
                    MensajeError("Hay Datos Por Completar");
                    errorProvider1.SetError(this.txtNombre, "Rellene esta parte del Formulario");
                }
                else if (this.txtApellido.Text == "              ")
                {
                    MensajeError("Hay Datos Por Completar");
                    errorProvider1.SetError(this.txtNombre, "Rellene esta parte del Formulario");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NEmpleado.Insertar(this.txtNombre.Text.Trim(), this.txtApellido.Text.Trim(), this.txtAlias.Text.Trim(), this.txtCedula.Text.Trim(), this.txtDireccion.Text.Trim(), this.cbSexo.Text.Trim(), Convert.ToInt32(this.txtTelefono.Text), Convert.ToInt32(this.txtSalario.Text), this.txtCorreo.Text.Trim(), this.txtUsuario.Text.Trim(), this.txtContrasena.Text.Trim(), this.cbAcceso.Text.Trim());
                    }
                    else
                    {
                        rpta = NEmpleado.Editar(Convert.ToInt32(this.txtIdEmpleado.Text), this.txtNombre.Text.Trim(), this.txtApellido.Text.Trim(), this.txtAlias.Text.Trim(), this.txtCedula.Text.Trim(), this.txtDireccion.Text.Trim().ToUpper(), this.cbSexo.Text.Trim().ToUpper(), Convert.ToInt32(this.txtTelefono.Text), Convert.ToInt32(this.txtSalario.Text), this.txtCorreo.Text.Trim(), this.txtUsuario.Text.Trim(), this.txtContrasena.Text.Trim(), this.cbAcceso.Text.Trim());
                    }
                    if (rpta.Equals("Ok"))
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
                    this.Habilitar(false);
                    this.btnNuevo.Enabled = true;
                    this.btnGuardar.Enabled = false;
                    this.btnEditar.Enabled = true;
                    this.btnCancelar.Enabled = false;
                    this.Limpiar();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdEmpleado.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                MessageBox.Show("Selccione un empleado de la lista");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Habilitar(false);
            this.btnNuevo.Enabled = true;
            this.btnGuardar.Enabled = false;
            this.btnEditar.Enabled = true;
            this.btnCancelar.Enabled = false;
            this.Limpiar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IsNuevo = true;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (checkEliminar.Checked)
            {
                this.Buscar();
                this.DataListado.Columns[0].Visible = true;
            }
            else
            {
                this.Buscar();
                this.DataListado.Columns[0].Visible = false;
            }
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            this.label4.Visible = false;
            this.txtBuscar.Text = "";
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            this.label4.Visible = true;
            lblRegistros.Text = "Total de Registros : " + Convert.ToString(DataListado.Rows.Count);
        }

        private void DataListado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow[] old;
            old = new DataGridViewRow[DataListado.SelectedRows.Count];
            DataListado.SelectedRows.CopyTo(old, 0);
            DataGridViewCheckBoxCell chckEliminar = (DataGridViewCheckBoxCell)DataListado.Rows[e.RowIndex].Cells["Eliminar1"];
            
            foreach (DataGridViewRow row in old)
            {
                {
                    if (e.ColumnIndex == DataListado.Columns["Eliminar1"].Index)
                    {
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
                }
            }
        }
    }
}
