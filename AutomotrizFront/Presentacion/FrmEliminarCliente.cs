using CorPartAutomotriz.Datos.intefaz;
using CorPartAutomotriz.Dominio;
using CorPartAutomotriz.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront.Presentacion
{
    public partial class FrmEliminarCliente : Form
    {
        private Cliente cliente;
        List<Cliente> clientes;
        int id;
        public FrmEliminarCliente()
        {
            InitializeComponent();
            cliente = new Cliente();
            clientes = new List<Cliente>();
            id = 0;
            
        }

        private async void FrmEliminarCliente_Load(object sender, EventArgs e)
        {
            await ListaSinFactura();
            await comboTipoCliente();
            await comboTipoDoc();
            habilitar(false);
        }

        public async Task ListaSinFactura()
        {
            lstClientes.Items.Clear();
            clientes.Clear();

            string url = "https://localhost:7037/api/Automotriz/listaClienteSinFactura";
            using (HttpClient client = new HttpClient())
            {
                var result = await client.GetAsync(url);
                var body = await result.Content.ReadAsStringAsync();
                var lst = new List<Cliente>();
                lst = JsonConvert.DeserializeObject<List<Cliente>>(body);
                lstClientes.DataSource = lst;
                clientes = lst;
            }
            lstClientes.SelectedIndex = -1;
        }

        private async Task comboTipoCliente()
        {
            string url = "https://localhost:7037/api/Automotriz/TiposClientes";
            var data = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TiposClientes>>(data);
            CboTipoCliente.DataSource = lst;
            CboTipoCliente.DisplayMember = "Nombre";
            CboTipoCliente.ValueMember = "IdTipoCliente";
        }

        private async Task comboTipoDoc()
        {
            string url = "https://localhost:7037/api/Automotriz/ObtenerTiposDoc";
            var data = await ClientSingleton.GetInstance().GetAsync(url);
            List<TiposDocumento> lst = JsonConvert.DeserializeObject<List<TiposDocumento>>(data);
            CboTipoDoc.DataSource = lst;
            CboTipoDoc.DisplayMember = "Nombre";
            CboTipoDoc.ValueMember = "IdTipoDoc";
        }

        private void habilitar(bool x)
        {
            TxtApellido.Enabled = x;
            TxtCorreo.Enabled = x;
            TxtNombre.Enabled = x;
            TxtTelefono.Enabled = x;
            CboTipoCliente.Enabled = x;
            TxtNumeroDoc.Enabled = x;
            CboTipoDoc.Enabled = x;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        public async Task<bool> EliminarCliente(int id)
        {
            string url = "https://localhost:7037/api/Automotriz/EliminarCliente";
            var result = await ClientSingleton.GetInstance().DeleteAsync(url);
            return result.Equals(true);
        }

        private async void BtnEliminar_ClickAsync(object sender, EventArgs e)
        {

            //int idtipocliente = Convert.ToInt32(CboTipoCliente.SelectedValue.ToString());
            //int idtipodoc = Convert.ToInt32(CboTipoDoc.SelectedValue.ToString());
            //int idBarrio = Convert.ToInt32(CboBarrio.SelectedValue.ToString());
            //int localidad = Convert.ToInt32(CboLocalidad.SelectedValue.ToString());
            //int provincia = Convert.ToInt32(CboProvincia.SelectedValue.ToString());

            //Localidad loc = new Localidad();
            //loc.IdLocalidad = localidad;

            //Provincia prov = new Provincia();
            //prov.IdProvincia = provincia;



            //cliente.Nombre = Convert.ToString(TxtNombre.Text);
            //cliente.Apellido = Convert.ToString(TxtApellido.Text);
            //cliente.NumeroDocumento = Convert.ToInt32(TxtNumeroDoc.Text);
            //cliente.Telefono = Convert.ToInt32(TxtTelefono.Text);
            //cliente.Email = Convert.ToString(TxtCorreo.Text);
            //TiposClientes tc = new TiposClientes();
            //tc.IdTipoCliente = idtipocliente;
            //TiposDocumento td = new TiposDocumento();
            //td.IdTipoDoc = idtipodoc;
            //Barrio b = new Barrio();
            //b.IdBarrio = idBarrio;
            //b.Localidad = loc;
            //b.Localidad.Provincia = prov;
            //cliente.TipoCliente = tc;
            //cliente.TiposDocumento = td;
            //cliente.Barrio = b;


            Cliente c = (Cliente)lstClientes.SelectedItem;
            if (c != null)
            {
                try
                {
                    await ClientSingleton.GetInstance().DeleteAsync("https://localhost:7037/api/Automotriz/EliminarCliente/" + c.IdCliente);
                    MessageBox.Show("El cliente se eliminio exitosamente","Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error, no se pudo eliminar el cliente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            lstClientes.SelectedIndex = -1;
            //limpiar();
            habilitar(false);
            this.Close();
        }

        private void lstClientes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int posicion = lstClientes.SelectedIndex;
            if (posicion > -1)
            {
                if (clientes.Count > 1)
                {
                    cliente = clientes[posicion];
                    TxtApellido.Text = cliente.Apellido;
                    TxtNombre.Text = cliente.Nombre;
                    CboTipoCliente.SelectedValue = cliente.TipoCliente.IdTipoCliente;
                    CboTipoDoc.SelectedValue = cliente.TiposDocumento.IdTipoDoc;
                    TxtNumeroDoc.Text = Convert.ToString(cliente.NumeroDocumento);
                    TxtTelefono.Text = Convert.ToString(cliente.Telefono);
                    TxtCorreo.Text = cliente.Email;
                    cliente.IdCliente = clientes[posicion].IdCliente;
                    id = clientes[posicion].IdCliente;
                    CboBarrio.SelectedIndex = -1;
                    CboLocalidad.SelectedIndex = -1;
                    CboProvincia.SelectedIndex = -1;

                }
            }
        }
    }
}
