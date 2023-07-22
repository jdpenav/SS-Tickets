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

namespace SeminarioTickets
{
    public partial class FrmEventos : Form
    {
        Conexion Conexion = new Conexion();
        CargaDatos CargarDatos = new CargaDatos();
        SqlDataReader DR1;
        SqlCommand CMD;
        int codigoTipoEvento = 0, codigoLugar = 0;

        string cadena = "Select idEvt as [Identificador Evento], Eventos.NomEvt as Nombre, TipoEventos.NomEvn as [Tipo de Evento], FchEvt as Fecha, HrEvt as Hora, NomLug as Lugar, CapEvt as Capacidad, ResEvt as Reservacion from Eventos Inner Join TipoEventos on Eventos.IdEvn = TipoEventos.IdEvn Inner Join Lugares on Eventos.IdLug = Lugares.IdLug";
        string cadenaTipoEvento = "Select NomEvn from TipoEventos";
        string cadenaLugar = "Select NomLug from Lugares";
        string usuario = Properties.Settings.Default.EmlUsu;
        string dscbit = "";

        public FrmEventos()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void limpiarCampos()
        {
            txtNombre.Clear();
            txtCapacidad.Clear();
            txtReservacion.Clear();
            dtpFecha.Value = DateTime.Now;
            cbHora.SelectedIndex = 0;
            cbLugar.SelectedIndex = 0;
            cbTipoEvento.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.abrir();
                if (txtNombre.Text == string.Empty || txtCapacidad.Text == string.Empty || txtReservacion.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Para sacar el id del tipo de evento
                    CMD = new SqlCommand("SELECT IdEvn FROM TipoEventos WHERE NomEvn = '" + cbTipoEvento.Text + "'", Conexion.sc);
                    DR1 = CMD.ExecuteReader();

                    if (DR1.Read())
                    {
                        codigoTipoEvento = Convert.ToInt32(DR1["IdEvn"]);
                    }
                    DR1.Close();

                    //Para sacar el id del lugar
                    CMD = new SqlCommand("SELECT IdLug FROM Lugares WHERE NomLug = '" + cbLugar.Text + "'", Conexion.sc);
                    DR1 = CMD.ExecuteReader();

                    if (DR1.Read())
                    {
                        codigoLugar = Convert.ToInt32(DR1["IdLug"]);
                    }
                    DR1.Close();

                    Conexion.Modificaciones("exec InsercionEventos '" + txtNombre.Text + "', " + codigoTipoEvento + ", '" + dtpFecha.Text + "', '" + cbHora.Text + "', " + codigoLugar + ", " + Convert.ToInt32(txtCapacidad.Text) + ", " + Convert.ToInt32(txtReservacion.Text) + "");
                    dscbit = "Se realizo insercion en Eventos";
                    Conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    MessageBox.Show("Datos guardados correctamente", "Eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos.cargaDatos(dgvEventos, cadena);

                    limpiarCampos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Guardado de Datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }finally
            { 
                Conexion.cerrar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.abrir();
                if (lblIdentificador.Text == string.Empty || txtNombre.Text == string.Empty || txtCapacidad.Text == string.Empty || txtReservacion.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Para sacar el id del tipo de evento
                    CMD = new SqlCommand("SELECT IdEvn FROM TipoEventos WHERE NomEvn = '" + cbTipoEvento.Text + "'", Conexion.sc);
                    DR1 = CMD.ExecuteReader();

                    if (DR1.Read())
                    {
                        codigoTipoEvento = Convert.ToInt32(DR1["IdEvn"]);
                    }
                    DR1.Close();

                    //Para sacar el id del lugar
                    CMD = new SqlCommand("SELECT IdLug FROM Lugares WHERE NomLug = '" + cbLugar.Text + "'", Conexion.sc);
                    DR1 = CMD.ExecuteReader();

                    if (DR1.Read())
                    {
                        codigoLugar = Convert.ToInt32(DR1["IdLug"]);
                    }
                    DR1.Close();

                    Conexion.Modificaciones("Exec ActualizarEvento " + Convert.ToInt32(lblIdentificador.Text) + ", '" + txtNombre.Text + "', " + codigoTipoEvento + ", '" + dtpFecha.Text + "', '" + cbHora.Text + "', " + codigoLugar + ", " + Convert.ToInt32(txtCapacidad.Text) + ", " + Convert.ToInt32(txtReservacion.Text) + "");
                    dscbit = "Se realizo Actualizacion en Eventos";
                    Conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    MessageBox.Show("Datos actualizados correctamente", "Eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos.cargaDatos(dgvEventos, cadena);

                    limpiarCampos();
                    btnGuardar.Enabled = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al actualizar datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { 
                Conexion.cerrar(); 
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.abrir();
                if(lblIdentificador.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(MessageBox.Show("¿Está seguro de que desea eliminar este objeto?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Conexion.Modificaciones("Exec EliminarEvento " + Convert.ToInt32(lblIdentificador.Text) + "");
                        dscbit = "Se realizo Eliminacion de un registro en eventos";
                        Conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                        MessageBox.Show("Datos eliminados correctamente", "Eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos.cargaDatos(dgvEventos, cadena);

                        limpiarCampos();
                        btnGuardar.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            { 
                Conexion.cerrar(); 
            }
        }

        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblIdentificador.Text = dgvEventos.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvEventos.CurrentRow.Cells[1].Value.ToString();
                cbTipoEvento.Text = dgvEventos.CurrentRow.Cells[2].Value.ToString();
                dtpFecha.Text = dgvEventos.CurrentRow.Cells[3].Value.ToString();
                cbHora.Text = dgvEventos.CurrentRow.Cells[4].Value.ToString();
                cbLugar.Text = dgvEventos.CurrentRow.Cells[5].Value.ToString();
                txtCapacidad.Text = dgvEventos.CurrentRow.Cells[6].Value.ToString();
                txtReservacion.Text = dgvEventos.CurrentRow.Cells[7].Value.ToString();

                btnGuardar.Enabled = false;
            }catch (Exception ex)
            {
                MessageBox.Show("Error seleccionando el dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FrmEventos_Load(object sender, EventArgs e)
        {
            CargarDatos.cargaDatos(dgvEventos, cadena);
            CargarDatos.cargarComboBox(cbTipoEvento, cadenaTipoEvento, "NomEvn");
            CargarDatos.cargarComboBox(cbLugar, cadenaLugar, "NomLug");

            dtpFecha.MinDate = DateTime.Now;

            cbTipoEvento.SelectedIndex = 0;
            cbLugar.SelectedIndex = 0;
            cbHora.SelectedIndex = 0;
        }
    }
}
