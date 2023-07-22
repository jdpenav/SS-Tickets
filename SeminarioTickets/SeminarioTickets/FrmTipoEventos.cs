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
    public partial class FrmTipoEventos : Form
    {
        Conexion conexion = new Conexion();
        string usuario = Properties.Settings.Default.EmlUsu;
        string dscbit = "";

        public FrmTipoEventos()
        {
            InitializeComponent();
        }

        private void FrmTipoEventos_Load(object sender, EventArgs e)
        {
            conexion.Grids("SELECT IdEvn, NomEvn FROM TipoEventos", dgvTipoEventos);
            txtIdTipoEventos.Enabled = false;
        }

        private void btnActualizarTipoEventos_Click(object sender, EventArgs e)
        {

            try
            {
                conexion.abrir();

                if (txtIdTipoEventos.Text == string.Empty || txtNombreTipoEventos.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtIdTipoEventos.Enabled = true;
                    conexion.Modificaciones("exec ActualizacionTipoEventos '" + txtIdTipoEventos.Text + "', '" + txtNombreTipoEventos.Text + "'");
                    dscbit = "Se realizo Actualizacion en TipoEventos";
                    conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    MessageBox.Show("Tipo de evento actualizado correctamente", "TICKETS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIdTipoEventos.Clear();
                    txtNombreTipoEventos.Clear();
                    txtNombreTipoEventos.Focus();

                    conexion.Grids("SELECT IdEvn, NomEvn FROM TipoEventos", dgvTipoEventos);

                    btnGuardarTipoEventos.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Guardado de Datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }
           

            
        }

        private void btnGuardarTipoEventos_Click(object sender, EventArgs e)
        {

            try
            {
                conexion.abrir();

                if(txtNombreTipoEventos.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conexion.Modificaciones("exec InsercionesTipoEventos '" + txtNombreTipoEventos.Text + "'");
                    dscbit = "Se realizo insercion en TipoEventos";
                    conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    MessageBox.Show("Tipo de evento guardado correctamente", "TICKETS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtIdTipoEventos.Clear();
                    txtNombreTipoEventos.Clear();
                    txtNombreTipoEventos.Focus();

                    conexion.Grids("SELECT IdEvn, NomEvn FROM TipoEventos", dgvTipoEventos);
                }


            } catch(Exception ex)
            {
                MessageBox.Show("Error en el Guardado de Datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                conexion.cerrar();
            }

            
            
        }

        private void btnEliminarTipoEventos_Click(object sender, EventArgs e)
        {

            try
            {
                conexion.abrir();

                if (txtIdTipoEventos.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(MessageBox.Show("¿Está seguro de que desea eliminar este objeto?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        txtIdTipoEventos.Enabled = true;
                        conexion.Modificaciones("exec EliminarTipoEventos '" + txtIdTipoEventos.Text + "'");
                        dscbit = "Se realizo Eliminacion de registro en TipoEventos";
                        conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                        MessageBox.Show("Tipo de evento eliminado correctamente", "TICKETS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtIdTipoEventos.Clear();
                        txtNombreTipoEventos.Clear();
                        txtNombreTipoEventos.Focus();

                        conexion.Grids("SELECT IdEvn, NomEvn FROM TipoEventos", dgvTipoEventos);

                        btnGuardarTipoEventos.Enabled = true;


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Guardado de Datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }

            

        }

        private void btnBuscarTipoEventos_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtBuscarNombreEvento.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conexion.Grids("SELECT * FROM TipoEventos WHERE NomEvn LIKE '%" + txtBuscarNombreEvento.Text + "%'", dgvTipoEventos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Guardado de Datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { 
                conexion.cerrar();
            } 
        }

        private void txtBuscarNombreEvento_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarNombreEvento.Text == "")
            {
                conexion.Grids("SELECT * FROM TipoEventos", dgvTipoEventos);
            }
        }

        private void dgvTipoEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdTipoEventos.Text = dgvTipoEventos.Rows[dgvTipoEventos.CurrentRow.Index].Cells[0].Value.ToString();
                txtNombreTipoEventos.Text = dgvTipoEventos.Rows[dgvTipoEventos.CurrentRow.Index].Cells[1].Value.ToString();

                btnGuardarTipoEventos.Enabled = false;

            }
            catch
            {
                MessageBox.Show("Error seleccionando el dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
