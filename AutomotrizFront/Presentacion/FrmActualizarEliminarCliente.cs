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
    public partial class FrmActualizarEliminarCliente : Form
    {
        private Cliente cliente;
        List<Cliente> clientes;
        public FrmActualizarEliminarCliente()
        {
            InitializeComponent();
            cliente = new Cliente();
            clientes = new List<Cliente>();
        }

        private async void FrmActualizarEliminarCliente_Load(object sender, EventArgs e)
        {
            await actualizarLista();
            await comboTipoCliente();
            await comboTipoDoc();
            await comboProvincia();
            habilitar(false);
            TxtNumeroDoc.Enabled = false;
            CboTipoDoc.Enabled = false;

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

        private async Task comboProvincia()
        {
            string url = "https://localhost:7037/api/Automotriz/ObtenerProvincias";
            var data = await ClientSingleton.GetInstance().GetAsync(url);
            List<Provincia> lst = JsonConvert.DeserializeObject<List<Provincia>>(data);
            CboProvincia.DataSource = lst;
            CboProvincia.DisplayMember = "Nombre";
            CboProvincia.ValueMember = "IdProvincia";
        }

        private async void comboLocalidad()
        {
            int i = Convert.ToInt32(CboProvincia.SelectedIndex) + 1;


            if (i >= 0)
            {
                string url = "https://localhost:7037/api/Automotriz/ObtenerLocalidad";
                var data = await ClientSingleton.GetInstance().GetAsync(url);
                List<Localidad> lst = JsonConvert.DeserializeObject<List<Localidad>>(data);
                List<Localidad> final = new List<Localidad>();

                foreach (Localidad index in lst)
                {
                    if (index.Provincia.IdProvincia.Equals(i))
                    {
                        final.Add(index);
                    }
                }
                CboLocalidad.DataSource = final;
                CboLocalidad.DisplayMember = "Nombre";
                CboLocalidad.ValueMember = "IdLocalidad";
            }


        }

        private async void comboBarrio()
        {
            //Acordate que al momento de insertar el id del barrio hay que sumarle 1 para que coincida!!!!!!!

            int i = Convert.ToInt32(CboLocalidad.SelectedIndex) + 1;

            if (i >= 0)
            {
                string url = "https://localhost:7037/api/Automotriz/ObtenerBarrio";
                var data = await ClientSingleton.GetInstance().GetAsync(url);
                var lst = JsonConvert.DeserializeObject<List<Barrio>>(data);

                List<Barrio> final = new List<Barrio>();

                if (lst != null)
                {
                    foreach (Barrio bar in lst)
                    {
                        if (bar.Localidad.IdLocalidad.Equals(i))
                        {
                            final.Add(bar);
                        }
                    }
                    CboBarrio.DataSource = final;
                    CboBarrio.DisplayMember = "Nombre";
                    CboBarrio.ValueMember = "IdBarrio";
                }

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
                var lst = new List<Cliente>();
                lst = JsonConvert.DeserializeObject<List<Cliente>>(body);
                lstClientes.DataSource = lst;
                clientes = lst;
            }
            lstClientes.SelectedIndex = -1;
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
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
                    CboBarrio.SelectedIndex = -1;
                    CboLocalidad.SelectedIndex = -1;
                    CboProvincia.SelectedIndex = -1;
                    cliente.IdCliente = clientes[posicion].IdCliente;
                    
                }

                habilitar(true);

            }
        }

        private void CboBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CboLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboLocalidad.SelectedIndex >= 0)
            {
                comboBarrio();
            }
        }

        private void CboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboProvincia.SelectedIndex >= 0)
            {
                comboLocalidad();
            }
        }

        private void habilitar(bool x)
        {
            TxtApellido.Enabled = x;
            TxtCorreo.Enabled = x;
            TxtNombre.Enabled = x;
            TxtTelefono.Enabled = x;
            CboBarrio.Enabled = x;
            CboLocalidad.Enabled = x;
            CboProvincia.Enabled = x;
            CboTipoCliente.Enabled = x;
            BtnActualizar.Enabled = x;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea salir?", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (validarActualizar())
            {
                int idtipocliente = Convert.ToInt32(CboTipoCliente.SelectedValue.ToString());
                int idtipodoc = Convert.ToInt32(CboTipoDoc.SelectedValue.ToString());
                int idBarrio = Convert.ToInt32(CboBarrio.SelectedValue.ToString());
                int localidad = Convert.ToInt32(CboLocalidad.SelectedValue.ToString());
                int provincia = Convert.ToInt32(CboProvincia.SelectedValue.ToString());

                Localidad loc = new Localidad();
                loc.IdLocalidad = localidad;

                Provincia prov = new Provincia();
                prov.IdProvincia = provincia;



                cliente.Nombre = Convert.ToString(TxtNombre.Text);
                cliente.Apellido = Convert.ToString(TxtApellido.Text);
                cliente.NumeroDocumento = Convert.ToInt32(TxtNumeroDoc.Text);
                cliente.Telefono = Convert.ToInt32(TxtTelefono.Text);
                cliente.Email = Convert.ToString(TxtCorreo.Text);
                TiposClientes tc = new TiposClientes();
                tc.IdTipoCliente = idtipocliente;
                TiposDocumento td = new TiposDocumento();
                td.IdTipoDoc = idtipodoc;
                Barrio b = new Barrio();
                b.IdBarrio = idBarrio;
                b.Localidad = loc;
                b.Localidad.Provincia = prov;
                cliente.TipoCliente = tc;
                cliente.TiposDocumento = td;
                cliente.Barrio = b;

                //string data = JsonConvert.SerializeObject(cliente);
                //var result = await GrabarCliente(data);
                //string final = result.ToString();


                string url = "https://localhost:7037/api/Automotriz/ActualizarCliente";
                string bodyContent = JsonConvert.SerializeObject(cliente);
                var result = await ClientSingleton.GetInstance().UpdateAsync(url, bodyContent);

                if (result.Equals("true"))
                {
                    MessageBox.Show("El cliente fue ingresado con éxito.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El cliente no pudo ser ingresado.", "ERROR.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                lstClientes.SelectedIndex = -1;
                //limpiar();
                habilitar(false);
                //await actualizarLista();
            }
        }


        private bool validarActualizar()
        {
            bool aux = true;

            if (CboTipoCliente.SelectedIndex < 0)
            {
                MessageBox.Show("Debe selectionar un tipo de cliente!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CboTipoCliente.Focus();
                return false;
            }

            if (CboTipoDoc.SelectedIndex < 0)
            {
                MessageBox.Show("Debe selectionar un tipo de documento!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CboTipoDoc.Focus();
                return false;
            }

            if (CboProvincia.SelectedIndex < 0)
            {
                MessageBox.Show("Debe selectionar una provincia!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CboProvincia.Focus();
                return false;
            }

            if (CboLocalidad.SelectedIndex < 0)//
            {
                MessageBox.Show("Debe selectionar una localidad!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CboLocalidad.Focus();
                return false;
            }

            if (CboBarrio.SelectedIndex < 0)
            {
                MessageBox.Show("Debe selectionar un barrio!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CboBarrio.Focus();
                return false;
            }

            if (TxtNombre.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNombre.Focus();
                return false;
            }

            if (TxtApellido.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un apellido válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtApellido.Focus();
                return false;
            }

            if (TxtNumeroDoc.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un número de documento válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNumeroDoc.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtNumeroDoc.Text);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar un número de documento válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNumeroDoc.Focus();
                    return false;
                }
            }

            if (TxtTelefono.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un número de telefono válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtTelefono.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(TxtTelefono.Text);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar un número de telefono válido. solo pueden contener números", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtTelefono.Focus();
                    return false;
                }
            }

            if (TxtCorreo.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un correo electrónico válido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCorreo.Focus();
                return false;
            }



            return aux;
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
        }

        private void ChkClienteSinFactu_CheckedChanged(object sender, EventArgs e)
        {
        }
    }

}
