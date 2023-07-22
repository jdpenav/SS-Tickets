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
    public partial class FrmUbicaciones : Form
    {

        Conexion conexion = new Conexion();
        string usuario = Properties.Settings.Default.EmlUsu;
        string dscbit = "";


        public FrmUbicaciones()
        {
            InitializeComponent();
        }

        private void FrmUbicaciones_Load(object sender, EventArgs e)
        {
            conexion.Grids("SELECT IdUbc as ID, ZonaUbc as Ubicacion, PreTct as Precio FROM Ubicaciones", dgvUbicaciones);
            txtId.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir();

                if (txtNombre.Text == string.Empty || txtPrecio.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    conexion.Modificaciones("exec InsercionUbicaciones '" + txtNombre.Text +  "' , "+txtPrecio.Text+"");
                    dscbit = "Se realizo insercion en Ubicaciones";
                    conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    MessageBox.Show("Datos guardados correctamente", "NUEVA UBICACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNombre.Clear();
                    txtNombre.Focus();

                    conexion.Grids("SELECT IdUbc as ID, ZonaUbc as Ubicacion, PreTct as Precio FROM Ubicaciones", dgvUbicaciones);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Guardado de los Datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }finally
            {
                conexion.cerrar();
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try
            {
                conexion.abrir();

                if (txtId.Text == string.Empty || txtNombre.Text == string.Empty ||  txtPrecio.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {
                    conexion.Modificaciones("exec ActualizarUbicacion2 " + txtId.Text + ", '" + txtNombre.Text + "' , "+txtPrecio.Text+"");
                    dscbit = "Se realizo Actualizacion en Ubicaciones";
                    conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    MessageBox.Show("Datos editados correctamente", "UBICACIÓN ACTUALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtId.Clear();
                    txtNombre.Clear();
                    txtNombre.Focus();

                    conexion.Grids("SELECT IdUbc as ID, ZonaUbc as Ubicacion, PreTct as Precio FROM Ubicaciones", dgvUbicaciones);
                }

            } 
            catch (Exception ex) 
            {
                MessageBox.Show("Error al actualizar datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conexion.cerrar();
            }





        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                conexion.abrir();

                if(txtId.Text == string.Empty || txtNombre.Text== string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    if (MessageBox.Show("¿Está seguro de que desea eliminar este objeto?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        conexion.Modificaciones("exec EliminarUbicacion " + txtId.Text);
                        dscbit = "Se realizo Eliminacion de registro en Ubicaciones";
                        conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                        MessageBox.Show("Registro eliminado correctamente", "UBICACIÓN ELIMINADA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtId.Clear();
                        txtNombre.Clear();
                        txtNombre.Focus();

                        conexion.Grids("SELECT IdUbc as ID, ZonaUbc as Ubicacion, PreTct as Precio FROM Ubicaciones", dgvUbicaciones);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtBuscar.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    conexion.Grids("SELECT IdUbc as ID, ZonaUbc as Ubicacion FROM Ubicaciones WHERE ZonaUbc LIKE '%" + txtBuscar.Text + "%'", dgvUbicaciones);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al buscar los datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btnBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                conexion.Grids("SELECT IdUbc as ID, ZonaUbc as Ubicacion, PreTct as Precio FROM Ubicaciones", dgvUbicaciones);
            }
        }

        private void dgvUbicaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dgvUbicaciones.Rows[dgvUbicaciones.CurrentRow.Index].Cells[0].Value.ToString();
                txtNombre.Text = dgvUbicaciones.Rows[dgvUbicaciones.CurrentRow.Index].Cells[1].Value.ToString();

                btnGuardar.Enabled = false;
            }catch(Exception ex)
            {
                MessageBox.Show("Error seleccionando el dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
