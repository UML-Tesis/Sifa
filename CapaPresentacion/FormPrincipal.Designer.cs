namespace SIFA
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arqueoDeCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almacenToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.helpMenu,
            this.consultasToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 5, 0, 5);
            this.menuStrip.Size = new System.Drawing.Size(945, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // almacenToolStripMenuItem
            // 
            this.almacenToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.almacenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productoToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.presentacionToolStripMenuItem});
            this.almacenToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.almacenToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            this.almacenToolStripMenuItem.Size = new System.Drawing.Size(79, 23);
            this.almacenToolStripMenuItem.Text = "Almacen";
            this.almacenToolStripMenuItem.DropDownClosed += new System.EventHandler(this.almacenToolStripMenuItem_DropDownClosed);
            this.almacenToolStripMenuItem.DropDownOpened += new System.EventHandler(this.almacenToolStripMenuItem_DropDownOpened);
            this.almacenToolStripMenuItem.Click += new System.EventHandler(this.almacenToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.productoToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.productoToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.categoriaToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            this.categoriaToolStripMenuItem.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // presentacionToolStripMenuItem
            // 
            this.presentacionToolStripMenuItem.BackColor = System.Drawing.Color.AliceBlue;
            this.presentacionToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.presentacionToolStripMenuItem.Name = "presentacionToolStripMenuItem";
            this.presentacionToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.presentacionToolStripMenuItem.Text = "Presentacion";
            this.presentacionToolStripMenuItem.Click += new System.EventHandler(this.presentacionToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.comprasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.comprasToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.DropDownClosed += new System.EventHandler(this.comprasToolStripMenuItem_DropDownClosed);
            this.comprasToolStripMenuItem.DropDownOpened += new System.EventHandler(this.comprasToolStripMenuItem_DropDownOpened);
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem1,
            this.clientesToolStripMenuItem});
            this.ventasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ventasToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.DropDownClosed += new System.EventHandler(this.ventasToolStripMenuItem_DropDownClosed);
            this.ventasToolStripMenuItem.DropDownOpened += new System.EventHandler(this.ventasToolStripMenuItem_DropDownOpened);
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.ForeColor = System.Drawing.Color.SteelBlue;
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            this.ventasToolStripMenuItem1.Click += new System.EventHandler(this.ventasToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosToolStripMenuItem,
            this.arqueoDeCajaToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mantenimientoToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(122, 23);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.DropDownClosed += new System.EventHandler(this.mantenimientoToolStripMenuItem_DropDownClosed);
            this.mantenimientoToolStripMenuItem.DropDownOpened += new System.EventHandler(this.mantenimientoToolStripMenuItem_DropDownOpened);
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // arqueoDeCajaToolStripMenuItem
            // 
            this.arqueoDeCajaToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.arqueoDeCajaToolStripMenuItem.Name = "arqueoDeCajaToolStripMenuItem";
            this.arqueoDeCajaToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.arqueoDeCajaToolStripMenuItem.Text = "Arqueo de caja";
            // 
            // helpMenu
            // 
            this.helpMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.ForeColor = System.Drawing.Color.White;
            this.helpMenu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(64, 23);
            this.helpMenu.Text = "Ay&uda";
            this.helpMenu.DropDownClosed += new System.EventHandler(this.helpMenu_DropDownClosed);
            this.helpMenu.DropDownOpened += new System.EventHandler(this.helpMenu_DropDownOpened);
            this.helpMenu.Click += new System.EventHandler(this.helpMenu_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(170, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue;
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockDeProductosToolStripMenuItem});
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.consultasToolStripMenuItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.DropDownClosed += new System.EventHandler(this.consultasToolStripMenuItem_DropDownClosed);
            this.consultasToolStripMenuItem.DropDownOpened += new System.EventHandler(this.consultasToolStripMenuItem_DropDownOpened);
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // stockDeProductosToolStripMenuItem
            // 
            this.stockDeProductosToolStripMenuItem.ForeColor = System.Drawing.Color.SteelBlue;
            this.stockDeProductosToolStripMenuItem.Name = "stockDeProductosToolStripMenuItem";
            this.stockDeProductosToolStripMenuItem.Size = new System.Drawing.Size(208, 24);
            this.stockDeProductosToolStripMenuItem.Text = "Stock de Productos";
            this.stockDeProductosToolStripMenuItem.Click += new System.EventHandler(this.stockDeProductosToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 452);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIFA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arqueoDeCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockDeProductosToolStripMenuItem;
    }
}



