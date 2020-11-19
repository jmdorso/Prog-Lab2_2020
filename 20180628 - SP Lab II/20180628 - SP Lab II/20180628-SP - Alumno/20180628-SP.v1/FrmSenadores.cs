using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Entidades;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace _20180628_SP.v1
{
    [Serializable]
    public partial class FrmSenadores : Form
    {
        Votacion votacion;
        Dictionary<string, Votacion.EVoto> participantes;
        List<PictureBox> graficos;
        private Thread hilo;
        public FrmSenadores()
        {
            InitializeComponent();
            // Instancio el Diccionario de Senadores y sus votos
            this.participantes = new Dictionary<string, Votacion.EVoto>();
            this.votacion = new Votacion();
            

            // Creo las Bancas y sus Senadores
            this.graficos = new List<PictureBox>();
            int x = 20;
            int y = 20;
            for (int i = 1; i <= 72; i++)
            {
                this.participantes.Add(i.ToString(), Votacion.EVoto.Esperando);
                PictureBox p = new PictureBox();
                p.BackColor = Color.White;
                p.Size = new Size(20, 20);
                p.Location = new Point(x, y);
                x += 25;
                if (x > 595)
                {
                    x = 20;
                    y += 25;
                }

                this.gpbSenado.Controls.Add(p);
                this.graficos.Add(p);
            }
            //this.votacion.EventoVotoEfectuado += ManejadorVoto;
        }

        public void ManejadorVoto(string senador, Votacion.EVoto voto)
        {
            if (this.groupBox2.InvokeRequired)
            {
                Voto recall = new Voto(ManejadorVoto);
               
                //Voto arecall = new Votacion.(this.ManejadorVoto);
                object[] obj = new object[] { senador, voto };
                //this.Invoke(recall, new object[] { senador, voto });
                this.Invoke(recall, obj);
            }
            else
            {
                // Leo la banca del Senador actual
                PictureBox p = this.graficos.ElementAt(int.Parse(senador)-1);
                switch (voto)
                {
                    case Votacion.EVoto.Afirmativo:
                        // Sumo votantes al Label correspondiente
                        lblAfirmativo.Text = (int.Parse(lblAfirmativo.Text) + 1).ToString();
                        // Marco la banca con color Verde
                        p.BackColor = Color.Green;
                        break;
                    case Votacion.EVoto.Negativo:
                        // Sumo votantes al Label correspondiente
                        lblNegativo.Text = (int.Parse(lblNegativo.Text) + 1).ToString();
                        // Marco la banca con color Rojo
                        p.BackColor = Color.Red;
                        break;
                    case Votacion.EVoto.Abstencion:
                        // Sumo votantes al Label correspondiente
                        lblAbstenciones.Text = (int.Parse(lblAbstenciones.Text) + 1).ToString();
                        // Marco la banca con color Amarillo
                        p.BackColor = Color.Yellow;
                        break;
                }
                // Quito un Senador de los que un no votaron, para marcar cuando termina la votación
                int aux = int.Parse(lblEsperando.Text) - 1;
                lblEsperando.Text = aux.ToString();
                // Si finaliza la votación, muestro si Es Ley o No Es Ley
                if (aux == 0)
                {
                    
                    MessageBox.Show((int.Parse(lblAfirmativo.Text) - int.Parse(lblNegativo.Text)) > 0 ? "Es Ley" : "No es Ley", txtLeyNombre.Text);
                    // Guardar resultados
                    Binario<Votacion> binario = new Binario<Votacion>();
                    Votacion ej = this.votacion;
                    SerializarXML<Votacion> serializarXML = new SerializarXML<Votacion>();
                    try
                    {
                        //binario.Guardar("archivoBin.bin", ej);
                        serializarXML.Guardar("senadores.xml", ej);
                        MessageBox.Show("Se guardaron los resultados");

                    }
                    catch (ErrorArchivoExcepcion ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    DAO < Votacion > dao = new DAO<Votacion>();
                    dao.Guardar("Server=.;Database=votacion-sp-2018;Trusted_Connection=True;", this.votacion);
                }
            }
        }

        private void btnSimular_Click(object sender, EventArgs e)//MANEJADOR??
        {
            // Creo una nueva votación
            votacion = new Votacion(txtLeyNombre.Text, this.participantes);
            // Mostrar Quorum
            lblEsperando.Text = this.participantes.Count.ToString();

            // Reseteo de la votación
            foreach (PictureBox p in this.graficos)
                p.BackColor = Color.White;
            lblAfirmativo.Text = "0";
            lblNegativo.Text = "0";
            lblAbstenciones.Text = "0";

            // EVENTO
            votacion.EventoVotoEfectuado += ManejadorVoto;
            // THREAD
            this.hilo = new Thread(votacion.Simular);
            this.hilo.Start();

        }

        private void FrmSenadores_Load(object sender, EventArgs e)
        {

        }

        private void FrmSenadores_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (this.hilo != null && this.hilo.IsAlive)
            {
                this.hilo.Abort();
            }
            

        }
    }
}
