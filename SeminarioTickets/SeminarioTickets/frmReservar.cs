using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
{
    public partial class frmReservar : Form
    {

        public string idEvt, NomEvt;
        Conexion conexion = new Conexion();

        string usuario = Properties.Settings.Default.EmlUsu;
        string dscbit = "";

        public frmReservar()
        {
            InitializeComponent();
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


        public bool clienteExiste(string idCli) {


            int count = Convert.ToInt32( conexion.Escalar("select count(*) from clientes where idCli = '" + idCli + "' "));
            
            if (count>0) 
                return true;
            else
                return false;

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
      
            if (txtDni.Text != "" && txtNombre.Text != "")
            {

                string dni = txtDni.Text;
                string correo = txtCorreo.Text;
                string telefono = txtTelefono.Text;
                string nombre = txtNombre.Text;


                if (IsValid(correo) || correo.Length == 0)
                {

                    if (nombre.Length > 8)
                    {

                        if (telefono.Length == 8 || telefono.Length == 0)
                        {

                            if (dni.Length == 13)
                            {
                                int sexo = 2;

                                if (rdbMasc.Checked)
                                    sexo = 1;

                                else if (rdbFem.Checked)
                                    sexo = 0;

                                else
                                    MessageBox.Show("Seleccione su sexo");


                                if (cmbxUbi.Text != "")
                                {

                                    if (sexo != 2)
                                    {

                                        string cuenta = conexion.Escalar("Select count(*) from colaboradores where EmlUsu = '" + Properties.Settings.Default.EmlUsu + "' ");


                                        if (Convert.ToInt32(cuenta) > 0)
                                        {
                                            DateTime hoy = DateTime.Today;
                                            if (!clienteExiste(dni))
                                            { 
                                            conexion.Modificaciones("exec InsercionClientes '" + dni + "', '" + nombre + "', '" + telefono + "', '" + correo + "','','', '" + sexo + "'  ");
                                            }

                                            conexion.Modificaciones("exec InsercionesTickets2 '" + idEvt + "', '" + dni + "', '" + cmbxUbi.SelectedValue + "', '" + (Convert.ToInt32(idEvt) * 1900 ) +"' ");

                                            string idEmp = conexion.Escalar("select top 1 IdEmp from colaboradores where EmlUsu = '" + Properties.Settings.Default.EmlUsu + "' ");

                                            conexion.Modificaciones("exec InsercionFacturaEncabezado2 '" + dni + "', '" + int.Parse(idEmp) + "', '" + hoy + "'");

                                            string NroFact = conexion.Escalar("select top 1 NroFact from FacturasEncabezado order by NroFact DESC");

                                            string IdTct = conexion.Escalar("select top 1 IdTct from tickets order by IdTct DESC");

                                            conexion.Modificaciones("exec InsercionFacturaDetalle2 '" + int.Parse(NroFact) + "', '" + int.Parse(IdTct) + "' ");
                                            dscbit = "Se realizo insercion en clientes, factura, facturadetalles y Tickects";
                                            conexion.Modificaciones("exec InsertarBitacora '" + usuario + "', '" + dscbit + "'");


                                            MessageBox.Show("Se Reservo Correctamente la entrada a " + NomEvt + " " + cmbxUbi.Text);

                                            conexion.Escalar("select top 1 IdTct from tickets order by IdTct DESC");

                                            FrmMenu m = new FrmMenu();
                                            DetalleFactura d = new DetalleFactura();
                                            d.id = Convert.ToInt32(NroFact);
                                            m.Show();
                                            d.ShowDialog();
                                            this.Hide();
                                        }
                                        else
                                        {

                                            AsigEmp a = new AsigEmp();
                                            a.Show();

                                        }

                                    }

                                }
                                else
                                    MessageBox.Show("Seleccione una ubicacion");

                            }
                            else
                                MessageBox.Show("Ingrese un dni valido", "Error {dni} Minimo-Caracteres{13}");

                        }
                        else
                            MessageBox.Show("Ingrese un telefono valido!", "Error {Telefono} Mininmo-Caracteres{8}");

                    }
                    else
                        MessageBox.Show("Ingrese un nombre valido!", "Error {Nombre} Mininmo-Caracteres{8}");
                }
                else
                    MessageBox.Show("Ingrese un correo valido!", "Error {Correo}");

            }
            else
                MessageBox.Show("Llene los Campos Obligatorios");
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmMenu m = new FrmMenu();
            this.Hide();
            m.Show();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmReservar_Load(object sender, EventArgs e)
        {

        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            this.ubicacionesTableAdapter1.Fill(this.seminarioTicketsDataSet1.Ubicaciones);
            this.Text = "Reservar Entrada Para " + NomEvt;
            if (clienteExiste(txtDni.Text))
            {
                txtNombre.Text = conexion.Escalar("select NomCli from clientes where idCli = '" + txtDni.Text + "'");
                string sexo = conexion.Escalar("select top 1 GnrCli from clientes where idCli = '" + txtDni.Text + "'");

                if (sexo != "true")
                    rdbMasc.Checked = true;
                else
                    rdbFem.Checked = true;               

                
            }
        }

        
    }
}
