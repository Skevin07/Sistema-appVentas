namespace appVentas.VISTA
{
    partial class frmVentas
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
            this.txtNumeroDeVenta = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.Label();
            this.txtTipoDeDocuemnto = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.Label();
            this.txtNombreDeProducto = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.txtPrecioDelProdcuto = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.textBoxNumeroDeVenta = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxBuscarProducto = new System.Windows.Forms.TextBox();
            this.textBoxidProducto = new System.Windows.Forms.TextBox();
            this.textBoxNombreDeProducto = new System.Windows.Forms.TextBox();
            this.textBoxPrecioDeProducto = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dtvProductos = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxTipoDeDocumento = new System.Windows.Forms.ComboBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotalFinal = new System.Windows.Forms.TextBox();
            this.btnGuardarVenta = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNumeroDeVenta
            // 
            this.txtNumeroDeVenta.AutoSize = true;
            this.txtNumeroDeVenta.Location = new System.Drawing.Point(31, 27);
            this.txtNumeroDeVenta.Name = "txtNumeroDeVenta";
            this.txtNumeroDeVenta.Size = new System.Drawing.Size(89, 13);
            this.txtNumeroDeVenta.TabIndex = 0;
            this.txtNumeroDeVenta.Text = "Numero de venta";
            // 
            // txtCliente
            // 
            this.txtCliente.AutoSize = true;
            this.txtCliente.Location = new System.Drawing.Point(356, 27);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(39, 13);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.Text = "Cliente";
            // 
            // txtTipoDeDocuemnto
            // 
            this.txtTipoDeDocuemnto.AutoSize = true;
            this.txtTipoDeDocuemnto.Location = new System.Drawing.Point(356, 87);
            this.txtTipoDeDocuemnto.Name = "txtTipoDeDocuemnto";
            this.txtTipoDeDocuemnto.Size = new System.Drawing.Size(99, 13);
            this.txtTipoDeDocuemnto.TabIndex = 3;
            this.txtTipoDeDocuemnto.Text = "Tipo de docuemnto";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.AutoSize = true;
            this.txtBuscarProducto.Location = new System.Drawing.Point(31, 182);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(85, 13);
            this.txtBuscarProducto.TabIndex = 5;
            this.txtBuscarProducto.Text = "Buscar producto";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.AutoSize = true;
            this.txtCodigoProducto.Location = new System.Drawing.Point(22, 263);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(86, 13);
            this.txtCodigoProducto.TabIndex = 7;
            this.txtCodigoProducto.Text = "Codigo Producto";
            // 
            // txtNombreDeProducto
            // 
            this.txtNombreDeProducto.AutoSize = true;
            this.txtNombreDeProducto.Location = new System.Drawing.Point(140, 263);
            this.txtNombreDeProducto.Name = "txtNombreDeProducto";
            this.txtNombreDeProducto.Size = new System.Drawing.Size(107, 13);
            this.txtNombreDeProducto.TabIndex = 9;
            this.txtNombreDeProducto.Text = "Nombre De Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSize = true;
            this.txtCantidad.Location = new System.Drawing.Point(457, 263);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(49, 13);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.Text = "Cantidad";
            // 
            // txtPrecioDelProdcuto
            // 
            this.txtPrecioDelProdcuto.AutoSize = true;
            this.txtPrecioDelProdcuto.Location = new System.Drawing.Point(288, 263);
            this.txtPrecioDelProdcuto.Name = "txtPrecioDelProdcuto";
            this.txtPrecioDelProdcuto.Size = new System.Drawing.Size(99, 13);
            this.txtPrecioDelProdcuto.TabIndex = 13;
            this.txtPrecioDelProdcuto.Text = "Precio del producto";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Location = new System.Drawing.Point(641, 263);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(31, 13);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.Text = "Total";
            // 
            // textBoxNumeroDeVenta
            // 
            this.textBoxNumeroDeVenta.Enabled = false;
            this.textBoxNumeroDeVenta.Location = new System.Drawing.Point(122, 24);
            this.textBoxNumeroDeVenta.Name = "textBoxNumeroDeVenta";
            this.textBoxNumeroDeVenta.Size = new System.Drawing.Size(163, 20);
            this.textBoxNumeroDeVenta.TabIndex = 16;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(460, 279);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(151, 20);
            this.textBoxCantidad.TabIndex = 18;
            this.textBoxCantidad.Text = "1";
            this.textBoxCantidad.TextChanged += new System.EventHandler(this.textBoxCantidad_TextChanged);
            this.textBoxCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCantidad_KeyUp);
            // 
            // textBoxBuscarProducto
            // 
            this.textBoxBuscarProducto.Location = new System.Drawing.Point(122, 179);
            this.textBoxBuscarProducto.Name = "textBoxBuscarProducto";
            this.textBoxBuscarProducto.Size = new System.Drawing.Size(257, 20);
            this.textBoxBuscarProducto.TabIndex = 20;
            this.textBoxBuscarProducto.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBoxBuscarProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBuscarProducto_KeyUp);
            // 
            // textBoxidProducto
            // 
            this.textBoxidProducto.Enabled = false;
            this.textBoxidProducto.Location = new System.Drawing.Point(25, 279);
            this.textBoxidProducto.Name = "textBoxidProducto";
            this.textBoxidProducto.Size = new System.Drawing.Size(100, 20);
            this.textBoxidProducto.TabIndex = 22;
            // 
            // textBoxNombreDeProducto
            // 
            this.textBoxNombreDeProducto.Enabled = false;
            this.textBoxNombreDeProducto.Location = new System.Drawing.Point(143, 279);
            this.textBoxNombreDeProducto.Name = "textBoxNombreDeProducto";
            this.textBoxNombreDeProducto.Size = new System.Drawing.Size(117, 20);
            this.textBoxNombreDeProducto.TabIndex = 24;
            // 
            // textBoxPrecioDeProducto
            // 
            this.textBoxPrecioDeProducto.Enabled = false;
            this.textBoxPrecioDeProducto.Location = new System.Drawing.Point(291, 279);
            this.textBoxPrecioDeProducto.Name = "textBoxPrecioDeProducto";
            this.textBoxPrecioDeProducto.Size = new System.Drawing.Size(132, 20);
            this.textBoxPrecioDeProducto.TabIndex = 26;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(644, 279);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(160, 20);
            this.textBoxTotal.TabIndex = 28;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(412, 179);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(820, 279);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtvProductos
            // 
            this.dtvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOMBRE,
            this.PRECIO,
            this.CANTIDAD,
            this.TOTAL});
            this.dtvProductos.Location = new System.Drawing.Point(34, 325);
            this.dtvProductos.Name = "dtvProductos";
            this.dtvProductos.ReadOnly = true;
            this.dtvProductos.Size = new System.Drawing.Size(843, 150);
            this.dtvProductos.TabIndex = 31;
            this.dtvProductos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dtvProductos_RowsRemoved);
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO PROD";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "NOMBRE PROD";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO PROD";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.ReadOnly = true;
            // 
            // TOTAL
            // 
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // comboBoxTipoDeDocumento
            // 
            this.comboBoxTipoDeDocumento.FormattingEnabled = true;
            this.comboBoxTipoDeDocumento.Location = new System.Drawing.Point(460, 84);
            this.comboBoxTipoDeDocumento.Name = "comboBoxTipoDeDocumento";
            this.comboBoxTipoDeDocumento.Size = new System.Drawing.Size(151, 21);
            this.comboBoxTipoDeDocumento.TabIndex = 32;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(460, 24);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(151, 21);
            this.comboBoxCliente.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Total $ :";
            // 
            // textBoxTotalFinal
            // 
            this.textBoxTotalFinal.Enabled = false;
            this.textBoxTotalFinal.Font = new System.Drawing.Font("Lucida Fax", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalFinal.Location = new System.Drawing.Point(326, 523);
            this.textBoxTotalFinal.Multiline = true;
            this.textBoxTotalFinal.Name = "textBoxTotalFinal";
            this.textBoxTotalFinal.Size = new System.Drawing.Size(199, 36);
            this.textBoxTotalFinal.TabIndex = 35;
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.Location = new System.Drawing.Point(728, 501);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Size = new System.Drawing.Size(122, 23);
            this.btnGuardarVenta.TabIndex = 36;
            this.btnGuardarVenta.Text = "GUARDAR VENTA";
            this.btnGuardarVenta.UseVisualStyleBackColor = true;
            this.btnGuardarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "YYYY-MM-DD";
            this.dtpFecha.Location = new System.Drawing.Point(695, 36);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 37;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(825, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 38;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(820, 229);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 39;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 598);
            this.ControlBox = false;
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnGuardarVenta);
            this.Controls.Add(this.textBoxTotalFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.comboBoxTipoDeDocumento);
            this.Controls.Add(this.dtvProductos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxPrecioDeProducto);
            this.Controls.Add(this.textBoxNombreDeProducto);
            this.Controls.Add(this.textBoxidProducto);
            this.Controls.Add(this.textBoxBuscarProducto);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxNumeroDeVenta);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPrecioDelProdcuto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombreDeProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.txtTipoDeDocuemnto);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtNumeroDeVenta);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNumeroDeVenta;
        private System.Windows.Forms.Label txtCliente;
        private System.Windows.Forms.Label txtTipoDeDocuemnto;
        private System.Windows.Forms.Label txtBuscarProducto;
        private System.Windows.Forms.Label txtCodigoProducto;
        private System.Windows.Forms.Label txtNombreDeProducto;
        private System.Windows.Forms.Label txtCantidad;
        private System.Windows.Forms.Label txtPrecioDelProdcuto;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.TextBox textBoxNumeroDeVenta;
        private System.Windows.Forms.TextBox textBoxBuscarProducto;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dtvProductos;
        private System.Windows.Forms.ComboBox comboBoxTipoDeDocumento;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        public System.Windows.Forms.TextBox textBoxidProducto;
        public System.Windows.Forms.TextBox textBoxNombreDeProducto;
        public System.Windows.Forms.TextBox textBoxPrecioDeProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxTotalFinal;
        private System.Windows.Forms.Button btnGuardarVenta;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnBorrar;
    }
}