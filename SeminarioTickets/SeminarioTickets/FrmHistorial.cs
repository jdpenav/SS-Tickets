using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SeminarioTickets
{
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
        }

        Conexion cnx = new Conexion();


        private void FrmHistorial_Load(object sender, EventArgs e)
        {

            cnx.Grids("SELECT dbo.FacturasDetalle.NroFact, dbo.FacturasEncabezado.FchEmp, dbo.Clientes.NomCli, dbo.Colaboradores.NomEmp, dbo.Puestos.NomPst, dbo.Tickets.IdTct, dbo.Ubicaciones.ZonaUbc, dbo.Ubicaciones.PreTct , dbo.Tickets.NumUbc, dbo.colaboradores.EmlUsu FROM dbo.FacturasDetalle INNER JOIN dbo.FacturasEncabezado ON dbo.FacturasDetalle.NroFact = dbo.FacturasEncabezado.NroFact INNER JOIN dbo.Clientes ON dbo.FacturasEncabezado.IdCli = dbo.Clientes.IdCli " +
               "INNER JOIN dbo.Colaboradores ON dbo.FacturasEncabezado.IdEmp = dbo.Colaboradores.IdEmp INNER JOIN dbo.Tickets ON dbo.FacturasDetalle.IdTct = dbo.Tickets.IdTct AND dbo.Clientes.IdCli = dbo.Tickets.IdCli INNER JOIN dbo.Puestos ON dbo.Colaboradores.IdPst = dbo.Puestos.IdPst INNER JOIN dbo.Ubicaciones ON dbo.Tickets.IdUbc = dbo.Ubicaciones.IdUbc  ", dataGridView1);
        
    }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmMenu f = new FrmMenu();
            f.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reporteFactura r = new reporteFactura();
            r.Show();
            this.Hide();

        }

       

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DetalleFactura d = new DetalleFactura();
            d.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            d.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorialC_Click(object sender, EventArgs e)
        {
            cnx.Grids("SELECT dbo.FacturasDetalle.NroFact, dbo.FacturasEncabezado.FchEmp, dbo.Clientes.NomCli, dbo.Colaboradores.NomEmp, dbo.Puestos.NomPst, dbo.Tickets.IdTct, dbo.Ubicaciones.ZonaUbc, dbo.Ubicaciones.PreTct , dbo.Tickets.NumUbc, dbo.colaboradores.EmlUsu FROM dbo.FacturasDetalle INNER JOIN dbo.FacturasEncabezado ON dbo.FacturasDetalle.NroFact = dbo.FacturasEncabezado.NroFact INNER JOIN dbo.Clientes ON dbo.FacturasEncabezado.IdCli = dbo.Clientes.IdCli " +
               "INNER JOIN dbo.Colaboradores ON dbo.FacturasEncabezado.IdEmp = dbo.Colaboradores.IdEmp INNER JOIN dbo.Tickets ON dbo.FacturasDetalle.IdTct = dbo.Tickets.IdTct AND dbo.Clientes.IdCli = dbo.Tickets.IdCli INNER JOIN dbo.Puestos ON dbo.Colaboradores.IdPst = dbo.Puestos.IdPst INNER JOIN dbo.Ubicaciones ON dbo.Tickets.IdUbc = dbo.Ubicaciones.IdUbc  ", dataGridView1);
    }

        private void btnMiHistorial_Click(object sender, EventArgs e)
        {
            string usu = Properties.Settings.Default.EmlUsu;
            if (Properties.Settings.Default.Nvl == "Usuario")
                button1.Visible = false;

            cnx.Grids("SELECT dbo.FacturasDetalle.NroFact, dbo.FacturasEncabezado.FchEmp, dbo.Clientes.NomCli, dbo.Colaboradores.NomEmp, dbo.Puestos.NomPst, dbo.Tickets.IdTct, dbo.Ubicaciones.ZonaUbc, dbo.Ubicaciones.PreTct , dbo.Tickets.NumUbc, dbo.colaboradores.EmlUsu FROM dbo.FacturasDetalle INNER JOIN dbo.FacturasEncabezado ON dbo.FacturasDetalle.NroFact = dbo.FacturasEncabezado.NroFact INNER JOIN dbo.Clientes ON dbo.FacturasEncabezado.IdCli = dbo.Clientes.IdCli INNER JOIN dbo.Colaboradores ON dbo.FacturasEncabezado.IdEmp = dbo.Colaboradores.IdEmp INNER JOIN dbo.Tickets ON dbo.FacturasDetalle.IdTct = dbo.Tickets.IdTct AND dbo.Clientes.IdCli = dbo.Tickets.IdCli INNER JOIN dbo.Puestos ON dbo.Colaboradores.IdPst = dbo.Puestos.IdPst INNER JOIN dbo.Ubicaciones ON dbo.Tickets.IdUbc = dbo.Ubicaciones.IdUbc where EmlUsu = '" + Properties.Settings.Default.EmlUsu + "' ", dataGridView1);

        }
    }
}
