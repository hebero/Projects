using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Text;

namespace CrediSeguroWS
{
    public class TarjetaDB
    {

        private string Query(string NumeroTarjeta)
        {
            string sQuery = ""; StringBuilder sbQuery;

            sbQuery = new StringBuilder();
            sbQuery.Append("  SELECT CodTarjeta");
            sbQuery.Append("  FROM Tarjeta");
            sbQuery.Append("  WHERE");
            sbQuery.AppendFormat("  NumeroTarjeta = '{0}'    ", NumeroTarjeta);

            sQuery = sbQuery.ToString();
            return sQuery;
        }

        private string QueryMonto(int CodTarjeta)
        {
            string sQuery = ""; StringBuilder sbQuery;

            sbQuery = new StringBuilder();
            sbQuery.Append("  SELECT LimiteCredito - SaldoActual AS MontoDisponible");
            sbQuery.Append("  FROM Tarjeta");
            sbQuery.Append("  WHERE");
            sbQuery.AppendFormat("  CodTarjeta = {0}    ", CodTarjeta);

            sQuery = sbQuery.ToString();
            return sQuery;
        }

        public void Cargo(string NumeroTarjeta, decimal MontoCargo, 
            DateTime Fecha, string ConexionSQL)
        {
            //ADO.NET
            SqlConnection Cn;
            SqlCommand Cmd; SqlDataReader dr;
            int CodTarjeta = 0; int NoDigitos = 0;
            Regex ExpRegular; 

            try
            {
                ExpRegular = new Regex(@"\d");

                //Valida el número de tarjeta
                NoDigitos = NumeroTarjeta.Length;
                if ((NoDigitos==16) && (ExpRegular.IsMatch(NumeroTarjeta)))
                {
                    using (Cn = new SqlConnection(ConexionSQL))
                    {
                        //Instancia el Comando a Ejecutar
                        using (Cmd = Cn.CreateCommand())
                        {
                            //Encuentra el Código Tarjeta utilizando el Número de Tarjeta
                            Cmd.CommandType = CommandType.Text;
                            Cmd.CommandText = Query(NumeroTarjeta);
                            //Ejecuta el SELECT
                            Cn.Open();
                            dr = Cmd.ExecuteReader();
                            //Lee la información retornada, si encuentra la tarjeta
                            if (dr.Read())
                            {
                                CodTarjeta = dr.GetInt32(0);
                                // Cierra el SQLDataReader para poder utilizar de nuevo el SQLCommand
                                dr.Close();

                                //Ejecuta el Stored Procedure para realizar el cargo
                                Cmd.CommandType = CommandType.StoredProcedure;
                                Cmd.CommandText = "paTarjetaCargo";
                                //Agrega parametros al Stored Procedure
                                Cmd.Parameters.AddWithValue("@CodTarjeta", SqlDbType.Int).Value = CodTarjeta;
                                Cmd.Parameters.AddWithValue("@Fecha", SqlDbType.DateTime).Value = Fecha;
                                Cmd.Parameters.AddWithValue("@Cargo", SqlDbType.Decimal).Value = MontoCargo;

                                //EJECUTA EL STORED PROCEDURE
                                
                                Cmd.ExecuteNonQuery();
                                Cn.Close();
                            }
                            else
                            {
                                //Tarjeta no existe
                                Exception ex1;
                                ex1 = new Exception("TarjetaDB: Error Número Tarjeta No Existe: " + NumeroTarjeta);
                                throw ex1;
                            }

                        }   //using
                    }       //using
                }           //if
                else
                {
                    Exception ex1;
                    ex1 = new Exception("TarjetaDB: Error Número Tarjeta Inválido: "+ NumeroTarjeta);
                    throw ex1;
                }           //else
            }               //try

            catch (SqlException ex)
            {
                Exception ex1;
                ex1 = new Exception("TarjetaDB: Error de Base de Datos: "+ex.Message, ex);
                throw ex1;
            }
             
            return;
        }


        public decimal MontoDisponible(string NumeroTarjeta, string ConexionSQL)
        {
            decimal dMonto = 0;
            //ADO.NET
            SqlConnection Cn;
            SqlCommand Cmd; SqlDataReader dr;
            int CodTarjeta = 0; int NoDigitos = 0;
            Regex ExpRegular;

            try
            {
                ExpRegular = new Regex(@"\d");

                //Valida el número de tarjeta
                NoDigitos = NumeroTarjeta.Length;
                if ((NoDigitos == 16) && (ExpRegular.IsMatch(NumeroTarjeta)))
                {

                    using (Cn = new SqlConnection(ConexionSQL))
                    {
                        //Instancia el Comando a Ejecutar
                        using (Cmd = Cn.CreateCommand())
                        {
                            //Encuentra el Código Tarjeta utilizando el Número de Tarjeta
                            Cmd.CommandType = CommandType.Text;
                            Cmd.CommandText = Query(NumeroTarjeta);
                            //Ejecuta el SELECT
                            Cn.Open();
                            dr = Cmd.ExecuteReader();
                            //Lee la información retornada, si encuentra la tarjeta
                            if (dr.Read())
                            {
                                CodTarjeta = dr.GetInt32(0);
                                
                                //Cierra el SQLDataReader, para utilizar de nuevo el SQLCommand
                                dr.Close();

                                //Ejecuta el Stored Procedure para Actualizar Saldo Tarjeta
                                Cmd.CommandType = CommandType.StoredProcedure;
                                Cmd.CommandText = "paTarjetaSaldo";
                                //Agrega parametros al Stored Procedure
                                Cmd.Parameters.AddWithValue("@CTarjeta", SqlDbType.Int).Value = CodTarjeta;                                

                                //EJECUTA EL STORED PROCEDURE
                                Cmd.ExecuteNonQuery();


                                //Ejecuta un Select para encontrar el monto disponible
                                Cmd.CommandType = CommandType.Text;
                                Cmd.CommandText = QueryMonto(CodTarjeta);
                                dr = Cmd.ExecuteReader();
                                //Lee la información retornada, si encuentra la tarjeta
                                if (dr.Read())
                                {
                                    dMonto = dr.GetDecimal(0);
                                }
                                else
                                {
                                    dMonto = 0;
                                }
                                dr.Close();

                                Cn.Close();
                            }
                            else
                            {
                                //Tarjeta no existe
                                Exception ex1;
                                ex1 = new Exception("TarjetaDB: Error Número Tarjeta No Existe: " + NumeroTarjeta);
                                throw ex1;
                            }

                        }   //using
                    }       //using
                }           //if
                else
                {
                    Exception ex1;
                    ex1 = new Exception("TarjetaDB: Error Número Tarjeta Inválido: " + NumeroTarjeta);
                    throw ex1;
                }           //else

            }               //try

            catch (SqlException ex)
            {
                Exception ex1;
                ex1 = new Exception("TarjetaDB: Error de Base de Datos: " + ex.Message, ex);
                throw ex1;
            }

            return dMonto;
        }


    }
}