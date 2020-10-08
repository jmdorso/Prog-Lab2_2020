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
using System.Media;

namespace QuinteroHernandez.Michell
{
    public partial class frmAltaDocente : frmPersona
    {
        private DateTime horaEntrada;
        private DateTime horaSalida;
        private double valorHora;
        Docente unDocente;
        //RECORDATORIO: SETEAR PARA AGREGAR A LISTA EXISTENTE.
        public frmAltaDocente()
        {
            InitializeComponent();

            Bitmap img = new Bitmap(Application.StartupPath + @"\fondos\fondoDocente.JPG");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        protected override void btnAgregar_Click(object sender, EventArgs e)
        {
            base.btnAgregar_Click(sender, e);
            if ( dtpHoraEntrada.Text.Length == 0 || dtpHoraSalida.Text.Length == 0 || !double.TryParse(this.txtValorHora.Text, out this.valorHora) || !ValidarNumero(this.txtValorHora.Text))
            {
                MessageBox.Show("¡Complete los campos!");

            }
            else
            {
                this.horaEntrada = this.dtpHoraEntrada.Value;
                this.horaSalida = this.dtpHoraSalida.Value;

                
            }
            if (this.DialogResult == DialogResult.OK)
            {
                this.unDocente = RetornarDocente();
                rtbListaAgregados.Text = unDocente.ToString();
                Listas.listaDocentes.Add(unDocente);
                MessageBox.Show(this.unDocente.ToString(), "cant docentes agregados: " + Listas.listaDocentes.Count);
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
        public Docente RetornarDocente()
        {
           

            return new Docente(this.nombre, this.apellido, this.dni, this.esFemenino, this.horaEntrada, this.horaSalida, this.valorHora);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.btnModificar.Text == "Cancelar")
            {
                this.Close();
            }
            else
            {
                if (!(this.unDocente is null))
                {
                    frmAltaDocente modificacionDocente = new frmAltaDocente();
                    modificacionDocente.SetCamposModificar(this.unDocente);
                    DialogResult resultado = modificacionDocente.ShowDialog();
                    modificacionDocente.LimpiarVentana();
                    if (resultado == DialogResult.OK)
                    {
                        this.unDocente = modificacionDocente.RetornarDocente();
                        rtbListaAgregados.Text = unDocente.ToString();
                        LimpiarVentana();
                    }
                    else if (resultado == DialogResult.Cancel)
                    {
                        MessageBox.Show("se canceló con exito");
                    }


                }
                else if (this.unDocente is null)
                {
                    MessageBox.Show("No hay ningun docente para modificar.");
                }
            }


        }
        public void SetCamposModificar(Docente datos)
        {
            this.txtNombre.Text = datos.Nombre;
            this.txtApellido.Text = datos.Apellido;
            this.txtDni.Text = datos.Dni.ToString();
            this.rbFemenino.Checked = false;
            this.rbMasculino.Checked = false;
            this.txtValorHora.Text = datos.ValorHora.ToString();
            this.dtpHoraEntrada.Value = datos.HoraEntrada;
            this.dtpHoraSalida.Value = datos.HoraSalida;
            this.BackColor = Color.Pink;
            this.btnAgregar.Text = "Guardar Cambios.";
            this.btnModificar.Text = "Cancelar";
            this.rtbListaAgregados.Enabled = false;

        }
        public override void LimpiarVentana()
        {
            base.LimpiarVentana();
            this.txtValorHora.Clear();
            this.dtpHoraEntrada.Text = "";
            this.dtpHoraSalida.Text = "";
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            SoundPlayer guardar = new SoundPlayer(@"sonido\thanku.wav");
            guardar.Play();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se cancelo con exito");
            this.Close();
        }
    }
}
