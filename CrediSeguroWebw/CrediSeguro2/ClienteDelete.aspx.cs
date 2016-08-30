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
    public partial class ClienteDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            string sConexion = CrediSeguro2.Properties.Settings.Default.ConexionSQL;
            Clientedb xCliente = new Clientedb();
            int cod = 0;
            bool bcod = int.TryParse(txtCodCliente.Text, out cod);
            if (bcod)
            {
                try
                {
                    xCliente.Baja(cod, sConexion);
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "Cliente eliminado correctamente.";
                    lblMensaje.CssClass = "alert alert-success";
                }
                catch(SqlException ex)
                {
                    lblMensaje.Visible = true;
                    lblMensaje.CssClass = "alert alert-danger";
                    lblMensaje.Text = "Error de SQL: " + ex.Message;
                }
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Ingrese un código correcto.";
                lblMensaje.CssClass = "alert alert-warning";
            }
        }
    }
}