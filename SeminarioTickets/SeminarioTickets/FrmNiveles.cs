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
    public partial class FrmNiveles : Form
    {

        CargaDatos cargarDatos = new CargaDatos();
        Conexion Conexion = new Conexion();

        string cadena = "SELECT IdNvl AS Identificador, NomNvl AS Nivel FROM Niveles";

        public FrmNiveles()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmNiveles_Load(object sender, EventArgs e)
        {
            cargarDatos.cargaDatos(dgvNiveles, cadena);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.abrir();

                if (txtNomNvl.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Conexion.Modificaciones("Exec InsercionNiveles '" + txtNomNvl.Text + "' ");
                    MessageBox.Show("Datos Guardados correctamente", "Niveles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos.cargaDatos(dgvNiveles, cadena);

                    txtNomNvl.Clear();

                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error en el Guardado de los Datos" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally
            {
                Conexion.cerrar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion.abrir();

                if(lblIdentificador.Text == string.Empty || txtNomNvl.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    Conexion.Modificaciones("Exec ActualizarNiveles " + Convert.ToInt32(lblIdentificador.Text) + ", '"+txtNomNvl.Text+"' ");
                    MessageBox.Show("Datos actualizados correctamente", "Niveles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDatos.cargaDatos(dgvNiveles, cadena);

                    txtNomNvl.Clear();
                    btnGuardar.Enabled = true;
                }

            } catch (Exception ex) { 
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

                if (lblIdentificador.Text == string.Empty || txtNomNvl.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if(MessageBox.Show("¿Está seguro de que desea eliminar este objeto?", "ALERTA", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Conexion.Modificaciones("Exec EliminarNiveles " + Convert.ToInt32(lblIdentificador.Text) + "");
                        MessageBox.Show("Datos eliminados correctamente", "Niveles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarDatos.cargaDatos(dgvNiveles, cadena);

                        txtNomNvl.Clear();
                        btnGuardar.Enabled = true;
                    }
                    
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

        private void dgvNiveles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNiveles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblIdentificador.Text = dgvNiveles.CurrentRow.Cells[0].Value.ToString();
                txtNomNvl.Text = dgvNiveles.CurrentRow.Cells[1].Value.ToString();

                btnGuardar.Enabled = false;
            } catch(Exception ex)
            {
                MessageBox.Show("Error seleccionando el dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
