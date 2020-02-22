namespace CapaPresentacion
{
    partial class FormCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabCompra = new System.Windows.Forms.TabControl();
            this.tabnuevacopra = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.checkAnular = new System.Windows.Forms.CheckBox();
            this.btnBuscarXFecha = new System.Windows.Forms.Button();
            this.dtFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtFecha1 = new System.Windows.Forms.DateTimePicker();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.DataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tablista = new System.Windows.Forms.TabPage();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtIdCompra = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCorrelativo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataListadoDetalles = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio_Venta = new System.Windows.Forms.TextBox();
            this.txtPrecio_Compra = new System.Windows.Forms.TextBox();
            this.btnProducto = new System.Windows.Forms.Button();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.ttmensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabCompra.SuspendLayout();
            this.tabnuevacopra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).BeginInit();
            this.tablista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCompra
            // 
            this.tabCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabCompra.Controls.Add(this.tabnuevacopra);
            this.tabCompra.Controls.Add(this.tablista);
            this.tabCompra.Location = new System.Drawing.Point(12, 95);
            this.tabCompra.Name = "tabCompra";
            this.tabCompra.SelectedIndex = 0;
            this.tabCompra.Size = new System.Drawing.Size(847, 588);
            this.tabCompra.TabIndex = 0;
            // 
            // tabnuevacopra
            // 
            this.tabnuevacopra.BackColor = System.Drawing.Color.White;
            this.tabnuevacopra.Controls.Add(this.label13);
            this.tabnuevacopra.Controls.Add(this.label2);
            this.tabnuevacopra.Controls.Add(this.label1);
            this.tabnuevacopra.Controls.Add(this.btnAnular);
            this.tabnuevacopra.Controls.Add(this.checkAnular);
            this.tabnuevacopra.Controls.Add(this.btnBuscarXFecha);
            this.tabnuevacopra.Controls.Add(this.dtFecha2);
            this.tabnuevacopra.Controls.Add(this.dtFecha1);
            this.tabnuevacopra.Controls.Add(this.btnImprimir);
            this.tabnuevacopra.Controls.Add(this.DataListado);
            this.tabnuevacopra.Location = new System.Drawing.Point(4, 22);
            this.tabnuevacopra.Name = "tabnuevacopra";
            this.tabnuevacopra.Padding = new System.Windows.Forms.Padding(3);
            this.tabnuevacopra.Size = new System.Drawing.Size(839, 562);
            this.tabnuevacopra.TabIndex = 0;
            this.tabnuevacopra.Text = "Listado                         ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Desde:";
            // 
            // btnAnular
            // 
            this.btnAnular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.Image")));
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAnular.Location = new System.Drawing.Point(700, 16);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(65, 50);
            this.btnAnular.TabIndex = 73;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // checkAnular
            // 
            this.checkAnular.AutoSize = true;
            this.checkAnular.Location = new System.Drawing.Point(8, 49);
            this.checkAnular.Name = "checkAnular";
            this.checkAnular.Size = new System.Drawing.Size(56, 17);
            this.checkAnular.TabIndex = 72;
            this.checkAnular.Text = "Anular";
            this.checkAnular.UseVisualStyleBackColor = true;
            this.checkAnular.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnBuscarXFecha
            // 
            this.btnBuscarXFecha.Location = new System.Drawing.Point(636, 42);
            this.btnBuscarXFecha.Name = "btnBuscarXFecha";
            this.btnBuscarXFecha.Size = new System.Drawing.Size(29, 20);
            this.btnBuscarXFecha.TabIndex = 71;
            this.btnBuscarXFecha.Text = "B";
            this.btnBuscarXFecha.UseVisualStyleBackColor = true;
            this.btnBuscarXFecha.Click += new System.EventHandler(this.btnBuscarXFecha_Click);
            // 
            // dtFecha2
            // 
            this.dtFecha2.CustomFormat = "dd/MM/yyyy";
            this.dtFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha2.Location = new System.Drawing.Point(515, 42);
            this.dtFecha2.Name = "dtFecha2";
            this.dtFecha2.Size = new System.Drawing.Size(101, 20);
            this.dtFecha2.TabIndex = 70;
            this.dtFecha2.Value = new System.DateTime(2020, 1, 6, 0, 0, 0, 0);
            // 
            // dtFecha1
            // 
            this.dtFecha1.CustomFormat = "dd/MM/yyyy";
            this.dtFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha1.Location = new System.Drawing.Point(332, 42);
            this.dtFecha1.Name = "dtFecha1";
            this.dtFecha1.Size = new System.Drawing.Size(101, 20);
            this.dtFecha1.TabIndex = 69;
            this.dtFecha1.Value = new System.DateTime(2020, 1, 6, 0, 0, 0, 0);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(771, 16);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(61, 50);
            this.btnImprimir.TabIndex = 41;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar1});
            this.DataListado.GridColor = System.Drawing.Color.Black;
            this.DataListado.Location = new System.Drawing.Point(6, 86);
            this.DataListado.Name = "DataListado";
            this.DataListado.ReadOnly = true;
            this.DataListado.RowHeadersVisible = false;
            this.DataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataListado.ShowEditingIcon = false;
            this.DataListado.Size = new System.Drawing.Size(826, 466);
            this.DataListado.TabIndex = 40;
            this.DataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataListado_CellContentClick);
            this.DataListado.DoubleClick += new System.EventHandler(this.DataListado_DoubleClick);
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
            this.tablista.Controls.Add(this.btnQuitar);
            this.tablista.Controls.Add(this.btnNuevo);
            this.tablista.Controls.Add(this.txtIdCompra);
            this.tablista.Controls.Add(this.btnCancelar);
            this.tablista.Controls.Add(this.btnGuardar);
            this.tablista.Controls.Add(this.btnAgregar);
            this.tablista.Controls.Add(this.label11);
            this.tablista.Controls.Add(this.dateTimePicker2);
            this.tablista.Controls.Add(this.label10);
            this.tablista.Controls.Add(this.txtCorrelativo);
            this.tablista.Controls.Add(this.label9);
            this.tablista.Controls.Add(this.txtIva);
            this.tablista.Controls.Add(this.label7);
            this.tablista.Controls.Add(this.txtFactura);
            this.tablista.Controls.Add(this.label8);
            this.tablista.Controls.Add(this.lblTotal);
            this.tablista.Controls.Add(this.dataListadoDetalles);
            this.tablista.Controls.Add(this.label6);
            this.tablista.Controls.Add(this.txtCantidad);
            this.tablista.Controls.Add(this.label5);
            this.tablista.Controls.Add(this.label4);
            this.tablista.Controls.Add(this.txtPrecio_Venta);
            this.tablista.Controls.Add(this.txtPrecio_Compra);
            this.tablista.Controls.Add(this.btnProducto);
            this.tablista.Controls.Add(this.txtIdProducto);
            this.tablista.Controls.Add(this.txtNombreProducto);
            this.tablista.Controls.Add(this.label3);
            this.tablista.Controls.Add(this.btnProveedor);
            this.tablista.Controls.Add(this.txtIdProveedor);
            this.tablista.Controls.Add(this.txtNombreProveedor);
            this.tablista.Controls.Add(this.lblCategoria);
            this.tablista.Location = new System.Drawing.Point(4, 22);
            this.tablista.Name = "tablista";
            this.tablista.Padding = new System.Windows.Forms.Padding(3);
            this.tablista.Size = new System.Drawing.Size(839, 562);
            this.tablista.TabIndex = 1;
            this.tablista.Text = "Ingresar Compras            ";
            this.tablista.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(493, 220);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(54, 24);
            this.btnQuitar.TabIndex = 103;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(433, 259);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(54, 24);
            this.btnNuevo.TabIndex = 102;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.Location = new System.Drawing.Point(125, 42);
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Size = new System.Drawing.Size(138, 20);
            this.txtIdCompra.TabIndex = 101;
            this.txtIdCompra.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(613, 259);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 24);
            this.btnCancelar.TabIndex = 100;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(553, 259);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(54, 24);
            this.btnGuardar.TabIndex = 99;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(493, 259);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(54, 24);
            this.btnAgregar.TabIndex = 98;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label11
            // 
            this.label11.AccessibleName = "";
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 15);
            this.label11.TabIndex = 97;
            this.label11.Text = "Correlativo";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(125, 146);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker2.TabIndex = 96;
            // 
            // label10
            // 
            this.label10.AccessibleName = "";
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(69, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 95;
            this.label10.Text = "Fecha";
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.Location = new System.Drawing.Point(125, 172);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.Size = new System.Drawing.Size(138, 20);
            this.txtCorrelativo.TabIndex = 94;
            // 
            // label9
            // 
            this.label9.AccessibleName = "";
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(88, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 93;
            this.label9.Text = "Iva";
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(125, 120);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(138, 20);
            this.txtIva.TabIndex = 92;
            // 
            // label7
            // 
            this.label7.AccessibleName = "";
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(62, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 15);
            this.label7.TabIndex = 91;
            this.label7.Text = "Factura";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(125, 94);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(138, 20);
            this.txtFactura.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(655, 535);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 89;
            this.label8.Text = "Total a Pagar:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(756, 535);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 13);
            this.lblTotal.TabIndex = 88;
            this.lblTotal.Text = "0.00";
            // 
            // dataListadoDetalles
            // 
            this.dataListadoDetalles.AllowUserToAddRows = false;
            this.dataListadoDetalles.AllowUserToDeleteRows = false;
            this.dataListadoDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListadoDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoDetalles.Location = new System.Drawing.Point(6, 289);
            this.dataListadoDetalles.Name = "dataListadoDetalles";
            this.dataListadoDetalles.ReadOnly = true;
            this.dataListadoDetalles.Size = new System.Drawing.Size(827, 233);
            this.dataListadoDetalles.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AccessibleName = "";
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(467, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 86;
            this.label6.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(538, 143);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(138, 20);
            this.txtCantidad.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AccessibleName = "";
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 84;
            this.label5.Text = "Precio de Venta";
            // 
            // label4
            // 
            this.label4.AccessibleName = "";
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 83;
            this.label4.Text = "Precio de Compra";
            // 
            // txtPrecio_Venta
            // 
            this.txtPrecio_Venta.Location = new System.Drawing.Point(538, 117);
            this.txtPrecio_Venta.Name = "txtPrecio_Venta";
            this.txtPrecio_Venta.Size = new System.Drawing.Size(138, 20);
            this.txtPrecio_Venta.TabIndex = 82;
            // 
            // txtPrecio_Compra
            // 
            this.txtPrecio_Compra.Location = new System.Drawing.Point(538, 91);
            this.txtPrecio_Compra.Name = "txtPrecio_Compra";
            this.txtPrecio_Compra.Size = new System.Drawing.Size(138, 20);
            this.txtPrecio_Compra.TabIndex = 81;
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(682, 64);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(30, 20);
            this.btnProducto.TabIndex = 79;
            this.btnProducto.Text = "B";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(731, 64);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(57, 20);
            this.txtIdProducto.TabIndex = 78;
            this.txtIdProducto.Visible = false;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(538, 65);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(138, 20);
            this.txtNombreProducto.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 76;
            this.label3.Text = "Producto";
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(269, 65);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(30, 24);
            this.btnProveedor.TabIndex = 75;
            this.btnProveedor.Text = "B";
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(318, 68);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(57, 20);
            this.txtIdProveedor.TabIndex = 74;
            this.txtIdProveedor.Visible = false;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(125, 68);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(138, 20);
            this.txtNombreProveedor.TabIndex = 73;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AccessibleName = "";
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(47, 69);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(63, 15);
            this.lblCategoria.TabIndex = 72;
            this.lblCategoria.Text = "Proveedor";
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 33);
            this.panel1.TabIndex = 46;
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
            this.btnCerrar.Location = new System.Drawing.Point(835, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 30);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.ttmensaje.SetToolTip(this.btnCerrar, "Cerrar Ventana");
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Crimson;
            this.label12.Location = new System.Drawing.Point(12, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 31);
            this.label12.TabIndex = 45;
            this.label12.Text = "Compras";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(377, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 15);
            this.label13.TabIndex = 76;
            this.label13.Text = "Buscar compras por fechas";
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 695);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tabCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCompra";
            this.Text = "Compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCompra_FormClosing);
            this.Load += new System.EventHandler(this.FormCompra_Load);
            this.tabCompra.ResumeLayout(false);
            this.tabnuevacopra.ResumeLayout(false);
            this.tabnuevacopra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataListado)).EndInit();
            this.tablista.ResumeLayout(false);
            this.tablista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCompra;
        private System.Windows.Forms.TabPage tabnuevacopra;
        private System.Windows.Forms.TabPage tablista;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView DataListado;
        private System.Windows.Forms.Button btnBuscarXFecha;
        private System.Windows.Forms.DateTimePicker dtFecha2;
        private System.Windows.Forms.DateTimePicker dtFecha1;
        private System.Windows.Forms.CheckBox checkAnular;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecio_Venta;
        private System.Windows.Forms.TextBox txtPrecio_Compra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataListadoDetalles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCorrelativo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ToolTip ttmensaje;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtIdCompra;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label12;
    }
}