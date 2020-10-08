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
    public partial class frmAltaPariente : frmPersona
    {
        private EParentesco parentesco;
        private string telefono;
        Responsable unResponsable;
        

        public frmAltaPariente()
        {
            InitializeComponent();
            
            Bitmap img = new Bitmap(Application.StartupPath + @"\fondos\fondoPariente.JPG");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            foreach (EParentesco parentesco in EParentesco.GetValues(typeof(EParentesco)))
            {
                this.cmbParentesco.Items.Add(parentesco);
            }
        }
        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            base.btnAgregar_Click(sender, e);
            
            if (cmbParentesco.Text==null || !ValidarNumero(this.txtTelefono.Text) || string.IsNullOrEmpty(this.txtTelefono.Text))
            {
                MessageBox.Show("¡Complete los campos!");

            }
            else
            {
                this.telefono = txtTelefono.Text;
                this.parentesco = (EParentesco)cmbParentesco.SelectedItem;
                this.DialogResult = DialogResult.OK;
                
            }
            if (this.DialogResult == DialogResult.OK)
            {
                this.unResponsable = RetornaResponsable();
                rtbListaAgregados.Text = unResponsable.ToString();
                MessageBox.Show("Se agrego correctamente: "+unResponsable.ToString());
            }
            else if (this.DialogResult == DialogResult.Cancel)
            {
                MessageBox.Show("Se cancelo con exito");
            }

        }
        public Responsable RetornaResponsable()
        {

            return new Responsable(this.nombre, this.apellido, this.dni, this.esFemenino,this.parentesco,this.telefono);
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

        }

        private void rtbListaAgregados_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
