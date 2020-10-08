namespace QuinteroHernandez.Michell
{
    partial class frmAltaDocente
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
            this.dtpHoraEntrada = new System.Windows.Forms.DateTimePicker();
            this.lblHoraEntrada = new System.Windows.Forms.Label();
            this.lblHoraSalida = new System.Windows.Forms.Label();
            this.dtpHoraSalida = new System.Windows.Forms.DateTimePicker();
            this.lblValorHora = new System.Windows.Forms.Label();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dtpHoraEntrada
            // 
            this.dtpHoraEntrada.Checked = false;
            this.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraEntrada.Location = new System.Drawing.Point(379, 38);
            this.dtpHoraEntrada.Name = "dtpHoraEntrada";
            this.dtpHoraEntrada.Size = new System.Drawing.Size(112, 20);
            this.dtpHoraEntrada.TabIndex = 13;
            // 
            // lblHoraEntrada
            // 
            this.lblHoraEntrada.AutoSize = true;
            this.lblHoraEntrada.Location = new System.Drawing.Point(376, 22);
            this.lblHoraEntrada.Name = "lblHoraEntrada";
            this.lblHoraEntrada.Size = new System.Drawing.Size(87, 13);
            this.lblHoraEntrada.TabIndex = 14;
            this.lblHoraEntrada.Text = "Hora de entrada:";
            // 
            // lblHoraSalida
            // 
            this.lblHoraSalida.AutoSize = true;
            this.lblHoraSalida.Location = new System.Drawing.Point(376, 86);
            this.lblHoraSalida.Name = "lblHoraSalida";
            this.lblHoraSalida.Size = new System.Drawing.Size(80, 13);
            this.lblHoraSalida.TabIndex = 15;
            this.lblHoraSalida.Text = "Hora de Salida:";
            // 
            // dtpHoraSalida
            // 
            this.dtpHoraSalida.Checked = false;
            this.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraSalida.Location = new System.Drawing.Point(379, 102);
            this.dtpHoraSalida.Name = "dtpHoraSalida";
            this.dtpHoraSalida.Size = new System.Drawing.Size(112, 20);
            this.dtpHoraSalida.TabIndex = 16;
            this.dtpHoraSalida.Value = new System.DateTime(2020, 5, 12, 0, 0, 0, 0);
            // 
            // lblValorHora
            // 
            this.lblValorHora.AutoSize = true;
            this.lblValorHora.Location = new System.Drawing.Point(376, 158);
            this.lblValorHora.Name = "lblValorHora";
            this.lblValorHora.Size = new System.Drawing.Size(58, 13);
            this.lblValorHora.TabIndex = 18;
            this.lblValorHora.Text = "Valor hora:";
            // 
            // txtValorHora
            // 
            this.txtValorHora.Location = new System.Drawing.Point(379, 174);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(100, 20);
            this.txtValorHora.TabIndex = 19;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(379, 231);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAltaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 272);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtValorHora);
            this.Controls.Add(this.lblValorHora);
            this.Controls.Add(this.dtpHoraSalida);
            this.Controls.Add(this.lblHoraSalida);
            this.Controls.Add(this.lblHoraEntrada);
            this.Controls.Add(this.dtpHoraEntrada);
            this.Name = "frmAltaDocente";
            this.Text = "frmAltaDocente";
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
            this.Controls.SetChildIndex(this.dtpHoraEntrada, 0);
            this.Controls.SetChildIndex(this.lblHoraEntrada, 0);
            this.Controls.SetChildIndex(this.lblHoraSalida, 0);
            this.Controls.SetChildIndex(this.dtpHoraSalida, 0);
            this.Controls.SetChildIndex(this.lblValorHora, 0);
            this.Controls.SetChildIndex(this.txtValorHora, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpHoraEntrada;
        private System.Windows.Forms.Label lblHoraEntrada;
        private System.Windows.Forms.Label lblHoraSalida;
        private System.Windows.Forms.DateTimePicker dtpHoraSalida;
        private System.Windows.Forms.Label lblValorHora;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.Button btnSalir;
    }
}