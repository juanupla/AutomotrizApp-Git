using CorPartAutomotriz.Dominio;
using CorPartAutomotriz.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorPartAutomotriz.Presentacion
{
    public partial class FrmFactura : Form
    {
        private List<Cliente> clientes;
        private Cliente cliente;
        private Factura factura;
        private decimal totalFacturado;
        private decimal interes;
        private decimal descuento;
        private decimal totalFianl;

        public FrmFactura()
        {
            InitializeComponent();
            clientes = new List<Cliente>();
            cliente = new Cliente();
            factura = new Factura();
            totalFacturado = 0;
            interes = 0;
            descuento = 0;
            totalFianl = 0;
        }

        private async void FrmFactura_Load(object sender, EventArgs e)
        {
            dtpFecha.Enabled = false;
            dtpFecha.Value = DateTime.Now;
            txtClienteApellido.Enabled = false;
            txtClienteNombre.Enabled = false;
            grpFactura.Enabled = false;
            grpboxProductos.Enabled = false;
            btnAceptar.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;
            txtStockMinimo.Enabled = false;
            await facturaNro();
            await actualizarLista();
            await comboTipoClientes();
            await comboFormasPagos();
            await comboFormasEnvios();
            await comboTipoProductos();
        

        }

        public async Task comboTipoClientes()
        {
            string url = "https://localhost:7037/api/Automotriz/TiposClientes";
            var data = await ClientSingleton.GetInstance().GetAsync(url);
            List<TiposClientes> lst = JsonConvert.DeserializeObject<List<TiposClientes>>(data);

            cboTipo.DataSource = lst;
            cboTipo.DisplayMember = "Nombre";
            cboTipo.ValueMember = "IdTipoCliente";
        }

        public async Task comboFormasPagos()
        {
            //EEEEEEAAAAAA

            string url = "https://localhost:7037/api/Automotriz/formasPagos";
            var data = await ClientSingleton.GetInstance().GetAsync(url);
            List<FormasPago> lst = JsonConvert.DeserializeObject<List<FormasPago>>(data);

            cboFormaPago.DataSource = lst;
            cboFormaPago.DisplayMember = "Nombre";
            cboFormaPago.ValueMember = "IdFormaPago";

        }

        public async Task comboFormasEnvios()
        {

            string url = "https://localhost:7037/api/Automotriz/FormasEnvio";
            var data = await ClientSingleton.GetInstance().GetAsync(url);
            List<FormasEnvio> lst = JsonConvert.DeserializeObject<List<FormasEnvio>>(data);

            cboFormaEnvio.DataSource = lst;
            cboFormaEnvio.DisplayMember = "Nombre";
            cboFormaEnvio.ValueMember = "IdFormaEnvio";

        }

        public async Task comboTipoProductos()
        {
            string url = "https://localhost:7037/api/Automotriz/TiposProductos";
            var data = await ClientSingleton.GetInstance().GetAsync(url);
            List<TiposProductos> lst = JsonConvert.DeserializeObject<List<TiposProductos>>(data);

            cboTipoProducto.DataSource = lst;
            cboTipoProducto.DisplayMember = "TipoProducto";
            cboTipoProducto.ValueMember = "IdTipoProducto";
        }


        public async Task facturaNro()
        {

            string url = "https://localhost:7037/api/Automotriz/proxima";
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetAsync(url);
                var body = await result.Content.ReadAsStringAsync();
                int proxFactu = JsonConvert.DeserializeObject<int>(body);
                if (proxFactu > 0)
                    lblFacturaNro.Text = "Factura #: " + proxFactu; //oServicio.proximaFactura();
                else
                    lblFacturaNro.Text = "Factura #: " + 1;
            }
        }

        public async Task actualizarLista()
        {
            lstClientes.Items.Clear();
            clientes.Clear();

            string url = "https://localhost:7037/api/Automotriz/listaCliente";
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetAsync(url);
                var body = await result.Content.ReadAsStringAsync();
                List<Cliente> lst = new List<Cliente>();
                lst = JsonConvert.DeserializeObject<List<Cliente>>(body);
                lstClientes.DataSource = lst;
                clientes = lst;
            }
            lstClientes.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool validarDocumento()
        {
            bool aux;
            aux = true;
            if (txtDocumento.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un Nro de Documento", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDocumento.Focus();
                return false;

            }
            else
            {
                try
                {
                    Convert.ToInt32(txtDocumento.Text);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar un Nro de Documento válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDocumento.Focus();
                    return false;
                }
            }
            return aux;
        }

        private bool existeCliente()
        {
            bool aux = false;
            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].NumeroDocumento.Equals(Convert.ToInt32(txtDocumento.Text)))
                {
                    cliente = clientes[i];
                    txtClienteApellido.Text = cliente.Apellido;
                    txtClienteNombre.Text = cliente.Nombre;
                    cboTipo.SelectedValue = cliente.TipoCliente.IdTipoCliente;

                    aux = true;
                    break;
                }
            }
            return aux;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (validarDocumento())
            {
                if (existeCliente())
                {
                    if (cliente.IdCliente > 0)
                    {
                        habilitarCliente(false);
                        grpFactura.Enabled = true;
                        grpboxProductos.Enabled = true;
                        btnAtras.Enabled = true;
                        btnAceptar.Enabled = true;
                        txtDocumento.Text = String.Empty;
                        lstClientes.SelectedIndex = -1;
                        cboTipo.Enabled = false;
                        txtInteres.Enabled = false;
                        txtDescuento.Enabled = false;
                        cboTipoProducto.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("El documento ingresado no se encuentra. Intentelo nuevamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int posicion = lstClientes.SelectedIndex;
            if (posicion > -1)
            {
                if (clientes.Count > 1)
                {
                    cliente = clientes[posicion];
                    txtClienteApellido.Text = cliente.Apellido;
                    txtClienteNombre.Text = cliente.Nombre;
                    cboTipo.SelectedValue = cliente.TipoCliente.IdTipoCliente;



                    Provincia prov = new Provincia();//-------------------
                    prov.IdProvincia = 0;//-------------------
                    Localidad loc = new Localidad();//-------------------
                    loc.IdLocalidad = 0;//-------------------
                    loc.Provincia = prov;//-------------------

                    cliente.Barrio.Localidad = loc;
                    
                }

            }
        }

        public void habilitarCliente(bool x)
        {
            txtDocumento.Enabled = x;
            btnBuscar.Enabled = x;
            lstClientes.Enabled = x;
            btnSiguiente.Enabled = x;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (cliente.IdCliente > 0)
            {
                habilitarCliente(false);
                grpFactura.Enabled = true;
                grpboxProductos.Enabled = true;
                btnAtras.Enabled = true;
                btnAceptar.Enabled = true;
                txtDocumento.Text = String.Empty;
                cboTipo.Enabled = false;
                txtInteres.Enabled = false;
                txtDescuento.Enabled = false;
                cboTipoProducto.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Cliente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            habilitarCliente(true);
            grpFactura.Enabled = false;
            grpboxProductos.Enabled = false;
            btnAceptar.Enabled = false;
            chkAutoPlan.Checked = false;
            cboCuotas.SelectedIndex = -1;
            limpiarFactura();
        }

        private void limpiarFactura()
        {
            totalFacturado = 0;
            interes = 0;
            descuento = 0;
            totalFianl = 0;
            lblDescuento.Text = "Descuento total: ";
            lblInteres.Text = "Interés total: ";
            lblSubTotal.Text = "Sub total: ";
            lblTotal.Text = "Total: ";
            dgvDetalles.Rows.Clear();
            dgvOrdenes.Rows.Clear();
            factura.LimpiarDetalle();
            factura.LimpiarDetalleOrden();
            txtInteres.Text = "0";
            txtDescuento.Text = "0";
            dtpFechaEntrega.Value = DateTime.Now;
            numCantidad.Value = 0;
            chkAutoPlan.Checked = false;
        }


        private async void cboTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoProducto.SelectedIndex >= 0)
            {



                List<Producto> lst = new List<Producto>();
                if (cboTipoProducto.Text == "AutoPartes")
                {    //El estado de los productos listado es activo, es decir, que su atributo estado es = a 1

                    string url = "https://localhost:7037/api/Automotriz/ObtenerAutoparte";
                    using (HttpClient client = new HttpClient())
                    {
                        var result = await client.GetAsync(url);
                        var body = await result.Content.ReadAsStringAsync();
                        lst = JsonConvert.DeserializeObject<List<Producto>>(body);

                        cboProducto.DataSource = lst;
                        cboProducto.ValueMember = "IdProducto";
                        cboProducto.DisplayMember = "Nombre";
                    }

                }
                else
                {   //El estado de los productos listado es activo, es decir, que su atributo estado es = a 1
                    string url = "https://localhost:7037/api/Automotriz/ObtenerVehiculo";
                    using (HttpClient client = new HttpClient())
                    {
                        var result = await client.GetAsync(url);
                        var body = await result.Content.ReadAsStringAsync();
                        lst = JsonConvert.DeserializeObject<List<Producto>>(body);

                        cboProducto.DataSource = lst;
                        cboProducto.ValueMember = "IdProducto";
                        cboProducto.DisplayMember = "Nombre";
                    }
                }
                int posicion = cboProducto.SelectedIndex;
                txtPrecio.Text = lst[posicion].Precio.ToString();
                txtStock.Text = lst[posicion].Stock.ToString();
                txtStockMinimo.Text = lst[posicion].StockMinimo.ToString();
            }
        }


        public bool validarProducto()
        {

            if (cboTipoProducto.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar tipo de producto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTipoProducto.Focus();
                return false;
            }
            if (cboProducto.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProducto.Focus();
                return false;
            }
            if (numCantidad.Value < 1)
            {
                MessageBox.Show("La cantidad seleccionada debe ser mayor o igual que 1", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numCantidad.Focus();
                return false;
            }
            return true;
        }

        public bool existeProducto(int c)
        {
            bool aux = false;
            foreach (DataGridViewRow item in dgvDetalles.Rows)
            {
                if (item.Cells["Producto"].Value.ToString().Equals(cboProducto.Text))
                {
                    int cantidad;
                    int cantidadASumar;
                    decimal precio;
                    cantidad = Convert.ToInt32(item.Cells["Cantidad"].Value.ToString()); //Cantidad que ya había
                    cantidadASumar = Convert.ToInt32(numCantidad.Value);                                          //Cantidad que vamos a sumar
                    precio = Convert.ToDecimal(item.Cells["Precio"].Value.ToString());

                    if ((cantidad + cantidadASumar) > c)
                    {
                        MessageBox.Show("La cantidad total que se intenta ingresar de este producto supera el stock disponible. Puede generar una orden de pedido para el excedente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        aux = true;
                        dtpFechaEntrega.Focus();
                        break;
                    }
                    else
                    {
                        item.Cells["Cantidad"].Value = (cantidad + cantidadASumar);
                        int posicion = Convert.ToInt32(item.Index);
                        factura.ModificarListaDetalles(posicion, cantidadASumar);
                        decimal o = Convert.ToDecimal(cantidadASumar) * precio;
                        totalFacturado += o;
                        lblSubTotal.Text = "Sub Total: " + totalFacturado;
                        aux = true;
                        calcularDescuento();
                        calcularTotalFinal();
                        break;

                    }
                }
            }
            return aux;
        }

        public bool existeProductoEnOrdenes()
        {
            bool aux = false;
            foreach (DataGridViewRow item in dgvOrdenes.Rows)
            {
                if (item.Cells["ProductoOrden"].Value.ToString().Equals(cboProducto.Text) && item.Cells["FechaEntrega"].Value.Equals(dtpFechaEntrega.Value))
                {
                    int cantidad;
                    int cantidadASumar;
                    cantidad = Convert.ToInt32(item.Cells["CantidadOrden"].Value.ToString());         //Cantidad que ya había
                    cantidadASumar = Convert.ToInt32(numCantidad.Value);                              //Cantidad que vamos a sumar
                    decimal precio = Convert.ToDecimal(item.Cells["PrecioOrden"].Value.ToString());

                    item.Cells["CantidadOrden"].Value = (cantidad + cantidadASumar);
                    int posicion = Convert.ToInt32(item.Index);
                    factura.ModificarListaDetallesOrdenes(posicion, cantidadASumar);      //debe modificar la orden
                    aux = true;
                    //Aca hay que actualizar Totales, interes y descuento
                    //decimal o = Convert.ToDecimal(cantidadASumar) * precio;
                    //totalFacturado += o;
                    calcularIntereses();
                    calcularTotalesAgregados(cantidadASumar, precio);
                    calcularDescuento();
                    calcularTotalFinal();
                    //lblTotal.Text = "Total: " + totalFacturado;

                    break;

                }
            }
            return aux;


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarProducto())
            {
                if (cboTipoProducto.Text == "vehículos")
                {
                    MessageBox.Show("La venta de vehículos deben cargarse como orden de pedido indicando su fecha de entrega", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpFechaEntrega.Focus();
                }
                else
                {
                    int a = Convert.ToInt32(txtStock.Text);
                    int b = Convert.ToInt32(txtStockMinimo.Text);
                    int c = a - b;
                    if (c < Convert.ToInt32(numCantidad.Value))
                    {
                        MessageBox.Show("La cantidad ingresada no se encuentra en stock para este producto. Puede generar una orden de pedido para el mismo", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        if (!existeProducto(c))
                        {


                            TiposProductos tp = new TiposProductos();//--------------
                            tp.IdTipoProducto = 0;//--------------------
                            Marcas marca = new Marcas();//---------------------
                            marca.IdMarca = 0;//-----------------------------

                            





                            Producto producto = new Producto();
                            producto.IdProducto = Convert.ToInt32(cboProducto.SelectedValue);
                            producto.Nombre = cboProducto.Text;

                            producto.Marca = marca;//-----------------
                            producto.TipoProducto = tp;//-------------


                            DetalleFactura detalle = new DetalleFactura();
                            detalle.Producto = producto;
                            detalle.Cantidad = Convert.ToInt32(numCantidad.Value);
                            detalle.PrecioUnitario = Convert.ToDecimal(txtPrecio.Text);

                            dgvDetalles.Rows.Add(new object[] { detalle.Producto.Nombre, detalle.PrecioUnitario, detalle.Cantidad });
                            factura.AgregarListaDetalle(detalle);
                            //Aca hay que actualizar Totales, interes y descuento

                            calcularTotalesAgregados(detalle.Cantidad, detalle.PrecioUnitario);
                            calcularDescuento();
                            calcularTotalFinal();

                        }
                    }
                }
            }
        }


        private void calcularTotalesAgregados(int cantidad, decimal precio)
        {
            decimal item = (cantidad * precio);
            totalFacturado = totalFacturado + item;
            lblSubTotal.Text = "Sub Total: " + totalFacturado;
        }

        private async void calcularDescuento()
        {
            if (cboTipo.Text == "VendedoraDeAutopartes")
            {
                descuento = 0;
                List<Producto> lst = new List<Producto>();
                //DataTable tabla = oServicio.productosAutopartes();
                string url = "https://localhost:7037/api/Automotriz/ObtenerAutoparte";
                using (HttpClient client = new HttpClient())
                {
                    var result = await client.GetAsync(url);
                    var body = await result.Content.ReadAsStringAsync();
                    lst = JsonConvert.DeserializeObject<List<Producto>>(body);


                }
                decimal total = 0;
                decimal totalOrden = 0;
                decimal totalDetalle = 0;
                foreach (DataGridViewRow item in dgvOrdenes.Rows)
                {

                    for (int i = 0; i < lst.Count; i++)
                    {
                        string nombreProdu = lst[i].Nombre.ToString();
                        if (item.Cells["ProductoOrden"].Value.ToString().Equals(nombreProdu))
                        {
                            decimal precio = Convert.ToDecimal(item.Cells["PrecioOrden"].Value.ToString());
                            int cantidad = Convert.ToInt32(item.Cells["CantidadOrden"].Value.ToString());

                            decimal subTotal = (precio * cantidad);


                            totalOrden += subTotal;
                            //decimal interesAplicado = 3;
                            //decimal interesRow = total * (interesAplicado / 100);

                            //subtotal += interesRow;
                            //interes += interesRow;
                            break;
                        }
                    }
                }

                foreach (DataGridViewRow item in dgvDetalles.Rows)
                {

                    for (int i = 0; i < lst.Count; i++)
                    {
                        string nombreProducto = lst[i].Nombre.ToString();
                        if (item.Cells["Producto"].Value.ToString().Equals(nombreProducto))
                        {
                            decimal precio2 = Convert.ToDecimal(item.Cells["Precio"].Value.ToString());
                            int cantidad2 = Convert.ToInt32(item.Cells["Cantidad"].Value.ToString());

                            decimal subTotal2 = (precio2 * cantidad2);


                            totalDetalle += subTotal2;
                            //decimal interesAplicado = 3;
                            //decimal interesRow = total * (interesAplicado / 100);

                            //subtotal += interesRow;
                            //interes += interesRow;
                            break;
                        }
                    }
                }
                total = totalDetalle + totalOrden;
                if (total >= 600000)
                {
                    descuento = (total * 21) / 100;  // Autopartista que compra más de 600K en autopartes = descuento del 21%
                    txtDescuento.Text = "21";
                    lblDescuento.Text = "Descuento total: " + descuento;
                }
                else
                {
                    if (total >= 400000)
                    {
                        descuento = (total * 8) / 100;
                        txtDescuento.Text = "8";
                        lblDescuento.Text = "Descuento total: " + descuento;
                    }
                    else
                    {
                        if (total >= 250000)
                        {
                            descuento = (total * 3) / 100;
                            txtDescuento.Text = "3";
                            lblDescuento.Text = "Descuento total: " + descuento;
                        }
                        else
                        {
                            descuento = 0;
                            txtDescuento.Text = "0";
                            lblDescuento.Text = "Descuento total: " + descuento;
                        }
                    }
                }
                //descuento = totalOrden;
                //lblDescuento.Text = "Descuento total: " + descuento;
            }
        }

        private void calcularTotalesQuitados(int cantidad, decimal precio)
        {
            decimal item = cantidad * precio;
            totalFacturado = totalFacturado - item;
            lblSubTotal.Text = "Sub Total: " + totalFacturado;
        }

        private void btnAgregarOrden_Click(object sender, EventArgs e)
        {
            if (validarProducto())
            {
                if (dtpFechaEntrega.Value > DateTime.Now)
                {
                    if (!existeProductoEnOrdenes())
                    {


                        Producto producto = new Producto();
                        producto.IdProducto = Convert.ToInt32(cboProducto.SelectedValue);
                        producto.Nombre = cboProducto.Text;

                        TiposProductos tp = new TiposProductos();//--------------
                        tp.IdTipoProducto = 0;//--------------------
                        Marcas marca = new Marcas();//---------------------
                        marca.IdMarca = 0;//-----------------------------

                        producto.Marca = marca;//-----------------
                        producto.TipoProducto = tp;//-------------



                        DetalleOrdenPedido detalle = new DetalleOrdenPedido();
                        detalle.Producto = producto;
                        detalle.Cantidad = Convert.ToInt32(numCantidad.Value);
                        detalle.PrecioUnitario = Convert.ToDecimal(txtPrecio.Text);
                        detalle.FechaEntrega = dtpFechaEntrega.Value;

                        

                        dgvOrdenes.Rows.Add(new object[] { detalle.Producto.Nombre, detalle.PrecioUnitario, detalle.Cantidad, detalle.FechaEntrega });
                        factura.AgregarListaDetalleOrden(detalle);

                        calcularTotalesAgregados(detalle.Cantidad, detalle.PrecioUnitario); //Aca hay que actualizar Totales, interes y descuento
                        calcularIntereses();
                        calcularDescuento();
                        calcularTotalFinal();
                    }

                }
                else
                {
                    MessageBox.Show("Debe indicar una fecha de entrega, superior a la fecha actual", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpFechaEntrega.Focus();

                }
            }
        }

        private void dgvDetalles_Click(object sender, EventArgs e) //   NO SE USAAAAAAAAAAA
        {

        }

        private void dgvDetalles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles.CurrentRow != null)
            {

                int posicion = Convert.ToInt32(dgvDetalles.CurrentRow.Index);


                int cantidad = Convert.ToInt32(dgvDetalles.Rows[posicion].Cells["Cantidad"].Value.ToString());
                decimal precio = Convert.ToDecimal(dgvDetalles.Rows[posicion].Cells["Precio"].Value.ToString());
                calcularTotalesQuitados(cantidad, precio); //Aca hay que actualizar Totales, interes y descuento

                dgvDetalles.Rows.RemoveAt(posicion);
                factura.EliminarDetalle(posicion);
                calcularDescuento();
                calcularTotalFinal();
            }
        }

        private void dgvOrdenes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrdenes.CurrentRow != null)
            {
                int posicion = Convert.ToInt32(dgvOrdenes.CurrentRow.Index);


                int cantidad = Convert.ToInt32(dgvOrdenes.Rows[posicion].Cells["CantidadOrden"].Value.ToString());
                decimal precio = Convert.ToDecimal(dgvOrdenes.Rows[posicion].Cells["PrecioOrden"].Value.ToString());
                calcularTotalesQuitados(cantidad, precio); //Aca hay que actualizar Totales, interes y descuento

                dgvOrdenes.Rows.RemoveAt(posicion);
                factura.EliminarDetalleOrden(posicion);
                //totalFacturado -= interes;
                calcularIntereses();
                calcularDescuento();
                calcularTotalFinal();

            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.Text == "consumidorFinal")
            {
                chkAutoPlan.Enabled = true;
            }
            else
            {
                chkAutoPlan.Enabled = false;
                cboCuotas.Enabled = false;
            }
        }

        private async void chkAutoPlan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutoPlan.Checked)
            {
                List<Producto> lst = new List<Producto>();
                string url = "https://localhost:7037/api/Automotriz/ObtenerAutoparte";
                using (HttpClient client = new HttpClient())
                {
                    var result = await client.GetAsync(url);
                    var body = await result.Content.ReadAsStringAsync();
                    lst = JsonConvert.DeserializeObject<List<Producto>>(body);


                }

                int estado = 0;

                //DataTable tabla = oServicio.productosAutopartes();
                int totalprductosAutoPArtes = lst.Count;
                foreach (DataGridViewRow item in dgvOrdenes.Rows)
                {
                    for (int i = 0; i < totalprductosAutoPArtes; i++)
                    {


                        if (item.Cells["ProductoOrden"].Value.ToString().Equals(lst[i].Nombre.ToString()))
                        {
                            MessageBox.Show("Solamente puede añadir vehículos para utilizar el Autoplan. Revise la carga de datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            estado = 1;
                            chkAutoPlan.Checked = false;
                            break;

                        }
                    }
                    if (estado == 1)
                    {
                        break;
                    }
                }
                foreach (DataGridViewRow item2 in dgvDetalles.Rows)
                {
                    for (int i = 0; i < totalprductosAutoPArtes; i++)
                    {

                        if (estado == 0) //Si el estado del foreach anterior cambia la variable estado a 1, entonces ya no tiene sentido revisar el Detalle porque hay una autoparte cargada, la cual debe restringirse
                        {
                            if (item2.Cells["Producto"].Value.ToString().Equals(lst[i].Nombre.ToString()))
                            {
                                MessageBox.Show("Solamente puede añadir vehículos para utilizar el Autoplan. Revise la carga de datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                estado = 1;
                                chkAutoPlan.Checked = false;
                                break;

                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (estado == 1)
                    {
                        break;
                    }
                }
                if (estado == 0)
                {
                    cboCuotas.Enabled = true;
                    cboCuotas.SelectedIndex = 0;        //valor x defecto del cboCuotas al seleccionar el chkbox
                    cboTipoProducto.SelectedValue = 2;
                    cboTipoProducto.Enabled = false;

                    cboFormaPago.Enabled = false;
                    cboFormaPago.Text = "Crédito";

                    calcularTotalFinal();
                }
                else
                {
                    if (dgvDetalles.Rows.Count < 1)
                    {
                        dgvOrdenes.Focus();
                    }
                    else
                    {
                        dgvDetalles.Focus();
                    }
                }
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
                txtInteres.Text = "0";
                cboTipoProducto.Enabled = true;

                cboFormaPago.Enabled = true;

                interes = 0;
                lblInteres.Text = "Interés total: " + interes;
                calcularTotalFinal();
            }
        }

        private void calcularTotalFinal()
        {
            totalFianl = totalFacturado + interes - descuento;
            lblTotal.Text = "Total: " + totalFianl;
        }

        private void cboCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCuotas.Text == "3")
            {
                txtInteres.Text = "3";
            }
            else
            {
                if (cboCuotas.Text == "6")
                {
                    txtInteres.Text = "7";
                }
                else
                {
                    if (cboCuotas.Text == "12")
                    {
                        txtInteres.Text = "15";
                    }
                    else
                    {
                        if (cboCuotas.Text == "18")
                        {
                            txtInteres.Text = "21";
                        }
                        else
                        {
                            if (cboCuotas.Text == "24")
                            {
                                txtInteres.Text = "30";
                            }
                        }
                    }
                }
            }

            calcularIntereses();
            calcularTotalFinal();
        }

        private async void calcularIntereses() //Calcula intereses para los tipos de cliente "consumidorFinal" que tílden el checkbox Autoplan
        {
            if (cboCuotas.SelectedIndex == 0) // para 3 cuotas, el interés es de 3%
            {
                interes = 0;
                //DataTable tabla = oServicio.productosVehiculos();
                decimal subtotal = 0;

                var lst = new List<Producto>();
                string url = "https://localhost:7037/api/Automotriz/ObtenerVehiculo";
                using (HttpClient client = new HttpClient())
                {
                    var result = await client.GetAsync(url);
                    var body = await result.Content.ReadAsStringAsync();
                    lst = JsonConvert.DeserializeObject<List<Producto>>(body);


                }

                if(lst != null)
                {
                    foreach (DataGridViewRow item in dgvOrdenes.Rows)
                    {
                        //foreach (DataRow fila in lst.Count)
                        for (int i = 0; i < lst.Count; i++)
                        {
                            string nombreProdu = lst[i].Nombre.ToString();
                            if (item.Cells["ProductoOrden"].Value.ToString().Equals(nombreProdu))
                            {
                                decimal precio = Convert.ToDecimal(item.Cells["PrecioOrden"].Value.ToString());
                                int cantidad = Convert.ToInt32(item.Cells["Cantidadorden"].Value.ToString());

                                decimal total = (precio * cantidad);
                                decimal interesAplicado = 3;
                                decimal interesRow = total * (interesAplicado / 100);

                                subtotal += interesRow;
                                //interes += interesRow;
                                break;

                            }
                        }
                    }
                    interes = subtotal;
                    lblInteres.Text = "Interés total: " + interes;
                }
                
            }
            else
            {
                if (cboCuotas.SelectedIndex == 1) // para 6 cuotas, el interés es de 7%
                {
                    List<Producto> lst = new List<Producto>();
                    string url = "https://localhost:7037/api/Automotriz/ObtenerVehiculo";
                    using (HttpClient client = new HttpClient())
                    {
                        var result = await client.GetAsync(url);
                        var body = await result.Content.ReadAsStringAsync();
                        lst = JsonConvert.DeserializeObject<List<Producto>>(body);
                    }

                    //DataTable tabla = oServicio.productosVehiculos();
                    interes = 0;

                    decimal subtotal = 0;
                    foreach (DataGridViewRow item in dgvOrdenes.Rows)
                    {

                        for (int i = 0; i < lst.Count; i++)//foreach (DataRow fila in tabla.Rows)
                        {
                            string nombreProdu = lst[i].Nombre.ToString();
                            if (item.Cells["ProductoOrden"].Value.ToString().Equals(nombreProdu))
                            {
                                decimal precio = Convert.ToDecimal(item.Cells["PrecioOrden"].Value.ToString());
                                int cantidad = Convert.ToInt32(item.Cells["Cantidadorden"].Value.ToString());

                                decimal total = (precio * cantidad);
                                decimal interesAplicado = 7;
                                decimal interesRow = total * (interesAplicado / 100);

                                subtotal += interesRow;
                                //interes += interesRow;
                                break;

                            }
                        }
                    }
                    interes = subtotal;
                    lblInteres.Text = "Interés total: " + interes;
                }
                else
                {
                    if (cboCuotas.SelectedIndex == 2) // para 12 cuotas, el interés es de 15%
                    {
                        List<Producto> lst = new List<Producto>();
                        string url = "https://localhost:7037/api/Automotriz/ObtenerVehiculo";
                        using (HttpClient client = new HttpClient())
                        {
                            var result = await client.GetAsync(url);
                            var body = await result.Content.ReadAsStringAsync();
                            lst = JsonConvert.DeserializeObject<List<Producto>>(body);
                        }

                        interes = 0;
                        //DataTable tabla = oServicio.productosVehiculos();
                        decimal subtotal = 0;
                        foreach (DataGridViewRow item in dgvOrdenes.Rows)
                        {

                            for (int i = 0; i < lst.Count; i++)//foreach (DataRow fila in tabla.Rows)
                            {
                                string nombreProdu = lst[i].Nombre.ToString();
                                if (item.Cells["ProductoOrden"].Value.ToString().Equals(nombreProdu))
                                {
                                    decimal precio = Convert.ToDecimal(item.Cells["PrecioOrden"].Value.ToString());
                                    int cantidad = Convert.ToInt32(item.Cells["Cantidadorden"].Value.ToString());

                                    decimal total = (precio * cantidad);
                                    decimal interesAplicado = 15;
                                    decimal interesRow = total * (interesAplicado / 100);

                                    subtotal += interesRow;
                                    //interes += interesRow;
                                    break;

                                }
                            }
                        }
                        interes = subtotal;
                        lblInteres.Text = "Interés total: " + interes;

                    }
                    else
                    {
                        if (cboCuotas.SelectedIndex == 3) // para 18 cuotas, el interés es de 21%
                        {
                            List<Producto> lst = new List<Producto>();
                            string url = "https://localhost:7037/api/Automotriz/ObtenerVehiculo";
                            using (HttpClient client = new HttpClient())
                            {
                                var result = await client.GetAsync(url);
                                var body = await result.Content.ReadAsStringAsync();
                                lst = JsonConvert.DeserializeObject<List<Producto>>(body);
                            }

                            interes = 0;
                            //DataTable tabla = oServicio.productosVehiculos();
                            decimal subtotal = 0;
                            foreach (DataGridViewRow item in dgvOrdenes.Rows)
                            {

                                for (int i = 0; i < lst.Count; i++)//foreach (DataRow fila in tabla.Rows)
                                {
                                    string nombreProdu = lst[i].Nombre.ToString();
                                    if (item.Cells["ProductoOrden"].Value.ToString().Equals(nombreProdu))
                                    {
                                        decimal precio = Convert.ToDecimal(item.Cells["PrecioOrden"].Value.ToString());
                                        int cantidad = Convert.ToInt32(item.Cells["Cantidadorden"].Value.ToString());

                                        decimal total = (precio * cantidad);
                                        decimal interesAplicado = 21;
                                        decimal interesRow = total * (interesAplicado / 100);

                                        subtotal += interesRow;
                                        //interes += interesRow;
                                        break;

                                    }
                                }
                            }
                            interes = subtotal;
                            lblInteres.Text = "Interés total: " + interes;
                        }
                        else
                        {
                            if (cboCuotas.SelectedIndex == 4) // para 24 cuotas, el interés es de 30%
                            {
                                List<Producto> lst = new List<Producto>();
                                string url = "https://localhost:7037/api/Automotriz/ObtenerVehiculo";
                                using (HttpClient client = new HttpClient())
                                {
                                    var result = await client.GetAsync(url);
                                    var body = await result.Content.ReadAsStringAsync();
                                    lst = JsonConvert.DeserializeObject<List<Producto>>(body);
                                }

                                interes = 0;
                                //DataTable tabla = oServicio.productosVehiculos();
                                decimal subtotal = 0;
                                foreach (DataGridViewRow item in dgvOrdenes.Rows)
                                {

                                    for (int i = 0; i < lst.Count; i++)//foreach (DataRow fila in tabla.Rows)
                                    {
                                        string nombreProdu = lst[i].Nombre.ToString();
                                        if (item.Cells["ProductoOrden"].Value.ToString().Equals(nombreProdu))
                                        {
                                            decimal precio = Convert.ToDecimal(item.Cells["PrecioOrden"].Value.ToString());
                                            int cantidad = Convert.ToInt32(item.Cells["Cantidadorden"].Value.ToString());

                                            decimal total = (precio * cantidad);
                                            decimal interesAplicado = 30;
                                            decimal interesRow = total * (interesAplicado / 100);

                                            subtotal += interesRow;
                                            //interes += interesRow;
                                            break;

                                        }
                                    }
                                }
                                interes = subtotal;
                                lblInteres.Text = "Interés total: " + interes;
                            }
                        }
                    }
                }
            }
        }

        public bool validarFactura()
        {
            if (cboFormaPago.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una Forma de pago antes de continuar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboFormaPago.Focus();
                return false;
            }
            if (cboFormaEnvio.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una Forma de envío antes de continuar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboFormaEnvio.Focus();
                return false;
            }
            return true;
        }


        private async Task<bool> GrabarDetallesOrdenes(string data)
        {
            string url = "https://localhost:7037/api/Automotriz/GuardarDetallesOrdenes";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("OK");

            }
        }

        private async Task<bool> GrabarOrdenes(string data)
        {
            string url = "https://localhost:7037/api/Automotriz/GuardarOrdenes";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("OK");

            }
        }

        private async Task<bool> GrabarDetalles(string data)
        {
            string url = "https://localhost:7037/api/Automotriz/GuardarDetalles";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("OK");

            }
        }


        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (validarFactura())
            {
                if (dgvDetalles.Rows.Count < 1 && dgvOrdenes.Rows.Count < 1) //si no hay ninguno
                {
                    MessageBox.Show("Debe cargar al menos un producto en el detalle o en las ordenes de pedido de la factura", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboProducto.Focus();
                }
                else
                {

                    if (dgvDetalles.Rows.Count >= 1 && dgvOrdenes.Rows.Count >= 1) //si estan los 2
                    {
                        FormasPago fp = new FormasPago();
                        fp.IdFormaPago = Convert.ToInt32(cboFormaPago.SelectedValue);
                        FormasEnvio fe = new FormasEnvio();
                        fe.IdFormaEnvio = Convert.ToInt32(cboFormaEnvio.SelectedValue);
                        factura.FormasEnvio = fe;
                        factura.FormasPago = fp;
                        factura.Cliente = cliente;
                        factura.Interes = interes;
                        factura.Descuento = descuento;
                        factura.Fecha = dtpFecha.Value;

                        string data = JsonConvert.SerializeObject(factura);
                        var result = await GrabarDetallesOrdenes(data);
                        string final = result.ToString();

                        if (final != null)
                        {
                            MessageBox.Show("La factura se ha cargado correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiarFactura();
                            await facturaNro();
                            await comboTipoProductos();        //-------------------------------------------------------
                            factura.LimpiarDetalle();
                            factura.LimpiarDetalleOrden();
                            factura.FormasEnvio = null;
                            factura.FormasPago = null;
                            factura.Cliente = null;
                            factura.Interes = 0;
                            factura.Descuento = 0;
                        }
                        else
                        {
                            MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (dgvDetalles.Rows.Count < 1 && dgvOrdenes.Rows.Count >= 1) //si solo hay ordenes
                        {

                

                            FormasPago fp = new FormasPago();
                            fp.IdFormaPago = Convert.ToInt32(cboFormaPago.SelectedIndex) + 1; //----------------//Cambió a selectedindex revisar, prueba de como cargar el combo con lista --------------------------------------------------------------------
                            FormasEnvio fe = new FormasEnvio();
                            fe.IdFormaEnvio = Convert.ToInt32(cboFormaEnvio.SelectedValue);
                            factura.FormasEnvio = fe;
                            factura.FormasPago = fp;
                            factura.Cliente = cliente;
                            factura.Interes = interes;
                            factura.Descuento = descuento;
                            factura.Fecha = dtpFecha.Value;

                            string data = JsonConvert.SerializeObject(factura);
                            var result = await GrabarOrdenes(data);
                            string final = result.ToString();

                            if (final != null)//Cambiar a =="true"
                            {
                                MessageBox.Show("La factura se ha cargado correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiarFactura();
                                await facturaNro();
                                await comboTipoProductos();//-------------------------------------------------------
                                factura.LimpiarDetalleOrden();
                                factura.FormasEnvio = null;
                                factura.FormasPago = null;
                                factura.Cliente = null;
                                factura.Interes = 0;
                                factura.Descuento = 0;

                            }
                            else
                            {
                                MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            if (dgvDetalles.Rows.Count >= 1 && dgvOrdenes.Rows.Count < 1) //si solo hay detalle
                            {
                                FormasPago fp = new FormasPago();
                                fp.IdFormaPago = Convert.ToInt32(cboFormaPago.SelectedValue);
                                FormasEnvio fe = new FormasEnvio();
                                fe.IdFormaEnvio = Convert.ToInt32(cboFormaEnvio.SelectedValue);
                                factura.FormasEnvio = fe;
                                factura.FormasPago = fp;
                                factura.Cliente = cliente;
                                factura.Interes = interes;
                                factura.Descuento = descuento;
                                factura.Fecha = dtpFecha.Value;

                                string data = JsonConvert.SerializeObject(factura);
                                //var result = await GrabarDetalles(data);                                      SE CAMBIO ESTE TRAMO PARA UTILIZAR EL SINGLETON Y DESCARTAR LO ANTERIOR
                                var result = await ClientSingleton.GetInstance().PostAsync("https://localhost:7037/api/Automotriz/GuardarDetalles", data);
                                string final = result.ToString();

                                if (final != null)
                                {
                                    MessageBox.Show("La factura se ha cargado correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    limpiarFactura();
                                    await facturaNro();
                                    await comboTipoProductos();//---------------------------------------------------------------
                                    factura.LimpiarDetalle();
                                    factura.FormasEnvio = null;
                                    factura.FormasPago = null;
                                    factura.Cliente = null;
                                    factura.Interes = 0;
                                    factura.Descuento = 0;

                                }
                                else
                                {
                                    MessageBox.Show("Error", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
            }
        }

        private async void cboProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {


            //DataTable tabla = new DataTable();
            if (cboTipoProducto.Text == "AutoPartes")
            {
                List<Producto> lst = new List<Producto>();
                string url = "https://localhost:7037/api/Automotriz/ObtenerAutoparte";
                using (HttpClient client = new HttpClient())
                {
                    var result = await client.GetAsync(url);
                    var body = await result.Content.ReadAsStringAsync();
                    lst = JsonConvert.DeserializeObject<List<Producto>>(body);
                }

                int i = cboProducto.SelectedIndex;
                //tabla = oServicio.productosAutopartes();   //El estado de los productos listado es activo, es decir, que su atributo estado es = a 1
                txtPrecio.Text = Convert.ToString(lst[i].Precio.ToString());
                txtStock.Text = lst[i].Stock.ToString();
                txtStockMinimo.Text = lst[i].StockMinimo.ToString();
            }
            else
            {
                List<Producto> lst = new List<Producto>();
                string url = "https://localhost:7037/api/Automotriz/ObtenerVehiculo";
                using (HttpClient client = new HttpClient())
                {
                    var result = await client.GetAsync(url);
                    var body = await result.Content.ReadAsStringAsync();
                    lst = JsonConvert.DeserializeObject<List<Producto>>(body);
                }

                int i = cboProducto.SelectedIndex;
                //tabla = oServicio.productosVehiculos();    //El estado de los productos listado es activo, es decir, que su atributo estado es = a 1
                txtPrecio.Text = Convert.ToString(lst[i].Precio.ToString());
                txtStock.Text = lst[i].Stock.ToString();
                txtStockMinimo.Text = lst[i].StockMinimo.ToString();
            }
        }

        private async void cboTipoProducto_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            

            //DataTable tabla = new DataTable();
            if (cboTipoProducto.Text == "AutoPartes")
            {
                List<Producto> p = new List<Producto>();
                string url = "https://localhost:7037/api/Automotriz/ObtenerAutoparte";

                var data = await ClientSingleton.GetInstance().GetAsync(url);  //ACÁ USA EL SINGLETOOOON
                var lst = JsonConvert.DeserializeObject<List<Producto>>(data);
                cboProducto.DataSource = lst;
                cboProducto.ValueMember = "IdProducto";
                cboProducto.DisplayMember = "Nombre";


                //using (HttpClient client = new HttpClient())
                //{
                //    var result = await client.GetAsync(url);
                //    var body = await result.Content.ReadAsStringAsync();
                //    p = JsonConvert.DeserializeObject<List<Producto>>(body);

                //    cboProducto.DataSource = p;
                //    cboProducto.ValueMember = "IdProducto";
                //    cboProducto.DisplayMember = "Nombre";
                //}


                int i = cboProducto.SelectedIndex;
                //p = oServicio.productosAutopartes();   //El estado de los productos listado es activo, es decir, que su atributo estado es = a 1
                if (lst != null) //---------------------------------------------------------------------------------------------
                {
                    txtPrecio.Text = Convert.ToString(lst[i].Precio.ToString());
                    txtStock.Text = lst[i].Stock.ToString();
                    txtStockMinimo.Text = lst[i].StockMinimo.ToString();
                }

            }
            else
            {
                var p = new List<Producto>();  //------------------------------------------------------------------------------
                string url = "https://localhost:7037/api/Automotriz/ObtenerVehiculo";
                using (HttpClient client = new HttpClient())
                {
                    var result = await client.GetAsync(url);
                    var body = await result.Content.ReadAsStringAsync();
                    try
                    {
                        p = JsonConvert.DeserializeObject<List<Producto>>(body);
                        if (p != null)//------------------------------------------------------------------------------------------
                        {
                            cboProducto.DataSource = p;
                            cboProducto.ValueMember = "IdProducto";
                            cboProducto.DisplayMember = "Nombre";
                        }
                    }
                    catch
                    {

                    }
                    
                }
                int i = cboProducto.SelectedIndex;
                //p = oServicio.productosVehiculos();    //El estado de los productos listado es activo, es decir, que su atributo estado es = a 1
                try //--------------------------------------------------------------------------------------------
                {
                    txtPrecio.Text = Convert.ToString(p[i].Precio.ToString());
                    txtStock.Text = p[i].Stock.ToString();
                    txtStockMinimo.Text = p[i].StockMinimo.ToString();
                }
                catch
                {

                }

            }
        }
    }
}
