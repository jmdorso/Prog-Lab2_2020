using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuinteroHernandez.Michell
{
    public partial class frmPersona : Form
    {
        public string nombre;
        public string apellido;
        public int dni;
        public bool esFemenino;
        private List<Alumno> listaAlumnos;
        
        public frmPersona()
        {
            InitializeComponent();
            
        }
        protected virtual void btnAgregar_Click(object sender, EventArgs e)
        {

            if ((string.IsNullOrEmpty(this.txtNombre.Text) || string.IsNullOrEmpty(this.txtApellido.Text) || !int.TryParse(this.txtDni.Text, out this.dni) || (this.rbFemenino.Checked == false && this.rbMasculino.Checked == false) || !ValidarNumero(this.txtDni.Text)))
            {
               
            }
            else
            {
                this.nombre = this.txtNombre.Text;
                this.apellido = this.txtApellido.Text;
                this.esFemenino = this.rbFemenino.Checked;
                this.DialogResult = DialogResult.OK;
            }
        }
        public bool ValidarNumero(string numero)
        {
            bool retorno = false;
            for (int i = 0; i < numero.Length; i++)
            {
                if (numero[i]>='0' && numero[i]<='9')
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public virtual void LimpiarVentana()
        {
            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtDni.Clear();
            this.rbFemenino.Checked = false;
            this.rbMasculino.Checked = false;
        }
        

    }
}
