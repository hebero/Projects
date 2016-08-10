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

namespace Modulo05_Lab01
{
    public partial class frmTexto : Form
    {
        public string Archivo;

        public frmTexto()
        {
            InitializeComponent();
        }

        private void frmTexto_Load(object sender, EventArgs e)
        {
            if (File.Exists(Archivo))
            {
                this.Text = Archivo;
                txtData.Text = File.ReadAllText(Archivo);
            }
            else
            {
                this.Text = Archivo;
                File.WriteAllText(Archivo + ".txt","");
            }
           

        }

        private void frmTexto_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Desa guardar?","¿Desea guardar el documento?", MessageBoxButtons.YesNo);
            if (dialogo == DialogResult.Yes)
            {
                File.WriteAllText(Archivo, txtData.Text);
            }


            
        }
    }
}
