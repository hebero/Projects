using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace CrediSeguro2
{
    public partial class ClienteAlta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bGrabar_Click(object sender, EventArgs e)
        {
            string sConexion = WebConfigurationManager.ConnectionStrings["CrediSeguro2.Properties.Settings.ConexionSQL"].ToString();
            Clientedb xCliente = new Clientedb();
            int iDPI = 0; bool bDPI = false;
            lblMensaje.Text = "";

            bDPI = int.TryParse(txtDPI.Text, out iDPI);
            if (bDPI)
            {
                
                xCliente.Alta(txtNomP.Text, txtNomS.Text, txtApeP.Text, txtApeS.Text, iDPI, txtNIT.Text, txtFNac.Text, sConexion);
                lblMensaje.Visible = true;
                lblMensaje.Text = "Cliente grabado correctamente.";
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Debe ingresar un número de DPI.";
            }
        }
    }
}