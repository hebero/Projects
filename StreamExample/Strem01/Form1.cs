using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.EntityClient;


namespace Strem01
{
    public partial class frmArchivo : Form
    {
        public frmArchivo()
        {
            InitializeComponent();
        }

        private void AbrirArchivo_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            AbrirArchivo.ShowDialog();
            lbArchivo.Text = AbrirArchivo.FileName;
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            StringBuilder sLinea; string EscribirLinea;
            FileStream Archivo; BinaryWriter Escribir;
            Archivo = new FileStream(AbrirArchivo.FileName, FileMode.Append);

            Escribir = new BinaryWriter(Archivo);

            sLinea = new StringBuilder();
            sLinea.AppendFormat("Fecha: {0} Msj: {1}", dtFecha.Value, txtRegistro.Text);
            EscribirLinea = sLinea.ToString();
            byte[] arr = System.Text.Encoding.ASCII.GetBytes(EscribirLinea);
            Escribir.Write(arr);
            Escribir.Flush();
            Escribir.Close();
        }
    }
}