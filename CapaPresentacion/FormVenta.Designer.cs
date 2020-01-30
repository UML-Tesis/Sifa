namespace CapaPresentacion
{
    partial class FormVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            this.tabventa = new System.Windows.Forms.TabControl();
            this.tablistaventa = new System.Windows.Forms.TabPage();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.lblidcliente = new System.Windows.Forms.Label();
            this.lblidempleado = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblserie = new System.Windows.Forms.Label();
            this.txtfechaora = new System.Windows.Forms.TextBox();
            this.lblfechaora = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dataventa = new System.Windows.Forms.DataGridView();
            this.tabventa.SuspendLayout();
            this.tablistaventa.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataventa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabventa
            // 
            this.tabventa.Controls.Add(this.tablistaventa);
            this.tabventa.Controls.Add(this.tabPage2);
            this.tabventa.Location = new System.Drawing.Point(12, 12);
            this.tabventa.Name = "tabventa";
            this.tabventa.SelectedIndex = 0;
            this.tabventa.Size = new System.Drawing.Size(781, 408);
            this.tabventa.TabIndex = 1;
            // 
            // tablistaventa
            // 
            this.tablistaventa.Controls.Add(this.txtidcliente);
            this.tablistaventa.Controls.Add(this.txtidempleado);
            this.tablistaventa.Controls.Add(this.txtIVA);
            this.tablistaventa.Controls.Add(this.txtserie);
            this.tablistaventa.Controls.Add(this.lblidcliente);
            this.tablistaventa.Controls.Add(this.lblidempleado);
            this.tablistaventa.Controls.Add(this.lblIVA);
            this.tablistaventa.Controls.Add(this.lblserie);
            this.tablistaventa.Controls.Add(this.txtfechaora);
            this.tablistaventa.Controls.Add(this.lblfechaora);
            this.tablistaventa.Controls.Add(this.btnGuardar);
            this.tablistaventa.Controls.Add(this.btnSalir);
            this.tablistaventa.Location = new System.Drawing.Point(4, 22);
            this.tablistaventa.Name = "tablistaventa";
            this.tablistaventa.Padding = new System.Windows.Forms.Padding(3);
            this.tablistaventa.Size = new System.Drawing.Size(773, 382);
            this.tablistaventa.TabIndex = 0;
            this.tablistaventa.Text = "Nueva Venta";
            this.tablistaventa.UseVisualStyleBackColor = true;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(518, 118);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(100, 20);
            this.txtidcliente.TabIndex = 43;
            // 
            // txtidempleado
            // 
            this.txtidempleado.Location = new System.Drawing.Point(518, 73);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(100, 20);
            this.txtidempleado.TabIndex = 42;
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(518, 17);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(100, 20);
            this.txtIVA.TabIndex = 41;
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(102, 92);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(108, 20);
            this.txtserie.TabIndex = 40;
            // 
            // lblidcliente
            // 
            this.lblidcliente.AutoSize = true;
            this.lblidcliente.Location = new System.Drawing.Point(401, 125);
            this.lblidcliente.Name = "lblidcliente";
            this.lblidcliente.Size = new System.Drawing.Size(54, 13);
            this.lblidcliente.TabIndex = 39;
            this.lblidcliente.Text = "Id_Cliente";
            // 
            // lblidempleado
            // 
            this.lblidempleado.AutoSize = true;
            this.lblidempleado.Location = new System.Drawing.Point(401, 73);
            this.lblidempleado.Name = "lblidempleado";
            this.lblidempleado.Size = new System.Drawing.Size(69, 13);
            this.lblidempleado.TabIndex = 38;
            this.lblidempleado.Text = "Id_Empleado";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(401, 20);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(24, 13);
            this.lblIVA.TabIndex = 37;
            this.lblIVA.Text = "IVA";
            this.lblIVA.Click += new System.EventHandler(this.lblcantidad_Click);
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Location = new System.Drawing.Point(15, 95);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(31, 13);
            this.lblserie.TabIndex = 36;
            this.lblserie.Text = "Serie";
            // 
            // txtfechaora
            // 
            this.txtfechaora.Location = new System.Drawing.Point(112, 20);
            this.txtfechaora.Name = "txtfechaora";
            this.txtfechaora.Size = new System.Drawing.Size(182, 20);
            this.txtfechaora.TabIndex = 35;
            // 
            // lblfechaora
            // 
            this.lblfechaora.AutoSize = true;
            this.lblfechaora.Location = new System.Drawing.Point(15, 24);
            this.lblfechaora.Name = "lblfechaora";
            this.lblfechaora.Size = new System.Drawing.Size(66, 13);
            this.lblfechaora.TabIndex = 34;
            this.lblfechaora.Text = "Fecha_Hora";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(664, 313);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(54, 56);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(736, 313);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(28, 40);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnimprimir);
            this.tabPage2.Controls.Add(this.txtBuscar);
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.dataventa);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(773, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista de detalle de venta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // btnimprimir
            // 
            this.btnimprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnimprimir.FlatAppearance.BorderSize = 0;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnimprimir.Location = new System.Drawing.Point(557, 57);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(52, 51);
            this.btnimprimir.TabIndex = 61;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(15, 73);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(232, 20);
            this.txtBuscar.TabIndex = 62;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(474, 57);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(52, 51);
            this.btnEliminar.TabIndex = 60;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(395, 52);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(55, 56);
            this.btnEditar.TabIndex = 59;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.White;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(306, 52);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(58, 56);
            this.btnNuevo.TabIndex = 58;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // dataventa
            // 
            this.dataventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataventa.Location = new System.Drawing.Point(15, 129);
            this.dataventa.Name = "dataventa";
            this.dataventa.Size = new System.Drawing.Size(673, 219);
            this.dataventa.TabIndex = 0;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 426);
            this.Controls.Add(this.tabventa);
            this.Name = "FormVenta";
            this.Text = "Venta";
            this.tabventa.ResumeLayout(false);
            this.tablistaventa.ResumeLayout(false);
            this.tablistaventa.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataventa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabventa;
        private System.Windows.Forms.TabPage tablistaventa;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtidempleado;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Label lblidcliente;
        private System.Windows.Forms.Label lblidempleado;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label lblserie;
        private System.Windows.Forms.TextBox txtfechaora;
        private System.Windows.Forms.Label lblfechaora;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dataventa;
    }
}