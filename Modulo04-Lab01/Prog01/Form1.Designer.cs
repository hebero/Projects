namespace Prog01
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.numValor = new System.Windows.Forms.NumericUpDown();
            this.cbHabilitar = new System.Windows.Forms.CheckBox();
            this.pbResultado = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdApagado = new System.Windows.Forms.RadioButton();
            this.rdEncendido = new System.Windows.Forms.RadioButton();
            this.timTiempo = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.cboLista = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numValor
            // 
            this.numValor.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numValor.Location = new System.Drawing.Point(12, 12);
            this.numValor.Name = "numValor";
            this.numValor.Size = new System.Drawing.Size(120, 20);
            this.numValor.TabIndex = 0;
            this.numValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numValor.ValueChanged += new System.EventHandler(this.numValor_ValueChanged);
            // 
            // cbHabilitar
            // 
            this.cbHabilitar.AutoSize = true;
            this.cbHabilitar.Checked = true;
            this.cbHabilitar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHabilitar.Location = new System.Drawing.Point(158, 14);
            this.cbHabilitar.Name = "cbHabilitar";
            this.cbHabilitar.Size = new System.Drawing.Size(64, 17);
            this.cbHabilitar.TabIndex = 1;
            this.cbHabilitar.Text = "Habilitar";
            this.cbHabilitar.UseVisualStyleBackColor = true;
            this.cbHabilitar.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pbResultado
            // 
            this.pbResultado.Location = new System.Drawing.Point(12, 106);
            this.pbResultado.Name = "pbResultado";
            this.pbResultado.Size = new System.Drawing.Size(269, 23);
            this.pbResultado.Step = 5;
            this.pbResultado.TabIndex = 2;
            this.pbResultado.Click += new System.EventHandler(this.pbResultado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdApagado);
            this.groupBox1.Controls.Add(this.rdEncendido);
            this.groupBox1.Location = new System.Drawing.Point(14, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automatico";
            // 
            // rdApagado
            // 
            this.rdApagado.AutoSize = true;
            this.rdApagado.Checked = true;
            this.rdApagado.Location = new System.Drawing.Point(122, 19);
            this.rdApagado.Name = "rdApagado";
            this.rdApagado.Size = new System.Drawing.Size(68, 17);
            this.rdApagado.TabIndex = 5;
            this.rdApagado.TabStop = true;
            this.rdApagado.Text = "Apagado";
            this.rdApagado.UseVisualStyleBackColor = true;
            this.rdApagado.CheckedChanged += new System.EventHandler(this.rdApagado_CheckedChanged);
            // 
            // rdEncendido
            // 
            this.rdEncendido.AutoSize = true;
            this.rdEncendido.Location = new System.Drawing.Point(16, 19);
            this.rdEncendido.Name = "rdEncendido";
            this.rdEncendido.Size = new System.Drawing.Size(76, 17);
            this.rdEncendido.TabIndex = 4;
            this.rdEncendido.Text = "Encendido";
            this.rdEncendido.UseVisualStyleBackColor = true;
            this.rdEncendido.CheckedChanged += new System.EventHandler(this.rdEncendido_CheckedChanged);
            // 
            // timTiempo
            // 
            this.timTiempo.Interval = 3000;
            this.timTiempo.Tick += new System.EventHandler(this.timTiempo_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Texto a agregar:";
            // 
            // txtLista
            // 
            this.txtLista.Location = new System.Drawing.Point(100, 158);
            this.txtLista.MaxLength = 15;
            this.txtLista.Name = "txtLista";
            this.txtLista.Size = new System.Drawing.Size(100, 20);
            this.txtLista.TabIndex = 6;
            // 
            // cboLista
            // 
            this.cboLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLista.FormattingEnabled = true;
            this.cboLista.Location = new System.Drawing.Point(12, 197);
            this.cboLista.Name = "cboLista";
            this.cboLista.Size = new System.Drawing.Size(188, 21);
            this.cboLista.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(206, 156);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(206, 195);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 261);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboLista);
            this.Controls.Add(this.txtLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbResultado);
            this.Controls.Add(this.cbHabilitar);
            this.Controls.Add(this.numValor);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numValor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numValor;
        private System.Windows.Forms.CheckBox cbHabilitar;
        private System.Windows.Forms.ProgressBar pbResultado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdEncendido;
        private System.Windows.Forms.RadioButton rdApagado;
        private System.Windows.Forms.Timer timTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.ComboBox cboLista;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRemover;
    }
}

