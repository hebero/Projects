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
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargo frm;
            frm = new frmCargo();
            frm.MdiParent = this;
            frm.Show();

        }

        private void disponibleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDisponible frm;
            frm = new frmDisponible();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
