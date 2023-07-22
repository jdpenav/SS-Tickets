using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
{
    public class CargaDatos
    {
        DataTable dt;
        SqlDataAdapter sda;
        SqlCommand cmd;
        SqlDataReader dr;
        Conexion Conexion = new Conexion();

        public void cargaDatos(DataGridView DGV, string sentencia)
        {
            try
            {
                Conexion.abrir();
                sda = new SqlDataAdapter(sentencia, Conexion.sc);
                dt = new DataTable();
                sda.Fill(dt);
                DGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar los Datos\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        public void cargarComboBox(ComboBox CB, string sentencia, string campo)
        {
            try
            {
                Conexion.abrir();
                cmd = new SqlCommand(sentencia, Conexion.sc);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CB.Items.Add(dr[campo]).ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cargar los Datos\n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.cerrar();
            }
        }
    }


}
