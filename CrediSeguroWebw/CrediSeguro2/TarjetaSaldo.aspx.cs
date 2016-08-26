using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace CrediSeguro2
{
    public partial class TarjetaSaldo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string sConexion = WebConfigurationManager.ConnectionStrings["CrediSeguro2.Properties.Settings.ConexionSQL"].ToString();
            Tarjetadb xTarjeta = new Tarjetadb();
            int iCCli = 0; bool bCCli = false;
            lblMensaje.Text = "";
            bCCli = int.TryParse(txtClieCod.Text, out iCCli);
            if (bCCli)
            {
                try
                {
                    xTarjeta.ActualizarSaldoCliente(iCCli, sConexion);
                    lblMensaje.CssClass = "alert alert-info";
                    lblMensaje.Text = "Saldo actualizado.";
                }catch (Exception ex)
                {
                    lblMensaje.CssClass = "alert alert-danger";
                    lblMensaje.Text = "Error de Clase Tarjetadb: " + ex.Message;
                }
            }
            else{
                lblMensaje.CssClass = "alert alert-danger";
                lblMensaje.Text = "Igrese un número correcto de tarjeta";
            }
        }
    }
}