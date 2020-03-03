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
    public partial class FormCliente : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public FormCliente()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txt1Nombre, "Ingrese falta este dato");
        }

        private void Mostrar()
        {
            this.DataListado.DataSource = NCliente.Mostrar();
            this.OcultarColumnas();
            this.DiseñoColumnas();
            this.Eliminar();
            lblRegistros.Text = "Total de Registros : " + Convert.ToString(DataListado.Rows.Count);
        }

        private void Eliminar()
        {
            this.checkEliminar.Checked = false;
            this.btnEliminar.Enabled = false;
        }
        // Metodo para Ocultar Columnas
        private void OcultarColumnas()
        {
            this.DataListado.Columns[0].Visible = false;
            this.DataListado.Columns[1].Visible = false;
        }
       
        public void Buscar()
        {
            this.DataListado.DataSource = NCliente.Buscar(this.txtBuscar.Text);
            this.OcultarColumnas();
            this.DiseñoColumnas();
            lblRegistros.Text = "Registros Encontrados : " + Convert.ToString(DataListado.Rows.Count);
        }

        public void MensajeOK(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Limpiar()
        {
            this.txtIdCliente.Text = string.Empty;
            this.txt1Nombre.Text = string.Empty;
            this.txt1Apellido.Text = string.Empty;
            this.txt2Apellido.Text = string.Empty;
            this.txtCedula.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.txtTelefono.Text = string.Empty;
         
        }

        public void Habilitar(bool valor)
        {
            this.txtIdCliente.ReadOnly = !valor;
            this.txt1Nombre.ReadOnly = !valor;
            this.txt1Apellido.ReadOnly = !valor;
            this.txt2Apellido.ReadOnly = !valor;
            this.txtCedula.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            this.cbSexo.Enabled = valor;
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
        private void txt1Nombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumerosyLetras(e);
        }
       
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void DiseñoColumnas()
        {
            this.DataListado.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.DataListado.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataListado.Columns[9].DefaultCellStyle.Format = "C$ 0.00";
            DataListado.Columns[0].Width = 65;
            DataListado.Columns[2].Width = 160;
            DataListado.Columns[3].Width = 160;
            DataListado.Columns[4].Width = 120;
            DataListado.Columns[5].Width = 130;
            DataListado.Columns[6].Width = 50;
            DataListado.Columns[7].Width = 320;
            DataListado.Columns[8].Width = 100;
            DataListado.Columns[9].Width = 100;
        }
        #endregion

        private void btngEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdCliente.Text.Equals(""))
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

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.Eliminar();
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

                        rpta = NCliente.Insertar(this.txt1Nombre.Text.Trim().ToUpper(), this.txt1Apellido.Text.Trim().ToUpper(), this.txt2Apellido.Text.Trim().ToUpper(), this.txtCedula.Text.Trim().ToUpper(), this.txtDireccion.Text.Trim().ToUpper(), this.cbSexo.Text.Trim().ToUpper(), Convert.ToInt32(this.txtTelefono.Text));
                    }
                    else
                    {
                        rpta = NCliente.Editar(Convert.ToInt32(txtIdCliente.Text),
                        this.txt1Nombre.Text.Trim().ToUpper(), txt1Apellido.Text.Trim().ToUpper(), txt2Apellido.Text.Trim().ToUpper(), txtCedula.Text.Trim().ToUpper(), txtDireccion.Text.Trim().ToUpper(), cbSexo.Text.Trim().ToUpper(), Convert.ToInt32(txtTelefono.Text));
                    }

                    if (rpta.Equals("Ok"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOK("Se inserto el registro correctamente");
                        }
                        else
                        {
                            this.MensajeOK("Se edito el registro");
                        }
                        this.Limpiar();
                        this.Habilitar(true);
                        this.Mostrar();
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                }
            }
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
            this.txtIdCliente.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Id_Cliente"].Value);
            this.txt1Nombre.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["NOMBRES"].Value);
            this.txt1Apellido.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["APELLIDOS"].Value);
            this.txt2Apellido.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["ALIAS"].Value);
            this.txtTelefono.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["TELEFONO"].Value);
            this.txtCedula.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["CEDULA"].Value);
            this.txtDireccion.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["DIRECCION"].Value);
            this.cbSexo.SelectedItem = Convert.ToString(this.DataListado.CurrentRow.Cells["SEXO"].Value);
            this.tabcliente.SelectedIndex = 1;
            this.Mostrar();
            this.Eliminar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdCliente.Text.Equals(""))
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
    }
}
