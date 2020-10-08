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
    public partial class frmReportes : Form
    {
        private List<Aula> listaAulas;
        string aux;
        private string auxiliar;
        private object aulasLista;

        public frmReportes()
        {
            Bitmap img = new Bitmap(Application.StartupPath + @"\fondos\fondoAula.JPG");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
            InitializeComponent();
        }

        public frmReportes(List<Aula> listaAulas, string auxiliar) : this()
        {
            this.listaAulas = listaAulas;
            this.aux = auxiliar;
           
            cmbAulas.Visible = true;
            for (int i = 0; i < listaAulas.Count; i++)
            {
                cmbAulas.Items.Add(listaAulas[i].ToString());
            }
        }

        public void InformacionDePadres()//todas las aulas
        {
            lblResult.Text = "informacion de los familiares";
            lsbReporte.Items.Clear();
            foreach (var item in Listas.listaResponsables)
            {
                lsbReporte.Items.Add(item.ToString());
            }

        }
        public void SueldoDocente()
        {
            cmbAulas.Visible = false;
            btnMostrar.Visible = false;
            lblResult.Text = "Sueldo de las docentes";
            foreach (var item in Listas.listaDocentes)
            {
                lsbReporte.Items.Add(item.Nombre + " " + item.Apellido + " Horas laboradas en el mes: " + item.HorasMensuales + ". Sueldo: " + item.Salario.ToString());
            }

        }
        public void SueldoNoDocentes()
        {
            cmbAulas.Visible = false;
            btnMostrar.Visible = false;
            lblResult.Text = "Sueldo de las administrativas";
            foreach (var item in Listas.listaNoDocentes)
            {
                lsbReporte.Items.Add(item.Nombre + " " + item.Apellido + " Cargo: " + item.Cargo + ". Sueldo: " + item.Salario.ToString());
            }

        }

        private void cmbAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (aux)
            {
                case "reportePadres":
                    this.lblAviso2.Text = "Mostrar por aula";
                    this.lblAviso.Text = "Mostrar todos los responsables";
                    lsbReporte.Items.Clear();
                    for (int i = 0; i < listaAulas[cmbAulas.SelectedIndex].Alumnos.Count; i++)
                    {
                        lsbReporte.Items.Add("Alumno Legajo:" + listaAulas[cmbAulas.SelectedIndex].Alumnos[i].Legajo + " - " + listaAulas[cmbAulas.SelectedIndex].Alumnos[i].Responsable.ToString());
                    }
                    break;

                case "recaudacionAula":

                    this.lblAviso2.Text = "Mostrar recaudacion por aula";
                    this.lblAviso.Text = "Mostrar recaudacion total del jardin: ";
                    int acumulador = 0;
                    int cuota;
                    lsbReporte.Items.Clear();
                    for (int i = 0; i < listaAulas[cmbAulas.SelectedIndex].Alumnos.Count; i++)
                    {
                        lsbReporte.Items.Add("Alumno Legajo:" + listaAulas[cmbAulas.SelectedIndex].Alumnos[i].Legajo.ToString() + " Valor de cuota $" + listaAulas[cmbAulas.SelectedIndex].Alumnos[i].PrecioCuota.ToString());
                        cuota = (int)listaAulas[cmbAulas.SelectedIndex].Alumnos[i].PrecioCuota;
                        acumulador = cuota + acumulador;
                    }
                    lblResult.Text= "La recaudacion de esta sala es de $" + acumulador.ToString();
                    
                    break;
                default:
                    break;
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            switch (aux)
            {
                case "reportePadres":
                    InformacionDePadres();
                    break;
                case "recaudacionAula":
                    int acumulador = 0;
                    int cuota;

                    for (int i = 0; i < listaAulas.Count; i++)
                    {
                        for (int j = 0; j < listaAulas[i].Alumnos.Count; j++)
                        {
                            cuota = (int)listaAulas[i].Alumnos[j].PrecioCuota;
                            acumulador = cuota + acumulador;
                        }
                    }
                    lblResult.Text=("La recaudacion total fue de $" + acumulador.ToString());            
                    break;
                default:
                    break;
            }
           
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }
    }
}
