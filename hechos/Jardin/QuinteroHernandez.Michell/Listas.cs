using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuinteroHernandez.Michell
{
    public static class Listas
    {
        public static List<Alumno> listaAlumnos { get; set; } = new List<Alumno>();
        public static List<Alumno> AlumnosAsignados { get; set; } = new List<Alumno>();
        public static List<Docente> listaDocentes { get; set; } = new List<Docente>();
        public static List<Aula> listaAulas { get; set; } = new List<Aula>();
        public static List<Administrativa> listaNoDocentes { get; set; }  = new List<Administrativa>();
        public static List<Responsable> listaResponsables { get; set; } = new List<Responsable>();





    }
}
