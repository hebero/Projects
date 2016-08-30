using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrediSeguroPOS
{
    public partial class frmDisponible : Form
    {
        private bool ValidarNumeros()
        {
            bool bValidar = false;
            bool b1, b2, b3, b4; int i1, i2, i3, i4;
            b1 = int.TryParse(txt1.Text,out i1);
            b2 = int.TryParse(txt2.Text, out i2);
            b3 = int.TryParse(txt3.Text, out i3);
            b4 = int.TryParse(txt4.Text, out i4);
            bValidar = false;
            if(b1 && (txt1.TextLength ==4))
                if(b2 && (txt2.TextLength==4))
                    if(b3 && (txt3.TextLength==4))
                        if(b4 && (txt4.TextLength==4))
                        {
                            bValidar = true;
                        }
            return bValidar; 
        }
        public frmDisponible()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string sNoTarjeta; decimal dMonto = 0;
            try
            {
                if (ValidarNumeros())
                {
                    sNoTarjeta = txt1.Text + txt2.Text + txt3.Text + txt4.Text;
                    CrediSeguroWS.Tarjeta xTarjeta;
                    xTarjeta = new CrediSeguroWS.Tarjeta();
                    dMonto = xTarjeta.MontoDisponible(sNoTarjeta);

                    txtMensaje.Text = "Saldo disponible: " + dMonto.ToString("C");
                }
                else
                {
                    txtMensaje.Text = "Debe ingresar número correctos en las casillas.";
                }
            }
            catch(Exception ex) { txtMensaje.Text = "Error: " + ex.Message; }
        }
    }
}
