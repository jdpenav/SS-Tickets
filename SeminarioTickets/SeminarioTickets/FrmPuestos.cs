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
    public partial class FrmPuestos : Form
    {
        CargaDatos cargarDatos = new CargaDatos();
        Conexion Conexion = new Conexion();
        string cadena = "SELECT IdPst AS Identificador, NomPst AS Puesto FROM Puestos";
        string usuario = Properties.Settings.Default.EmlUsu;
        string dscbit = "";

        public FrmPuestos()
        {
            InitializeComponent();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.abrir();

                if (txtNomPst.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Conexion.Modificaciones("Exec InsercionesPuestos '" + txtNomPst.Text + "' ");
                    dscbit = "Se realizo insercion en Puestos";
                    Conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    MessageBox.Show("Datos Guardados correctamente", "Puestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos.cargaDatos(dgvPuestos, cadena);

                    txtNomPst.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        private void FrmPuestos_Load(object sender, EventArgs e)
        {
            cargarDatos.cargaDatos(dgvPuestos, cadena);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.abrir();

                if (lblIdentificador.Text == string.Empty || txtNomPst.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Conexion.Modificaciones("Exec ActualizarPuestos " + Convert.ToInt32(lblIdentificador.Text) + ", '" + txtNomPst.Text + "' ");
                    dscbit = "Se realizo Actualizacion en Puestos";
                    Conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    MessageBox.Show("Datos actualizados correctamente", "Puestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos.cargaDatos(dgvPuestos, cadena);

                    txtNomPst.Clear();
                    btnGuardar.Enabled = true;
                }

            }
            catch (Exception ex)
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

                if (lblIdentificador.Text == string.Empty || txtNomPst.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Conexion.Modificaciones("Exec EliminarPuestos " + Convert.ToInt32(lblIdentificador.Text) + "");
                        dscbit = "Se realizo Eliminacion de registro en Puestos";
                        Conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                        MessageBox.Show("Datos eliminados correctamente", "Puestos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDatos.cargaDatos(dgvPuestos, cadena);

                        txtNomPst.Clear();
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

        private void dgvPuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblIdentificador.Text = dgvPuestos.CurrentRow.Cells[0].Value.ToString();
                txtNomPst.Text = dgvPuestos.CurrentRow.Cells[1].Value.ToString();

                btnGuardar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error seleccionando el dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

 
    }
}
