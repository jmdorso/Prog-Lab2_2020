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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\fondos\fondoLoguin.JPG");
            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        

        private void btnLogear_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != ""&&txtContraseña.Text != "")
            {
                frmMenuPrincipal menu = new frmMenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error, Los campos contraseña y usario no pueden estar vacios.");
            }

        }
    }
}
