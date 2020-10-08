using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using QuinteroHernandez;
using QuinteroHernandez.Michell;

namespace Test_Unitarario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(PersonaSinDni))]
        public void PersonaSinDni()
        {
            Alumno a1 = new Alumno("Ricardo", "Herran", 20000000, false, 2500);
            a1.Dni = 0;
            ///Assert.IsNotNull(a1);//Si se crea el alumno, entonces el test es postivo

        }
        [TestMethod]
        public void PersonaDniValido()
        {
            Alumno a1 = new Alumno("Ricardo", "Herran", 2000000, false, 2500);

            Assert.IsNotNull(a1);//Si se crea el alumno, entonces el test es postivo

        }
        [TestMethod]
        public void Crear50Profesores()
        {
            QuinteroHernandez.Michell.frmMenuPrincipal f1 = new QuinteroHernandez.Michell.frmMenuPrincipal();
            f1.CargarDocentesBoton();
            f1.CargarAlumnosBoton();
            Assert.IsTrue(Listas.listaDocentes.Count == 6 && Listas.listaAlumnos.Count == 50);
        }
        #region prueba interface 
        /*
        [TestMethod]
        public void PruebaInterface()
        {
            List<IMensaje> lstMensjaes = new List<IMensaje>();

            DateTime mañana = new DateTime(2020, 05, 09, 07, 30, 00);
            DateTime mañana1 = new DateTime(2020, 05, 09, 12, 59, 00);
            DateTime tarde = new DateTime(2020, 05, 09, 13, 00, 00);
            DateTime tarde1 = new DateTime(2020, 05, 09, 18, 30, 00);


            Docente d1 = new Docente(" Love ", " ruiz ", 14722, true, mañana, mañana1, 700);
            Docente d2 = new Docente(" risoti ", " lopez ", 14718, false, mañana, mañana1, 500);
            Docente d3 = new Docente(" miriam ", " londres ", 14717, true, tarde, tarde1, 250);
            Docente d4 = new Docente(" fernando ", " masoti ", 14709, false, tarde, tarde1, 400);
            Docente d5 = new Docente(" richi ", " rey ", 14785, false, tarde, tarde1, 350);
            Docente d6 = new Docente(" Paquita ", " La del barrio ", 14785, false, tarde, tarde1, 350);

            lstMensjaes.Add(d1);
            lstMensjaes.Add(d2);
            lstMensjaes.Add(d3);
            lstMensjaes.Add(d4);
            lstMensjaes.Add(d5);
            lstMensjaes.Add(d6);

            lstMensjaes.Add(new Aula(EColores.Rojo, d1, ETurno.Mañana));
            lstMensjaes.Add(new Aula(EColores.Rojo, d2, ETurno.Mañana));
            lstMensjaes.Add(new Aula(EColores.Amarillo, d3, ETurno.Tarde));
            lstMensjaes.Add(new Aula(EColores.Amarillo, d4, ETurno.Tarde));
            lstMensjaes.Add(new Aula(EColores.Verde, d5, ETurno.Tarde));
            lstMensjaes.Add(new Aula(EColores.Verde, d6, ETurno.Mañana));

            string salida = "";

            foreach (IMensaje item in lstMensjaes)
            {
                salida += item.Mostrar();
            }

            Assert.IsTrue(salida.Length > 200);
           
        } */
        #endregion
    }
}
