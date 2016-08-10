using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog01
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void numValor_ValueChanged(object sender, EventArgs e)
        {
            if(numValor.Value == numValor.Maximum)
            {
                numValor.Value = numValor.Minimum;
            }
            pbResultado.Value = Convert.ToInt32(numValor.Value);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbHabilitar.Checked == true)
            {
                numValor.Enabled = true;
            }
            else
            {
                numValor.Enabled = false;
            }
        }

        private void timTiempo_Tick(object sender, EventArgs e)
        {
            numValor.Value = numValor.Value + numValor.Increment;
        }

        private void rdEncendido_CheckedChanged(object sender, EventArgs e)
        {
            timTiempo.Enabled = true;
            if (timTiempo.Enabled == true)
            {
                timTiempo.Start();
            }
        }

        private void rdApagado_CheckedChanged(object sender, EventArgs e)
        {
            timTiempo.Enabled = false;
            if (timTiempo.Enabled == true)
            {
                timTiempo.Stop();
            }
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cboLista.Items.Add(txtLista.Text);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            { cboLista.Items.RemoveAt(cboLista.SelectedIndex); }
            catch(ArgumentOutOfRangeException ex) {
                MessageBox.Show("Lista vacia." + ex);
            }
        }

        private void pbResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
