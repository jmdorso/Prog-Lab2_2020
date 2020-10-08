using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Windows.Forms.VisualStyles;

namespace QuinteroHernandez.Michell
{
    public partial class frmAsignarAlumno : Form
    {
        
        //BindingSource bsSinAula = new BindingSource();
        //BindingSource bsAula = new BindingSource();
        //BindingSource bsDocentes = new BindingSource();
        private Docente unDocente;
        EColores colorSala;
        ETurno jornadas;
        private List<Aula> listaAulas;
        public Aula aula;
        //private List<Alumno> listaAlumConAula;

        public frmAsignarAlumno()
        {
            InitializeComponent();

            
            DoncenteMañana = new List<Docente>();
            DocenteTarde = new List<Docente>();
            ListaAlumConAula = new List<Alumno>();
            DocenteAux = new List<Docente>();

        }
        public frmAsignarAlumno(List<Alumno> listaAlumnos, List<Docente> listaDocentes, List<Aula> listaAulas, List<Alumno> alumnosAsignados) : this()
        {
            this.ListaAlumnos = listaAlumnos;
            this.ListaDocentes = listaDocentes;
            this.listaAulas = listaAulas;
            this.ListaAlumConAula = alumnosAsignados;
            foreach (var item in Enum.GetValues(typeof(ETurno)))
            {
                cmbTurno.Items.Add(item);
            }
            this.cmbColorSala.DataSource = Enum.GetValues(typeof(EColores));
            MostrarListaAlumnosSinAula();

            // lsbConSala.DataSource = bsAula;
        }
        public List<Alumno> ListaAlumnos { get; set; }
        public List<Docente> ListaDocentes { get; set; }
        public List<Docente> DocenteAux { get; set; }
        public List<Docente> DoncenteMañana { get; set; }
        public List<Docente> DocenteTarde { get; set; }
        public List<Alumno> ListaAlumConAula { get; set; }
        public Aula AulaCreada
        {
            get { return this.aula; }
            set { this.aula = value; }
        }

        public Docente this[int i]
        {
            get { return DocenteAux[i]; }
        }

        private void MostrarListaAlumnosSinAula()
        {
            lsbConSala.Items.Clear();
            foreach (Alumno item in ListaAlumConAula)
            {
                lsbConSala.Items.Add(item.MostrarPersona());

            }
            lsbSinSala.Items.Clear();
            foreach (Alumno item in ListaAlumnos)
            {
                lsbSinSala.Items.Add(item.MostrarPersona());
            }
            //if (ListaAlumnos==null)//preguntar.

            //{
            //    bsSinAula.DataSource = ListaAlumnos;
            //}

        }

        private void frmAsignarAlumno_Load(object sender, EventArgs e)
        {
            lsbConSala.Items.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (lsbSinSala.Items.Count > 0 && lsbSinSala.SelectedItem != null && lsbConSala.Items.Count <=30)
            {
                #region probando
                //if (cmbColorSala.SelectedIndex==1)
                //{
                //    ListaAlumConAula.Add(ListaAlumnos[lsbSinSala.SelectedIndex]);
                //    ListaAlumnos.Remove(ListaAlumnos[lsbSinSala.SelectedIndex]);
                //}else if(cmbColorSala.SelectedIndex == 2)
                //{
                //    ListaAlumConAula.Add(ListaAlumnos[lsbSinSala.SelectedIndex]);
                //    ListaAlumnos.Remove(ListaAlumnos[lsbSinSala.SelectedIndex]);
                //}
                //else if (cmbColorSala.SelectedIndex==3)
                //{
                //    ListaAlumConAula.Add(ListaAlumnos[lsbSinSala.SelectedIndex]);
                //    ListaAlumnos.Remove(ListaAlumnos[lsbSinSala.SelectedIndex]);
                //}else if (cmbColorSala.SelectedIndex == 4)
                //{
                //    ListaAlumConAula.Add(ListaAlumnos[lsbSinSala.SelectedIndex]);
                //    ListaAlumnos.Remove(ListaAlumnos[lsbSinSala.SelectedIndex]);
                //}


                //int index = lsbSinSala.SelectedIndex;
                //lsbConSala.Items.Add(lsbSinSala.SelectedItem);
                //lsbSinSala.Items.RemoveAt(index);

                //for (int i = 0; i < alumnosEnAulaLista.Count; i++)
                //{
                //    listBoxAlumnosEnAula.Items.Add(alumnosEnAulaLista[i].Listar());
                //}
                #endregion
                ListaAlumConAula.Add(ListaAlumnos[lsbSinSala.SelectedIndex]);
                ListaAlumnos.Remove(ListaAlumnos[lsbSinSala.SelectedIndex]);               
                
                
                MostrarListaAlumnosSinAula();
            }
            else
            {
                MessageBox.Show("No hay mas espacio en el aula.");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lsbConSala.Items.Count > 0 && lsbConSala.SelectedIndex != -1)
            {
                
              
                ListaAlumnos.Add(ListaAlumConAula[lsbConSala.SelectedIndex]);
                ListaAlumConAula.Remove(ListaAlumConAula[lsbConSala.SelectedIndex]);
                MostrarListaAlumnosSinAula();
            }
        }
        public void CambiarColorFondo()
        {
            EColores colorFondo = (EColores)cmbColorSala.SelectedItem;
            switch (colorFondo)
            {
                case EColores.Naranja:
                    this.BackColor = Color.DarkOrange;
                    SalaNaranja();
                    break;
                case EColores.Rojo:
                    this.BackColor = Color.DarkRed;
                    SalaRoja();
                    break;
                case EColores.Amarillo:
                    this.BackColor = Color.Yellow;
                    SalaAmarilla();
                    break;
                case EColores.Verde:
                    this.BackColor = Color.DarkOliveGreen;
                    SalaVerde();
                    break;
                default:

                    break;
            }
        }

        private void cmbColorSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarColorFondo();
        }
        public void SalaNaranja()
        {
            lsbSinSala.Items.Clear();
            MostrarListaAlumnosSinAula();
            foreach (Alumno item in ListaAlumnos)
            {
                if (item.ColorSala == EColores.Naranja)
                {

                    lsbSinSala.Items.Add(item.Mostrar(item));

                }
            }
        }
        public void SalaAmarilla()
        {
            lsbSinSala.Items.Clear();
            lsbConSala.Items.Clear();
            MostrarListaAlumnosSinAula();
            foreach (Alumno item in ListaAlumnos)
            {

                if (item.ColorSala == EColores.Amarillo)
                {

                    lsbSinSala.Items.Add(item.Mostrar(item));
                }
            }
        }
        public void SalaRoja()
        {
            lsbSinSala.Items.Clear();
            lsbConSala.Items.Clear();
            MostrarListaAlumnosSinAula();
            foreach (Alumno item in ListaAlumnos)
            {

                if (item.ColorSala == EColores.Rojo)
                {

                    lsbSinSala.Items.Add(item.Mostrar(item));
                }
            }
        }
        public void SalaVerde()
        {
            lsbConSala.Items.Clear();
            lsbSinSala.Items.Clear();
            MostrarListaAlumnosSinAula();
            foreach (Alumno item in ListaAlumnos)
            {

                if (item.ColorSala == EColores.Verde)
                {

                    lsbSinSala.Items.Add(item.Mostrar(item));
                }
            }
        }
        public void Jornadas()
        {

            ETurno jornadas = (ETurno)cmbTurno.SelectedItem;
            switch (jornadas)
            {
                case ETurno.Mañana:
                    TurnosDocentesMañana();
                    foreach (Docente item in DoncenteMañana)
                    {
                        DocenteAux.Add(item);
                    }
                    break;
                case ETurno.Tarde:
                    TurnosDocentesTarde();
                    foreach (Docente item in DocenteTarde)
                    {
                        DocenteAux.Add(item);
                    }
                    break;
                default:
                    break;
            }

        }

        private void cmbDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResultadoProfe.Text = (cmbDocente.SelectedItem.ToString()); ;
        }
        public void TurnosDocentesMañana()
        {
            
            MostrarListaAlumnosSinAula();
            DateTime mañanaEntrada = new DateTime(01, 01, 01, 07, 00, 00);
            DateTime mañanaSalida = new DateTime(01, 01, 01, 13, 00, 00);
            

            foreach (Docente item in ListaDocentes)
            {
                if ((item.HoraEntrada.Hour >= mañanaEntrada.Hour) && (item.HoraSalida.Hour <= mañanaSalida.Hour ))//Hacerlo con for para que cargue d euna vez co el tostring
                {
                    DoncenteMañana.Add(item);

                }
            }
            for (int i = 0; i < DoncenteMañana.Count; i++)
            {

                cmbDocente.Items.Add(this.DoncenteMañana[i].MostrarPersona());

            }
        }
        public void TurnosDocentesTarde()
        {
            
            DateTime TardeEntrada = new DateTime(01, 01, 01, 13, 30, 00);
            DateTime TardeSalida = new DateTime(01, 01, 01, 19, 00, 00);
           

            foreach (Docente item in ListaDocentes)
            {
                if ((item.HoraEntrada.Hour >= TardeEntrada.Hour) && (item.HoraSalida.Hour <= TardeSalida.Hour))//Convert.ToDateTime("01,01,01,07,00,00").Hour
                {
                    DocenteTarde.Add(item);

                }
            }
            for (int i = 0; i < DocenteTarde.Count; i++)
            {

                cmbDocente.Items.Add(this.DocenteTarde[i].MostrarPersona());

            }
        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jornadas();
        }

        private void tlmGuardar_Click(object sender, EventArgs e)
        {
            SoundPlayer guardar = new SoundPlayer(@"sonido\thanku.wav");
            guardar.Play();
            if(cmbDocente.SelectedItem==null || cmbTurno.SelectedItem==null || lsbConSala.Items.Count < 0 || cmbColorSala == null)
            {
                MessageBox.Show("¡Complete los campos!");
            }
            else
            {
                this.colorSala = (EColores)cmbColorSala.SelectedItem;
                this.unDocente = this[cmbDocente.SelectedIndex];
                this.jornadas = (ETurno)cmbTurno.SelectedItem;
                foreach (Alumno item in ListaAlumConAula)
                {
                    item.ColorSala = (EColores)cmbColorSala.SelectedItem;
                }
                
                aula = new Aula(colorSala, unDocente, jornadas);
                aula.Alumnos = new List<Alumno>();
                foreach (Alumno item in ListaAlumConAula)
                {
                    if ((aula + item)==false)
                    {
                        MessageBox.Show("Error al agregar alumno!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }   
                }
                
                this.DialogResult = DialogResult.OK;
            }
            if (this.DialogResult == DialogResult.OK)
            {
                
                //this.listaAulas.Add(aula);
                MessageBox.Show("Se agregaron: " + aula.Alumnos.Count + " alumnos al aula " + aula.ToString());

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
    }
}
