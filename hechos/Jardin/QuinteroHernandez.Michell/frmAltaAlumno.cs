using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuinteroHernandez.Michell
{
    public partial class frmAltaAlumno : frmPersona
    {
        private EColores colorSala;
        private int legajo;
        private float precioCuota;
        private Responsable responsable;
        private Alumno unAlumno;
        
        public frmAltaAlumno()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath+@"\fondos\fondoAlumno.JPG");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.btnAgregar.Enabled = false;
           
            foreach (EColores colorSala in EColores.GetValues(typeof(EColores)))
            {
                this.cmbColorSala.Items.Add(colorSala);
            }
            btnModificar.Text = "Cancelar";

        }
        public Alumno Alumno
        {
            get { return this.unAlumno; }
            set { this.unAlumno = value; }
        }

        private void btnAgregarPariente_Click(object sender, EventArgs e)
        {
            frmAltaPariente altaPariente = new frmAltaPariente();
            DialogResult resultado = altaPariente.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.responsable = altaPariente.RetornaResponsable();
                Listas.listaResponsables.Add(this.responsable);
                this.lsbPariente.Items.Clear();
                foreach (Responsable responsable in Listas.listaResponsables)
                {
                    ListViewItem item = new ListViewItem();
                    item = lsbPariente.Items.Add(responsable.Nombre);
                    item.SubItems.Add(responsable.Apellido);
                    item.SubItems.Add(responsable.Femenino.ToString());
                    item.SubItems.Add(responsable.Dni.ToString());
                    item.SubItems.Add(responsable.Parentesco.ToString());
                    item.SubItems.Add(responsable.Telefono);
                }
                this.btnAgregar.Enabled = true;
            }
             else if (this.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Se cancelo con exito");
            }
            
        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            base.btnAgregar_Click(sender, e);
            ValidarCamposAlumno();
            this.colorSala = (EColores)cmbColorSala.SelectedItem;
            if (this.DialogResult == DialogResult.OK)
            {
                this.unAlumno = RetornarAlumnoConSala();
                this.rtbListaAgregados.Text = unAlumno.ToString();
                Listas.listaAlumnos.Add(unAlumno);
                MessageBox.Show(unAlumno.ToString(), "cant alumnos agregados: " + Listas.listaAlumnos.Count);
            }
            else if (this.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Se cancelo con exito");
            }
            else
            {
                MessageBox.Show("Informacion Incorrecta.Proceso abortado. Validar la informacion y reintentar");
            }
            

        }
        public Alumno RetornarAlumnoConSala()
        {
            
            return new Alumno(this.nombre, this.apellido, this.dni, this.esFemenino, this.precioCuota, this.legajo, this.responsable, this.colorSala );
        }
        public void ValidarCamposAlumno()
        {
            if (cmbColorSala.Text== null ||!int.TryParse(txtLegajo.Text, out this.legajo) || !ValidarNumero(this.txtLegajo.Text) || !float.TryParse(txtPrecioCuota.Text, out this.precioCuota) || !ValidarNumero(txtPrecioCuota.Text) || lsbPariente.SelectedItems == null)
            {
                MessageBox.Show("¡Complete los campos!");
            }
        }

        private void frmAltaAlumno_Load(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cancelo Con Exito");
            this.DialogResult = DialogResult.Cancel;
        }
    } 
}
