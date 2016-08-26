using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Web.Configuration;
using System.Data.SqlClient;


namespace CrediSeguro2
{
    public partial class TarjetaxCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sCont;
                string sNom, sApe, comando;
                sCont = new StringBuilder();
                sNom = txtNombre.Text; sApe = txtApellido.Text;
                sCont.Append("SELECT * ");
                sCont.Append("FROM dbo.vClienteTarjeta ");
                sCont.Append("WHERE ");
                sCont.AppendFormat("NombrePrimero LIKE '{0}%' ", sNom);
                sCont.AppendFormat("AND ApellidoPrimero LIKE '{0}%' ", sApe);
                comando = sCont.ToString();
                SQLDataSource.ConnectionString = WebConfigurationManager.ConnectionStrings["CrediSeguro2.Properties.Settings.ConexionSQL"].ToString();
                SQLDataSource.SelectCommand = comando;

                gvTarjeta.DataSource = SQLDataSource;
                gvTarjeta.DataBind();
            }
            catch(SqlException r)
            {
                lblAlert.Visible = true;
                lblAlert.CssClass = "alert alert-danger";
                lblAlert.Text = ("Error de base de datos");
            }


        }
    }
}