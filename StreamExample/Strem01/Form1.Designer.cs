namespace Strem01
{
    partial class frmArchivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AbrirArchivo = new System.Windows.Forms.OpenFileDialog();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.lbArchivo = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AbrirArchivo
            // 
            this.AbrirArchivo.CheckFileExists = false;
            this.AbrirArchivo.FileName = "Registro";
            this.AbrirArchivo.InitialDirectory = "c:\\demo\\";
            this.AbrirArchivo.FileOk += new System.ComponentModel.CancelEventHandler(this.AbrirArchivo_FileOk);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(101, 40);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 0;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // lbArchivo
            // 
            this.lbArchivo.AutoSize = true;
            this.lbArchivo.Location = new System.Drawing.Point(122, 79);
            this.lbArchivo.Name = "lbArchivo";
            this.lbArchivo.Size = new System.Drawing.Size(44, 13);
            this.lbArchivo.TabIndex = 1;
            this.lbArchivo.Text = "Nombre";
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(12, 140);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(99, 20);
            this.dtFecha.TabIndex = 2;
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(117, 140);
            this.txtRegistro.MaxLength = 140;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(135, 20);
            this.txtRegistro.TabIndex = 3;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(268, 138);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // frmArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 282);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lbArchivo);
            this.Controls.Add(this.btnAbrir);
            this.Name = "frmArchivo";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog AbrirArchivo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Label lbArchivo;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Button btnRegistro;
    }
}

