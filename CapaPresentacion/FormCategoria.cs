﻿using System;
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
    public partial class FormCategoria : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        
        public FormCategoria()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtNombre, "Ingrese falta este dato");
        }

        // Metodo para Ocultar Columnas
        private void OcultarColumnas()
        {
            this.DataListado.Columns[0].Visible = false;
            this.DataListado.Columns[1].Visible = false;
        }

        private void DiseñoColumnas()
        {
            DataListado.Columns[0].Width = 65;
            DataListado.Columns[2].Width = 200;
            DataListado.Columns[3].Width = 415;
        }

        private void Mostrar()
        {
            this.DataListado.DataSource = NCategoria.Mostrar();
            this.OcultarColumnas();
            this.DiseñoColumnas();
            this.DataListado.ClearSelection();
            lblRegistros.Text = "Total de Registros : " + Convert.ToString(DataListado.Rows.Count);
        }

        private void Buscar()
        {
            this.DataListado.DataSource = NCategoria.Buscar(txtBuscar.Text);
            this.OcultarColumnas();
            lblRegistros.Text = "Registros Encontrados : " + Convert.ToString(DataListado.Rows.Count);
        }

        private void Eliminar()
        {
            this.checkEliminar.Checked = false;
            this.btnEliminar.Enabled = false;
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.Eliminar();
        }

        public void MensajeOK(string mensaje) 
        {
            MessageBox.Show(mensaje, "Sistema de inventario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeError(string mensaje) 
        {
            MessageBox.Show(mensaje, "Sistema de Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void Limpiar() 
        {
            this.txtIdCategoria.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
        }

        public void Habilitar(bool valor) 
        {
            this.txtIdCategoria.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
        }

        public void Botones() 
        {
            if (this.IsNuevo || this.IsEditar) {
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
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty)
                {
                    MensajeError("Falta el Nombre");
                    errorProvider1.SetError(txtNombre, "Ingrese el Nombre");
                }
                else 
                {
                    if (this.IsNuevo) {
                        rpta = NCategoria.Insertar(this.txtNombre.Text.Trim().ToUpper(), this.txtDescripcion.Text.Trim().ToUpper());
                    }
                    else{
                        rpta = NCategoria.Editar(Convert.ToInt32(txtIdCategoria.Text),
                        this.txtNombre.Text.Trim().ToUpper(), this.txtDescripcion.Text.Trim().ToUpper());
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOK("Se inserto el registro correctamente");
                        }

                        else
                        {
                            this.MensajeOK("Se edito el registro");
                        }
                    }
                    else 
                    {
                        this.MensajeError(rpta);
                    }
                }
                this.IsNuevo = false;
                this.IsEditar = false;
                this.Botones();
                this.Limpiar();
                this.Mostrar();
            }
            catch (Exception ex)
            { 
            
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
            errorProvider1.Clear();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.sololetras(e);
        }
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.sololetras(e);
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdCategoria.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Id_Categoria"].Value);
            this.txtNombre.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Nombre"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Descripcion"].Value);
            this.tabControl1.SelectedIndex = 1;
            this.Mostrar();
            this.Eliminar();
        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdCategoria.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else 
            {
                MessageBox.Show("Selccione una Categoria de la lista");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Habilitar(false);
            this.btnNuevo.Enabled = true;
            this.btnGuardar.Enabled = false;
            this.btnEditar.Enabled = true;
            this.btnCancelar.Enabled = false;
            this.Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DataListado.SelectedRows.Count == 0)
            {
                MensajeError("Seleccione una columna");
            }
            else
            {
                try
                {
                    DialogResult opcion;
                    opcion = MessageBox.Show("¿Desea eliminar el producto seleccionado?", "Inventario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (opcion == DialogResult.OK)
                    {
                        string Codigo = "";
                        string rpta = "";

                        foreach (DataGridViewRow row in DataListado.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToString(row.Cells[1].Value);
                                rpta = NPresentacion.Eliminar(Convert.ToInt32(Codigo));
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

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            this.txtBuscar.Text = "";
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            this.label1.Visible = true;
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
