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
    public partial class FormProducto : Form
    {
        private bool IsNuevo= false;
        private bool IsEditar= false;
        private static FormProducto _Instancia;

        public static FormProducto GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FormProducto();
            }
            return _Instancia;
        }

        public void setCategoria(string IdCategoria, string nombre)
        {
            this.txtIdCategoria.Text = IdCategoria;
            this.txtNombreCategoria.Text = nombre;
        }

        public FormProducto()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtNombre, "Ingrese falta este dato");
            this.LlenarComboPresentacion();
        }

        private void Mostrar()
        {
            this.DataListado.DataSource = NProducto.Mostrar();
            this.OcultarColumnas();
            lblRegistros.Text = "Total de Registros : " + Convert.ToString(DataListado.Rows.Count);
        }

        public void Buscar()
        {
            this.DataListado.DataSource = NProducto.Buscar(this.txtBuscar.Text);
            this.OcultarColumnas();
            lblRegistros.Text = "Registros Encontrados : " + Convert.ToString(DataListado.Rows.Count);
        }

        private void LlenarComboPresentacion()
        {
            cbPresentacion.DataSource = NPresentacion.Mostrar();
            cbPresentacion.ValueMember = "Id_Presentacion";
            cbPresentacion.DisplayMember = "Nombre";
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
            this.txtIdProducto.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtMarca.Text = string.Empty;
            this.txtPrecio.Text = string.Empty;
            this.cbPresentacion.Text = string.Empty;
            this.txtMedida.Text = string.Empty;
        }

        public void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtMarca.ReadOnly = !valor;
            this.txtPrecio.ReadOnly = !valor;
            this.dateTimePicker1.Enabled = valor;
            this.cbPresentacion.Enabled = valor;
            this.txtMedida.ReadOnly = !valor;
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
        // Metodo para Ocultar Columnas
        private void OcultarColumnas()
        {
            this.DataListado.Columns[0].Visible = false;
            this.DataListado.Columns[6].Visible = false;
            this.DataListado.Columns[8].Visible = false;
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtNombre.Text == string.Empty || this.txtPrecio.Text ==  string.Empty || this.txtMarca.Text == string.Empty || this.txtMedida.Text == string.Empty)
                {
                    MensajeError("Falta el Nombre");
                    errorProvider1.SetError(txtNombre, "Ingrese el Nombre");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NProducto.Insertar(this.txtNombre.Text.Trim().ToUpper(), Convert.ToInt32(this.txtPrecio.Text), this.txtMarca.Text.Trim().ToUpper(), Convert.ToDateTime(this.dateTimePicker1.Value), Convert.ToInt32(this.txtIdCategoria.Text), Convert.ToInt32(this.cbPresentacion.SelectedValue), Convert.ToInt32(this.txtMedida.Text));
                    }
                    else
                    {
                        rpta = NProducto.Editar(Convert.ToInt32(this.txtIdProducto.Text), this.txtNombre.Text.Trim().ToUpper(), Convert.ToInt32(this.txtPrecio.Text), this.txtMarca.Text.Trim().ToUpper(), Convert.ToDateTime(this.dateTimePicker1.Value), Convert.ToInt32(this.txtIdCategoria.Text), Convert.ToInt32(this.cbPresentacion.SelectedValue), Convert.ToInt32(this.txtMedida.Text));
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
                }
                this.IsNuevo = false;
                this.IsEditar = false;
                this.Mostrar();
                this.Botones();
                this.Limpiar();
                this.Habilitar(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!this.txtIdProducto.Text.Equals(""))
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IsNuevo = true;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
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

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdProducto.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Id_Producto"].Value);
            this.txtCodigo.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Codigo"].Value);
            this.txtNombre.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Nombre"].Value);
            this.txtMarca.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Marca"].Value);
            this.txtPrecio.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Precio"].Value);
            this.dateTimePicker1.Value = Convert.ToDateTime(this.DataListado.CurrentRow.Cells["Fecha_Vencimiento"].Value);
            this.txtIdCategoria.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Id_Categoria"].Value);
            this.txtNombreCategoria.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Categoria"].Value);
            this.cbPresentacion.SelectedValue = Convert.ToString(this.DataListado.CurrentRow.Cells["Id_Presentacion"].Value);
            this.txtMedida.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Medida"].Value);
            this.tabproducto.SelectedIndex = 1;
        }

        #region Eventos de Diseño

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            this.label3.Visible = false;
            this.txtBuscar.Text = "";
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            this.label3.Visible = true;
            lblRegistros.Text = "Total de Registros : " + Convert.ToString(DataListado.Rows.Count);
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            ListarCategoria form = new ListarCategoria();
            form.ShowDialog();
        }

        private void FormProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            {
                _Instancia = null;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormReporteProductos form = new FormReporteProductos();
            form.ShowDialog();
        }
    }
}
