using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace CrediSeguro2
{
    public partial class TarjetaAbono : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string sConexion = WebConfigurationManager.ConnectionStrings["CrediSeguro2.Properties.Settings.ConexionSQL"].ToString();
            sConexion = CrediSeguro2.Properties.Settings.Default.ConexionSQL;
            Tarjetadb xTarjeta = new Tarjetadb(); ;
            DateTime Fech; int CodTar = 0; decimal Cargo = 0;
            bool BFech = DateTime.TryParse(txtFecha.Text, out Fech);
            bool BCod = int.TryParse(txtCodTar.Text, out CodTar);
            bool BCarg = decimal.TryParse(txtMonto.Text, out Cargo);
            if (BFech == true && BCod == true && BCarg == true)
            {
                try
                {
                    xTarjeta.AbonoTarjeta(CodTar, Fech, Cargo, sConexion);
                    lblMensaje.Visible = true;
                    lblMensaje.CssClass = "alert alert-success";
                    lblMensaje.Text = "Abono agregado correctamente.";
                }
                catch (SqlException Ex)
                {
                    lblMensaje.Visible = true;
                    lblMensaje.CssClass = "alert alert-danger";
                    lblMensaje.Text = "Cargo agregado correctamente." + Ex.Message;
                }
            }
        }
    }
}