using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using Microsoft.Reporting.WebForms;

namespace CrediSeguro2
{
    public partial class ReporteClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private DataTable Datos()
        {
            DataTable Tabla;
            SqlConnection cn; SqlCommand cmd;
            string sConexion = CrediSeguro2.Properties.Settings.Default.ConexionSQL;
            string sQuery; StringBuilder sbQuery;
            sbQuery = new StringBuilder();
            sbQuery.Append("SELECT CodCliente, DPI, NombrePrimero, ApellidoPrimero, FecNacimiento, Estado ");
            sbQuery.Append("FROM Cliente ");
            sbQuery.Append("ORDER BY Estado, ApellidoPrimero, NombrePrimero");
            sQuery = sbQuery.ToString();
            Tabla = new DataTable();
            try
            {
                using(cn  = new SqlConnection(sConexion))
                {
                    using(cmd = cn.CreateCommand())
                    {
                        cmd.CommandText = sQuery;
                        cmd.CommandType = CommandType.Text;
                        cn.Open();
                        Tabla.Load(cmd.ExecuteReader());
                        cn.Close();

                    }
                }

            }
            catch(SqlException ex)
            {
                throw ex;
            }
            return Tabla;

        }
        protected void btnReporte_Click(object sender, EventArgs e)
        {

            rvClientes.Reset();
            rvClientes.LocalReport.DataSources.Clear();
            try
            {

                rvClientes.ProcessingMode = ProcessingMode.Local;

                rvClientes.LocalReport.ReportPath = Server.MapPath("~/rptClientes.rdlc");

                DataTable dt; ReportDataSource rds;
                rds = new ReportDataSource();
                dt = Datos();
                rds.Name = "dsrptClientes";
                rds.Value = dt;
                rvClientes.LocalReport.DataSources.Add(rds);
                rvClientes.ShowRefreshButton = true;
                lblMensaje.Visible = true;
                lblMensaje.Text = "Reporte cargado correctamente";
                lblMensaje.CssClass = "alert alert-success";
            }catch( Exception ex)
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "Error al cargar reporte: " + ex.Message;
                lblMensaje.CssClass = "alert alert-danger";
            }

        }
    }
}