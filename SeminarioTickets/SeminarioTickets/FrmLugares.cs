using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
{
    public partial class FrmLugares : Form
    {

        Conexion Conexion = new Conexion();
        CargaDatos CargarDatos = new CargaDatos();
        string cadena = "Select * from Lugares";

        string usuario = Properties.Settings.Default.EmlUsu;
        string dscbit = "";

        public void limpiarCampos()
        {
            txtNombre.Clear();
            txtCapacidad.Clear();
        }

        public FrmLugares()
        {
            InitializeComponent();
        }

        private void FrmLugares_Load(object sender, EventArgs e)
        {
            CargarDatos.cargaDatos(dgvLugares, cadena);
        }

        static bool EsNumero(string texto)
        {
            Regex regex = new Regex(@"^\d+$"); // Expresión regular que solo permite dígitos
            return regex.IsMatch(texto);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.abrir();
                if (txtNombre.Text == string.Empty || txtCapacidad.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (EsNumero(txtCapacidad.Text))
                    {
                        Conexion.Modificaciones("exec InsercionLugares '" + txtNombre.Text + "', " + Convert.ToInt32(txtCapacidad.Text) + "");
                        dscbit = "Se realizo insercion en Lugares";
                        Conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                        MessageBox.Show("Datos guardados correctamente", "Lugares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos.cargaDatos(dgvLugares, cadena);

                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("El campo Capacidad solo acepta numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el Guardado de Datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.cerrar();
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.abrir();
                if (lblIdentificador.Text == string.Empty || txtNombre.Text == string.Empty || txtCapacidad.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Conexion.Modificaciones("Exec ActualizarLugares " + Convert.ToInt32(lblIdentificador.Text) + ", '" + txtNombre.Text + "'," + Convert.ToInt32(txtCapacidad.Text) + "");
                    dscbit = "Se realizo Actualizacion en Lugares";
                    Conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                    MessageBox.Show("Datos actualizados correctamente", "Lugares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos.cargaDatos(dgvLugares, cadena);

                    limpiarCampos();
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
                if (lblIdentificador.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro de que desea eliminar este objeto?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Conexion.Modificaciones("Exec EliminarLugares " + Convert.ToInt32(lblIdentificador.Text) + "");
                        dscbit = "Se realizo Eliminacion de un registro en Lugares";
                        Conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");

                        MessageBox.Show("Datos eliminados correctamente", "Lugares", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos.cargaDatos(dgvLugares, cadena);
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

        private void dgvLugares_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblIdentificador.Text = dgvLugares.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dgvLugares.CurrentRow.Cells[1].Value.ToString();
                txtCapacidad.Text = dgvLugares.CurrentRow.Cells[2].Value.ToString();

                btnGuardar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error seleccionando el dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
