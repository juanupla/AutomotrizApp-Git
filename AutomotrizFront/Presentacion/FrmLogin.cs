using CorPartAutomotriz.Dominio;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblLogin.Parent = pictureBox1;
            lblLogin.BackColor = Color.Transparent;
            lblContraseña.Parent = pictureBox1;
            lblContraseña.BackColor = Color.Transparent;
            lblUsuario.Parent = pictureBox1;
            lblUsuario.BackColor = Color.Transparent;
            lblSugerido.Parent = pictureBox1;
            lblSugerido.BackColor = Color.Transparent;
            txtUsuario.Text = "Administrador";
            txtContraseña.Text = "123456";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea abandoar la aplicación?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public async Task<bool> validarLogin()
        {
          
            string url = "https://localhost:7037/api/Automotriz/loginUsuarios";
            using (HttpClient client = new HttpClient())
            {
                List<Usuario> user = new List<Usuario>();
                var result = await client.GetAsync(url);
                var body = await result.Content.ReadAsStringAsync();
                user = JsonConvert.DeserializeObject<List<Usuario>>(body);
                bool aux = false;
                for (int i = 0; i < user.Count; i++)
                {
                    if (user[i].NombreUsuario == txtUsuario.Text && user[i].Contraseña == Convert.ToInt32(txtContraseña.Text))
                    {
                        aux = true;
                        break;
                    }
                }
                return aux;
            }

        }

        public bool validarDatos()
        {
            bool aux = true;
            if (txtUsuario.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un nombre de usuario", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                aux = false;
            }
            if (txtContraseña.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar una contraseña válida", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
                aux = false;
            }
            else
            {
                try
                {
                    Convert.ToInt32(txtContraseña.Text);
                }
                catch
                {
                    MessageBox.Show("La contraseña solo puede contener números", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtContraseña.Focus();
                    aux = false;
                }
            }

            return aux;
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (await validarLogin())
                {
                    FrmInicio fr = new FrmInicio();
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
                }
            }
        }
    }
}
