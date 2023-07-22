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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        Conexion conexion = new Conexion();

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Show();
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void buscarToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            FrmBitacora frmBitacora = new FrmBitacora();
            frmBitacora.Show();

        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPuestos frmPuestos = new FrmPuestos();
            frmPuestos.Show();
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmColaboradores frmColaboradores = new FrmColaboradores();
            frmColaboradores.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            conexion.Grids("select IdEvt No, NomEvt as Evento, FchEvt as Fecha,HrEvt Hora, CapEvt Capacidad from eventos", dgvDatos);

            if (Properties.Settings.Default.Nvl == "Usuario")
            {
                toolStripMenuItem1.Visible = false;
                ticketsToolStripMenuItem.Visible = false;
                seguridadToolStripMenuItem.Visible = false;
               
            }

            usuStrip.Text = "Sesion Iniciada Como " + Properties.Settings.Default.EmlUsu;
            usuStrip.ForeColor = Color.MediumSeaGreen;
            usuStrip.BackColor = Color.DimGray;

            checkEvento(Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value));

        }

        private void nuevoToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FrmEventos Evento = new FrmEventos();
            Evento.ShowDialog();
        }

        private void nivelesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            FrmNiveles nivel = new FrmNiveles();
            nivel.ShowDialog();
        }

        private void nuevoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmLugares lugares = new FrmLugares();
            lugares.ShowDialog();

        }

        private void nuevoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmUbicaciones frmUbicaciones = new FrmUbicaciones();
            frmUbicaciones.Show();
        }

        private void nuevoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FrmTipoEventos frmTipoEventos = new FrmTipoEventos();
            frmTipoEventos.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Nvl = String.Empty;
            Properties.Settings.Default.Pass = String.Empty;
            Properties.Settings.Default.EmlUsu = String.Empty;
            frmLogin Login = new frmLogin();
            this.Hide();
            Login.Show();
        }

        private void nuevoToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.Show();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            frmReservar r = new frmReservar();
            r.idEvt = dgvDatos.CurrentRow.Cells[0].Value.ToString();
            r.NomEvt = dgvDatos.CurrentRow.Cells[1].Value.ToString();

            this.Hide();
            r.Show();
        }

     
    

        private void facturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorialFacturas_Click(object sender, EventArgs e)
        {
            FrmHistorial fh = new FrmHistorial();
            fh.Show();
            this.Hide();
        }

        private void cerrarSesionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.Nvl = String.Empty;
            Properties.Settings.Default.Pass = String.Empty;
            Properties.Settings.Default.EmlUsu = String.Empty;
            Properties.Settings.Default.RememberMe = false;
            Properties.Settings.Default.FechaInicio = DateTime.Now.AddDays(1);
            Properties.Settings.Default.Save();

            frmLogin Login = new frmLogin();
            this.Hide();
            Login.Show();
        }

        private void usuStrip_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void checkEvento(int idEvt)
        {
            string Fecha = conexion.Escalar("select top 1 FchEvt from eventos where IdEvt = '"+idEvt+"'"  );
            DateTime Fch = Convert.ToDateTime(Fecha);

            string capacidad = conexion.Escalar("select top 1 CapEvt from eventos where IdEvt = '" + idEvt + "'");
            int Cap = Convert.ToInt32(capacidad);

            string TckV = conexion.Escalar("select count(*) from tickets where IdEvt = '" + idEvt + "'");
            int TckVendidos = Convert.ToInt32(TckV);

            if (TckVendidos>=Cap || DateTime.Now > Fch) {
                btnReservar.Enabled = false;
            }
            else 
                btnReservar.Enabled = true;
            


        }


        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checkEvento(Convert.ToInt32(dgvDatos.CurrentRow.Cells[0].Value));
        }
    }
}
