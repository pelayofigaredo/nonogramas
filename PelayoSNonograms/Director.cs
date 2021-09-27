using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonogramasDePelayo
{
    class Director
    {
        public Nonograma Objetivo;
        public Nonograma Usuario;
        public Button[,] Botones;
        public Button[,] BotonesBloquesFilas;
        public Button[,] BotonesBloquesColumnas;
        public Color[] colores = {Color.Gray, Color.White, Color.Black};
        public int Salud;
        public FormMenu menu;
        public FormNonograma form;
       

        //Sonido
        private SoundPlayer spClick;
        private SoundPlayer spError;
        private SoundPlayer spVictoria;
        private SoundPlayer spDerrota;

        public Director(Nonograma nonograma, Button[,] botones, Button[,] botonesFilas, Button[,] botonesColumnas, FormMenu menu, FormNonograma form)
        {
            this.Objetivo = nonograma;
            this.Usuario = new Nonograma(this.Objetivo.Alto());
            this.Botones = botones;
            this.BotonesBloquesColumnas = botonesColumnas;
            this.BotonesBloquesFilas = botonesFilas;
            this.menu = menu;
            this.form = form;
            RestaurarBotones();
            for (int i = 0; i < Objetivo.Alto(); i++)
            {
                ComprobarHaCompletado(i, i);
            }
            //Salud
            if(nonograma.Alto() <= 10)
            {
                Salud = 7;
            }
            else if(nonograma.Alto() <= 15 && nonograma.Alto() > 10)
            {
                Salud = 12;
            }
            else if ( nonograma.Alto() >= 15)
            {
                Salud = 18;
            }
            //Audio
            spClick = new SoundPlayer(Application.StartupPath + "\\resources\\sound\\click.wav");
            spError = new SoundPlayer(Application.StartupPath + "\\resources\\sound\\error.wav");
            spVictoria = new SoundPlayer(Application.StartupPath + "\\resources\\sound\\victoria.wav");
            spDerrota = new SoundPlayer(Application.StartupPath + "\\resources\\sound\\derrota.wav");
        }

        public void ActualizarBotonesFilas()
        {
            for(int y = 0; y < Objetivo.Alto(); y++)
            {
                List<Bloque> bloquesFila = Objetivo.Filas[y].ObtenerInformacionBloques();
                for(int x = 0; x < bloquesFila.Count; x++)
                {
                    BotonesBloquesFilas[y, x].Text = bloquesFila[x].tamaño.ToString();
                    BotonesBloquesFilas[y, x].ForeColor = colores[bloquesFila[x].estado];
                }
            }
        }

        //Elige una casilla y si se corresponde con el estado dado la colorea ,la añade al nonogrma de usuario y comprueba que se haya
        //finalizado el puzle, si no, resta vida y comprueba la derrota
        public void ElegirCasilla(int intX, int intY, int intEstado)
        {
            if (Objetivo.ElegirCasilla(intX, intY, intEstado))
            {
                Usuario.ModificarCasilla(intX, intY, intEstado);
                PintarImagen(intX, intY, intEstado);
                spClick.Play();
            }
            else
            {
                spError.Play();
                PintarImagen(intX, intY, -1);
                Salud--;
                if (Salud <= 0)
                {
                    Perder();
                }
            }
            ComprobarHaCompletado(intX, intY);
            if (ComprobarVictoria())
            {
                Ganar();
            }
        }

        private bool ComprobarVictoria()
        {
            return Objetivo.Equals(Usuario);
        }

        private void Perder()
        {
            spDerrota.Play();
            DialogResult result1 = MessageBox.Show("Has fallado, más suerte la proxima vez", "¡Oh no!", MessageBoxButtons.OK);
            menu.Visible = true;
            if (result1 == DialogResult.OK || result1 == DialogResult.Abort || result1 == DialogResult.Cancel)
            {
                form.Close();
            }
        }

        private void Ganar()
        {
            spVictoria.Play();
            
            DialogResult result1 = MessageBox.Show("Puzle resuelto", "Felicidades", MessageBoxButtons.OK);
            if (result1 == DialogResult.OK || result1 == DialogResult.Abort || result1 == DialogResult.Cancel)
            {
                form.Close();
                menu.Visible = true;
                menu.NonogramaResuelto();
            }
            
        }




        //Comprueba que tras elegir una casilla su fila y su columna hayan sido completadas
        private void ComprobarHaCompletado(int intX, int intY)
        {
            if (Objetivo.Filas[intX].ObtenerCoincidenciaLinea(Usuario.Filas[intX]))
            {
                Console.WriteLine("Fila " + intX + " resuelta!!!");
                CompletarFila(intX);
            }
            if (Objetivo.Columnas[intY].ObtenerCoincidenciaLinea(Usuario.Columnas[intY]))
            {
                Console.WriteLine("Fila " + intY + " resuelta!!!");
                CompletarColumna(intY);
            }
        }
        //Comprueba si una fila ha sido completada y la bloquea
        private void CompletarFila(int intFila)
        {
            for(int i = 0;  i < Objetivo.Filas[intFila].Longitud(); i++)
            {
                PintarImagen(intFila, i, Objetivo.Filas[intFila].Casillas[i]);
            }
        }
        //Comprueba si una columna ha sido completada y la bloquea
        private void CompletarColumna(int intColumna)
        {
            for (int i = 0; i < Objetivo.Columnas[intColumna].Longitud(); i++)
            {
                PintarImagen(i, intColumna, Objetivo.Columnas[intColumna].Casillas[i]);
            }
        }
        //Devuelve los botones a su estado inicial
        private void RestaurarBotones()
        {
            foreach (Button b in Botones)
            {
                b.Enabled = true;
                b.BackColor = Color.White;
            }
        }
 
        public void PintarImagen(int intX, int intY, int intEstado)
        {
            Botones[intX, intY].Enabled = false;
            switch (intEstado)
            {
                case 1:
                    Botones[intX, intY].BackColor = Color.FromArgb(246, 108, 32);
                    break;
                case 0:
                    Botones[intX, intY].BackColor = Color.Gray;
                    break;
                case -1:
                    Botones[intX, intY].BackColor = Color.Red;
                    break;
            }
            
        }
    }
}
