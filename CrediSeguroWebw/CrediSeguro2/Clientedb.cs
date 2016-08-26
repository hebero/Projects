using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CrediSeguro2
{
    public class Clientedb
    {
        public void Alta(string NombrePrimero, string NombreSegundo, string ApellidoPrimero, string ApellidoSegundo, int DPI, string NIT, string FecNacimiento, string ConexionSQL)
        {
            SqlConnection cn;
            SqlCommand cmd; DateTime fnac = new DateTime();
            fnac = DateTime.Parse(FecNacimiento);
            using (cn = new SqlConnection(ConexionSQL))
            {
                using (cmd = cn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "paClienteInsert";
                    //
                    cmd.Parameters.AddWithValue("@NomPrim", SqlDbType.VarChar).Value = NombrePrimero;
                    cmd.Parameters.AddWithValue("@NomSeg", SqlDbType.VarChar).Value = NombreSegundo;
                    cmd.Parameters.AddWithValue("@ApePrim", SqlDbType.VarChar).Value = ApellidoPrimero;
                    cmd.Parameters.AddWithValue("@ApeSeg", SqlDbType.VarChar).Value = ApellidoSegundo;
                    cmd.Parameters.AddWithValue("@NIT", SqlDbType.VarChar).Value = NIT;
                    cmd.Parameters.AddWithValue("@DPI", SqlDbType.Int).Value = DPI;
                    cmd.Parameters.AddWithValue("@FNac", SqlDbType.DateTime).Value = fnac;

                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            return;
        }
    }
}