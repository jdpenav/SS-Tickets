using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        Conexion conexion = new Conexion();
        string usuario = Properties.Settings.Default.EmlUsu;
        string dscbit = "";



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int genero;
            if(cbxGenero.Text == "Femenino")
            {
                genero = 1;
            }
            else
            {
                genero = 0;
            }

            try
            {
                conexion.abrir();

                if (txtId.Text == string.Empty || txtNombre.Text == string.Empty || txtTelefono.Text == string.Empty || txtCorreo.Text == string.Empty || txtDireccion.Text == string.Empty || txtRTN.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                else
                {
                    conexion.Modificaciones("exec InsercionClientes '" + txtId.Text + "', '" + txtNombre.Text + "', " + txtTelefono.Text + ", '" + txtCorreo.Text + "', '" + txtDireccion.Text + "', '" + txtRTN.Text + "', " + "'" + genero + "'");

                    

                    MessageBox.Show("Datos guardados correctamente", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dscbit = "Se realizo insercion en Lugares";
                    conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    txtId.Clear();
                    txtNombre.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                    txtDireccion.Clear();
                    txtRTN.Clear();

                    txtId.Focus();

                    conexion.Grids("SELECT IdCli as Identidad, NomCli as Nombre,  TelCli as Telefono, EmlCli as Correo, DirCli as Direccion, RtnCli  as RTN, CASE WHEN GnrCli = 1 THEN 'Femenino' ELSE 'Masculino' END AS Genero FROM Clientes", dgvClientes);
                }

            }catch(Exception ex) 
            {
                MessageBox.Show("Error en el Guardado de Datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }

            

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            conexion.Grids("SELECT IdCli as Identidad, NomCli as Nombre,  TelCli as Telefono, EmlCli as Correo, DirCli as Direccion, RtnCli  as RTN, CASE WHEN GnrCli = 1 THEN 'Femenino' ELSE 'Masculino' END as Genero FROM Clientes", dgvClientes);
            cbxGenero.SelectedIndex = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int genero;
            if (cbxGenero.Text == "Femenino")
            {
                genero = 1;
            }
            else
            {
                genero = 0;
            }

            try
            {
                conexion.abrir();

                if (txtId.Text == string.Empty || txtNombre.Text == string.Empty || txtTelefono.Text == string.Empty || txtCorreo.Text == string.Empty || txtDireccion.Text == string.Empty || txtRTN.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    conexion.Modificaciones("exec ActualizarClientes '" + txtId.Text + "', '" + txtNombre.Text + "', '" + txtTelefono.Text + "', '" + txtCorreo.Text + "', '" + txtDireccion.Text + "', '" + txtRTN.Text + "', '" + genero + "'");
                    dscbit = "Se realizo Actualizacion en Lugares";
                    conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");
                     
                    MessageBox.Show("Datos editados correctamente", "CLIENTES ACTUALIZADA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtId.Clear();
                    txtNombre.Clear();
                    txtTelefono.Clear();
                    txtCorreo.Clear();
                    txtDireccion.Clear();
                    txtRTN.Clear();

                    txtId.Enabled = true;

                    txtId.Focus();

                    conexion.Grids("SELECT IdCli as Identidad, NomCli as Nombre,  TelCli as Telefono, EmlCli as Correo, DirCli as Direccion, RtnCli  as RTN, CASE WHEN GnrCli = 1 THEN 'Femenino' ELSE 'Masculino' END AS Genero FROM Clientes", dgvClientes);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error en el Guardado de Datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (txtId.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro de que desea eliminar este objeto?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        conexion.Modificaciones("exec EliminarClientes '" + txtId.Text + "'");
                        dscbit = "Se realizo Eliminacion de un registro en Lugares";
                        conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                        MessageBox.Show("Registro eliminado correctamente", "CLIENTE ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtId.Clear();
                        txtNombre.Clear();
                        txtTelefono.Clear();
                        txtCorreo.Clear();
                        txtDireccion.Clear();
                        txtRTN.Clear();

                        txtId.Enabled = true;

                        txtId.Focus();

                        conexion.Grids("SELECT IdCli as Identidad, NomCli as Nombre,  TelCli as Telefono, EmlCli as Correo, DirCli as Direccion, RtnCli  as RTN, CASE WHEN GnrCli = 1 THEN 'Femenino' ELSE 'Masculino' END AS Genero FROM Clientes", dgvClientes);
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

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                txtTelefono.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                txtCorreo.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
                txtRTN.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
                cbxGenero.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();

                btnGuardar.Enabled = false;
                txtId.Enabled = false;

            }
            catch
            {
                MessageBox.Show("Error seleccionando el dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
