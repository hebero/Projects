using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testDB
{
    public partial class frmTestDB : Form
    {
        public frmTestDB()
        {
            InitializeComponent();
        }

        private void frmTestDB_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlCon;
                string sConexion;
                sConexion = Properties.Settings.Default.Conexion;
                using (sqlCon = new SqlConnection(sConexion))
                {
                    sqlCon.Open();
                    MessageBox.Show("Conexión establecida", "test", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sqlCon.Close();
                }
            }catch(Exception r)
            {
                MessageBox.Show("Error de conexión: "+r.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            decimal tarj; bool a;

            a = decimal.TryParse(txtCargo.Text, out tarj);
            if (a == true)
            {
                try
                {
                    SqlConnection ConSQL; SqlCommand CmdSQL;
                    string sConection;
                    sConection = Properties.Settings.Default.Conexion;
                    using (ConSQL = new SqlConnection(sConection))
                    {
                        CmdSQL = ConSQL.CreateCommand();
                        CmdSQL.CommandText = "paTarjetaCArgo";
                        CmdSQL.CommandType = CommandType.StoredProcedure;

                        CmdSQL.Parameters.AddWithValue("@CodTarjeta", txtTarjeta.Text);
                        CmdSQL.Parameters.AddWithValue("@Cargo", txtCargo.Text);
                        CmdSQL.Parameters.AddWithValue("@Fecha", dtpFecha.Value);

                        ConSQL.Open();

                        CmdSQL.ExecuteNonQuery();

                        MessageBox.Show("Cargo realizado", "Cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ConSQL.Close();
                    }
                }
                catch(SqlException r){ MessageBox.Show("Error en conexión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else{ MessageBox.Show("El valor ingresado no es decimal", "Valor", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
