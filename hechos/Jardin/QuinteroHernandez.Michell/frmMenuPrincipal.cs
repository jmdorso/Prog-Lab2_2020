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
    public partial class frmMenuPrincipal : Form
    {
        private Docente docente;
        private Administrativa administrativo;
        private Responsable r1, r2, r3, r4, r5;
        Aula aula;
        bool flagCarga = false;
        bool flagCarga2 = false;
        bool flagCarga3 = false;
        private object aula11;

        public frmMenuPrincipal()
        {
            InitializeComponent();
            
        }
        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            
            Bitmap img = new Bitmap(Application.StartupPath + @"\fondos\perro.JPG");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;             
        }
        
        public Aula Aula
        {
            get { return aula; }
            set { aula = value; }
        }
        private void recaudacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altaDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaDocente altaDocente = new frmAltaDocente();
            //altaDocente.MdiParent = this;
            altaDocente.Show();
        }

        private void datosAdministrativaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (flagCarga2)
            {
                MessageBox.Show("Ya se cargaron los datos. ");
            }
            else
            {
                flagCarga2 = CargarNoDocentes();

            }
        }
        public void CargarAlumnosBoton()
        {
            if (flagCarga3)
            {
                MessageBox.Show("Ya se cargaron los datos. ");
            }
            else
            {
                flagCarga3 = CargarPersonas();

            }
        }
        private void datosAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarAlumnosBoton(); 
        }

        private void informacionDePadresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string auxiliar = "reportePadres";
            frmReportes reportesPadres = new frmReportes(Listas.listaAulas, auxiliar);
            reportesPadres.Text = "Informacion de Padres de familia o parientes.";
            
            reportesPadres.ShowDialog();

        }

        private void sueldoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportes reportesDocentes = new frmReportes();
            reportesDocentes.Text = "Sueldo de los Docentes: ";
            reportesDocentes.SueldoDocente();
            reportesDocentes.ShowDialog();
        }

        private void sueldoNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportes reportesNoDocentes = new frmReportes();
            reportesNoDocentes.Text = "Sueldo de los empleados administrativos:";
            reportesNoDocentes.SueldoNoDocentes();
            reportesNoDocentes.ShowDialog();
        }

        private void cargarAulasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lsbRojo.Items.Clear();

            for (int i = 0; i < Listas.listaAulas.Count; i++)
            {
                lsbRojo.Items.Add(Listas.listaAulas[i].ToString());
            }

        }

        private void recaudacionPorAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string auxiliar = "recaudacionAula";
            frmReportes frmReportes = new frmReportes(Listas.listaAulas, auxiliar);
            frmReportes.ShowDialog();
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        { 
            
            if ((txtBuscar.Text == "") || (txtBuscar.Text.Length < 2))
            {
                MessageBox.Show("Debe completar el campo");
            }
            else
            {
                foreach (Alumno item in Listas.AlumnosAsignados )
                {
                    if (item.Apellido==txtBuscar.Text)
                    {
                        MessageBox.Show("Se ha encontrado al siguiente alumno/a:\n\n" + item.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
        }

        private void altaNoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaNoDocente altaNoDocente = new frmAltaNoDocente();
            altaNoDocente.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aula aula=new Aula();
            int indice = lsbRojo.SelectedIndex;
            if (indice != -1)
            {
                foreach (var item in lsbRojo.Items)
                {
                    rtcMostrarAula.Text = item.ToString();
                }
                //for (int i = 0; i < aula.Alumnos.Count; i++)
                //{
                //    rtcMostrarAula.Text = aula.Alumnos.ToString();
                //}

            }
            else
            {
                MessageBox.Show("Debe seleccionar un aula");
            }
        }

        private void altaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltaAlumno altaAlumno = new frmAltaAlumno();

            altaAlumno.ShowDialog();



        }

        private void altaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignarAlumno altaAula = new frmAsignarAlumno(Listas.listaAlumnos, Listas.listaDocentes, Listas.listaAulas, Listas.AlumnosAsignados);
            DialogResult resultado = altaAula.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                Listas.listaAulas.Add(altaAula.AulaCreada);
                Listas.listaDocentes.Remove(altaAula.AulaCreada.Docente);
                Listas.listaAlumnos = altaAula.ListaAlumnos;
            }

        }
        public void CargarDocentesBoton()
        {
            if (flagCarga)
            {
                MessageBox.Show("Ya se cargaron los datos. ");
            }
            else
            {
                flagCarga = CargarDocentes();

            }
        }

        public void datosDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CargarDocentesBoton();
        }
        public bool CargarDocentes()
        {
            #region docentes

            DateTime mañana = new DateTime(2020, 05, 09, 07, 30, 00);
            DateTime mañana1 = new DateTime(2020, 05, 09, 12, 59, 00);
            DateTime tarde = new DateTime(2020, 05, 09, 13, 00, 00);
            DateTime tarde1 = new DateTime(2020, 05, 09, 18, 30, 00);

            Listas.listaDocentes.Add(new Docente(" Love ", " ruiz ", 14722, true, mañana, mañana1, 700));
            Listas.listaDocentes.Add(new Docente(" risoti ", " lopez ", 14718, false, mañana, mañana1, 500));
            Listas.listaDocentes.Add(new Docente(" miriam ", " londres ", 14717, true, tarde, tarde1, 250));
            Listas.listaDocentes.Add(new Docente(" fernando ", " masoti ", 14709, false, tarde, tarde1, 400));
            Listas.listaDocentes.Add(new Docente(" richi ", " rey ", 14785, false, tarde, tarde1, 350));
            Listas.listaDocentes.Add(new Docente(" Paquita ", " La del barrio ", 14785, false, tarde, tarde1, 350));
            #endregion
            return true;
        }
        public bool CargarPersonas()
        {
           
            #region Alumnos
            r1 = new Responsable("Daniel", "Gonzalez", 123654872, false, EParentesco.Padre, "11234568");
            r2 = new Responsable("Nubia", "Hernandez", 95825136, true, EParentesco.Madre, "11234568");
            r3 = new Responsable("Liliana", "Herran", 95725136, true, EParentesco.Tia, "11234568");
            r4 = new Responsable("Lina", "Mosquera", 95875136, true, EParentesco.Abuela, "11234568");
            r5 = new Responsable("Marcelo", "Maldonado", 95425136, true, EParentesco.Tio, "11234568");
            Listas.listaResponsables.Add(r1);
            Listas.listaResponsables.Add(r2);
            Listas.listaResponsables.Add(r3);
            Listas.listaResponsables.Add(r4);
            Listas.listaResponsables.Add(r5);
            Listas.listaAlumnos.Add(new Alumno("Wilie", "Mensler", 569142265, false, 395, 1, r1, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Joshua", "Leasor", 873887298, true, 289, 2, r2, EColores.Amarillo));
            Listas.listaAlumnos.Add(new Alumno("Jacintha", "Findlow", 907386156, true, 544, 3, r3, EColores.Naranja));
            Listas.listaAlumnos.Add(new Alumno("Jervis", "Cusworth", 711690091, false, 392, 4, r4, EColores.Verde));
            Listas.listaAlumnos.Add(new Alumno("Julina", "Mather", 771491982, false, 775, 5, r5, EColores.Verde));
            Listas.listaAlumnos.Add(new Alumno("Morganica", "Benard", 289460490, false, 147, 6, r1, EColores.Amarillo));
            Listas.listaAlumnos.Add(new Alumno("Gale", "Antrag", 089238675, false, 356, 7, r2, EColores.Amarillo));
            Listas.listaAlumnos.Add(new Alumno("Perri", "Orrin", 402162271, false, 195, 8, r3, EColores.Naranja));
            Listas.listaAlumnos.Add(new Alumno("Maris", "Skippen", 063170256, false, 732, 9, r4, EColores.Naranja));
            Listas.listaAlumnos.Add(new Alumno("Olva", "Dearnly", 737722609, true, 894, 10, r5, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Loretta", "Kuhnel", 503594956, false, 048, 11, r1, EColores.Amarillo));
            Listas.listaAlumnos.Add(new Alumno("Debra", "Shouler", 714512074, true, 158, 12, r2, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Vitoria", "Birckmann", 646524971, true, 375, 13, r3, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Betsy", "Kinnen", 380626302, false, 127, 14, r3, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Ephrem", "Luthwood", 094210334, false, 665, 15, r3, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Dasya", "Hugli", 587962541, true, 796, 16, r3, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Elli", "Eyden", 564319386, true, 246, 17, r3, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Pierre", "Kobel", 908785210, false, 556, 18, r3, EColores.Naranja));
            Listas.listaAlumnos.Add(new Alumno("Koren", "Brugemann", 037299695, true, 765, 19, r3, EColores.Naranja));
            Listas.listaAlumnos.Add(new Alumno("Rhiamon", "Kennifick", 515890592, true, 210, 20, r3, EColores.Naranja));
            Listas.listaAlumnos.Add(new Alumno("Maxie", "Laugharne", 917394619, false, 449, 21, r3, EColores.Naranja));
            Listas.listaAlumnos.Add(new Alumno("Fanechka", "Gittings", 728506891, false, 5842, 22, r3, EColores.Naranja));
            Listas.listaAlumnos.Add(new Alumno("Ricardo", "Weatherley", 658458349, true, 6852, 23, r3, EColores.Naranja));
            Listas.listaAlumnos.Add(new Alumno("Alexandro", "Knoller", 075508493, true, 3942, 24, r3, EColores.Naranja));
            Listas.listaAlumnos.Add(new Alumno("Harper", "Gilstin", 501060006, true, 360, 25, r3, EColores.Verde));
            Listas.listaAlumnos.Add(new Alumno("Reuven", "Broady", 462912522, false, 2461, 26, r3, EColores.Verde));
            Listas.listaAlumnos.Add(new Alumno("Lorry", "Leedal", 788024461, true, 145, 27, r3, EColores.Verde));
            Listas.listaAlumnos.Add(new Alumno("Jeannie", "Burtonshaw", 241137555, false, 830, 28, r3, EColores.Verde));
            Listas.listaAlumnos.Add(new Alumno("Lauri", "Corps", 114188843, false, 135, 29, r3, EColores.Verde));
            Listas.listaAlumnos.Add(new Alumno("Cy", "Benninger", 542928768, false, 358, 30, r3, EColores.Verde));
            Listas.listaAlumnos.Add(new Alumno("Marcello", "MacAllen", 839829656, true, 212, 31, r3, EColores.Verde));
            Listas.listaAlumnos.Add(new Alumno("Miguelita", "Jugging", 218670575, true, 712, 32, r3, EColores.Verde));
            Listas.listaAlumnos.Add(new Alumno("Wren", "Pach", 036111977, false, 726, 33, r2, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Staford", "Rumgay", 947540456, false, 437, 34, r2, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Nanon", "Jewiss", 139524527, false, 676, 35, r2, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Matilda", "Capstack", 774453470, true, 36, 4, r2, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Meier", "Siely", 423157861, false, 414, 37, r2, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Lee", "Fripp", 431924406, true, 837, 38, r2, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Trenna", "Charnock", 233779239, true, 360, 39, r2, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Dottie", "Putnam", 254144845, true, 978, 40, r2, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Jobey", "Whorlow", 240393006, false, 269, 41, r2, EColores.Rojo));
            Listas.listaAlumnos.Add(new Alumno("Ferdinand", "Bousler", 731748931, false, 284, 42, r1, EColores.Amarillo));
            Listas.listaAlumnos.Add(new Alumno("Ianthe", "Kirsche", 013266978, false, 852, 43, r1, EColores.Amarillo));
            Listas.listaAlumnos.Add(new Alumno("Gordie", "Cockin", 471742112, false, 393, 44, r1, EColores.Amarillo));
            Listas.listaAlumnos.Add(new Alumno("Jard", "Mendes", 604764082, false, 261, 45, r1, EColores.Amarillo));
            Listas.listaAlumnos.Add(new Alumno("Elsworth", "Durn", 118965899, true, 877, 46, r1, EColores.Amarillo));
            Listas.listaAlumnos.Add(new Alumno("Catherine", "Paragreen", 099078200, true, 354, 47, r1, EColores.Amarillo));
            Listas.listaAlumnos.Add(new Alumno("Gertrud", "Lardier", 965787272, true, 900, 48, r1, EColores.Amarillo));
            Listas.listaAlumnos.Add(new Alumno("Kassi", "Kenealy", 046136466, true, 248, 49, r1, EColores.Amarillo));
            Listas.listaAlumnos.Add(new Alumno("Langston", "Skerman", 746234537, true, 300, 50, r1, EColores.Rojo));
            #endregion
            return true;
        }
        public bool CargarNoDocentes()
        {
            #region No docentes
            DateTime mañana = new DateTime(2020, 05, 09, 07, 30, 00);
            DateTime mañana1 = new DateTime(2020, 05, 09, 12, 59, 00);
            DateTime tarde = new DateTime(2020, 05, 09, 13, 00, 00);
            DateTime tarde1 = new DateTime(2020, 05, 09, 18, 30, 00);



            mañana.ToString("HH:mm");
            mañana1.ToString("HH:mm");
            tarde.ToString("HH:mm");
            tarde1.ToString("HH:mm");
            Listas.listaNoDocentes.Add(new Administrativa("isac", "herran", 68614, false, tarde, tarde1, 30000, ECargo.Direccion));
            Listas.listaNoDocentes.Add(new Administrativa("marcos", "catorce", 68614, false, tarde, tarde1, 30000, ECargo.Porteria));
            Listas.listaNoDocentes.Add(new Administrativa("Eze", "eltor", 68614, false, tarde, tarde1, 30000, ECargo.Porteria));
            Listas.listaNoDocentes.Add(new Administrativa("lucas", "Elteacher", 68614, false, tarde, tarde1, 30000, ECargo.Secretaria));
            Listas.listaNoDocentes.Add(new Administrativa("roberto", "falla", 68614, false, tarde, tarde1, 30000, ECargo.Secretaria));
            Listas.listaNoDocentes.Add(new Administrativa("puerta", "carisia", 68614, true, mañana, mañana1, 30000, ECargo.Secretaria));
            Listas.listaNoDocentes.Add(new Administrativa("mishaker", "reds", 68614, true, mañana, mañana1, 30000, ECargo.Cocina));
            Listas.listaNoDocentes.Add(new Administrativa("gabi", "luteada", 68614, true, mañana, mañana1, 30000, ECargo.Tesoreria));
            Listas.listaNoDocentes.Add(new Administrativa("liz", "henoa", 68614, true, mañana, mañana1, 30000, ECargo.Secretaria));
            Listas.listaNoDocentes.Add(new Administrativa("Martha", "rojas", 68614, true, mañana, mañana1, 30000, ECargo.Porteria));
            Listas.listaNoDocentes.Add(new Administrativa("micaela", "martinez", 9874563, true, mañana, mañana1, 30000, ECargo.Direccion));
            #endregion

            return true;
        }
    }
}
