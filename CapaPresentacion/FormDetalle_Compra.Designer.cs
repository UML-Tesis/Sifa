namespace CapaPresentacion
{
    partial class FormDetalle_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetalle_Compra));
            this.tabdetalle_compra = new System.Windows.Forms.TabControl();
            this.tabdetallecompra = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblpreciocompra = new System.Windows.Forms.Label();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.lblprecioventa = new System.Windows.Forms.Label();
            this.lblstockinicial = new System.Windows.Forms.Label();
            this.lblstockactual = new System.Windows.Forms.Label();
            this.lblfechavencimiento = new System.Windows.Forms.Label();
            this.lblidcompra = new System.Windows.Forms.Label();
            this.lblidproducto = new System.Windows.Forms.Label();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.txtstockinicial = new System.Windows.Forms.TextBox();
            this.txtstockactual = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtidcompra = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tabdetalle_compra.SuspendLayout();
            this.tabdetallecompra.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabdetalle_compra
            // 
            this.tabdetalle_compra.Controls.Add(this.tabdetallecompra);
            this.tabdetalle_compra.Controls.Add(this.tabPage2);
            this.tabdetalle_compra.Location = new System.Drawing.Point(12, 41);
            this.tabdetalle_compra.Name = "tabdetalle_compra";
            this.tabdetalle_compra.SelectedIndex = 0;
            this.tabdetalle_compra.Size = new System.Drawing.Size(762, 415);
            this.tabdetalle_compra.TabIndex = 0;
            // 
            // tabdetallecompra
            // 
            this.tabdetallecompra.Controls.Add(this.btnGuardar);
            this.tabdetallecompra.Controls.Add(this.btnSalir);
            this.tabdetallecompra.Controls.Add(this.textBox7);
            this.tabdetallecompra.Controls.Add(this.txtidcompra);
            this.tabdetallecompra.Controls.Add(this.textBox5);
            this.tabdetallecompra.Controls.Add(this.txtstockactual);
            this.tabdetallecompra.Controls.Add(this.txtstockinicial);
            this.tabdetallecompra.Controls.Add(this.txtprecioventa);
            this.tabdetallecompra.Controls.Add(this.lblidproducto);
            this.tabdetallecompra.Controls.Add(this.lblidcompra);
            this.tabdetallecompra.Controls.Add(this.lblfechavencimiento);
            this.tabdetallecompra.Controls.Add(this.lblstockactual);
            this.tabdetallecompra.Controls.Add(this.lblstockinicial);
            this.tabdetallecompra.Controls.Add(this.lblprecioventa);
            this.tabdetallecompra.Controls.Add(this.txtpreciocompra);
            this.tabdetallecompra.Controls.Add(this.lblpreciocompra);
            this.tabdetallecompra.Location = new System.Drawing.Point(4, 22);
            this.tabdetallecompra.Name = "tabdetallecompra";
            this.tabdetallecompra.Padding = new System.Windows.Forms.Padding(3);
            this.tabdetallecompra.Size = new System.Drawing.Size(754, 389);
            this.tabdetallecompra.TabIndex = 0;
            this.tabdetallecompra.Text = "Detalle de Compra";
            this.tabdetallecompra.UseVisualStyleBackColor = true;
            this.tabdetallecompra.Click += new System.EventHandler(this.tabdetallecompra_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.btnimprimir);
            this.tabPage2.Controls.Add(this.txtBuscar);
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(754, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista detalle de compra";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // btnimprimir
            // 
            this.btnimprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnimprimir.FlatAppearance.BorderSize = 0;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnimprimir.Location = new System.Drawing.Point(575, 42);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(52, 51);
            this.btnimprimir.TabIndex = 55;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(33, 58);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(232, 20);
            this.txtBuscar.TabIndex = 56;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(492, 42);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(52, 51);
            this.btnEliminar.TabIndex = 54;
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
            this.btnEditar.Location = new System.Drawing.Point(413, 37);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(55, 56);
            this.btnEditar.TabIndex = 53;
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
            this.btnNuevo.Location = new System.Drawing.Point(324, 37);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(58, 56);
            this.btnNuevo.TabIndex = 52;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // lblpreciocompra
            // 
            this.lblpreciocompra.AutoSize = true;
            this.lblpreciocompra.Location = new System.Drawing.Point(6, 37);
            this.lblpreciocompra.Name = "lblpreciocompra";
            this.lblpreciocompra.Size = new System.Drawing.Size(79, 13);
            this.lblpreciocompra.TabIndex = 0;
            this.lblpreciocompra.Text = "Precio_Compra";
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(93, 37);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(108, 20);
            this.txtpreciocompra.TabIndex = 1;
            // 
            // lblprecioventa
            // 
            this.lblprecioventa.AutoSize = true;
            this.lblprecioventa.Location = new System.Drawing.Point(6, 108);
            this.lblprecioventa.Name = "lblprecioventa";
            this.lblprecioventa.Size = new System.Drawing.Size(71, 13);
            this.lblprecioventa.TabIndex = 2;
            this.lblprecioventa.Text = "Precio_Venta";
            // 
            // lblstockinicial
            // 
            this.lblstockinicial.AutoSize = true;
            this.lblstockinicial.Location = new System.Drawing.Point(6, 183);
            this.lblstockinicial.Name = "lblstockinicial";
            this.lblstockinicial.Size = new System.Drawing.Size(68, 13);
            this.lblstockinicial.TabIndex = 3;
            this.lblstockinicial.Text = "Stock_Inicial";
            // 
            // lblstockactual
            // 
            this.lblstockactual.AutoSize = true;
            this.lblstockactual.Location = new System.Drawing.Point(392, 33);
            this.lblstockactual.Name = "lblstockactual";
            this.lblstockactual.Size = new System.Drawing.Size(71, 13);
            this.lblstockactual.TabIndex = 4;
            this.lblstockactual.Text = "Stock_Actual";
            // 
            // lblfechavencimiento
            // 
            this.lblfechavencimiento.AutoSize = true;
            this.lblfechavencimiento.Location = new System.Drawing.Point(392, 86);
            this.lblfechavencimiento.Name = "lblfechavencimiento";
            this.lblfechavencimiento.Size = new System.Drawing.Size(101, 13);
            this.lblfechavencimiento.TabIndex = 5;
            this.lblfechavencimiento.Text = "Fecha_Vencimiento";
            // 
            // lblidcompra
            // 
            this.lblidcompra.AutoSize = true;
            this.lblidcompra.Location = new System.Drawing.Point(392, 138);
            this.lblidcompra.Name = "lblidcompra";
            this.lblidcompra.Size = new System.Drawing.Size(57, 13);
            this.lblidcompra.TabIndex = 6;
            this.lblidcompra.Text = "Id_compra";
            // 
            // lblidproducto
            // 
            this.lblidproducto.AutoSize = true;
            this.lblidproducto.Location = new System.Drawing.Point(392, 193);
            this.lblidproducto.Name = "lblidproducto";
            this.lblidproducto.Size = new System.Drawing.Size(65, 13);
            this.lblidproducto.TabIndex = 7;
            this.lblidproducto.Text = "Id_Producto";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(93, 105);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(108, 20);
            this.txtprecioventa.TabIndex = 8;
            // 
            // txtstockinicial
            // 
            this.txtstockinicial.Location = new System.Drawing.Point(93, 176);
            this.txtstockinicial.Name = "txtstockinicial";
            this.txtstockinicial.Size = new System.Drawing.Size(108, 20);
            this.txtstockinicial.TabIndex = 9;
            // 
            // txtstockactual
            // 
            this.txtstockactual.Location = new System.Drawing.Point(509, 26);
            this.txtstockactual.Name = "txtstockactual";
            this.txtstockactual.Size = new System.Drawing.Size(100, 20);
            this.txtstockactual.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(509, 86);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            // 
            // txtidcompra
            // 
            this.txtidcompra.Location = new System.Drawing.Point(509, 131);
            this.txtidcompra.Name = "txtidcompra";
            this.txtidcompra.Size = new System.Drawing.Size(100, 20);
            this.txtidcompra.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(509, 186);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 13;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(709, 327);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(28, 40);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(637, 327);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(54, 56);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // FormDetalle_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 468);
            this.Controls.Add(this.tabdetalle_compra);
            this.Name = "FormDetalle_Compra";
            this.Text = "Detalle de compra";
            this.tabdetalle_compra.ResumeLayout(false);
            this.tabdetallecompra.ResumeLayout(false);
            this.tabdetallecompra.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabdetalle_compra;
        private System.Windows.Forms.TabPage tabdetallecompra;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtidcompra;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtstockactual;
        private System.Windows.Forms.TextBox txtstockinicial;
        private System.Windows.Forms.TextBox txtprecioventa;
        private System.Windows.Forms.Label lblidproducto;
        private System.Windows.Forms.Label lblidcompra;
        private System.Windows.Forms.Label lblfechavencimiento;
        private System.Windows.Forms.Label lblstockactual;
        private System.Windows.Forms.Label lblstockinicial;
        private System.Windows.Forms.Label lblprecioventa;
        private System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.Label lblpreciocompra;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
    }
}