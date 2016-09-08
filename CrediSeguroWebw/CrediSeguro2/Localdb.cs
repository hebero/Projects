using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CrediSeguro2
{
    public class Localdb
    {
        public int Insert(int CodAfiliado, string NombreLocal, decimal MontoMaximoCredito, string SQLConexion)
        {
            int iCodLocal = 0;
            SqlConnection cn;
            SqlCommand cmd;
            SqlParameter spRetorno;
            try
            {
                using (cn = new SqlConnection(SQLConexion))
                {
                    using (cmd = cn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "paLocalInsert";
                        cmd.Parameters.AddWithValue("@CodAfiliado", SqlDbType.Int).Value = CodAfiliado;
                        cmd.Parameters.AddWithValue("@NombreLocal", SqlDbType.VarChar).Value = NombreLocal;
                        cmd.Parameters.AddWithValue("@MontoMaximoCredito", SqlDbType.Decimal).Value = MontoMaximoCredito;

                        //Parametro adicional para recuperar el varlor de retorno del SP
                        spRetorno = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                        spRetorno.Direction = ParameterDirection.ReturnValue;
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();

                        iCodLocal = (int)spRetorno.Value;
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return iCodLocal;
        }
    }
}