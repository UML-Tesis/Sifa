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
        }


        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCliente_Load_1(object sender, EventArgs e)
        {
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

       
        public void Buscar()
        {
            this.DataListado.DataSource = NCliente.Buscar(this.txtBuscar.Text);
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
            this.txt2Nombre.Text = string.Empty;
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
            this.txt2Nombre.ReadOnly = !valor;
            this.txt1Apellido.ReadOnly = !valor;
            this.txt2Apellido.ReadOnly = !valor;
            this.txtCedula.ReadOnly = !valor;
            this.txtDireccion.ReadOnly = !valor;
            this.txtTelefono.ReadOnly = !valor;
            
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

        // llegue asta aca en formproveedor
        private void btnGuardar_Click_1(object sender, EventArgs e)
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

                        rpta = NCliente.Insertar(this.txt1Nombre.Text.Trim().ToUpper(), this.txt2Nombre.Text.Trim().ToUpper(), this.txt1Apellido.Text.Trim().ToUpper(), this.txt2Apellido.Text.Trim().ToUpper(), this.txtCedula.Text.Trim().ToUpper(), this.txtDireccion.Text.Trim().ToUpper(), this.TxTsexo.Text.Trim().ToUpper(), Convert.ToInt32(this.txtTelefono.Text));
                    }
                    else
                    {
                        rpta = NCliente.Editar(Convert.ToInt32(txtIdCliente.Text),
                        this.txt1Nombre.Text.Trim().ToUpper(), this.txt2Nombre.Text.Trim().ToUpper(), txt1Apellido.Text.Trim().ToUpper(), txt2Apellido.Text.Trim().ToUpper(), txtCedula.Text.Trim().ToUpper(), txtDireccion.Text.Trim().ToUpper(), TxTsexo.Text, Convert.ToInt32(txtTelefono.Text));
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
              
            }
            catch (Exception ex)
            {

            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            IsNuevo = true;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.Mostrar();
        }
        #region Keypress
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

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.sololetras(e);
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

       
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

       
        #endregion

        private void DataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdCliente.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Id_Proveedor"].Value);
            this.txt1Nombre.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Primer_Nombre"].Value);
            this.txt2Nombre.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Segundo_Nombre"].Value);
            this.txt1Apellido.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Primer_Apellido"].Value);
            this.txt2Apellido.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Segundo_Apellido"].Value);
            this.txtTelefono.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Telefono"].Value);
            this.txtCedula.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Cedula"].Value);
            this.txtDireccion.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Direccion"].Value);
            this.TxTsexo.Text = Convert.ToString(this.DataListado.CurrentRow.Cells["Sexo"].Value);
           
            this.tabcliente.SelectedIndex = 1;
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Habilitar(false);
            this.btnNuevo.Enabled = true;
            this.btnGuardar.Enabled = false;
            this.btnEditar.Enabled = true;
            this.btnCancelar.Enabled = false;
            this.Limpiar();
            errorProvider1.Clear();
        }

        private void DataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.Buscar();
        }


        

        
    }
}
