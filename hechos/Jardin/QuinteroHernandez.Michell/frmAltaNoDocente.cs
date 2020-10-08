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
    public partial class frmAltaNoDocente : frmPersona
    {
        private ECargo cargo;
        Administrativa unNoDocente;
        private double salarioBase;
        private DateTime horaSalida;
        private DateTime horaEntrada;

        public frmAltaNoDocente()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\fondos\fondoAdmin.JPG");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            foreach (ECargo cargo in ECargo.GetValues(typeof(ECargo)))
            {
                this.cmbCargo.Items.Add(cargo);
            }
            
            
        }
        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            base.btnAgregar_Click(sender, e);
            if (dtpHoraEntrada.Text.Length == 0 || dtpHoraSalida.Text.Length == 0 ||cmbCargo.SelectedItem==null  )
            {
                MessageBox.Show("¡Complete los campos!");
            }
            else
            {
                this.cargo = (ECargo)cmbCargo.SelectedItem;
                this.horaEntrada = this.dtpHoraEntrada.Value;
                this.horaSalida = this.dtpHoraSalida.Value;
                txtSalarioBase.Text = "30000";
                double.TryParse(txtSalarioBase.Text, out this.salarioBase);
                
            }
            if (this.DialogResult == DialogResult.OK)
            {
                this.unNoDocente = RetornarNoDocente();
                Listas.listaNoDocentes.Add(unNoDocente);
                rtbListaAgregados.Text = unNoDocente.ToString();
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
        public Administrativa RetornarNoDocente()
        {
    
            return new Administrativa(this.nombre, this.apellido, this.dni, this.esFemenino,this.horaEntrada,this.horaSalida, this.salarioBase,this.cargo);
        }

        private void frmAltaNoDocente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.btnModificar.Text == "Cancelar")
            {
                this.Close();
            }
            else
            {
                if (!(this.unNoDocente is null))
                {
                    frmAltaNoDocente modificacionNoDocente = new frmAltaNoDocente();
                    modificacionNoDocente.SetCamposModificar(this.unNoDocente);
                    DialogResult resultado = modificacionNoDocente.ShowDialog();
                    modificacionNoDocente.LimpiarVentana();
                    if (resultado == DialogResult.OK)
                    {
                        this.unNoDocente = modificacionNoDocente.RetornarNoDocente();
                        rtbListaAgregados.Text = unNoDocente.ToString();
                        LimpiarVentana();
                    }
                    else if (resultado == DialogResult.Cancel)
                    {
                        MessageBox.Show("se canceló con exito");
                    }
                }
                else if (this.unNoDocente is null)
                {
                    MessageBox.Show("No hay ningun docente para modificar.");
                }
            }
        }
        public void SetCamposModificar(Administrativa datos)
        {
            this.txtNombre.Text = datos.Nombre;
            this.txtApellido.Text = datos.Apellido;
            this.txtDni.Text = datos.Dni.ToString();
            if ((this.rbFemenino.Checked = true) && (this.rbMasculino.Checked = false))
            {
                datos.Femenino = true;
            }            
            this.dtpHoraEntrada.Value = datos.HoraEntrada;
            this.dtpHoraSalida.Value = datos.HoraSalida;
            this.cmbCargo.SelectedItem = datos.Cargo;
            this.BackColor = Color.Aquamarine;
            this.btnAgregar.Text = "Guardar Cambios.";
            this.btnModificar.Text = "Cancelar";
            this.rtbListaAgregados.Enabled = false;

        }
        public override void LimpiarVentana()
        {
            base.LimpiarVentana();
            this.dtpHoraEntrada.Text = "";
            this.dtpHoraSalida.Text = "";
            this.cmbCargo.SelectedItem=null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Se agrego correctamente el empleado. cant: " + Listas.listaNoDocentes.Count);
        }
    }
}
