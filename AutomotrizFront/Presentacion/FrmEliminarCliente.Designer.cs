namespace AutomotrizFront.Presentacion
{
    partial class FrmEliminarCliente
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
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.CboTipoDoc = new System.Windows.Forms.ComboBox();
            this.CboTipoCliente = new System.Windows.Forms.ComboBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtNumeroDoc = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.CboLocalidad = new System.Windows.Forms.ComboBox();
            this.CboBarrio = new System.Windows.Forms.ComboBox();
            this.CboProvincia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 20;
            this.lstClientes.Location = new System.Drawing.Point(14, 33);
            this.lstClientes.Margin = new System.Windows.Forms.Padding(5);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(399, 504);
            this.lstClientes.TabIndex = 0;
            this.lstClientes.UseWaitCursor = true;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged_1);
            // 
            // CboTipoDoc
            // 
            this.CboTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoDoc.FormattingEnabled = true;
            this.CboTipoDoc.Location = new System.Drawing.Point(684, 228);
            this.CboTipoDoc.Name = "CboTipoDoc";
            this.CboTipoDoc.Size = new System.Drawing.Size(274, 28);
            this.CboTipoDoc.TabIndex = 9;
            // 
            // CboTipoCliente
            // 
            this.CboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoCliente.FormattingEnabled = true;
            this.CboTipoCliente.Location = new System.Drawing.Point(684, 112);
            this.CboTipoCliente.Name = "CboTipoCliente";
            this.CboTipoCliente.Size = new System.Drawing.Size(274, 28);
            this.CboTipoCliente.TabIndex = 3;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(684, 295);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(274, 27);
            this.TxtTelefono.TabIndex = 13;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(684, 328);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(274, 27);
            this.TxtCorreo.TabIndex = 15;
            // 
            // TxtNumeroDoc
            // 
            this.TxtNumeroDoc.Location = new System.Drawing.Point(684, 262);
            this.TxtNumeroDoc.Name = "TxtNumeroDoc";
            this.TxtNumeroDoc.Size = new System.Drawing.Size(274, 27);
            this.TxtNumeroDoc.TabIndex = 11;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(684, 195);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(274, 27);
            this.TxtApellido.TabIndex = 7;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(684, 162);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(274, 27);
            this.TxtNombre.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(502, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(406, 36);
            this.label11.TabIndex = 1;
            this.label11.Text = "Datos del cliente a eliminar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Correo electrónico";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Teléfono de contacto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Número de documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de cliente";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(1002, 509);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(94, 29);
            this.BtnSalir.TabIndex = 17;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(755, 457);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(118, 43);
            this.BtnEliminar.TabIndex = 16;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_ClickAsync);
            // 
            // CboLocalidad
            // 
            this.CboLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboLocalidad.FormattingEnabled = true;
            this.CboLocalidad.Location = new System.Drawing.Point(1369, 309);
            this.CboLocalidad.Name = "CboLocalidad";
            this.CboLocalidad.Size = new System.Drawing.Size(274, 28);
            this.CboLocalidad.TabIndex = 81;
            // 
            // CboBarrio
            // 
            this.CboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBarrio.FormattingEnabled = true;
            this.CboBarrio.Location = new System.Drawing.Point(1369, 343);
            this.CboBarrio.Name = "CboBarrio";
            this.CboBarrio.Size = new System.Drawing.Size(274, 28);
            this.CboBarrio.TabIndex = 80;
            // 
            // CboProvincia
            // 
            this.CboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProvincia.FormattingEnabled = true;
            this.CboProvincia.Location = new System.Drawing.Point(1369, 275);
            this.CboProvincia.Name = "CboProvincia";
            this.CboProvincia.Size = new System.Drawing.Size(274, 28);
            this.CboProvincia.TabIndex = 79;
            // 
            // FrmEliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 546);
            this.Controls.Add(this.CboLocalidad);
            this.Controls.Add(this.CboBarrio);
            this.Controls.Add(this.CboProvincia);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.CboTipoDoc);
            this.Controls.Add(this.CboTipoCliente);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtNumeroDoc);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnEliminar);
            this.Name = "FrmEliminarCliente";
            this.Text = "Eliminar Cliente";
            this.Load += new System.EventHandler(this.FrmEliminarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox lstClientes;
        private ComboBox CboTipoDoc;
        private ComboBox CboTipoCliente;
        private TextBox TxtTelefono;
        private TextBox TxtCorreo;
        private TextBox TxtNumeroDoc;
        private TextBox TxtApellido;
        private TextBox TxtNombre;
        private Label label11;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button BtnSalir;
        private Button BtnEliminar;
        private ComboBox CboLocalidad;
        private ComboBox CboBarrio;
        private ComboBox CboProvincia;
    }
}