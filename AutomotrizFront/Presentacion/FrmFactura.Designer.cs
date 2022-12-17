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
            this.grpboxProductos.Location = new System.Drawing.Point(581, 444);
            this.grpboxProductos.Margin = new System.Windows.Forms.Padding(5);
            this.grpboxProductos.Name = "grpboxProductos";
            this.grpboxProductos.Padding = new System.Windows.Forms.Padding(5);
            this.grpboxProductos.Size = new System.Drawing.Size(1061, 692);
            this.grpboxProductos.TabIndex = 5;
            this.grpboxProductos.TabStop = false;
            this.grpboxProductos.Text = "Productos";
            this.grpboxProductos.UseWaitCursor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(815, 668);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(47, 16);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total:";
            this.lblTotal.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDetalles);
            this.groupBox2.Location = new System.Drawing.Point(11, 173);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(1032, 212);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            this.groupBox2.UseWaitCursor = true;
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
            this.dgvDetalles.Location = new System.Drawing.Point(75, 17);
            this.dgvDetalles.Margin = new System.Windows.Forms.Padding(5);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersWidth = 51;
            this.dgvDetalles.Size = new System.Drawing.Size(931, 187);
            this.dgvDetalles.TabIndex = 0;
            this.dgvDetalles.UseWaitCursor = true;
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
            this.grpOrdenes.Location = new System.Drawing.Point(11, 387);
            this.grpOrdenes.Margin = new System.Windows.Forms.Padding(5);
            this.grpOrdenes.Name = "grpOrdenes";
            this.grpOrdenes.Padding = new System.Windows.Forms.Padding(5);
            this.grpOrdenes.Size = new System.Drawing.Size(1032, 239);
            this.grpOrdenes.TabIndex = 14;
            this.grpOrdenes.TabStop = false;
            this.grpOrdenes.Text = "Ordenes";
            this.grpOrdenes.UseWaitCursor = true;
            // 
            // btnAgregarOrden
            // 
            this.btnAgregarOrden.Location = new System.Drawing.Point(912, 17);
            this.btnAgregarOrden.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarOrden.Name = "btnAgregarOrden";
            this.btnAgregarOrden.Size = new System.Drawing.Size(93, 32);
            this.btnAgregarOrden.TabIndex = 2;
            this.btnAgregarOrden.Text = "Agregar";
            this.btnAgregarOrden.UseVisualStyleBackColor = true;
            this.btnAgregarOrden.UseWaitCursor = true;
            this.btnAgregarOrden.Click += new System.EventHandler(this.btnAgregarOrden_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(527, 20);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Fecha de entrega:";
            this.label17.UseWaitCursor = true;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(677, 19);
            this.dtpFechaEntrega.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(227, 27);
            this.dtpFechaEntrega.TabIndex = 1;
            this.dtpFechaEntrega.UseWaitCursor = true;
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
            this.dgvOrdenes.Location = new System.Drawing.Point(75, 59);
            this.dgvOrdenes.Margin = new System.Windows.Forms.Padding(5);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.ReadOnly = true;
            this.dgvOrdenes.RowHeadersWidth = 51;
            this.dgvOrdenes.Size = new System.Drawing.Size(931, 171);
            this.dgvOrdenes.TabIndex = 3;
            this.dgvOrdenes.UseWaitCursor = true;
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
            this.txtStockMinimo.Location = new System.Drawing.Point(827, 88);
            this.txtStockMinimo.Margin = new System.Windows.Forms.Padding(5);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(87, 27);
            this.txtStockMinimo.TabIndex = 7;
            this.txtStockMinimo.UseWaitCursor = true;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(621, 88);
            this.txtStock.Margin = new System.Windows.Forms.Padding(5);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(87, 27);
            this.txtStock.TabIndex = 5;
            this.txtStock.UseWaitCursor = true;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.Location = new System.Drawing.Point(789, 631);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(74, 16);
            this.lblSubTotal.TabIndex = 17;
            this.lblSubTotal.Text = "SubTotal:";
            this.lblSubTotal.UseWaitCursor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(923, 132);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 32);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.UseWaitCursor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(539, 92);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 20);
            this.label19.TabIndex = 4;
            this.label19.Text = "Stock:";
            this.label19.UseWaitCursor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(715, 91);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 20);
            this.label16.TabIndex = 6;
            this.label16.Text = "Stock Minimo:";
            this.label16.UseWaitCursor = true;
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Location = new System.Drawing.Point(243, 35);
            this.cboTipoProducto.Margin = new System.Windows.Forms.Padding(5);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(671, 28);
            this.cboTipoProducto.TabIndex = 1;
            this.cboTipoProducto.UseWaitCursor = true;
            this.cboTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cboTipoProducto_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipo de producto:";
            this.label3.UseWaitCursor = true;
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblInteres.Location = new System.Drawing.Point(539, 631);
            this.lblInteres.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(92, 16);
            this.lblInteres.TabIndex = 15;
            this.lblInteres.Text = "Interés total;";
            this.lblInteres.UseWaitCursor = true;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblDescuento.Location = new System.Drawing.Point(512, 668);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(119, 16);
            this.lblDescuento.TabIndex = 16;
            this.lblDescuento.Text = "Descuento total:";
            this.lblDescuento.UseWaitCursor = true;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(621, 135);
            this.numCantidad.Margin = new System.Windows.Forms.Padding(5);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(295, 27);
            this.numCantidad.TabIndex = 11;
            this.numCantidad.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(539, 139);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Cantidad:";
            this.label12.UseWaitCursor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(243, 133);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(281, 27);
            this.txtPrecio.TabIndex = 9;
            this.txtPrecio.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(96, 137);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Precio:";
            this.label11.UseWaitCursor = true;
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(243, 88);
            this.cboProducto.Margin = new System.Windows.Forms.Padding(5);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(281, 28);
            this.cboProducto.TabIndex = 3;
            this.cboProducto.UseWaitCursor = true;
            this.cboProducto.SelectedIndexChanged += new System.EventHandler(this.cboProducto_SelectedIndexChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 88);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Producto:";
            this.label10.UseWaitCursor = true;
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
            this.grpFactura.Location = new System.Drawing.Point(581, 16);
            this.grpFactura.Margin = new System.Windows.Forms.Padding(5);
            this.grpFactura.Name = "grpFactura";
            this.grpFactura.Padding = new System.Windows.Forms.Padding(5);
            this.grpFactura.Size = new System.Drawing.Size(1061, 417);
            this.grpFactura.TabIndex = 4;
            this.grpFactura.TabStop = false;
            this.grpFactura.Text = "Factura";
            this.grpFactura.UseWaitCursor = true;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(689, 115);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(225, 24);
            this.cboTipo.TabIndex = 19;
            this.cboTipo.UseWaitCursor = true;
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
            this.cboCuotas.Location = new System.Drawing.Point(405, 171);
            this.cboCuotas.Name = "cboCuotas";
            this.cboCuotas.Size = new System.Drawing.Size(169, 24);
            this.cboCuotas.TabIndex = 18;
            this.cboCuotas.UseWaitCursor = true;
            this.cboCuotas.SelectedIndexChanged += new System.EventHandler(this.cboCuotas_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(347, 175);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Cuotas:";
            this.label13.UseWaitCursor = true;
            // 
            // chkAutoPlan
            // 
            this.chkAutoPlan.AutoSize = true;
            this.chkAutoPlan.Location = new System.Drawing.Point(243, 173);
            this.chkAutoPlan.Name = "chkAutoPlan";
            this.chkAutoPlan.Size = new System.Drawing.Size(82, 20);
            this.chkAutoPlan.TabIndex = 16;
            this.chkAutoPlan.Text = "Autoplan";
            this.chkAutoPlan.UseVisualStyleBackColor = true;
            this.chkAutoPlan.UseWaitCursor = true;
            this.chkAutoPlan.CheckedChanged += new System.EventHandler(this.chkAutoPlan_CheckedChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(584, 121);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 16);
            this.label18.TabIndex = 14;
            this.label18.Text = "Tipo de cliente:";
            this.label18.UseWaitCursor = true;
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(689, 171);
            this.txtInteres.Margin = new System.Windows.Forms.Padding(5);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(227, 22);
            this.txtInteres.TabIndex = 13;
            this.txtInteres.Text = "0";
            this.txtInteres.UseWaitCursor = true;
            // 
            // txtDescuento
            // 
            this.txtDescuento.AccessibleDescription = "";
            this.txtDescuento.AccessibleName = "";
            this.txtDescuento.Location = new System.Drawing.Point(243, 237);
            this.txtDescuento.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(671, 22);
            this.txtDescuento.TabIndex = 11;
            this.txtDescuento.Tag = "";
            this.txtDescuento.Text = "0";
            this.txtDescuento.UseWaitCursor = true;
            this.txtDescuento.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 240);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Descuento:";
            this.label8.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(631, 175);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Interés:";
            this.label9.UseWaitCursor = true;
            // 
            // cboFormaEnvio
            // 
            this.cboFormaEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaEnvio.FormattingEnabled = true;
            this.cboFormaEnvio.Location = new System.Drawing.Point(243, 337);
            this.cboFormaEnvio.Margin = new System.Windows.Forms.Padding(5);
            this.cboFormaEnvio.Name = "cboFormaEnvio";
            this.cboFormaEnvio.Size = new System.Drawing.Size(671, 24);
            this.cboFormaEnvio.TabIndex = 9;
            this.cboFormaEnvio.UseWaitCursor = true;
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(243, 285);
            this.cboFormaPago.Margin = new System.Windows.Forms.Padding(5);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(671, 24);
            this.cboFormaPago.TabIndex = 7;
            this.cboFormaPago.UseWaitCursor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(243, 67);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(5);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(671, 22);
            this.dtpFecha.TabIndex = 5;
            this.dtpFecha.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(96, 341);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Forma de envio:";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(97, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Forma de pago:";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(96, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha:";
            this.label5.UseWaitCursor = true;
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Location = new System.Drawing.Point(243, 117);
            this.txtClienteNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(157, 22);
            this.txtClienteNombre.TabIndex = 3;
            this.txtClienteNombre.UseWaitCursor = true;
            // 
            // txtClienteApellido
            // 
            this.txtClienteApellido.Location = new System.Drawing.Point(405, 117);
            this.txtClienteApellido.Margin = new System.Windows.Forms.Padding(5);
            this.txtClienteApellido.Name = "txtClienteApellido";
            this.txtClienteApellido.Size = new System.Drawing.Size(169, 22);
            this.txtClienteApellido.TabIndex = 2;
            this.txtClienteApellido.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(96, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cliente:";
            this.label4.UseWaitCursor = true;
            // 
            // lblFacturaNro
            // 
            this.lblFacturaNro.AutoSize = true;
            this.lblFacturaNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblFacturaNro.Location = new System.Drawing.Point(83, 23);
            this.lblFacturaNro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFacturaNro.Name = "lblFacturaNro";
            this.lblFacturaNro.Size = new System.Drawing.Size(101, 20);
            this.lblFacturaNro.TabIndex = 0;
            this.lblFacturaNro.Text = "Factura #: ";
            this.lblFacturaNro.UseWaitCursor = true;
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
            this.grpboxCliente.Location = new System.Drawing.Point(13, 16);
            this.grpboxCliente.Margin = new System.Windows.Forms.Padding(5);
            this.grpboxCliente.Name = "grpboxCliente";
            this.grpboxCliente.Padding = new System.Windows.Forms.Padding(5);
            this.grpboxCliente.Size = new System.Drawing.Size(559, 1120);
            this.grpboxCliente.TabIndex = 3;
            this.grpboxCliente.TabStop = false;
            this.grpboxCliente.Text = "Cliente";
            this.grpboxCliente.UseWaitCursor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtras.Location = new System.Drawing.Point(345, 1052);
            this.btnAtras.Margin = new System.Windows.Forms.Padding(5);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(101, 45);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.UseWaitCursor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 20;
            this.lstClientes.Location = new System.Drawing.Point(45, 200);
            this.lstClientes.Margin = new System.Windows.Forms.Padding(5);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(399, 804);
            this.lstClientes.TabIndex = 4;
            this.lstClientes.UseWaitCursor = true;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSiguiente.Location = new System.Drawing.Point(451, 1052);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(5);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(101, 45);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.UseWaitCursor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento Nro:";
            this.label1.UseWaitCursor = true;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(165, 149);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(5);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(279, 27);
            this.txtDocumento.TabIndex = 2;
            this.txtDocumento.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Busque o seleccione un cliente";
            this.label2.UseWaitCursor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(451, 137);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 49);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.UseWaitCursor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1171, 1147);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(223, 60);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Caneclar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.UseWaitCursor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(930, 1147);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(223, 60);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.UseWaitCursor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1633, 936);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpboxProductos);
            this.Controls.Add(this.grpFactura);
            this.Controls.Add(this.grpboxCliente);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmFactura";
            this.Text = "Factura";
            this.UseWaitCursor = true;
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