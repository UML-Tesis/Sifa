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
using CapaPresentacion.Consultas;

namespace SIFA
{
    public partial class FormPrincipal : Form
    {
        public string Id_Trabajador;
        public string Nombre;
        public string Apellido;
        public string TipoAcceso;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            
        }

        private void AbrirInicio()
        {
            Form1nicio Formulario;
            Formulario = MdiChildren.OfType<Form1nicio>().FirstOrDefault();
            //Si el formulario no existe
            if (Formulario == null)
            {
                Formulario = new Form1nicio();
                Formulario.Id_Trabajador = Convert.ToInt32(this.Id_Trabajador);
                Formulario.Show();
                Formulario.MdiParent = this;
                Formulario.Dock = DockStyle.Fill;
            }
            else
            //Si el formulario existe
            {
                Formulario.Activate();
            }
        }

        private void GestionUsuarios()
        {
            //Controlar los Accesos
            if (TipoAcceso == "EMPLEADO")
            {
                this.mantenimientoToolStripMenuItem.Visible = false;
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        } 

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        public void AbrirFormEnMDI<MiForm>() where MiForm : Form, new()
        {
            Form Formulario;
            Formulario = MdiChildren.OfType<MiForm>().FirstOrDefault();
            //Si el formulario no existe
            if (Formulario == null)
            {
                Formulario = new MiForm();
                Formulario.Show();
                Formulario.MdiParent = this;
                Formulario.Dock = DockStyle.Fill;
            }
            else
                //Si el formulario existe
            {
                Formulario.Activate();
            }
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Formulario;
            Formulario = MdiChildren.OfType<FormProducto>().FirstOrDefault();
            //Si el formulario no existe
            if (Formulario == null)
            {
                Formulario = FormProducto.GetInstancia();
                Formulario.Show();
                Formulario.MdiParent = this;
                Formulario.Dock = DockStyle.Fill;
            }
            else
            //Si el formulario existe
            {
                Formulario.Activate();
            }
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCompra Formulario;
            Formulario = MdiChildren.OfType<FormCompra>().FirstOrDefault();
            //Si el formulario no existe
            if (Formulario == null)
            {
                Formulario = FormCompra.GetInstancia();
                Formulario.Show();
                Formulario.MdiParent = this;
                Formulario.Dock = DockStyle.Fill;
                Formulario.Id_Trabajador = Convert.ToInt32(this.Id_Trabajador);
            }
            else
            //Si el formulario existe
            {
                Formulario.Activate();
            }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnMDI<FormProveedor>();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormEnMDI<FormCliente>();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnMDI<FormCliente>();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnMDI<FormEmpleado>();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategoria Categoria = new FormCategoria();
            Categoria.ShowDialog();
        }

        private void presentacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPresentacion Presentacion = new FormPresentacion();
            Presentacion.ShowDialog();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login log = new Login();
            log.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            GestionUsuarios();
            AbrirInicio();
        }

        private void stockDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormEnMDI<FormConsultaStockProducto>();
        }
#region Diseño del Menu
        private void almacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.almacenToolStripMenuItem.ForeColor = Color.SteelBlue;
        }

        private void almacenToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            this.almacenToolStripMenuItem.ForeColor = Color.SteelBlue;
        }

        private void almacenToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            this.almacenToolStripMenuItem.ForeColor = Color.White;
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.comprasToolStripMenuItem.ForeColor = Color.SteelBlue;
        }

        private void comprasToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            this.comprasToolStripMenuItem.ForeColor = Color.SteelBlue;
        }

        private void comprasToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            this.comprasToolStripMenuItem.ForeColor = Color.White;
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ventasToolStripMenuItem.ForeColor = Color.SteelBlue;
        }

        private void ventasToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            this.ventasToolStripMenuItem.ForeColor = Color.SteelBlue;
        }

        private void ventasToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            this.ventasToolStripMenuItem.ForeColor = Color.White;
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.mantenimientoToolStripMenuItem.ForeColor = Color.SteelBlue;
        }

        private void mantenimientoToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            this.mantenimientoToolStripMenuItem.ForeColor = Color.SteelBlue;
        }

        private void mantenimientoToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            this.mantenimientoToolStripMenuItem.ForeColor = Color.White;
        }

        private void helpMenu_Click(object sender, EventArgs e)
        {
            this.helpMenu.ForeColor = Color.SteelBlue;
        }

        private void helpMenu_DropDownOpened(object sender, EventArgs e)
        {
            this.helpMenu.ForeColor = Color.SteelBlue;
        }

        private void helpMenu_DropDownClosed(object sender, EventArgs e)
        {
            this.helpMenu.ForeColor = Color.White;
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.consultasToolStripMenuItem.ForeColor = Color.SteelBlue;
        }

        private void consultasToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            this.consultasToolStripMenuItem.ForeColor = Color.SteelBlue;
        }

        private void consultasToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            this.consultasToolStripMenuItem.ForeColor = Color.White;
        }
#endregion
    }
}
