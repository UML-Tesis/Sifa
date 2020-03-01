using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormCompra : Form
    {
        public int Id_Trabajador;
        public bool IsNuevo = false;
        private DataTable dtDetalles;
        private decimal TotalPagado = 0;
        private static FormCompra _Instancia;

        public FormCompra()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtNombreProveedor, "Seleccione el Proveedor");
            this.ttmensaje.SetToolTip(this.txtFactura, "Ingrese el codigo de Factura");
            this.ttmensaje.SetToolTip(this.txtIva, "Ingrese el Iva Aplicado");
            this.ttmensaje.SetToolTip(this.txtCorrelativo, "Ingrese el Correlativo");
            this.ttmensaje.SetToolTip(this.txtNombreProducto, "Seleccione el Producto");
            this.ttmensaje.SetToolTip(this.txtPrecio_Compra, "Ingrese el Proveedor");
            this.ttmensaje.SetToolTip(this.txtPrecio_Venta, "Ingrese el Proveedor");
            this.ttmensaje.SetToolTip(this.txtCantidad, "Ingrese la Cantidad de Compra");
            this.txtNombreProveedor.ReadOnly = true;
            this.txtNombreProducto.ReadOnly = true;
        }

        public static FormCompra GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FormCompra();
            }
            return _Instancia;
        }

        public void setProveedor(string IdProveedor, string nombre)
        {
            this.txtIdProveedor.Text = IdProveedor;
            this.txtNombreProveedor.Text = nombre;
        }

        public void setProducto(string IdProducto, string nombre)
        {
            this.txtIdProducto.Text = IdProducto;
            this.txtNombreProducto.Text = nombre;
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
            this.txtIdCompra.Text = string.Empty;
            this.txtIdProveedor.Text = string.Empty;
            this.txtNombreProveedor.Text = string.Empty;
            this.txtFactura.Text = string.Empty;
            this.txtIva.Text = string.Empty;
            this.txtCorrelativo.Text = string.Empty;
            this.lblTotal.Text = "C$ 0.00";
            this.CrearTabla();
        }

        public void LimpiarDetalles()
        {
            this.txtIdProducto.Text = string.Empty;
            this.txtNombreProducto.Text = string.Empty;
            this.txtPrecio_Compra.Text = string.Empty;
            this.txtPrecio_Venta.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
        }

        public void Habilitar(bool valor)
        {
            this.txtIdCompra.ReadOnly = !valor;
            this.txtFactura.ReadOnly = !valor;
            this.txtIva.ReadOnly = !valor;
            this.dateTimePicker2.Enabled = valor;
            this.txtCorrelativo.ReadOnly = !valor;
            this.txtPrecio_Compra.ReadOnly = !valor;
            this.txtPrecio_Venta.ReadOnly = !valor;
            this.txtCantidad.ReadOnly = !valor;

            this.btnProveedor.Enabled = valor;
            this.btnProducto.Enabled = valor;
            this.btnAgregar.Enabled = valor;
        }

        public void Botones()
        {
            if (this.IsNuevo)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
            }
        }
        // Metodo para Ocultar Columnas
        private void OcultarColumnas()
        {
            this.DataListado.Columns[0].Visible = false;
        }

        private void DiseñoColumnas()
        {
            DataListado.Columns[9].DefaultCellStyle.Format = "C$ 0.00";
            DataListado.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataListado.Columns[0].Width = 60;
            DataListado.Columns[2].Width = 200;
            DataListado.Columns[3].Width = 200;
            DataListado.Columns[3].Width = 120;
            DataListado.Columns[5].Width = 120;
            DataListado.Columns[6].Width = 80;
        }

        private void Mostrar()
        {
            this.DataListado.DataSource = NCompra.Mostrar();
            this.OcultarColumnas();
            this.DiseñoColumnas();
        }

        private void Anular()
        {
            this.checkAnular.Checked = false;
            this.btnAnular.Enabled = false;
        }

        public void MostrarDetalle()
        {
            this.dataListadoDetalles.DataSource = NCompra.MostrarDetalle(this.txtIdCompra.Text);
        }

        public void BuscarFechas()
        {
            this.DataListado.DataSource = NCompra.BuscarFechas(this.dtFecha1.Value.ToString("dd/MM/yyyy"), this.dtFecha2.Value.ToString("dd/MM/yyyy"));
            this.OcultarColumnas();
        }

        private void CrearTabla()
        {
            this.dtDetalles = new DataTable("Detalle");
            this.dtDetalles.Columns.Add("Id_Producto", System.Type.GetType("System.Int32"));
            this.dtDetalles.Columns.Add("Producto", System.Type.GetType("System.String"));
            this.dtDetalles.Columns.Add("Precio_Compra", System.Type.GetType("System.Decimal"));
            this.dtDetalles.Columns.Add("Precio_Venta", System.Type.GetType("System.Decimal"));
            this.dtDetalles.Columns.Add("Stock_Inicial", System.Type.GetType("System.Int32"));
            this.dtDetalles.Columns.Add("SubTotal", System.Type.GetType("System.Decimal"));
            //Relacionar nuestro DataGridView con nuestro DataTable
            this.dataListadoDetalles.DataSource = this.dtDetalles;
            this.dataListadoDetalles.Columns["Producto"].Width = 160;
            this.dataListadoDetalles.Columns["Precio_Compra"].Width = 120;
            this.dataListadoDetalles.Columns["Precio_Venta"].Width = 120;
            this.dataListadoDetalles.Columns["SubTotal"].Width = 120;
            this.dataListadoDetalles.Columns["Precio_Compra"].HeaderText = "Precio de Compra";
            this.dataListadoDetalles.Columns["Precio_Venta"].HeaderText = "Precio de Venta";
            this.dataListadoDetalles.Columns["Stock_Inicial"].HeaderText = "Cantidad";
            this.dataListadoDetalles.Columns["Precio_Compra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataListadoDetalles.Columns["Precio_Venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataListadoDetalles.Columns["Stock_Inicial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataListadoDetalles.Columns["Precio_Compra"].DefaultCellStyle.Format = "C$ 0.00";
            this.dataListadoDetalles.Columns["Precio_Venta"].DefaultCellStyle.Format = "C$ 0.00";
            this.dataListadoDetalles.Columns["SubTotal"].DefaultCellStyle.Format = "C$ 0.00";
            this.dataListadoDetalles.Columns["Stock_Inicial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            ListarProveedor prov = new ListarProveedor();
            prov.ShowDialog();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            ListarProducto Prod = new ListarProducto();
            Prod.ShowDialog();
        }

        private void btnBuscarXFecha_Click(object sender, EventArgs e)
        {
            this.MostrarDetalle();
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.CrearTabla();
            this.Anular();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.LimpiarDetalles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Habilitar(false);
            this.Limpiar();
            this.Botones();
            this.IsNuevo = false;
            this.LimpiarDetalles();
            errorProvider1.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtIdProveedor.Text == string.Empty || this.txtFactura.Text == string.Empty || this.txtIva.Text == string.Empty || this.txtCorrelativo.Text == string.Empty)
                {
                    MensajeError("Falta el Nombre");
                    errorProvider1.SetError(txtIdProveedor, "Ingrese el Nombre");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NCompra.Insertar(Id_Trabajador, Convert.ToInt32(this.txtIdProveedor.Text), this.dateTimePicker2.Value, Convert.ToInt32(this.txtFactura.Text), Convert.ToDecimal(this.txtIva.Text), Convert.ToInt32(this.txtCorrelativo.Text), "EMITIDO", dtDetalles);
                    }
                    else
                    {
                        MensajeError("No es nuevo");
                    }
                    if (rpta.Equals("Ok"))
                    {
                        if (this.IsNuevo)
                        {
                            MensajeOK("Guardado Correctamente");
                        }
                    }
                    else
                    {
                        MensajeError(rpta);
                    }
                    this.IsNuevo = false;
                    this.Mostrar();
                    this.Botones();
                    this.Limpiar();
                    this.LimpiarDetalles();
                    this.Habilitar(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtIdProducto.Text == string.Empty || this.txtPrecio_Compra.Text == string.Empty || this.txtPrecio_Venta.Text == string.Empty || this.txtCantidad.Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos");
                    errorProvider1.SetError(txtIdProveedor, "Ingrese el Nombre");
                }
                else
                {
                    bool registrar = true;
                    foreach (DataRow row in dtDetalles.Rows)
                    {
                        if (Convert.ToInt32(row["Id_Producto"]) == Convert.ToInt32(this.txtIdProducto.Text))
                        {
                            registrar = false;
                            this.MensajeError("Ya se encuentra el articulo en el detalle");
                        }
                    }
                    if (registrar)
                    {
                        decimal subTotal = Convert.ToDecimal(this.txtCantidad.Text) * Convert.ToDecimal(this.txtPrecio_Compra.Text);
                        TotalPagado = TotalPagado + subTotal;
                        this.lblTotal.Text = TotalPagado.ToString("#C$ 0.00#");
                        //Agregar el detalle al datalistadoDetalle
                        DataRow row = this.dtDetalles.NewRow();
                        row["Id_Producto"] = Convert.ToInt32(this.txtIdProducto.Text);
                        row["Producto"] = this.txtNombreProducto.Text;
                        row["Precio_Compra"] = Convert.ToDecimal(this.txtPrecio_Compra.Text);
                        row["Precio_Venta"] = Convert.ToDecimal(this.txtPrecio_Venta.Text);
                        row["Stock_Inicial"] = Convert.ToInt32(this.txtCantidad.Text);
                        row["SubTotal"] = subTotal;
                        this.dtDetalles.Rows.Add(row);
                        this.LimpiarDetalles();
                    }
                }
                this.Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceFila = this.dataListadoDetalles.CurrentCell.RowIndex;
                DataRow row = this.dtDetalles.Rows[indiceFila];
                //Disminuir el total pagado
                this.TotalPagado = this.TotalPagado - Convert.ToDecimal(row["SubTotal"].ToString());
                this.lblTotal.Text = TotalPagado.ToString("#C$ 0.00#");
                //Removemos la fila
                this.dtDetalles.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MensajeError("No hay fila para remover");
            }
        }

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdCompra.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Id_Compra"].Value);
            this.txtNombreProveedor.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Proveedor"].Value);
            this.dateTimePicker2.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Fecha_Hora"].Value);
            this.txtFactura.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Cod_Factura"].Value);
            this.txtIva.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Iva"].Value);
            this.txtCorrelativo.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Correlativo"].Value);
            this.lblTotal.Text = "C$ " + Convert.ToString(this.DataListado.CurrentRow.Cells["Total"].Value) + ".00";
            this.MostrarDetalle();
            this.tabCompra.SelectedIndex = 1;
        }

        private void FormCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void btnAnular_Click(object sender, EventArgs e)
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
                    opcion = MessageBox.Show("¿Desea anular el registro seleccionado?", "Inventario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (opcion == DialogResult.OK)
                    {
                        string Codigo = "";
                        string rpta = "";

                        foreach (DataGridViewRow row in DataListado.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToString(row.Cells[1].Value);
                                rpta = NCompra.Anular(Convert.ToInt32(Codigo));
                            }
                        }
                        if (rpta.Equals("Ok"))
                        {
                            this.MensajeOK("Se anuló correctamente la compra");
                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }
                        this.Mostrar();
                        this.Anular();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAnular.Checked)
            {
                this.DataListado.Columns[0].Visible = true;
                this.btnAnular.Enabled = true;
            }
            else
            {
                this.DataListado.Columns[0].Visible = false;
                this.btnAnular.Enabled = false;
            }
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
