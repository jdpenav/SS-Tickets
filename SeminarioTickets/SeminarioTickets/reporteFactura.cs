using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
{
    public partial class reporteFactura : Form
    {
        public reporteFactura()
        {
            InitializeComponent();
        }

        private void reporteFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'SeminarioTicketsDataSet1.vistaReporteFactura' Puede moverla o quitarla según sea necesario.
            this.vistaReporteFacturaTableAdapter.Fill(this.SeminarioTicketsDataSet1.vistaReporteFactura);

            this.reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmHistorial f = new FrmHistorial();
            f.Show();
            this.Hide();
        }
    }
}
