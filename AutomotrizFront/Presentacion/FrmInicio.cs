using AutomotrizFront.Presentacion;
using CorPartReportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorPartAutomotriz.Presentacion
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFactura frmFactura = new FrmFactura();
            frmFactura.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoClientes frmCliente = new FrmNuevoClientes();
            frmCliente.Show();
        }

        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTop3 reporte = new FrmTop3();
            reporte.Show();
        }

        private void actualizarEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmActualizarEliminarCliente actualizarEliminar = new FrmActualizarEliminarCliente();
            actualizarEliminar.Show();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEliminarCliente eliminarCliente = new FrmEliminarCliente();
            eliminarCliente.Show();
        }

        private void reporte2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListado listado = new FrmListado();
            listado.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIntegrantes integrantes = new FrmIntegrantes();
            integrantes.Show();
        }
    }
}
