using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Crediseguro
{
    public class Tarjeta
    {
        public bool Existe(int cTarjeta,string sConexion)
        {
            bool bandera = false; int iFilas = 0;
            //bd
            SqlConnection Cn;
            SqlCommand Cmd;
            Cn = new SqlConnection(sConexion);
            Cmd = Cn.CreateCommand();
            Cmd.CommandText = "SELECT COUNT (*) FROM Tarjeta WHERE CodTarjeta=" + cTarjeta.ToString();
            Cn.Open();
            iFilas  = Convert.ToInt32(Cmd.ExecuteScalar());
            Cn.Close();
            if (iFilas > 0) { bandera = true; }

            return bandera;
        }
    }
}