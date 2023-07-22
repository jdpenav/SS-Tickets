using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
{
    public class Conexion
    {

        public string cadenaConexion = "Data Source = localhost; Initial Catalog = SeminarioTickets; Integrated Security = true";

        public SqlConnection sc = new SqlConnection();

        public Conexion()
        {
            sc.ConnectionString = cadenaConexion;
        }

        public void abrir()
        {
            try
            {
                sc.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Abrir la Base de Datos " + ex, "DATABASE");
            }
        }

        public void cerrar()
        {
            try
            {
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Cerrar la Base de Datos " + ex, "DATABASE");
            }

        }

        public DataSet Consultas (string Comando)
        {
            DataSet dsa = new DataSet();
            SqlConnection sqlCon = new SqlConnection("Data Source = localhost; Initial Catalog = SeminarioTickets; Integrated Security = true");
            sqlCon.Open();

            SqlDataAdapter sqlDA = new SqlDataAdapter(Comando, sqlCon);
            sqlDA.Fill(dsa, "Tabla");

            dsa.Dispose();
            sqlCon.Dispose();
            sqlDA.Dispose();

            return dsa;
        }


        public void Grids(string Comando, DataGridView dgv)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source = localhost; Initial Catalog = SeminarioTickets; Integrated Security = true");

            DataSet dsa = new DataSet();
            SqlDataAdapter sqlDA = new SqlDataAdapter(Comando, sqlCon);
            sqlDA.Fill(dsa, "Tabla");

            dgv.DataSource = dsa.Tables[0];
            dsa.Dispose();
            sqlCon.Dispose();
            sqlDA.Dispose();
        }

        public bool Modificaciones (string Comando)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source = localhost; Initial Catalog = SeminarioTickets; Integrated Security = true");
            SqlCommand sqlCmd = new SqlCommand(Comando, sqlCon);

            sqlCon.Open();
            sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            sqlCmd.Dispose();
            sqlCon.Dispose();

            return true;
        }

        public string Escalar(string Comando)
        {
            SqlConnection sqlCon = new SqlConnection("Data Source = localhost; Initial Catalog = SeminarioTickets; Integrated Security = true");
            SqlCommand c = new SqlCommand(Comando, sqlCon);
            sqlCon.Open();
            string a = c.ExecuteScalar().ToString();
            sqlCon.Close();
            return a;
        }
    }
}
