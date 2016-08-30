using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

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
                    using (cmd = cn.CreateCommand())
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
        public void CargoTarjeta(int CodTarjeta, DateTime Fecha, decimal Cargo, string ConexionSQL)
        {
            SqlConnection cn;
            SqlCommand cmd;
            try
            {
                using(cn = new SqlConnection(ConexionSQL))
                {
                    using(cmd = cn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "paTarjetaCargo";
                        cmd.Parameters.AddWithValue("@CodTarjeta", SqlDbType.Int).Value = CodTarjeta;
                        cmd.Parameters.AddWithValue("@Fecha", SqlDbType.Date).Value = Fecha;
                        cmd.Parameters.AddWithValue("@Cargo", SqlDbType.Decimal).Value = Cargo;
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return;
        }
        public void AbonoTarjeta(int CodTarjeta, DateTime Fecha, decimal Abono, string ConexionSQL)
        {
            SqlConnection cn;
            SqlCommand cmd;
            try
            {
                using (cn = new SqlConnection(ConexionSQL))
                {
                    using (cmd = cn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "paTarjetaAbono";
                        cmd.Parameters.AddWithValue("@CodTarjeta", SqlDbType.Int).Value = CodTarjeta;
                        cmd.Parameters.AddWithValue("@Fecha", SqlDbType.Date).Value = Fecha;
                        cmd.Parameters.AddWithValue("@Abono", SqlDbType.Decimal).Value = Abono;
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return;
        }
    }
}