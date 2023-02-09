namespace CorPartAutomotriz.Presentacion
{
    partial class FrmFactura
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
            this.grpboxProductos = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpOrdenes = new System.Windows.Forms.GroupBox();
            this.btnAgregarOrden = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.ProductoOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccionOrden = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpFactura = new System.Windows.Forms.GroupBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboCuotas = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.chkAutoPlan = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboFormaEnvio = new System.Windows.Forms.ComboBox();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.txtClienteApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFacturaNro = new System.Windows.Forms.Label();
            this.grpboxCliente = new System.Windows.Forms.GroupBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpboxProductos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.grpOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.grpFactura.SuspendLayout();
            this.grpboxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxProductos
            // 
            this.grpboxProductos.Controls.Add(this.lblTotal);
            this.grpboxProductos.Controls.Add(this.groupBox2);
            this.grpboxProductos.Controls.Add(this.grpOrdenes);
            this.grpboxProductos.Controls.Add(this.txtStockMinimo);
            this.grpboxProductos.Controls.Add(this.txtStock);
            this.grpboxProductos.Controls.Add(this.lblSubTotal);
            this.grpboxProductos.Controls.Add(this.btnAgregar);
            this.grpboxProductos.Controls.Add(this.label19);
            this.grpboxProductos.Controls.Add(this.label16);
            this.grpboxProductos.Controls.Add(this.cboTipoProducto);
            this.grpboxProductos.Controls.Add(this.label3);
            this.grpboxProductos.Controls.Add(this.lblInteres);
            this.grpboxProductos.Controls.Add(this.lblDescuento);
            this.grpboxProductos.Controls.Add(this.numCantidad);
            this.grpboxProductos.Controls.Add(this.label12);
            this.grpboxProductos.Controls.Add(this.txtPrecio);
            this.grpboxProductos.Controls.Add(this.label11);
            this.grpboxProductos.Controls.Add(this.cboProducto);
            this.grpboxProductos.Controls.Add(this.label10);
            this.grpboxProductos.Location = new System.Drawing.Point(508, 333);
            this.grpboxProductos.Margin = new System.Windows.Forms.Padding(4);
            this.grpboxProductos.Name = "grpboxProductos";
            this.grpboxProductos.Padding = new System.Windows.Forms.Padding(4);
            this.grpboxProductos.Size = new System.Drawing.Size(928, 519);
            this.grpboxProductos.TabIndex = 5;
            this.grpboxProductos.TabStop = false;
            this.grpboxProductos.Text = "Productos";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(713, 501);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDetalles);
            this.groupBox2.Location = new System.Drawing.Point(10, 130);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(903, 159);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Accion});
            this.dgvDetalles.Location = new System.Drawing.Point(66, 13);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(815, 140);
            this.dgvDetalles.TabIndex = 0;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            this.dgvDetalles.Click += new System.EventHandler(this.dgvDetalles_Click);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.MinimumWidth = 6;
            this.Accion.Name = "Accion";
            this.Accion.ReadOnly = true;
            this.Accion.Text = "Quitar";
            this.Accion.UseColumnTextForButtonValue = true;
            this.Accion.Width = 125;
            // 
            // grpOrdenes
            // 
            this.grpOrdenes.Controls.Add(this.btnAgregarOrden);
            this.grpOrdenes.Controls.Add(this.label17);
            this.grpOrdenes.Controls.Add(this.dtpFechaEntrega);
            this.grpOrdenes.Controls.Add(this.dgvOrdenes);
            this.grpOrdenes.Location = new System.Drawing.Point(10, 290);
            this.grpOrdenes.Margin = new System.Windows.Forms.Padding(4);
            this.grpOrdenes.Name = "grpOrdenes";
            this.grpOrdenes.Padding = new System.Windows.Forms.Padding(4);
            this.grpOrdenes.Size = new System.Drawing.Size(903, 179);
            this.grpOrdenes.TabIndex = 14;
            this.grpOrdenes.TabStop = false;
            this.grpOrdenes.Text = "Ordenes";
            // 
            // btnAgregarOrden
            // 
            this.btnAgregarOrden.Location = new System.Drawing.Point(798, 13);
            this.btnAgregarOrden.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarOrden.Name = "btnAgregarOrden";
            this.btnAgregarOrden.Size = new System.Drawing.Size(81, 24);
            this.btnAgregarOrden.TabIndex = 2;
            this.btnAgregarOrden.Text = "Agregar";
            this.btnAgregarOrden.UseVisualStyleBackColor = true;
            this.btnAgregarOrden.Click += new System.EventHandler(this.btnAgregarOrden_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(461, 15);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Fecha de entrega:";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(592, 14);
            this.dtpFechaEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(199, 23);
            this.dtpFechaEntrega.TabIndex = 1;
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.AllowUserToAddRows = false;
            this.dgvOrdenes.AllowUserToDeleteRows = false;
            this.dgvOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoOrden,
            this.PrecioOrden,
            this.CantidadOrden,
            this.FechaEntrega,
            this.AccionOrden});
            this.dgvOrdenes.Location = new System.Drawing.Point(66, 44);
            this.dgvOrdenes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.ReadOnly = true;
            this.dgvOrdenes.RowHeadersWidth = 51;
            this.dgvOrdenes.Size = new System.Drawing.Size(815, 128);
            this.dgvOrdenes.TabIndex = 3;
            this.dgvOrdenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdenes_CellContentClick);
            // 
            // ProductoOrden
            // 
            this.ProductoOrden.HeaderText = "Producto";
            this.ProductoOrden.MinimumWidth = 6;
            this.ProductoOrden.Name = "ProductoOrden";
            this.ProductoOrden.ReadOnly = true;
            this.ProductoOrden.Width = 125;
            // 
            // PrecioOrden
            // 
            this.PrecioOrden.HeaderText = "Precio";
            this.PrecioOrden.MinimumWidth = 6;
            this.PrecioOrden.Name = "PrecioOrden";
            this.PrecioOrden.ReadOnly = true;
            this.PrecioOrden.Width = 125;
            // 
            // CantidadOrden
            // 
            this.CantidadOrden.HeaderText = "Cantidad";
            this.CantidadOrden.MinimumWidth = 6;
            this.CantidadOrden.Name = "CantidadOrden";
            this.CantidadOrden.ReadOnly = true;
            this.CantidadOrden.Width = 125;
            // 
            // FechaEntrega
            // 
            this.FechaEntrega.HeaderText = "FechaEntrega";
            this.FechaEntrega.MinimumWidth = 6;
            this.FechaEntrega.Name = "FechaEntrega";
            this.FechaEntrega.ReadOnly = true;
            this.FechaEntrega.Width = 125;
            // 
            // AccionOrden
            // 
            this.AccionOrden.HeaderText = "Accion";
            this.AccionOrden.MinimumWidth = 6;
            this.AccionOrden.Name = "AccionOrden";
            this.AccionOrden.ReadOnly = true;
            this.AccionOrden.Text = "Quitar";
            this.AccionOrden.UseColumnTextForButtonValue = true;
            this.AccionOrden.Width = 125;
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(724, 66);
            this.txtStockMinimo.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(77, 23);
            this.txtStockMinimo.TabIndex = 7;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(543, 66);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(77, 23);
            this.txtStock.TabIndex = 5;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.Location = new System.Drawing.Point(690, 473);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(62, 13);
            this.lblSubTotal.TabIndex = 17;
            this.lblSubTotal.Text = "SubTotal:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(808, 99);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 24);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(472, 69);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 15);
            this.label19.TabIndex = 4;
            this.label19.Text = "Stock:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(626, 68);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "Stock Minimo:";
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Location = new System.Drawing.Point(213, 26);
            this.cboTipoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(588, 23);
            this.cboTipoProducto.TabIndex = 1;
            this.cboTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cboTipoProducto_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de producto:";
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblInteres.Location = new System.Drawing.Point(472, 473);
            this.lblInteres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(79, 13);
            this.lblInteres.TabIndex = 15;
            this.lblInteres.Text = "Interés total;";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDescuento.Location = new System.Drawing.Point(448, 501);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(101, 13);
            this.lblDescuento.TabIndex = 16;
            this.lblDescuento.Text = "Descuento total:";
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(543, 101);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(258, 23);
            this.numCantidad.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(472, 104);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Cantidad:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(213, 100);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(246, 23);
            this.txtPrecio.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Precio:";
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(213, 66);
            this.cboProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(246, 23);
            this.cboProducto.TabIndex = 3;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 66);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Producto:";
            // 
            // grpFactura
            // 
            this.grpFactura.Controls.Add(this.cboTipo);
            this.grpFactura.Controls.Add(this.cboCuotas);
            this.grpFactura.Controls.Add(this.label13);
            this.grpFactura.Controls.Add(this.chkAutoPlan);
            this.grpFactura.Controls.Add(this.label18);
            this.grpFactura.Controls.Add(this.txtInteres);
            this.grpFactura.Controls.Add(this.txtDescuento);
            this.grpFactura.Controls.Add(this.label8);
            this.grpFactura.Controls.Add(this.label9);
            this.grpFactura.Controls.Add(this.cboFormaEnvio);
            this.grpFactura.Controls.Add(this.cboFormaPago);
            this.grpFactura.Controls.Add(this.dtpFecha);
            this.grpFactura.Controls.Add(this.label7);
            this.grpFactura.Controls.Add(this.label6);
            this.grpFactura.Controls.Add(this.label5);
            this.grpFactura.Controls.Add(this.txtClienteNombre);
            this.grpFactura.Controls.Add(this.txtClienteApellido);
            this.grpFactura.Controls.Add(this.label4);
            this.grpFactura.Controls.Add(this.lblFacturaNro);
            this.grpFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpFactura.Location = new System.Drawing.Point(508, 12);
            this.grpFactura.Margin = new System.Windows.Forms.Padding(4);
            this.grpFactura.Name = "grpFactura";
            this.grpFactura.Padding = new System.Windows.Forms.Padding(4);
            this.grpFactura.Size = new System.Drawing.Size(928, 313);
            this.grpFactura.TabIndex = 4;
            this.grpFactura.TabStop = false;
            this.grpFactura.Text = "Factura";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(603, 86);
            this.cboTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(197, 21);
            this.cboTipo.TabIndex = 19;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // cboCuotas
            // 
            this.cboCuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCuotas.FormattingEnabled = true;
            this.cboCuotas.Items.AddRange(new object[] {
            "3",
            "6",
            "12",
            "18",
            "24"});
            this.cboCuotas.Location = new System.Drawing.Point(354, 128);
            this.cboCuotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(148, 21);
            this.cboCuotas.TabIndex = 18;
            this.cboCuotas.SelectedIndexChanged += new System.EventHandler(this.cboCuotas_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(304, 131);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Cuotas:";
            // 
            // chkAutoPlan
            // 
            this.chkAutoPlan.AutoSize = true;
            this.chkAutoPlan.Location = new System.Drawing.Point(213, 130);
            this.chkAutoPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAutoPlan.Name = "chkAutoPlan";
            this.chkAutoPlan.Size = new System.Drawing.Size(68, 17);
            this.chkAutoPlan.TabIndex = 16;
            this.chkAutoPlan.Text = "Autoplan";
            this.chkAutoPlan.UseVisualStyleBackColor = true;
            this.chkAutoPlan.CheckedChanged += new System.EventHandler(this.chkAutoPlan_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(511, 91);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Tipo de cliente:";
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(603, 128);
            this.txtInteres.Margin = new System.Windows.Forms.Padding(4);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(199, 19);
            this.txtInteres.TabIndex = 13;
            this.txtInteres.Text = "0";
            // 
            // txtDescuento
            // 
            this.txtDescuento.AccessibleDescription = "";
            this.txtDescuento.AccessibleName = "";
            this.txtDescuento.Location = new System.Drawing.Point(213, 178);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(588, 19);
            this.txtDescuento.TabIndex = 11;
            this.txtDescuento.Tag = "";
            this.txtDescuento.Text = "0";
            this.txtDescuento.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Descuento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(552, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Interés:";
            // 
            // cboFormaEnvio
            // 
            this.cboFormaEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaEnvio.FormattingEnabled = true;
            this.cboFormaEnvio.Location = new System.Drawing.Point(213, 253);
            this.cboFormaEnvio.Margin = new System.Windows.Forms.Padding(4);
            this.cboFormaEnvio.Name = "cboFormaEnvio";
            this.cboFormaEnvio.Size = new System.Drawing.Size(588, 21);
            this.cboFormaEnvio.TabIndex = 9;
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(213, 214);
            this.cboFormaPago.Margin = new System.Windows.Forms.Padding(4);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(588, 21);
            this.cboFormaPago.TabIndex = 7;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(213, 50);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(588, 19);
            this.dtpFecha.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(84, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Forma de envio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(85, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Forma de pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(84, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha:";
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Location = new System.Drawing.Point(213, 88);
            this.txtClienteNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(138, 19);
            this.txtClienteNombre.TabIndex = 3;
            // 
            // txtClienteApellido
            // 
            this.txtClienteApellido.Location = new System.Drawing.Point(354, 88);
            this.txtClienteApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtClienteApellido.Name = "txtClienteApellido";
            this.txtClienteApellido.Size = new System.Drawing.Size(148, 19);
            this.txtClienteApellido.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(84, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cliente:";
            // 
            // lblFacturaNro
            // 
            this.lblFacturaNro.AutoSize = true;
            this.lblFacturaNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFacturaNro.Location = new System.Drawing.Point(73, 17);
            this.lblFacturaNro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFacturaNro.Name = "lblFacturaNro";
            this.lblFacturaNro.Size = new System.Drawing.Size(87, 17);
            this.lblFacturaNro.TabIndex = 0;
            this.lblFacturaNro.Text = "Factura #: ";
            // 
            // grpboxCliente
            // 
            this.grpboxCliente.Controls.Add(this.btnAtras);
            this.grpboxCliente.Controls.Add(this.lstClientes);
            this.grpboxCliente.Controls.Add(this.btnSiguiente);
            this.grpboxCliente.Controls.Add(this.label1);
            this.grpboxCliente.Controls.Add(this.txtDocumento);
            this.grpboxCliente.Controls.Add(this.label2);
            this.grpboxCliente.Controls.Add(this.btnBuscar);
            this.grpboxCliente.Location = new System.Drawing.Point(11, 12);
            this.grpboxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.grpboxCliente.Name = "grpboxCliente";
            this.grpboxCliente.Padding = new System.Windows.Forms.Padding(4);
            this.grpboxCliente.Size = new System.Drawing.Size(489, 840);
            this.grpboxCliente.TabIndex = 3;
            this.grpboxCliente.TabStop = false;
            this.grpboxCliente.Text = "Cliente";
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(302, 789);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(88, 34);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 15;
            this.lstClientes.Location = new System.Drawing.Point(39, 150);
            this.lstClientes.Margin = new System.Windows.Forms.Padding(4);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(350, 604);
            this.lstClientes.TabIndex = 4;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSiguiente.Location = new System.Drawing.Point(395, 789);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(88, 34);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento Nro:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(144, 112);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(245, 23);
            this.txtDocumento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Busque o seleccione un cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(395, 103);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 37);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1025, 860);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(195, 45);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Caneclar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(814, 860);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(195, 45);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1437, 702);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpboxProductos);
            this.Controls.Add(this.grpFactura);
            this.Controls.Add(this.grpboxCliente);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FrmFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.grpboxProductos.ResumeLayout(false);
            this.grpboxProductos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.grpOrdenes.ResumeLayout(false);
            this.grpOrdenes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.grpFactura.ResumeLayout(false);
            this.grpFactura.PerformLayout();
            this.grpboxCliente.ResumeLayout(false);
            this.grpboxCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxProductos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn Accion;
        private System.Windows.Forms.GroupBox grpOrdenes;
        private System.Windows.Forms.Button btnAgregarOrden;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.DataGridView dgvOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEntrega;
        private System.Windows.Forms.DataGridViewButtonColumn AccionOrden;
        private System.Windows.Forms.TextBox txtStockMinimo;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpFactura;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboCuotas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkAutoPlan;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboFormaEnvio;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.TextBox txtClienteApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFacturaNro;
        private System.Windows.Forms.GroupBox grpboxCliente;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}