using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Pro01
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInstanciar_Click(object sender, EventArgs e)
        {
            Cliente c;
            c = new Cliente();
            c.ApellidoPrimero = "Perez";
            c.NombrePrimero = "Sergrop";
            c.FecNacimiento = new DateTime(1990,08,04);
            txtNombre.Text = c.NombrePrimero;
            txtEdad.Text = c.edad().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            //Mostrar el listado de los clientes
            //tipo de dato del modelo
            CrediSeguroEntities DBContext;
            //Instancia
            DBContext = new CrediSeguroEntities();
            //Recuperar información
            var query = from c in DBContext.Cliente
                        orderby c.NombrePrimero, c.ApellidoPrimero
                        select c;
            //Cambia el cursor
            this.UseWaitCursor = true;
            //Forzar la ejecucion de la consulta
            var vClientes = query.ToList();
            //Cambiar el cursor 
            this.UseWaitCursor = false;
            //datagrid
            dgvCliente.DataSource = vClientes;
        }

        private void btnFiltrado_Click(object sender, EventArgs e)
        {
            //Mostar el listado de los clientes
            //solo los clientes con el nombre ifual al textbox
            //tipo de dato dle modelo
            CrediSeguroEntities DBContext;
            //Inxtancia
            DBContext = new CrediSeguroEntities();
            var query = from c in DBContext.Cliente
                        where (c.NombrePrimero == txtNombre.Text)
                        orderby c.NombrePrimero, c.ApellidoPrimero
                        select c;
            //Cursosr
            this.UseWaitCursor = true;
            var vClientes = query.ToList();
            this.UseWaitCursor = false;
            dgvCliente.DataSource = vClientes;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CrediSeguroEntities DBContext;
            //Inxtancia
            DBContext = new CrediSeguroEntities();
           // dgvCliente.
            DBContext.SaveChanges();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Mostrar el listado de los clientes
            //Solo los clientes con el nombre igual al textbox
            //Tipo de Dato del mdelo
            CrediSeguroEntities DBContext;
            string sArchivoNombre;
            StreamWriter EscribirArchivo;
            string SerialJSON;
            //Instancia
            DBContext = new CrediSeguroEntities();
            //Recuperar información
            var query = from c in DBContext.Cliente
                        where (c.NombrePrimero == txtNombre.Text)
                        orderby c.NombrePrimero, c.ApellidoPrimero
                        select c;
            //Forzar la ejecucion de la consulta
            var vClientes = query.ToList();

            //Recorre los elementos seleccionados
            foreach (Cliente cli in vClientes)
            {
                //Ruta de almacenamiento del archivo, debe existir la carpeta demo en el disco c
                sArchivoNombre = "c:\\demo\\" + cli.DPI.ToString() + ".txt";
                //crea un streamwriter hacia un filestream
                EscribirArchivo = File.CreateText(sArchivoNombre);
                //Serializa a JSON
                SerialJSON = JsonConvert.SerializeObject(cli, Formatting.Indented, new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
                EscribirArchivo.WriteLine(SerialJSON);
                //Graba el archivo
                EscribirArchivo.Flush();
                //Cierra el archivo
                EscribirArchivo.Close();

            }
            //Notifica el fin del proceso
            MessageBox.Show("Proceso terminado", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }
    }

