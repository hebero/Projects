using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CrediSeguro2
{
    public class Afiliadodb
    {
        public int Insert(string Empresa, string Contacto, string SQLConexion)
        {
            int iCodAfiliado = 0;

            //Ejecucion de StoredProcedure que retorna el código del afiliado
            SqlConnection cn;
            SqlCommand cmd;
            SqlParameter spRemoto;
            //try
            //{
                using (cn = new SqlConnection(SQLConexion))
                {
                    using (cmd = cn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "paAfiliadoInsert";
                        //Parámetros
                        cmd.Parameters.AddWithValue("@Empresa", SqlDbType.VarChar).Value = Empresa;
                        cmd.Parameters.AddWithValue("@Contacto", SqlDbType.VarChar).Value = Contacto;
                        //Parametro que recupera el valor de retorno del código
                        spRemoto = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                        spRemoto.Direction = ParameterDirection.ReturnValue;
                        //ejecucion
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        iCodAfiliado = (int)spRemoto.Value;
                    }
                }
            //}
            //catch(Exception ex)
            //{
            //    throw ex;
            //}
            return iCodAfiliado;
        }
    }
}