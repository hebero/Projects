using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo05_Lab01
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //Muestra el dialogo y evalua el resultado 
           if (ofdArchivo.ShowDialog()==DialogResult.OK)
            {
                frmTexto frm;
                frm = new frmTexto();
                frm.Archivo = ofdArchivo.FileName;
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
