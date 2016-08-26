using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Crediseguro
{
    public partial class index : System.Web.UI.Page
    {
        string conexion = Properties.Settings.Default.Conexion;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int CodTarjeta = 0;
            Tarjeta xTarjeta;
            CodTarjeta = int.Parse(txt1.Text);

            xTarjeta = new Tarjeta();

            if (xTarjeta.Existe(CodTarjeta, conexion))
            { lblMensaje.Text = "La tarjeta existe."; }
            else { lblMensaje.Text = "No existe la tarjeta."; }

        }
    }
}