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
    public partial class frmCargo : Form
    {
        public frmCargo()
        {
            InitializeComponent();
        }

        bool validar()
        {
            bool valido = false;
            bool b1, b2, b3, b4; int i1, i2, i3, i4;

            b1 = int.TryParse(txt1.Text, out i1);
            b2 = int.TryParse(txt2.Text, out i2);
            b3 = int.TryParse(txt3.Text, out i3);
            b4 = int.TryParse(txt4.Text, out i4);
            valido = false;
            if (b1 && (txt1.TextLength == 4))
                if (b2 && (txt2.TextLength == 4))
                    if (b3 && (txt3.TextLength == 4))
                        if (b4 && (txt4.TextLength == 4))
                        {
                            valido = true;
                        }
            return valido;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt1_Click(object sender, EventArgs e)
        {
            //txt1.SelectAll();
        }

        private void btnCargo_Click(object sender, EventArgs e)
        {
            decimal cargo = 0; string sTarjeta; 
            bool bcargo = decimal.TryParse(txtCargo.Text, out cargo);
            try
            {
                if (validar() == true && bcargo == true)
                {
                    sTarjeta = txt1.Text + txt2.Text + txt3.Text + txt4.Text;
                    CrediSeguroWS.Tarjeta xTarjeta;
                    xTarjeta = new CrediSeguroWS.Tarjeta();
                    xTarjeta.Cargo(sTarjeta, cargo, dateTimePicker1.Value);
                    MessageBox.Show("Cargo agregado a la tarejeta", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ingrese valores correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
