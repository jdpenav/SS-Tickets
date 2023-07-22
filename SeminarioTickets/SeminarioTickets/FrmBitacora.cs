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
    public partial class FrmBitacora : Form
    {
        public FrmBitacora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Conexion conexion = new Conexion();

        private void FrmBitacora_Load(object sender, EventArgs e)
        {
            conexion.Grids("SELECT IdBit as ID, FchBit as Fecha, HrBit as Hora, EmlUsu as Usuario, TipBit as [Tipo Accion], DscBit as Descripcion FROM Bitacora", dgvBitacora);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime selectedDate = dateTimePicker1.Value.Date;
                string query = $"SELECT IdBit as ID, FchBit as Fecha, HrBit as Hora, EmlUsu as Usuario, TipBit as [Tipo Accion], DscBit as Descripcion FROM Bitacora WHERE FchBit = '{selectedDate}'";

                conexion.Grids(query, dgvBitacora);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            conexion.Grids("SELECT IdBit as ID, FchBit as Fecha, HrBit as Hora, EmlUsu as Usuario, TipBit as [Tipo Accion], DscBit as Descripcion FROM Bitacora", dgvBitacora);
        }
    }
}
