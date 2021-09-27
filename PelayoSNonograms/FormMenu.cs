using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Microsoft.DirectX.AudioVideoPlayback;

namespace NonogramasDePelayo
{
    public partial class FormMenu : Form
    {
        private LibreriaNonogramas libreria;
        private int indiceSeleccionado = -1;


        //SONIDOS
        private SoundPlayer spClick;
        private List<string> cancionesDeFondo = new List<string>();
        public int indiceMusica = 0;
        private bool reproducirSiguienteCancion = false;

        public FormMenu()
        {
            InitializeComponent();
            libreria = new LibreriaNonogramas();
            cargarListaEnComboBox();
            spClick = new SoundPlayer(Application.StartupPath + "\\resources\\sound\\click.wav");
            //Musica
            cancionesDeFondo.Add("monkeyIslandPuzzler.mp3");
            cancionesDeFondo.Add("puzzleGame.mp3");
            cancionesDeFondo.Add("hypnoticJewels.mp3");
            cancionesDeFondo.Add("puzzleGame2.mp3");
            cancionesDeFondo.Add("puzzleTrance.mp3");
            cancionesDeFondo.Add("midnightPuzzles.mp3");
            cancionesDeFondo.Add("technoRandomness.mp3");
            cancionesDeFondo.Add("theSnowGlobe.mp3");
            cancionesDeFondo.Add("farAwayPuzzlePlaces.mp3");
            Random r = new Random();
            indiceMusica = r.Next(cancionesDeFondo.Count - 1);
            ReproducirMusica(indiceMusica);
        }

        public void cargarListaEnComboBox()
        {
            cbnonogramaSeleccionado.Items.Clear();
            int tamaño = libreria.lista.Count;
            for(int i = 0; i < tamaño; i++)
            {
                string texto =  libreria.ObtenerNombre(i) + " (" + libreria.ObtenerTamaño(i) + ") ";
                if (libreria.obtenerResuelto(i))
                {
                    texto += " ✅";
                }
                cbnonogramaSeleccionado.Items.Insert(i,texto);
            }
        }
        
        //Marca el nonogorama indicado por el indiceSelecionado como resuelto, guarda el estado de la libreria y recarga el texto del comboBox
        public void NonogramaResuelto()
        {
            libreria.MarcarComoResuelto(indiceSeleccionado);
            cargarListaEnComboBox();
            indiceSeleccionado++;
            cbnonogramaSeleccionado.SelectedIndex = indiceSeleccionado;
            if (libreria.estanTodosResueltos())
            {
                FormFelicitacion ff = new FormFelicitacion(this);
                ff.Visible = true;
                wmp.Ctlcontrols.pause();
                this.Visible = false;

            }
        }


        public int GetIndiceSeleccionado()
        {
            return indiceSeleccionado;
        }

        public string GetNombreSeleccionado()
        {
            return libreria.ObtenerNombre(indiceSeleccionado);
        }

        //AUDIO

        public void ReproducirMusica(int indice)
        {
            if (indice < 0 || indice >= cancionesDeFondo.Count)
            {
                return;
            }
            wmp.settings.autoStart = true;
            wmp.URL = Application.StartupPath + "\\resources\\sound\\musica\\" + cancionesDeFondo[indice];
            wmp.Ctlcontrols.next();
            wmp.Ctlcontrols.play();
        }

        public void AvanzarIndiceMusica()
        {
            indiceMusica++;
            if(indiceMusica >= cancionesDeFondo.Count)
            {
                indiceMusica = 0;
            }
        }

        //BOTONES

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if(cbnonogramaSeleccionado.SelectedIndex != -1)
            {
                spClick.Play();
                indiceSeleccionado = cbnonogramaSeleccionado.SelectedIndex;
                FormNonograma f = new FormNonograma(libreria.ObtenerDireccion(cbnonogramaSeleccionado.SelectedIndex),this);
                f.Show();
                this.Visible = false;
            }
        }

        private void btnJugarAleatorio_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int i = r.Next(libreria.lista.Count - 1);
            indiceSeleccionado = i;
            FormNonograma f = new FormNonograma(libreria.direccionAleatoria(ref indiceSeleccionado),this);
            spClick.Play();
            f.Show();
            this.Visible = false;
        }

        //Marca todos los nonogramas de la libreria como no resueltos, la guarda y recarga el combo box
        private void btnReset_Click(object sender, EventArgs e)
        {
            spClick.Play();
            libreria.ResetearProgreso();
            cargarListaEnComboBox();
        }

        private void cbnonogramaSeleccionado_SelectedIndexChanged(object sender, EventArgs e)
        {
            spClick.Play();
        }

        private void cbnonogramaSeleccionado_Click(object sender, EventArgs e)
        {
            spClick.Play();
        }


        //Sobrescribe draw de combo box para cambiar el color de la seleccion
        private void cbnonogramaSeleccionado_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            Color color = Color.FromArgb(246, 108, 32);
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected && cmb.DroppedDown)
            {
                e.Graphics.FillRectangle(new SolidBrush(color), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
            }
            if(e.Index >= 0)
            {
                e.Graphics.DrawString(cmb.Items[e.Index].ToString(),
                                         e.Font,
                                         new SolidBrush(Color.Black),
                                         new Point(e.Bounds.X, e.Bounds.Y));
            }
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btnMute_Click(object sender, EventArgs e)
        {
            if(wmp.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                wmp.Ctlcontrols.pause();
                btnMute.Image = Image.FromFile(Application.StartupPath + "\\resources\\img\\soundOn.png");
            }
            else
            {
                AvanzarIndiceMusica();
                ReproducirMusica(indiceMusica);
                btnMute.Image = Image.FromFile(Application.StartupPath + "\\resources\\img\\soundOff.png");
            }
            btnMute.Refresh();
        }

        private void wmp_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            int estado = e.newState;
            if (estado == 8) //Un estado de 8 es cancion terminada
            {
                Console.WriteLine("Cancion terminada");
                reproducirSiguienteCancion = true;
            }
        }

        private void tmrMusica_Tick(object sender, EventArgs e)
        {
            if (reproducirSiguienteCancion)
            {
                reproducirSiguienteCancion = false;
                AvanzarIndiceMusica();
                ReproducirMusica(indiceMusica);
            }
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            FormInformacion fi = new FormInformacion(this);
            fi.Visible = true;
            this.Visible = false;
        }
    }
}
