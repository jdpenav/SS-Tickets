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
    public partial class DetalleFactura : Form
    {
        Conexion cnx = new Conexion();
        public int id;
        public DetalleFactura()
        {
            InitializeComponent();
        }



        private void DetalleFactura_Load(object sender, EventArgs e)
        {


         Fecha.Text=obtenerDato("FchEvt").Substring(0, 8); ;
         Hora.Text = obtenerDato("HrEvt");
         string ubi = obtenerDato("ZonaUbc");         
         string precio =  obtenerDato("PreTct") + " $" ;
         Ubicacion.Text = ubi +"\n"+ precio;
         Evento.Text = obtenerDato("NomEvt");
         Lugar.Text = obtenerDato("NomLug");
         TipoEvt.Text = obtenerDato("NomEvn");
         Cliente.Text = "Cliente\n" + obtenerDato("NomCli");
         Empleado.Text = "Empleado\n"+ obtenerDato("NomEmp");
            NroFact.Text = "Factura No. " + obtenerDato("FD.NroFact");
        }


        public string obtenerDato(string dato)
        {    
            
            string x = "select top 1 "+dato+ " from FacturasEncabezado inner join FacturasDetalle as FD on FD.NroFact = FacturasEncabezado.NroFact inner join Clientes as C on C.IdCli = FacturasEncabezado.IdCli inner join Tickets as T on T.IdTct = FD.IdTct inner join Eventos as E on E.IdEvt = t.IdEvt inner join Ubicaciones as U on T.IdUbc = U.IdUbc  inner join Lugares as L  on L.IdLug = E.IdLug  inner join TipoEventos as TE on TE.IdEvn = E.IdEvn inner join Colaboradores as CO on CO.IdEmp = FacturasEncabezado.IdEmp  where FD.NroFact = " + id;
            string data = cnx.Escalar(x);
            return data;
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
