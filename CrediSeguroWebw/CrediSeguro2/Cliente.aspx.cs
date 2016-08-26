using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text;
using System.Web.Configuration;

namespace CrediSeguro2
{
    public partial class Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            StringBuilder sbCond;
            string sNombre = "", sApellido = "";
            string sCondicion;
            sbCond = new StringBuilder();

            sNombre = txNombre.Text;
            sApellido = txtApellido.Text;

            sbCond.Append("SELECT * ");
            sbCond.Append("FROM dbo.Cliente ");
            sbCond.Append("WHERE ");
            sbCond.AppendFormat("ApellidoPrimero LIKE '{0}%' ", sApellido);
            sbCond.AppendFormat("AND NombrePrimero LIKE '{0}%' ", sNombre);

            sCondicion = sbCond.ToString();

            SQLdsCrediSeguro.ConnectionString = WebConfigurationManager.ConnectionStrings["CrediSeguro2.Properties.Settings.ConexionSQL"].ToString();

            SQLdsCrediSeguro.SelectCommand = sCondicion;

            gvClientes.DataSource = SQLdsCrediSeguro;
            gvClientes.DataBind();

        }
    }
}