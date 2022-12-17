using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorPartReportes
{
    public partial class FrmListado : Form
    {
        private string cadena;
        private SqlConnection cnn;

        public FrmListado()
        {
            InitializeComponent();
            cadena = @"Data Source=localhost;Initial Catalog=tp_laboratorio_automotriz;Integrated Security=True";
            cnn = new SqlConnection(cadena);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void BtnListado_Click(object sender, EventArgs e)
        {
            bool resultado = true;
            try
            {
                Convert.ToInt32(TxtAnio.Text);
            }
            catch
            {
                resultado = false;
            }
            if (TxtAnio.Text == "" || resultado == false)
            {
                MessageBox.Show("Porfavor ingrese el año que desea analizar", "FALTA INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            { 
                DataTable tabla = new DataTable();
                cnn.Open();
                SqlCommand cmd = new SqlCommand("mostrar_total_promedio_por_perido_con_param", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@año", Convert.ToInt32(TxtAnio.Text));
                tabla.Load(cmd.ExecuteReader());
                cnn.Close();
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSListado", tabla));
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
