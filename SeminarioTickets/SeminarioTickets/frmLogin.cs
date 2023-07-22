using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeminarioTickets
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {

            InitializeComponent();
        }

        Conexion conexion = new Conexion();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RememberMe )
            {
                txtEmail.Text = Properties.Settings.Default.EmlUsu;
                txtPass.Text = Properties.Settings.Default.Pass;                
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public static bool VerificarContraseña(string contraseñaIngresada, string contraseñaEncriptada)
        {

            return contraseñaIngresada.Equals(contraseñaEncriptada, StringComparison.OrdinalIgnoreCase);
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

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string contraseñaOriginal = txtPass.Text;
            string contraseñaEncriptada = EncriptarContraseña(contraseñaOriginal);
            string verif = conexion.Escalar("select count(*) from usuarios where EmlUsu ='" + txtEmail.Text + "' ");
            int verifint = Convert.ToInt32(verif);
            if (verifint > 0)
            {
                string contraIn = conexion.Escalar("select top 1 ConUsu from usuarios where EmlUsu ='" + txtEmail.Text + "' ");
                bool coinciden = VerificarContraseña(contraIn, contraseñaEncriptada);

                if (coinciden)
                {
                    string IdNvl = conexion.Escalar("select top 1 IdNvl from usuarios where EmlUsu ='" + txtEmail.Text + "' ");
                    string Nvl = conexion.Escalar("select top 1 NomNvl from Niveles where IdNvl ='" + IdNvl + "' ");
                    Properties.Settings.Default.EmlUsu = txtEmail.Text;
                    Properties.Settings.Default.Pass = txtPass.Text;
                    Properties.Settings.Default.Nvl = Nvl;
                    Properties.Settings.Default.RememberMe = true;
                    Properties.Settings.Default.Save();

                    FrmMenu menu = new FrmMenu();
                    this.Hide();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("La Contraseña es incorrecta!!", "TICKETS");

                }
            }

            else
            {
                MessageBox.Show("No Se Encontro ningun usuario registrado con ese correo", "TICKETS");

            }
        }
    }
}
