using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data.SqlClient;
using System.Web.Configuration;
namespace CrediSeguro2

{
    public partial class MovsxTarjeta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int Cod = 0; bool pass = false; string comando;
            StringBuilder scont;
            scont = new StringBuilder();
            pass = int.TryParse(txtCod.Text, out Cod);
            if(pass == true){
                scont.Append("SELECT * ");
                scont.Append("FROM dbo.vTarjetaMovimiento ");
                scont.AppendFormat("WHERE CodTarjeta = '{0}' ", Cod);
                scont.AppendFormat("ORDER BY Fecha DESC");
                comando = scont.ToString();
                SQLDataSourceMovs.ConnectionString = WebConfigurationManager.ConnectionStrings["CrediSeguro2.Properties.Settings.ConexionSQL"].ToString();
                SQLDataSourceMovs.SelectCommand = comando;
                gvMovs.DataSource = SQLDataSourceMovs;
                gvMovs.DataBind();
            }
            else
            {
                lblMensaje.Text = "Ingrese un codigo correcto.";
            }
        }
    }
}