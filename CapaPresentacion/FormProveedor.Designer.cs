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
            this.tabcliente = new System.Windows.Forms.TabControl();
            this.tabnuevocliente = new System.Windows.Forms.TabPage();
            this.checkEliminar = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.DataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tablista = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txttipodocumento = new System.Windows.Forms.TextBox();
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
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
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
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabcliente.SuspendLayout();
            this.tabnuevocliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            this.tablista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcliente
            // 
            this.tabcliente.Controls.Add(this.tabnuevocliente);
            this.tabcliente.Controls.Add(this.tablista);
            this.tabcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabcliente.Location = new System.Drawing.Point(21, 82);
            this.tabcliente.Name = "tabcliente";
            this.tabcliente.SelectedIndex = 0;
            this.tabcliente.Size = new System.Drawing.Size(930, 317);
            this.tabcliente.TabIndex = 60;
            // 
            // tabnuevocliente
            // 
            this.tabnuevocliente.Controls.Add(this.checkEliminar);
            this.tabnuevocliente.Controls.Add(this.btnEliminar);
            this.tabnuevocliente.Controls.Add(this.btnImprimir);
            this.tabnuevocliente.Controls.Add(this.txtBuscar);
            this.tabnuevocliente.Controls.Add(this.DataListado);
            this.tabnuevocliente.Location = new System.Drawing.Point(4, 24);
            this.tabnuevocliente.Name = "tabnuevocliente";
            this.tabnuevocliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabnuevocliente.Size = new System.Drawing.Size(922, 289);
            this.tabnuevocliente.TabIndex = 0;
            this.tabnuevocliente.Text = "Lista Proveedor";
            this.tabnuevocliente.UseVisualStyleBackColor = true;
            // 
            // checkEliminar
            // 
            this.checkEliminar.AutoSize = true;
            this.checkEliminar.Location = new System.Drawing.Point(7, 42);
            this.checkEliminar.Name = "checkEliminar";
            this.checkEliminar.Size = new System.Drawing.Size(72, 19);
            this.checkEliminar.TabIndex = 53;
            this.checkEliminar.Text = "Eliminar";
            this.checkEliminar.UseVisualStyleBackColor = true;
            this.checkEliminar.CheckedChanged += new System.EventHandler(this.checkEliminar_CheckedChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(784, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 50);
            this.btnEliminar.TabIndex = 52;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(852, 0);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(61, 50);
            this.btnImprimir.TabIndex = 50;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(417, 23);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(361, 20);
            this.txtBuscar.TabIndex = 51;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataListado.ColumnHeadersHeight = 25;
            this.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar1});
            this.DataListado.EnableHeadersVisualStyles = false;
            this.DataListado.Location = new System.Drawing.Point(6, 76);
            this.DataListado.MultiSelect = false;
            this.DataListado.Name = "DataListado";
            this.DataListado.ReadOnly = true;
            this.DataListado.RowHeadersVisible = false;
            this.DataListado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataListado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListado.Size = new System.Drawing.Size(907, 211);
            this.DataListado.TabIndex = 49;
            this.DataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListado_CellContentClick);
            // 
            // Eliminar1
            // 
            this.Eliminar1.HeaderText = "Eliminar";
            this.Eliminar1.Name = "Eliminar1";
            this.Eliminar1.ReadOnly = true;
            this.Eliminar1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tablista
            // 
            this.tablista.Controls.Add(this.label1);
            this.tablista.Controls.Add(this.txttipodocumento);
            this.tablista.Controls.Add(this.lbltipo_documento);
            this.tablista.Controls.Add(this.txtTelefono);
            this.tablista.Controls.Add(this.lbltelefono);
            this.tablista.Controls.Add(this.txtcorreo);
            this.tablista.Controls.Add(this.lblcorreo);
            this.tablista.Controls.Add(this.txtruc);
            this.tablista.Controls.Add(this.lblruc);
            this.tablista.Controls.Add(this.txtsectorcomercial);
            this.tablista.Controls.Add(this.txtIdProveedor);
            this.tablista.Controls.Add(this.btnEditar);
            this.tablista.Controls.Add(this.btnNuevo);
            this.tablista.Controls.Add(this.btnCancelar);
            this.tablista.Controls.Add(this.btnGuardar);
            this.tablista.Controls.Add(this.txtempresa);
            this.tablista.Controls.Add(this.lblMonto);
            this.tablista.Controls.Add(this.txtDireccion);
            this.tablista.Controls.Add(this.txt2Apellido);
            this.tablista.Controls.Add(this.txt1Apellido);
            this.tablista.Controls.Add(this.txt2Nombre);
            this.tablista.Controls.Add(this.txt1Nombre);
            this.tablista.Controls.Add(this.lbldireccion);
            this.tablista.Controls.Add(this.lblsexo);
            this.tablista.Controls.Add(this.lblsegapellido);
            this.tablista.Controls.Add(this.lblprimerapellido);
            this.tablista.Controls.Add(this.lblsegundonombre);
            this.tablista.Controls.Add(this.lblNombre);
            this.tablista.Location = new System.Drawing.Point(4, 22);
            this.tablista.Name = "tablista";
            this.tablista.Padding = new System.Windows.Forms.Padding(3);
            this.tablista.Size = new System.Drawing.Size(855, 417);
            this.tablista.TabIndex = 1;
            this.tablista.Text = "Nuevo Proveedor";
            this.tablista.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 131;
            this.label1.Text = "Id_Proveedor";
            // 
            // txttipodocumento
            // 
            this.txttipodocumento.Location = new System.Drawing.Point(596, 19);
            this.txttipodocumento.MaxLength = 6;
            this.txttipodocumento.Name = "txttipodocumento";
            this.txttipodocumento.Size = new System.Drawing.Size(167, 21);
            this.txttipodocumento.TabIndex = 130;
            // 
            // lbltipo_documento
            // 
            this.lbltipo_documento.AutoSize = true;
            this.lbltipo_documento.Location = new System.Drawing.Point(487, 22);
            this.lbltipo_documento.Name = "lbltipo_documento";
            this.lbltipo_documento.Size = new System.Drawing.Size(102, 15);
            this.lbltipo_documento.TabIndex = 129;
            this.lbltipo_documento.Text = "Tipo_Documento";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(180, 211);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(167, 21);
            this.txtTelefono.TabIndex = 126;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(114, 214);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(55, 15);
            this.lbltelefono.TabIndex = 125;
            this.lbltelefono.Text = "Telefono";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(596, 195);
            this.txtcorreo.MaxLength = 6;
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(167, 21);
            this.txtcorreo.TabIndex = 124;
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(538, 198);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(44, 15);
            this.lblcorreo.TabIndex = 123;
            this.lblcorreo.Text = "Correo";
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(596, 233);
            this.txtruc.MaxLength = 6;
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(167, 21);
            this.txtruc.TabIndex = 122;
            // 
            // lblruc
            // 
            this.lblruc.AutoSize = true;
            this.lblruc.Location = new System.Drawing.Point(546, 236);
            this.lblruc.Name = "lblruc";
            this.lblruc.Size = new System.Drawing.Size(33, 15);
            this.lblruc.TabIndex = 121;
            this.lblruc.Text = "RUC";
            // 
            // txtsectorcomercial
            // 
            this.txtsectorcomercial.Location = new System.Drawing.Point(596, 54);
            this.txtsectorcomercial.MaxLength = 8;
            this.txtsectorcomercial.Name = "txtsectorcomercial";
            this.txtsectorcomercial.Size = new System.Drawing.Size(167, 21);
            this.txtsectorcomercial.TabIndex = 120;
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(180, 19);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(167, 21);
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
            this.btnEditar.Location = new System.Drawing.Point(430, 306);
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
            this.btnNuevo.Location = new System.Drawing.Point(316, 306);
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
            this.btnCancelar.Location = new System.Drawing.Point(487, 306);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 53);
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
            this.btnGuardar.Location = new System.Drawing.Point(373, 306);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(57, 53);
            this.btnGuardar.TabIndex = 114;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtempresa
            // 
            this.txtempresa.Location = new System.Drawing.Point(596, 92);
            this.txtempresa.MaxLength = 6;
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.Size = new System.Drawing.Size(167, 21);
            this.txtempresa.TabIndex = 112;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(528, 95);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(57, 15);
            this.lblMonto.TabIndex = 111;
            this.lblMonto.Text = "Empresa";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(596, 131);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(167, 45);
            this.txtDireccion.TabIndex = 104;
            // 
            // txt2Apellido
            // 
            this.txt2Apellido.Location = new System.Drawing.Point(180, 171);
            this.txt2Apellido.Name = "txt2Apellido";
            this.txt2Apellido.Size = new System.Drawing.Size(167, 21);
            this.txt2Apellido.TabIndex = 102;
            // 
            // txt1Apellido
            // 
            this.txt1Apellido.Location = new System.Drawing.Point(180, 131);
            this.txt1Apellido.Name = "txt1Apellido";
            this.txt1Apellido.Size = new System.Drawing.Size(167, 21);
            this.txt1Apellido.TabIndex = 101;
            // 
            // txt2Nombre
            // 
            this.txt2Nombre.Location = new System.Drawing.Point(180, 92);
            this.txt2Nombre.Name = "txt2Nombre";
            this.txt2Nombre.Size = new System.Drawing.Size(167, 21);
            this.txt2Nombre.TabIndex = 100;
            // 
            // txt1Nombre
            // 
            this.txt1Nombre.Location = new System.Drawing.Point(180, 54);
            this.txt1Nombre.Name = "txt1Nombre";
            this.txt1Nombre.Size = new System.Drawing.Size(167, 21);
            this.txt1Nombre.TabIndex = 99;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(524, 134);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(59, 15);
            this.lbldireccion.TabIndex = 96;
            this.lbldireccion.Text = "Direccion";
            // 
            // lblsexo
            // 
            this.lblsexo.AutoSize = true;
            this.lblsexo.Location = new System.Drawing.Point(486, 58);
            this.lblsexo.Name = "lblsexo";
            this.lblsexo.Size = new System.Drawing.Size(105, 15);
            this.lblsexo.TabIndex = 95;
            this.lblsexo.Text = "Sector_Comercial";
            // 
            // lblsegapellido
            // 
            this.lblsegapellido.AutoSize = true;
            this.lblsegapellido.Location = new System.Drawing.Point(70, 174);
            this.lblsegapellido.Name = "lblsegapellido";
            this.lblsegapellido.Size = new System.Drawing.Size(108, 15);
            this.lblsegapellido.TabIndex = 94;
            this.lblsegapellido.Text = "Segundo_Apellido";
            // 
            // lblprimerapellido
            // 
            this.lblprimerapellido.AutoSize = true;
            this.lblprimerapellido.Location = new System.Drawing.Point(84, 134);
            this.lblprimerapellido.Name = "lblprimerapellido";
            this.lblprimerapellido.Size = new System.Drawing.Size(95, 15);
            this.lblprimerapellido.TabIndex = 93;
            this.lblprimerapellido.Text = "Primer_Apellido";
            // 
            // lblsegundonombre
            // 
            this.lblsegundonombre.AutoSize = true;
            this.lblsegundonombre.Location = new System.Drawing.Point(70, 95);
            this.lblsegundonombre.Name = "lblsegundonombre";
            this.lblsegundonombre.Size = new System.Drawing.Size(109, 15);
            this.lblsegundonombre.TabIndex = 92;
            this.lblsegundonombre.Text = "Segundo_Nombre";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(84, 61);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(96, 15);
            this.lblNombre.TabIndex = 91;
            this.lblNombre.Text = "Primer_Nombre";
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
            this.panel1.Size = new System.Drawing.Size(975, 33);
            this.panel1.TabIndex = 62;
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
            this.btnCerrar.Location = new System.Drawing.Point(939, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 30);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.ttmensaje.SetToolTip(this.btnCerrar, "Cerrar Ventana");
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 31);
            this.label2.TabIndex = 61;
            this.label2.Text = "Productos";
            // 
            // FormProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 414);
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
        private System.Windows.Forms.TextBox txtempresa;
        private System.Windows.Forms.Label lblMonto;
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
        private System.Windows.Forms.TextBox txttipodocumento;
        private System.Windows.Forms.Label lbltipo_documento;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkEliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;

    }
}