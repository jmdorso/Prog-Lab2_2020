using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_RodrigoNovas;
namespace frmPrincipal
{
    public partial class Campo : Form
    {
        public Campo()
        {
            
            InitializeComponent();
        }

        private void Campo_Load(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;

            this.campo = new Campo(1500);
            Campo.TipoServicio = Campo.Tipo.Pastoreo;
            bool pudo = this.campo + new Cerdo("Pegy", 300);
            pudo = this.campo + new Cerdo("Babe", 250);
            pudo = this.campo + new Vaca("Rosalinda", 450, Vaca.Clasificacion.Lechera);
            pudo = this.campo + new Vaca("Lola", 325);
            pudo = this.campo + new Caballo("Secretariat", 175, true);
            if (!(this.campo + new Caballo("BoJack", 1, false)))
            {
                MessageBox.Show("Error", "!",  buttons);
            }


        }
    }
}
