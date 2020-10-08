namespace QuinteroHernandez.Michell
{
    partial class frmAltaPariente
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
            this.cmbParentesco = new System.Windows.Forms.ComboBox();
            this.lblParentesco = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.grbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSexo
            // 
            this.grbSexo.Location = new System.Drawing.Point(165, 112);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 277);
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(103, 277);
            this.btnModificar.Text = "Cancelar";
            // 
            // rtbListaAgregados
            // 
            this.rtbListaAgregados.TextChanged += new System.EventHandler(this.rtbListaAgregados_TextChanged);
            // 
            // cmbParentesco
            // 
            this.cmbParentesco.FormattingEnabled = true;
            this.cmbParentesco.Location = new System.Drawing.Point(227, 185);
            this.cmbParentesco.Name = "cmbParentesco";
            this.cmbParentesco.Size = new System.Drawing.Size(121, 21);
            this.cmbParentesco.TabIndex = 13;
            // 
            // lblParentesco
            // 
            this.lblParentesco.AutoSize = true;
            this.lblParentesco.Location = new System.Drawing.Point(162, 188);
            this.lblParentesco.Name = "lblParentesco";
            this.lblParentesco.Size = new System.Drawing.Size(64, 13);
            this.lblParentesco.TabIndex = 14;
            this.lblParentesco.Text = "Parentesco:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(168, 236);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 15;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(227, 233);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 16;
            // 
            // frmAltaPariente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 312);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblParentesco);
            this.Controls.Add(this.cmbParentesco);
            this.Name = "frmAltaPariente";
            this.Text = "frmAltaPariente";
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
            this.Controls.SetChildIndex(this.cmbParentesco, 0);
            this.Controls.SetChildIndex(this.lblParentesco, 0);
            this.Controls.SetChildIndex(this.lblTelefono, 0);
            this.Controls.SetChildIndex(this.txtTelefono, 0);
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbParentesco;
        private System.Windows.Forms.Label lblParentesco;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
    }
}