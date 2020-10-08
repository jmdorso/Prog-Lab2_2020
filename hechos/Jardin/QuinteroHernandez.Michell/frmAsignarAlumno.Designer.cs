namespace QuinteroHernandez.Michell
{
    partial class frmAsignarAlumno
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
            this.cmbDocente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tlmGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.lsbConSala = new System.Windows.Forms.ListBox();
            this.lsbSinSala = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.cmbColorSala = new System.Windows.Forms.ComboBox();
            this.lblColorSala = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProfeSelect = new System.Windows.Forms.Label();
            this.lblResultadoProfe = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbDocente
            // 
            this.cmbDocente.FormattingEnabled = true;
            this.cmbDocente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbDocente.Location = new System.Drawing.Point(501, 37);
            this.cmbDocente.Name = "cmbDocente";
            this.cmbDocente.Size = new System.Drawing.Size(121, 21);
            this.cmbDocente.TabIndex = 2;
            this.cmbDocente.Text = "Seleccione";
            this.cmbDocente.SelectedIndexChanged += new System.EventHandler(this.cmbDocente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Turno:";
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(56, 37);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(121, 21);
            this.cmbTurno.TabIndex = 12;
            this.cmbTurno.SelectedIndexChanged += new System.EventHandler(this.cmbTurno_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmGuardar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tlmGuardar
            // 
            this.tlmGuardar.Name = "tlmGuardar";
            this.tlmGuardar.Size = new System.Drawing.Size(61, 20);
            this.tlmGuardar.Text = "Guardar";
            this.tlmGuardar.Click += new System.EventHandler(this.tlmGuardar_Click);
            // 
            // lsbConSala
            // 
            this.lsbConSala.FormattingEnabled = true;
            this.lsbConSala.HorizontalScrollbar = true;
            this.lsbConSala.Location = new System.Drawing.Point(12, 90);
            this.lsbConSala.Name = "lsbConSala";
            this.lsbConSala.Size = new System.Drawing.Size(235, 199);
            this.lsbConSala.TabIndex = 14;
            // 
            // lsbSinSala
            // 
            this.lsbSinSala.FormattingEnabled = true;
            this.lsbSinSala.HorizontalScrollbar = true;
            this.lsbSinSala.Location = new System.Drawing.Point(387, 90);
            this.lsbSinSala.Name = "lsbSinSala";
            this.lsbSinSala.ScrollAlwaysVisible = true;
            this.lsbSinSala.Size = new System.Drawing.Size(235, 199);
            this.lsbSinSala.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(283, 134);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.Text = "<-";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(283, 197);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 23);
            this.btnQuitar.TabIndex = 17;
            this.btnQuitar.Text = "->";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // cmbColorSala
            // 
            this.cmbColorSala.FormattingEnabled = true;
            this.cmbColorSala.Location = new System.Drawing.Point(272, 37);
            this.cmbColorSala.Name = "cmbColorSala";
            this.cmbColorSala.Size = new System.Drawing.Size(121, 21);
            this.cmbColorSala.TabIndex = 18;
            this.cmbColorSala.SelectedIndexChanged += new System.EventHandler(this.cmbColorSala_SelectedIndexChanged);
            // 
            // lblColorSala
            // 
            this.lblColorSala.AutoSize = true;
            this.lblColorSala.Location = new System.Drawing.Point(208, 40);
            this.lblColorSala.Name = "lblColorSala";
            this.lblColorSala.Size = new System.Drawing.Size(58, 13);
            this.lblColorSala.TabIndex = 19;
            this.lblColorSala.Text = "Color Sala:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Profesor:";
            // 
            // lblProfeSelect
            // 
            this.lblProfeSelect.AutoSize = true;
            this.lblProfeSelect.Location = new System.Drawing.Point(12, 74);
            this.lblProfeSelect.Name = "lblProfeSelect";
            this.lblProfeSelect.Size = new System.Drawing.Size(117, 13);
            this.lblProfeSelect.TabIndex = 20;
            this.lblProfeSelect.Text = "Profesor Seleccionado:";
            // 
            // lblResultadoProfe
            // 
            this.lblResultadoProfe.AutoSize = true;
            this.lblResultadoProfe.Location = new System.Drawing.Point(133, 61);
            this.lblResultadoProfe.Name = "lblResultadoProfe";
            this.lblResultadoProfe.Size = new System.Drawing.Size(133, 13);
            this.lblResultadoProfe.TabIndex = 21;
            this.lblResultadoProfe.Text = "Vacio                                .";
            // 
            // frmAsignarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 302);
            this.Controls.Add(this.lblResultadoProfe);
            this.Controls.Add(this.lblProfeSelect);
            this.Controls.Add(this.lblColorSala);
            this.Controls.Add(this.cmbColorSala);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lsbSinSala);
            this.Controls.Add(this.lsbConSala);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDocente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(650, 341);
            this.MinimumSize = new System.Drawing.Size(650, 341);
            this.Name = "frmAsignarAlumno";
            this.Text = "frmAsignarAlumno";
            this.Load += new System.EventHandler(this.frmAsignarAlumno_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbDocente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tlmGuardar;
        private System.Windows.Forms.ListBox lsbConSala;
        private System.Windows.Forms.ListBox lsbSinSala;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ComboBox cmbColorSala;
        private System.Windows.Forms.Label lblColorSala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProfeSelect;
        private System.Windows.Forms.Label lblResultadoProfe;
    }
}