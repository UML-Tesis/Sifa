namespace CapaPresentacion
{
    partial class FormProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProveedor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabcliente = new System.Windows.Forms.TabControl();
            this.tabnuevocliente = new System.Windows.Forms.TabPage();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.checkEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.DataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tablista = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltipo_documento = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.lblruc = new System.Windows.Forms.Label();
            this.txtsectorcomercial = new System.Windows.Forms.TextBox();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txt2Apellido = new System.Windows.Forms.TextBox();
            this.txt1Apellido = new System.Windows.Forms.TextBox();
            this.txt2Nombre = new System.Windows.Forms.TextBox();
            this.txt1Nombre = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lblsexo = new System.Windows.Forms.Label();
            this.lblsegapellido = new System.Windows.Forms.Label();
            this.lblprimerapellido = new System.Windows.Forms.Label();
            this.lblsegundonombre = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.gradColor1 = new CapaPresentacion.GradColor();
            this.cbDocumento = new System.Windows.Forms.ComboBox();
            this.tabcliente.SuspendLayout();
            this.tabnuevocliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            this.tablista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gradColor1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcliente
            // 
            this.tabcliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcliente.Controls.Add(this.tabnuevocliente);
            this.tabcliente.Controls.Add(this.tablista);
            this.tabcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcliente.Location = new System.Drawing.Point(12, 93);
            this.tabcliente.Name = "tabcliente";
            this.tabcliente.SelectedIndex = 0;
            this.tabcliente.Size = new System.Drawing.Size(1121, 484);
            this.tabcliente.TabIndex = 60;
            // 
            // tabnuevocliente
            // 
            this.tabnuevocliente.Controls.Add(this.lblRegistros);
            this.tabnuevocliente.Controls.Add(this.lblBuscar);
            this.tabnuevocliente.Controls.Add(this.checkEliminar);
            this.tabnuevocliente.Controls.Add(this.btnEliminar);
            this.tabnuevocliente.Controls.Add(this.btnImprimir);
            this.tabnuevocliente.Controls.Add(this.txtBuscar);
            this.tabnuevocliente.Controls.Add(this.DataListado);
            this.tabnuevocliente.Location = new System.Drawing.Point(4, 25);
            this.tabnuevocliente.Name = "tabnuevocliente";
            this.tabnuevocliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabnuevocliente.Size = new System.Drawing.Size(997, 455);
            this.tabnuevocliente.TabIndex = 0;
            this.tabnuevocliente.Text = "Lista de Proveedores";
            this.tabnuevocliente.UseVisualStyleBackColor = true;
            // 
            // lblRegistros
            // 
            this.lblRegistros.AutoSize = true;
            this.lblRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistros.Location = new System.Drawing.Point(627, 33);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(11, 17);
            this.lblRegistros.TabIndex = 55;
            this.lblRegistros.Text = "l";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblBuscar.Enabled = false;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(324, 33);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(280, 17);
            this.lblBuscar.TabIndex = 54;
            this.lblBuscar.Text = "Buscar...                                                      ";
            // 
            // checkEliminar
            // 
            this.checkEliminar.AutoSize = true;
            this.checkEliminar.Location = new System.Drawing.Point(6, 38);
            this.checkEliminar.Name = "checkEliminar";
            this.checkEliminar.Size = new System.Drawing.Size(158, 21);
            this.checkEliminar.TabIndex = 53;
            this.checkEliminar.Text = "Seleccionar Registro";
            this.checkEliminar.UseVisualStyleBackColor = true;
            this.checkEliminar.CheckedChanged += new System.EventHandler(this.checkEliminar_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(847, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(69, 50);
            this.btnEliminar.TabIndex = 52;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(922, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(69, 50);
            this.btnImprimir.TabIndex = 50;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.Location = new System.Drawing.Point(322, 31);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(289, 23);
            this.txtBuscar.TabIndex = 51;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // DataListado
            // 
            this.DataListado.AllowUserToAddRows = false;
            this.DataListado.AllowUserToDeleteRows = false;
            this.DataListado.AllowUserToResizeColumns = false;
            this.DataListado.AllowUserToResizeRows = false;
            this.DataListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataListado.BackgroundColor = System.Drawing.Color.White;
            this.DataListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataListado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataListado.ColumnHeadersHeight = 40;
            this.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar1});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataListado.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataListado.EnableHeadersVisualStyles = false;
            this.DataListado.GridColor = System.Drawing.Color.Black;
            this.DataListado.Location = new System.Drawing.Point(6, 75);
            this.DataListado.MultiSelect = false;
            this.DataListado.Name = "DataListado";
            this.DataListado.ReadOnly = true;
            this.DataListado.RowHeadersVisible = false;
            this.DataListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListado.Size = new System.Drawing.Size(985, 335);
            this.DataListado.TabIndex = 49;
            this.DataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListado_CellContentClick);
            this.DataListado.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataListado_CellMouseClick);
            this.DataListado.DoubleClick += new System.EventHandler(this.DataListado_DoubleClick);
            // 
            // Eliminar1
            // 
            this.Eliminar1.HeaderText = "Eliminar";
            this.Eliminar1.Name = "Eliminar1";
            this.Eliminar1.ReadOnly = true;
            this.Eliminar1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar1.Width = 60;
            // 
            // tablista
            // 
            this.tablista.Controls.Add(this.label1);
            this.tablista.Controls.Add(this.txtTelefono);
            this.tablista.Controls.Add(this.lbltelefono);
            this.tablista.Controls.Add(this.txtIdProveedor);
            this.tablista.Controls.Add(this.btnEditar);
            this.tablista.Controls.Add(this.btnNuevo);
            this.tablista.Controls.Add(this.btnCancelar);
            this.tablista.Controls.Add(this.btnGuardar);
            this.tablista.Controls.Add(this.txt2Apellido);
            this.tablista.Controls.Add(this.txt1Apellido);
            this.tablista.Controls.Add(this.txt2Nombre);
            this.tablista.Controls.Add(this.txt1Nombre);
            this.tablista.Controls.Add(this.lblsegapellido);
            this.tablista.Controls.Add(this.lblprimerapellido);
            this.tablista.Controls.Add(this.lblsegundonombre);
            this.tablista.Controls.Add(this.lblNombre);
            this.tablista.Controls.Add(this.gradColor1);
            this.tablista.Location = new System.Drawing.Point(4, 25);
            this.tablista.Name = "tablista";
            this.tablista.Padding = new System.Windows.Forms.Padding(3);
            this.tablista.Size = new System.Drawing.Size(1113, 455);
            this.tablista.TabIndex = 1;
            this.tablista.Text = "Agregar Proveedor";
            this.tablista.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 131;
            this.label1.Text = "Id_Proveedor";
            this.label1.Visible = false;
            // 
            // lbltipo_documento
            // 
            this.lbltipo_documento.AutoSize = true;
            this.lbltipo_documento.Location = new System.Drawing.Point(46, 172);
            this.lbltipo_documento.Name = "lbltipo_documento";
            this.lbltipo_documento.Size = new System.Drawing.Size(116, 17);
            this.lbltipo_documento.TabIndex = 129;
            this.lbltipo_documento.Text = "Tipo Documento:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(746, 50);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(167, 23);
            this.txtTelefono.TabIndex = 126;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(645, 53);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(80, 17);
            this.lbltelefono.TabIndex = 125;
            this.lbltelefono.Text = "Telefono 1:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(183, 216);
            this.txtcorreo.MaxLength = 25;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(520, 23);
            this.txtcorreo.TabIndex = 124;
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(107, 219);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(55, 17);
            this.lblcorreo.TabIndex = 123;
            this.lblcorreo.Text = "Correo:";
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(536, 169);
            this.txtruc.MaxLength = 14;
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(167, 23);
            this.txtruc.TabIndex = 122;
            // 
            // lblruc
            // 
            this.lblruc.AutoSize = true;
            this.lblruc.Location = new System.Drawing.Point(411, 175);
            this.lblruc.Name = "lblruc";
            this.lblruc.Size = new System.Drawing.Size(104, 17);
            this.lblruc.TabIndex = 121;
            this.lblruc.Text = "N° Documento:";
            // 
            // txtsectorcomercial
            // 
            this.txtsectorcomercial.Location = new System.Drawing.Point(536, 122);
            this.txtsectorcomercial.MaxLength = 25;
            this.txtsectorcomercial.Name = "txtsectorcomercial";
            this.txtsectorcomercial.Size = new System.Drawing.Size(167, 23);
            this.txtsectorcomercial.TabIndex = 120;
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(6, 36);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(167, 23);
            this.txtIdProveedor.TabIndex = 118;
            this.txtIdProveedor.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(612, 396);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 53);
            this.btnEditar.TabIndex = 117;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(473, 397);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(57, 53);
            this.btnNuevo.TabIndex = 116;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(675, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(76, 53);
            this.btnCancelar.TabIndex = 115;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(535, 397);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(71, 53);
            this.btnGuardar.TabIndex = 114;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(183, 262);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(520, 73);
            this.txtDireccion.TabIndex = 104;
            // 
            // txt2Apellido
            // 
            this.txt2Apellido.Location = new System.Drawing.Point(746, 94);
            this.txt2Apellido.MaxLength = 8;
            this.txt2Apellido.Name = "txt2Apellido";
            this.txt2Apellido.Size = new System.Drawing.Size(167, 23);
            this.txt2Apellido.TabIndex = 102;
            // 
            // txt1Apellido
            // 
            this.txt1Apellido.Location = new System.Drawing.Point(393, 139);
            this.txt1Apellido.Name = "txt1Apellido";
            this.txt1Apellido.Size = new System.Drawing.Size(167, 23);
            this.txt1Apellido.TabIndex = 101;
            // 
            // txt2Nombre
            // 
            this.txt2Nombre.Location = new System.Drawing.Point(393, 94);
            this.txt2Nombre.Name = "txt2Nombre";
            this.txt2Nombre.Size = new System.Drawing.Size(167, 23);
            this.txt2Nombre.TabIndex = 100;
            // 
            // txt1Nombre
            // 
            this.txt1Nombre.Location = new System.Drawing.Point(393, 50);
            this.txt1Nombre.Name = "txt1Nombre";
            this.txt1Nombre.Size = new System.Drawing.Size(167, 23);
            this.txt1Nombre.TabIndex = 99;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(95, 262);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(71, 17);
            this.lbldireccion.TabIndex = 96;
            this.lbldireccion.Text = "Direccion:";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(396, 125);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(119, 17);
            this.lblsexo.TabIndex = 95;
            this.lblsexo.Text = "Sector Comercial:";
            // 
            // lblsegapellido
            // 
            this.lblsegapellido.AutoSize = true;
            this.lblsegapellido.Location = new System.Drawing.Point(645, 97);
            this.lblsegapellido.Name = "lblsegapellido";
            this.lblsegapellido.Size = new System.Drawing.Size(80, 17);
            this.lblsegapellido.TabIndex = 94;
            this.lblsegapellido.Text = "Telefono 2:";
            // 
            // lblprimerapellido
            // 
            this.lblprimerapellido.AutoSize = true;
            this.lblprimerapellido.Location = new System.Drawing.Point(247, 142);
            this.lblprimerapellido.Name = "lblprimerapellido";
            this.lblprimerapellido.Size = new System.Drawing.Size(129, 17);
            this.lblprimerapellido.TabIndex = 93;
            this.lblprimerapellido.Text = "Apellidos Contacto:";
            // 
            // lblsegundonombre
            // 
            this.lblsegundonombre.AutoSize = true;
            this.lblsegundonombre.Location = new System.Drawing.Point(247, 97);
            this.lblsegundonombre.Name = "lblsegundonombre";
            this.lblsegundonombre.Size = new System.Drawing.Size(129, 17);
            this.lblsegundonombre.TabIndex = 92;
            this.lblsegundonombre.Text = "Nombres Contacto:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(219, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(157, 17);
            this.lblNombre.TabIndex = 91;
            this.lblNombre.Text = "Nombre de la Empresa:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Black;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1109, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 30);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.ttmensaje.SetToolTip(this.btnCerrar, "Cerrar Ventana");
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 33);
            this.panel1.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 31);
            this.label2.TabIndex = 61;
            this.label2.Text = "Proveedores";
            // 
            // gradColor1
            // 
            this.gradColor1.Angle = 0F;
            this.gradColor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradColor1.Controls.Add(this.cbDocumento);
            this.gradColor1.Controls.Add(this.txtsectorcomercial);
            this.gradColor1.Controls.Add(this.lbltipo_documento);
            this.gradColor1.Controls.Add(this.txtruc);
            this.gradColor1.Controls.Add(this.lblruc);
            this.gradColor1.Controls.Add(this.txtcorreo);
            this.gradColor1.Controls.Add(this.lblsexo);
            this.gradColor1.Controls.Add(this.lblcorreo);
            this.gradColor1.Controls.Add(this.txtDireccion);
            this.gradColor1.Controls.Add(this.lbldireccion);
            this.gradColor1.GradColorBottom = System.Drawing.Color.Empty;
            this.gradColor1.GradColorTop = System.Drawing.Color.Empty;
            this.gradColor1.Location = new System.Drawing.Point(209, 16);
            this.gradColor1.Name = "gradColor1";
            this.gradColor1.Size = new System.Drawing.Size(764, 353);
            this.gradColor1.TabIndex = 132;
            // 
            // cbDocumento
            // 
            this.cbDocumento.FormattingEnabled = true;
            this.cbDocumento.Items.AddRange(new object[] {
            "RUC\t",
            "CEDULA",
            "PASAPORTE"});
            this.cbDocumento.Location = new System.Drawing.Point(183, 169);
            this.cbDocumento.Name = "cbDocumento";
            this.cbDocumento.Size = new System.Drawing.Size(167, 24);
            this.cbDocumento.TabIndex = 131;
            // 
            // FormProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabcliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.FormProveedor_Load);
            this.tabcliente.ResumeLayout(false);
            this.tabnuevocliente.ResumeLayout(false);
            this.tabnuevocliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            this.tablista.ResumeLayout(false);
            this.tablista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gradColor1.ResumeLayout(false);
            this.gradColor1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabcliente;
        private System.Windows.Forms.TabPage tabnuevocliente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView DataListado;
        private System.Windows.Forms.TabPage tablista;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Label lblruc;
        private System.Windows.Forms.TextBox txtsectorcomercial;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txt2Apellido;
        private System.Windows.Forms.TextBox txt1Apellido;
        private System.Windows.Forms.TextBox txt2Nombre;
        private System.Windows.Forms.TextBox txt1Nombre;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lblsexo;
        private System.Windows.Forms.Label lblsegapellido;
        private System.Windows.Forms.Label lblprimerapellido;
        private System.Windows.Forms.Label lblsegundonombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lbltipo_documento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label lblBuscar;
        private GradColor gradColor1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar1;
        private System.Windows.Forms.ComboBox cbDocumento;

    }
}