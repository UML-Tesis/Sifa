using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaPresentacion;

namespace SIFA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ttmensaje.SetToolTip(this.txtUsuario, "Ingrese su nombre de usuario");
            this.ttmensaje.SetToolTip(this.txtContraseña, "Ingrese su Contraseña");
        }

        //METODO PARA ARRASTRAR EL FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lparam);


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        public void AbrirFormEnMDI<MiForm>() where MiForm : Form, new()
        {
            Form Formulario;
            FormPrincipal principal;
            Formulario = ParentForm.MdiChildren.OfType<MiForm>().FirstOrDefault();
            //Si el formulario no existe
            if (Formulario == null)
            {
                Formulario = new MiForm();
                Formulario.Show();
                Formulario.Dock = DockStyle.Fill;
            }
            else
            //Si el formulario existe
            {
                Formulario.Activate();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DataTable Datos = CapaNegocio.NEmpleado.Login(this.txtUsuario.Text, this.txtContraseña.Text);
            //Evaluar si existe el Usuario
            if (Datos.Rows.Count == 0)
            {
                MessageBox.Show("Usuario No Encontrado", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormPrincipal form = new FormPrincipal();
                form.Id_Trabajador = Datos.Rows[0][0].ToString();
                form.Nombre = Datos.Rows[0][1].ToString();
                form.Apellido = Datos.Rows[0][2].ToString();
                form.TipoAcceso = Datos.Rows[0][3].ToString();
                form.Show();
                this.Hide();
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
