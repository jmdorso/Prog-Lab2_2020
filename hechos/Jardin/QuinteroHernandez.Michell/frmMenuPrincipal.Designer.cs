namespace QuinteroHernandez.Michell
{
    partial class frmMenuPrincipal
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionDePadresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldoNoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionPorAulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recaudacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosAdministrativaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsCargarAulas = new System.Windows.Forms.ToolStripMenuItem();
            this.lsbRojo = new System.Windows.Forms.ListBox();
            this.lblJardin = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscarAlumno = new System.Windows.Forms.TextBox();
            this.lblBuscarAlumno = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rtcMostrarAula = new System.Windows.Forms.RichTextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.obtenerDatosToolStripMenuItem,
            this.tlsCargarAulas});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(651, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Menu";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDocenteToolStripMenuItem,
            this.altaNoDocenteToolStripMenuItem,
            this.altaAlumnoToolStripMenuItem,
            this.altaAulaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // altaDocenteToolStripMenuItem
            // 
            this.altaDocenteToolStripMenuItem.Name = "altaDocenteToolStripMenuItem";
            this.altaDocenteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.altaDocenteToolStripMenuItem.Text = "Alta docente";
            this.altaDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaDocenteToolStripMenuItem_Click);
            // 
            // altaNoDocenteToolStripMenuItem
            // 
            this.altaNoDocenteToolStripMenuItem.Name = "altaNoDocenteToolStripMenuItem";
            this.altaNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.altaNoDocenteToolStripMenuItem.Text = "Alta No docente";
            this.altaNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.altaNoDocenteToolStripMenuItem_Click);
            // 
            // altaAlumnoToolStripMenuItem
            // 
            this.altaAlumnoToolStripMenuItem.Name = "altaAlumnoToolStripMenuItem";
            this.altaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.altaAlumnoToolStripMenuItem.Text = "Alta alumno";
            this.altaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.altaAlumnoToolStripMenuItem_Click);
            // 
            // altaAulaToolStripMenuItem
            // 
            this.altaAulaToolStripMenuItem.Name = "altaAulaToolStripMenuItem";
            this.altaAulaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.altaAulaToolStripMenuItem.Text = "Alta aula";
            this.altaAulaToolStripMenuItem.Click += new System.EventHandler(this.altaAulaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacionDePadresToolStripMenuItem,
            this.sueldoDocenteToolStripMenuItem,
            this.sueldoNoDocenteToolStripMenuItem,
            this.recaudacionPorAulaToolStripMenuItem,
            this.recaudacionToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // informacionDePadresToolStripMenuItem
            // 
            this.informacionDePadresToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuBar;
            this.informacionDePadresToolStripMenuItem.Name = "informacionDePadresToolStripMenuItem";
            this.informacionDePadresToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.informacionDePadresToolStripMenuItem.Text = "Informacion de padres";
            this.informacionDePadresToolStripMenuItem.Click += new System.EventHandler(this.informacionDePadresToolStripMenuItem_Click);
            // 
            // sueldoDocenteToolStripMenuItem
            // 
            this.sueldoDocenteToolStripMenuItem.Name = "sueldoDocenteToolStripMenuItem";
            this.sueldoDocenteToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.sueldoDocenteToolStripMenuItem.Text = "Sueldo docente";
            this.sueldoDocenteToolStripMenuItem.Click += new System.EventHandler(this.sueldoDocenteToolStripMenuItem_Click);
            // 
            // sueldoNoDocenteToolStripMenuItem
            // 
            this.sueldoNoDocenteToolStripMenuItem.Name = "sueldoNoDocenteToolStripMenuItem";
            this.sueldoNoDocenteToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.sueldoNoDocenteToolStripMenuItem.Text = "Sueldo no docente";
            this.sueldoNoDocenteToolStripMenuItem.Click += new System.EventHandler(this.sueldoNoDocenteToolStripMenuItem_Click);
            // 
            // recaudacionPorAulaToolStripMenuItem
            // 
            this.recaudacionPorAulaToolStripMenuItem.Name = "recaudacionPorAulaToolStripMenuItem";
            this.recaudacionPorAulaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.recaudacionPorAulaToolStripMenuItem.Text = "Recaudacion por aula";
            this.recaudacionPorAulaToolStripMenuItem.Click += new System.EventHandler(this.recaudacionPorAulaToolStripMenuItem_Click);
            // 
            // recaudacionToolStripMenuItem
            // 
            this.recaudacionToolStripMenuItem.Name = "recaudacionToolStripMenuItem";
            this.recaudacionToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.recaudacionToolStripMenuItem.Text = "Recaudacion Total del jardin";
            this.recaudacionToolStripMenuItem.Click += new System.EventHandler(this.recaudacionToolStripMenuItem_Click);
            // 
            // obtenerDatosToolStripMenuItem
            // 
            this.obtenerDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDocentesToolStripMenuItem,
            this.datosAdministrativaToolStripMenuItem,
            this.datosAlumnosToolStripMenuItem});
            this.obtenerDatosToolStripMenuItem.Name = "obtenerDatosToolStripMenuItem";
            this.obtenerDatosToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.obtenerDatosToolStripMenuItem.Text = "Obtener Datos";
            // 
            // datosDocentesToolStripMenuItem
            // 
            this.datosDocentesToolStripMenuItem.Name = "datosDocentesToolStripMenuItem";
            this.datosDocentesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.datosDocentesToolStripMenuItem.Text = "Datos Docentes";
            this.datosDocentesToolStripMenuItem.Click += new System.EventHandler(this.datosDocentesToolStripMenuItem_Click);
            // 
            // datosAdministrativaToolStripMenuItem
            // 
            this.datosAdministrativaToolStripMenuItem.Name = "datosAdministrativaToolStripMenuItem";
            this.datosAdministrativaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.datosAdministrativaToolStripMenuItem.Text = "Datos Administrativa";
            this.datosAdministrativaToolStripMenuItem.Click += new System.EventHandler(this.datosAdministrativaToolStripMenuItem_Click);
            // 
            // datosAlumnosToolStripMenuItem
            // 
            this.datosAlumnosToolStripMenuItem.Name = "datosAlumnosToolStripMenuItem";
            this.datosAlumnosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.datosAlumnosToolStripMenuItem.Text = "Datos Alumnos";
            this.datosAlumnosToolStripMenuItem.Click += new System.EventHandler(this.datosAlumnosToolStripMenuItem_Click);
            // 
            // tlsCargarAulas
            // 
            this.tlsCargarAulas.Name = "tlsCargarAulas";
            this.tlsCargarAulas.Size = new System.Drawing.Size(86, 20);
            this.tlsCargarAulas.Text = "Cargar Aulas";
            this.tlsCargarAulas.Click += new System.EventHandler(this.cargarAulasToolStripMenuItem_Click);
            // 
            // lsbRojo
            // 
            this.lsbRojo.FormattingEnabled = true;
            this.lsbRojo.HorizontalScrollbar = true;
            this.lsbRojo.Location = new System.Drawing.Point(12, 156);
            this.lsbRojo.Name = "lsbRojo";
            this.lsbRojo.Size = new System.Drawing.Size(444, 121);
            this.lsbRojo.TabIndex = 3;
            // 
            // lblJardin
            // 
            this.lblJardin.AutoSize = true;
            this.lblJardin.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJardin.Location = new System.Drawing.Point(115, 51);
            this.lblJardin.Name = "lblJardin";
            this.lblJardin.Size = new System.Drawing.Size(100, 33);
            this.lblJardin.TabIndex = 5;
            this.lblJardin.Text = "Jardin: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(65, 108);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(196, 33);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Los Pichoncitos";
            // 
            // txtBuscarAlumno
            // 
            this.txtBuscarAlumno.Location = new System.Drawing.Point(471, 53);
            this.txtBuscarAlumno.Name = "txtBuscarAlumno";
            this.txtBuscarAlumno.Size = new System.Drawing.Size(111, 20);
            this.txtBuscarAlumno.TabIndex = 7;
            // 
            // lblBuscarAlumno
            // 
            this.lblBuscarAlumno.AutoSize = true;
            this.lblBuscarAlumno.Location = new System.Drawing.Point(468, 37);
            this.lblBuscarAlumno.Name = "lblBuscarAlumno";
            this.lblBuscarAlumno.Size = new System.Drawing.Size(78, 13);
            this.lblBuscarAlumno.TabIndex = 8;
            this.lblBuscarAlumno.Text = "BuscarAlumno:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(588, 51);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(51, 23);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.Text = "Search";
            this.txtBuscar.UseVisualStyleBackColor = true;
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Mostrar Aula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtcMostrarAula
            // 
            this.rtcMostrarAula.Location = new System.Drawing.Point(483, 127);
            this.rtcMostrarAula.Name = "rtcMostrarAula";
            this.rtcMostrarAula.Size = new System.Drawing.Size(156, 150);
            this.rtcMostrarAula.TabIndex = 11;
            this.rtcMostrarAula.Text = "";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(651, 289);
            this.Controls.Add(this.rtcMostrarAula);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblBuscarAlumno);
            this.Controls.Add(this.txtBuscarAlumno);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblJardin);
            this.Controls.Add(this.lsbRojo);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(667, 328);
            this.MinimumSize = new System.Drawing.Size(667, 328);
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionDePadresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoNoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionPorAulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recaudacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosAdministrativaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosAlumnosToolStripMenuItem;
        private System.Windows.Forms.ListBox lsbRojo;
        private System.Windows.Forms.ToolStripMenuItem tlsCargarAulas;
        private System.Windows.Forms.Label lblJardin;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscarAlumno;
        private System.Windows.Forms.Label lblBuscarAlumno;
        private System.Windows.Forms.Button txtBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtcMostrarAula;
    }
}