using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace CrediSeguro2
{
    public class Tarjetadb
    {
        public void ActualizarSaldoCliente(int CodCliente, string ConexionSQL)
        {
            SqlConnection cn;
            SqlCommand cmd;
            try
            {
                using (cn = new SqlConnection(ConexionSQL))
                {
                    using (cmd = new SqlCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "paClienteSaldo";
                        cmd.Parameters.AddWithValue("@CCliente", SqlDbType.Int).Value = CodCliente;
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
                return;
            }
            catch (SqlException r)
            {
                throw r;
            }
        }
    }
}