using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Configuration;

namespace CrediSeguroWS
{
    /// <summary>
    /// Summary description for Tarjeta
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Tarjeta : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void Cargo(string NumeroTarjeta, decimal Cargo, DateTime Fecha)
        {
            string sConexion = "";
            TarjetaDB xTarjeta;

            //Recupera el String de Conexión
            sConexion =
                WebConfigurationManager.ConnectionStrings["CrediSeguroWS.Properties.Settings.ConexionSQL"].ToString();

            //Instancia la Tarjeta
            xTarjeta = new TarjetaDB();
            xTarjeta.Cargo(NumeroTarjeta, Cargo, Fecha, sConexion);

            return;
        }

        [WebMethod]
        public decimal MontoDisponible(string NumeroTarjeta)
        {
            decimal dMonto = 0;
            string sConexion = "";
            TarjetaDB xTarjeta;

            //Recupera el String de Conexión
            sConexion =
                WebConfigurationManager.ConnectionStrings["CrediSeguroWS.Properties.Settings.ConexionSQL"].ToString();

            //Instancia la Tarjeta
            xTarjeta = new TarjetaDB();
            dMonto = xTarjeta.MontoDisponible(NumeroTarjeta, sConexion);

            return dMonto;
        }


    }
}
