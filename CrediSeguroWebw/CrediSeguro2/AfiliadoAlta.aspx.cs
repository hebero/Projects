using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrediSeguro2
{
    public partial class AfiliadoAlta2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }
        private string QueryCodAfiliado(int CodAfiliado)
        {
            string sQuery;
            StringBuilder sbCond;
            sbCond = new StringBuilder();
            sbCond.Append("SELECT * ");
            sbCond.Append("FROM dbo.Local ");
            sbCond.Append("WHERE ");
            sbCond.AppendFormat(" CodAfiliado = {0}", CodAfiliado);
            sbCond.Append(" ORDER BY CodEstado, NombreLocal");

            sQuery = sbCond.ToString();
            return sQuery;
        }
        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            string sConexion = CrediSeguro2.Properties.Settings.Default.ConexionSQL;
            int iCodAfiliado;
            Afiliadodb xAfiliado;
            xAfiliado = new Afiliadodb();
            iCodAfiliado = 0;
            try
            {
                iCodAfiliado = xAfiliado.Insert(txtEmpresa.Text, txtContacto.Text, sConexion);
                txtAfiliado.Text = iCodAfiliado.ToString();
                btnAgregar.Visible = true;
            }
            catch (Exception ex)
            {
                lblMensaje.Visible = true;
                lblMensaje.CssClass = "alert alert-danger";
                lblMensaje.Text = "Error de sql: " + ex.Message;
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            bool bMonto; decimal dMonto = 0;
            int iCodAfiliado = 0; string sConexion = CrediSeguro2.Properties.Settings.Default.ConexionSQL;
            iCodAfiliado = int.Parse(txtAfiliado.Text);
            if (iCodAfiliado == 0)
            {
                lblMensaje.Visible = true;
                lblMensaje.CssClass = "alert alert-warning";
                lblMensaje.Text = "Debe grabar el encabezado antes de agregar locales";

            }
            else
            {
                bMonto = decimal.TryParse(txtCredito.Text, out dMonto);
                Localdb xLocal; xLocal = new Localdb();
                try
                {
                    xLocal.Insert(iCodAfiliado, txtNombreLocal.Text, dMonto, sConexion);
                    sdsLocales.ConnectionString = sConexion;
                    sdsLocales.SelectCommand = QueryCodAfiliado(iCodAfiliado);
                    gvLocal.DataSource = sdsLocales;
                    gvLocal.DataBind();

                }
                catch(Exception ex)
                {
                    lblMensaje.Visible = true;
                    lblMensaje.CssClass = "alert alert-danger";
                    lblMensaje.Text = "Error de sql: " + ex.Message;

                }

            }
        }
    }
}