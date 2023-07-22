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
    public partial class AsigEmp : Form
    {
        public AsigEmp()
        {
            InitializeComponent();
        }

        Conexion conexion = new Conexion();

        private void AsigEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seminarioTicketsDataSet.Puestos' table. You can move, or remove it, as needed.
            this.puestosTableAdapter.Fill(this.seminarioTicketsDataSet.Puestos);

        }

        private void btnListo_Click(object sender, EventArgs e)
        {
            int sexo = 1;

            try
            {
                conexion.abrir();


                if (txtNombre.Text == string.Empty || txtDire.Text == string.Empty || txtTelefono.Text == string.Empty)
                {
                    MessageBox.Show("Datos en Blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                } else
                {
                    if (txtNombre.Text.Length > 8 && txtTelefono.Text.Length == 8 && txtDire.Text.Length > 8)
                    {

                        string puesto = cmbPuestos.SelectedValue.ToString();
                        DateTime Fnac = dateTimePicker1.Value;

                        if (rdbFem.Checked)
                            sexo = 0;

                        conexion.Modificaciones("exec InsercionColaboradores2 '" + txtNombre.Text + "', '" + Fnac.ToString() + "','" + txtDire.Text + "', '" + txtTelefono.Text + "', '" + sexo + "', '" + puesto + "', '" + Properties.Settings.Default.EmlUsu + "'");
                        MessageBox.Show("Se Asigno el empleado al usuario correctamente!");
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Ingrese Datos Validos!");
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
    }
}
