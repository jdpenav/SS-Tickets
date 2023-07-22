using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SeminarioTickets
{
    public partial class FrmColaboradores : Form
    {
        public string query = "SELECT IdEmp AS ID,NomEmp AS Nombre,FchNacEmp AS [Fecha Nacimiento],EmlEmp AS Email,DirEmp AS Direccion,TelEmp AS Telefono,GnrEmp AS Genero,p.NomPst AS Puesto,u.ConUsu AS Usuario FROM Colaboradores c INNER JOIN Puestos p ON p.IdPst = c.IdPst INNER JOIN Usuarios u ON u.EmlUsu = c.EmlUsu";
        

        CargaDatos CargarDatos = new CargaDatos();
        SqlDataReader DR1;
        SqlCommand CMD;


        public int genero;

        string usuario = Properties.Settings.Default.EmlUsu;
        string dscbit = "";


        public FrmColaboradores()
        {
            InitializeComponent();
        }

        private void FrmColaboradores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seminarioTicketsDataSet.Puestos' table. You can move, or remove it, as needed.
            this.puestosTableAdapter.Fill(this.seminarioTicketsDataSet.Puestos);
            conexion.Grids("SELECT * FROM Colaboradores", dgvColaboradores);




        }

        public bool IsValid(string correo)
        {
            if (correo == "")
            {
                correo = "LAGOS";
            }
            try
            {
                MailAddress m = new MailAddress(correo);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        Conexion conexion = new Conexion();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
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

                if (txtNombre.Text == string.Empty || txtEmail.Text == string.Empty || IsValid(txtEmail.Text)!=true  || txtDireccion.Text == string.Empty || txtTelefono.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conexion.Modificaciones("exec InsercionColaboradores2 '" + txtNombre.Text + "', '" + dtpFechaContratacion.Value.ToString("yyyy-MM-dd") + "', '" + txtDireccion.Text + "', '" + txtTelefono.Text + "', " + genero + ", " + cbxPuesto.SelectedValue + ", '" + txtEmail.Text + "'");
                    dscbit = "Se realizo insercion en Colaboradores";
                    conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    MessageBox.Show("Datos fueron guardados correctamente", "UNICAH", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtId.Clear();
                    txtNombre.Clear();
                    txtEmail.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();

                    txtId.Focus();

                    conexion.Grids("SELECT * FROM Colaboradores", dgvColaboradores);
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error Al guardar datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.cerrar();
            }

           
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
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

                if (txtId.Text == string.Empty || txtNombre.Text == string.Empty || txtEmail.Text == string.Empty || !txtEmail.Text.Contains("@") || txtDireccion.Text == string.Empty || txtTelefono.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conexion.Modificaciones("exec ActualizarColaborador " + txtId.Text + ", '" + txtNombre.Text + "', '" + dtpFechaContratacion.Value.ToString("yyyy-MM-dd") + "',  '" + txtDireccion.Text + "', '" + txtTelefono.Text + "', " + genero + ", " + cbxPuesto.SelectedValue + ", '" + txtEmail.Text + "'");
                    dscbit = "Se realizo Actualizacion en Colaboradores";
                    conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    MessageBox.Show("Datos fueron actualizados correctamente", "UNICAH", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtId.Clear();
                    txtNombre.Clear();
                    txtEmail.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();

                    txtId.Focus();

                    btnGuardar.Enabled = true;
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
                if(txtId.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conexion.Modificaciones("exec EliminarColaborador " + txtId.Text); 
                    dscbit = "Se realizo eliminacion de registro en Colaboradores";
                    conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    MessageBox.Show("Datos fueron Eliminados correctamente", "UNICAH", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtId.Clear();
                    txtNombre.Clear();
                    txtEmail.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();

                    txtId.Focus();

                    conexion.Grids(query, dgvColaboradores);

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

        private void dgvColaboradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvColaboradores.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvColaboradores.CurrentRow.Cells[1].Value.ToString();
            dtpFechaContratacion.Text = dgvColaboradores.CurrentRow.Cells[2].Value.ToString();
            txtDireccion.Text = dgvColaboradores.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvColaboradores.CurrentRow.Cells[4].Value.ToString();
            cbxGenero.Text = dgvColaboradores.CurrentRow.Cells[5].Value.ToString();
            cbxPuesto.Text = dgvColaboradores.CurrentRow.Cells[6].Value.ToString();
            txtEmail.Text = dgvColaboradores.CurrentRow.Cells[7].Value.ToString();
            
            
            
            

            
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
