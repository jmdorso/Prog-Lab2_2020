namespace QuinteroHernandez.Michell
{
    partial class frmAltaAlumno
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
            this.cmbColorSala = new System.Windows.Forms.ComboBox();
            this.lblColorSala = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblPrecioCuota = new System.Windows.Forms.Label();
            this.txtPrecioCuota = new System.Windows.Forms.TextBox();
            this.btnAgregarPariente = new System.Windows.Forms.Button();
            this.lsbPariente = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dni = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Parentesco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.grbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(193, 22);
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(193, 54);
            // 
            // lblDni
            // 
            this.lblDni.Location = new System.Drawing.Point(211, 89);
            // 
            // grbSexo
            // 
            this.grbSexo.Location = new System.Drawing.Point(368, 19);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(246, 51);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(246, 86);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 282);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(105, 282);
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(246, 19);
            // 
            // cmbColorSala
            // 
            this.cmbColorSala.FormattingEnabled = true;
            this.cmbColorSala.Location = new System.Drawing.Point(455, 89);
            this.cmbColorSala.Name = "cmbColorSala";
            this.cmbColorSala.Size = new System.Drawing.Size(121, 21);
            this.cmbColorSala.TabIndex = 13;
            // 
            // lblColorSala
            // 
            this.lblColorSala.AutoSize = true;
            this.lblColorSala.Location = new System.Drawing.Point(365, 93);
            this.lblColorSala.Name = "lblColorSala";
            this.lblColorSala.Size = new System.Drawing.Size(84, 13);
            this.lblColorSala.TabIndex = 14;
            this.lblColorSala.Text = "Color de la Sala:";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(198, 122);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(42, 13);
            this.lblLegajo.TabIndex = 15;
            this.lblLegajo.Text = "Legajo:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(246, 119);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 6;
            // 
            // lblPrecioCuota
            // 
            this.lblPrecioCuota.AutoSize = true;
            this.lblPrecioCuota.Location = new System.Drawing.Point(375, 122);
            this.lblPrecioCuota.Name = "lblPrecioCuota";
            this.lblPrecioCuota.Size = new System.Drawing.Size(70, 13);
            this.lblPrecioCuota.TabIndex = 16;
            this.lblPrecioCuota.Text = "Precio cuota:";
            // 
            // txtPrecioCuota
            // 
            this.txtPrecioCuota.Location = new System.Drawing.Point(455, 119);
            this.txtPrecioCuota.Name = "txtPrecioCuota";
            this.txtPrecioCuota.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCuota.TabIndex = 17;
            // 
            // btnAgregarPariente
            // 
            this.btnAgregarPariente.Location = new System.Drawing.Point(519, 285);
            this.btnAgregarPariente.Name = "btnAgregarPariente";
            this.btnAgregarPariente.Size = new System.Drawing.Size(99, 23);
            this.btnAgregarPariente.TabIndex = 18;
            this.btnAgregarPariente.Text = "Agregar Pariente";
            this.btnAgregarPariente.UseVisualStyleBackColor = true;
            this.btnAgregarPariente.Click += new System.EventHandler(this.btnAgregarPariente_Click);
            // 
            // lsbPariente
            // 
            this.lsbPariente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Apellido,
            this.sexo,
            this.Dni,
            this.Parentesco,
            this.Telefono});
            this.lsbPariente.HideSelection = false;
            this.lsbPariente.Location = new System.Drawing.Point(196, 171);
            this.lsbPariente.Name = "lsbPariente";
            this.lsbPariente.Size = new System.Drawing.Size(380, 97);
            this.lsbPariente.TabIndex = 19;
            this.lsbPariente.UseCompatibleStateImageBehavior = false;
            this.lsbPariente.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            // 
            // sexo
            // 
            this.sexo.Text = "Femenino";
            // 
            // Dni
            // 
            this.Dni.Text = "Dni";
            // 
            // Parentesco
            // 
            this.Parentesco.Text = "Parentesco";
            // 
            // Telefono
            // 
            this.Telefono.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Datos del Responsable:";
            // 
            // frmAltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbPariente);
            this.Controls.Add(this.btnAgregarPariente);
            this.Controls.Add(this.txtPrecioCuota);
            this.Controls.Add(this.lblPrecioCuota);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblColorSala);
            this.Controls.Add(this.cmbColorSala);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(646, 356);
            this.MinimumSize = new System.Drawing.Size(646, 356);
            this.Name = "frmAltaAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jardin los Pichoncitos: Alta Alumno";
            this.Load += new System.EventHandler(this.frmAltaAlumno_Load);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblApellido, 0);
            this.Controls.SetChildIndex(this.lblDni, 0);
            this.Controls.SetChildIndex(this.grbSexo, 0);
            this.Controls.SetChildIndex(this.txtNombre, 0);
            this.Controls.SetChildIndex(this.txtApellido, 0);
            this.Controls.SetChildIndex(this.txtDni, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.rtbListaAgregados, 0);
            this.Controls.SetChildIndex(this.cmbColorSala, 0);
            this.Controls.SetChildIndex(this.lblColorSala, 0);
            this.Controls.SetChildIndex(this.lblLegajo, 0);
            this.Controls.SetChildIndex(this.txtLegajo, 0);
            this.Controls.SetChildIndex(this.lblPrecioCuota, 0);
            this.Controls.SetChildIndex(this.txtPrecioCuota, 0);
            this.Controls.SetChildIndex(this.btnAgregarPariente, 0);
            this.Controls.SetChildIndex(this.lsbPariente, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbColorSala;
        private System.Windows.Forms.Label lblColorSala;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblPrecioCuota;
        private System.Windows.Forms.TextBox txtPrecioCuota;
        private System.Windows.Forms.Button btnAgregarPariente;
        private System.Windows.Forms.ListView lsbPariente;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader sexo;
        private System.Windows.Forms.ColumnHeader Dni;
        private System.Windows.Forms.ColumnHeader Parentesco;
        private System.Windows.Forms.ColumnHeader Telefono;
        private System.Windows.Forms.Label label1;
    }
}