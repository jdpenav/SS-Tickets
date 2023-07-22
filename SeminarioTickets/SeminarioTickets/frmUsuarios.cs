using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SeminarioTickets
{
    public partial class frmUsuarios : Form
    {

        Conexion conexion = new Conexion();

        string Eml;
        string usuario = Properties.Settings.Default.EmlUsu;
        string dscbit = "";

        public frmUsuarios()
        {
            InitializeComponent();
        }

        public void llenar()
        {
            txtEmail.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            Eml = txtEmail.Text; 
        }

        public static string EncriptarContraseña(string contraseña)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {

                byte[] bytesContraseña = Encoding.UTF8.GetBytes(contraseña);

                byte[] bytesHash = sha256Hash.ComputeHash(bytesContraseña);

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytesHash.Length; i++)
                {
                    builder.Append(bytesHash[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seminarioTicketsDataSet.Niveles' table. You can move, or remove it, as needed.
            this.nivelesTableAdapter.Fill(this.seminarioTicketsDataSet.Niveles);
            conexion.Grids("SELECT * from Usuarios", dgvUsuarios);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.abrir();

                if (txtEmail.Text == string.Empty || txtPass.Text == string.Empty || cmbNivel.SelectedItem.ToString() == string.Empty )
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conexion.Modificaciones("exec InsercionesUsuarios '" + txtEmail.Text + "', '" + EncriptarContraseña(txtPass.Text) + "', '" + "0000" + "', '" + cmbNivel.SelectedValue + "', '" + 1 + "'");
                    dscbit = "Se realizo insercion en Usuarios";
                    conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    MessageBox.Show("Datos guardados correctamente", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Grids("SELECT * from Usuarios", dgvUsuarios);
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEmail.Text == string.Empty || txtPass.Text == string.Empty || cmbNivel.SelectedItem.ToString() == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conexion.Modificaciones("exec ActualizarUsuarios '" + txtEmail.Text + "', '" + EncriptarContraseña(txtPass.Text) + "', '" + cmbNivel.SelectedValue + "','" + Eml + "'");
                    dscbit = "Se realizo Actualizacion en Usuarios";
                    conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    MessageBox.Show("Datos Actualizados correctamente", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Grids("SELECT * from Usuarios", dgvUsuarios);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Guardado de Datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conexion.cerrar(); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEmail.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conexion.Modificaciones("exec EliminarUsuarios '" + txtEmail.Text + "'");
                    dscbit = "Se realizo Eliminacion de registro en Usuarios";
                    conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    MessageBox.Show("Datos Eliminados correctamente", "SEMINARIO DE SOFTWARE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.Grids("SELECT * from Usuarios", dgvUsuarios);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error al Eliminar los Datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conexion.cerrar() ; }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == string.Empty)
                {
                    conexion.Grids("SELECT * from Usuarios where EmlUsu LIKE '%" + txtEmail.Text + "%'", dgvUsuarios);
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error al ejecutar esta accion" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                conexion.Grids("SELECT * from Usuarios", dgvUsuarios);
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            llenar();
        }
    }
}
