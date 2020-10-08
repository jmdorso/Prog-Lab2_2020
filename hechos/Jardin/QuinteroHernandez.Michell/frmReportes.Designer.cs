namespace QuinteroHernandez.Michell
{
    partial class frmReportes
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
            this.lsbReporte = new System.Windows.Forms.ListBox();
            this.cmbAulas = new System.Windows.Forms.ComboBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblAviso2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbReporte
            // 
            this.lsbReporte.BackColor = System.Drawing.Color.Bisque;
            this.lsbReporte.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lsbReporte.FormattingEnabled = true;
            this.lsbReporte.HorizontalScrollbar = true;
            this.lsbReporte.Location = new System.Drawing.Point(19, 81);
            this.lsbReporte.Name = "lsbReporte";
            this.lsbReporte.ScrollAlwaysVisible = true;
            this.lsbReporte.Size = new System.Drawing.Size(385, 121);
            this.lsbReporte.TabIndex = 0;
            // 
            // cmbAulas
            // 
            this.cmbAulas.FormattingEnabled = true;
            this.cmbAulas.Location = new System.Drawing.Point(19, 31);
            this.cmbAulas.Name = "cmbAulas";
            this.cmbAulas.Size = new System.Drawing.Size(164, 21);
            this.cmbAulas.TabIndex = 1;
            this.cmbAulas.SelectedIndexChanged += new System.EventHandler(this.cmbAulas_SelectedIndexChanged);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(327, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(324, 57);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(0, 13);
            this.lblAviso.TabIndex = 3;
            // 
            // lblAviso2
            // 
            this.lblAviso2.AutoSize = true;
            this.lblAviso2.Location = new System.Drawing.Point(16, 9);
            this.lblAviso2.Name = "lblAviso2";
            this.lblAviso2.Size = new System.Drawing.Size(0, 13);
            this.lblAviso2.TabIndex = 4;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(16, 65);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(9, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "l";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 214);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblAviso2);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.cmbAulas);
            this.Controls.Add(this.lsbReporte);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbReporte;
        private System.Windows.Forms.ComboBox cmbAulas;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblAviso2;
        private System.Windows.Forms.Label lblResult;
    }
}