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
    public partial class FrmTop3 : Form
    {
        private string cadena;
        private SqlConnection cnn;

        public FrmTop3()
        {
            InitializeComponent();
            cadena = @"Data Source=localhost;Initial Catalog=tp_laboratorio_automotriz;Integrated Security=True";
            cnn = new SqlConnection(cadena);
        }

        private void FrmTop3_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {

            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand("conocer_top_3_marcas", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSReporte", tabla));
            this.reportViewer1.RefreshReport();
        }
    }
}
