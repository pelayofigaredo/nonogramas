using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonogramasDePelayo
{
    public partial class FormNonograma : Form
    {
        Director director;

        private int Alto, Ancho;

        private int tamañoCasillas = 50;
        public float tamañoFuenteBloques = 16;

        public Color ColorFondoInformacionBloques = Color.SlateGray;
        


        public FormNonograma(string direccion,FormMenu menu)
        {
            Nonograma n = Nonograma.LeerDeArchivo(direccion);
            Alto = n.Alto();
            Ancho = n.Ancho();
            InitializeComponent();
            InicializarElementosDinamicos(n);
            InicializarNonograma(n,menu);
            this.Text = "Nonograma de Pelayo: " + menu.GetNombreSeleccionado();
        }

        private void btn_BotonPulsado(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            Console.WriteLine(boton.Tag);
            string tag = boton.Tag.ToString();
            string[] coordenadas = tag.Split('-');
            director.ElegirCasilla(Convert.ToInt32(coordenadas[0]), Convert.ToInt32(coordenadas[1]), 1);
            ActualizarLabelVida();
        }

        private void InicializarNonograma(Nonograma n, FormMenu menu)
        {
            director = new Director(n, botones, btnBloquesFilas, btnBloquesColumnas, menu, this);
            ActualizarLabelVida();
            ActualizarBotonesBloquesFilas();
            ActualizarBotonesBloquesColumnas();
        }

        private void ActualizarBotonesBloquesFilas()
        {
            for (int y = 0; y < director.Objetivo.Alto(); y++)
            {
                List<Bloque> bloquesFila = director.Objetivo.Filas[y].ObtenerInformacionBloques();
                for (int x = 0; x < bloquesFila.Count; x++)
                {
                    btnBloquesFilas[y, x].Text = bloquesFila[x].tamaño.ToString();
                    btnBloquesFilas[y, x].ForeColor = director.colores[bloquesFila[x].estado]; 
                }
            }
        }

        private void ActualizarBotonesBloquesColumnas()
        {
            for (int x = 0; x < director.Objetivo.Ancho(); x++)
            {
                List<Bloque> bloquesColumna = director.Objetivo.Columnas[x].ObtenerInformacionBloques();
                for (int y = 0; y < bloquesColumna.Count; y++)
                {
                    btnBloquesColumnas[x,y].Text = bloquesColumna[y].tamaño.ToString();
                    btnBloquesColumnas[x,y].ForeColor = director.colores[bloquesColumna[y].estado];
                }
            }
        }

        private void ActualizarLabelVida()
        {
            lblVida.Text = director.Salud.ToString();
            this.Refresh();
        }

        private void InicializarElementosDinamicos(Nonograma n)
        {
            InicializarPaneles(n);
            InicializarBotonesNonograma();
            InicializarBotonesColumnas();
            InicializarBotonesFilas();
            this.Refresh();
        }

        private void InicializarBotonesNonograma()
        {
            botones = new Button[Ancho, Alto];
            for (int x = 0; x < Ancho; x++)
            {
                for (int y = 0; y < Alto; y++)
                {
                    Button b = new Button();
                    b.BackColor = System.Drawing.Color.White;
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    b.Location = new System.Drawing.Point(y * tamañoCasillas, x * tamañoCasillas);
                    Console.WriteLine("Posicion X" + x * tamañoCasillas + "- Y" + y * tamañoCasillas);
                    b.Margin = new System.Windows.Forms.Padding(0);
                    b.Name = "btn" + x + y;
                    b.Size = new System.Drawing.Size(tamañoCasillas, tamañoCasillas);
                    b.TabIndex = 1 + y * Ancho + x;
                    b.Tag = x + "-" + y;
                    b.UseVisualStyleBackColor = false;
                    b.Click += new System.EventHandler(this.btn_BotonPulsado);
                    botones[x, y] = b;
                    pnlNonograma.Controls.Add(botones[x, y]);
                }
            }
        }

        private void InicializarBotonesFilas()
        {
            btnBloquesFilas = new Button[Ancho, Alto];
            for (int x = 0; x < Ancho; x++)
            {
                for (int y = 0; y < Alto; y++)
                {
                    Button b = new Button();
                    b.BackColor = ColorFondoInformacionBloques;
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    b.Location = new System.Drawing.Point(y * tamañoCasillas, x * tamañoCasillas);
                    b.Margin = new System.Windows.Forms.Padding(0);
                    b.Name = "btnFilas" + x + y;
                    b.Size = new System.Drawing.Size(tamañoCasillas, tamañoCasillas);
                    b.Font = new System.Drawing.Font("Microsoft Sans Serif", tamañoFuenteBloques, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))); 
                    b.UseVisualStyleBackColor = false;
                    b.Enabled = false;
                    btnBloquesFilas[x, y] = b;
                    pnlBloquesFilas.Controls.Add(btnBloquesFilas[x, y]);
                }
            }
        }

        private void InicializarBotonesColumnas()
        {
            btnBloquesColumnas = new Button[Ancho, Alto];
            for (int x = 0; x < Ancho; x++)
            {
                for (int y = 0; y < Alto; y++)
                {
                    Button b = new Button();
                    b.BackColor = ColorFondoInformacionBloques;
                    b.FlatAppearance.BorderSize = 0;
                    b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
                    b.Location = new System.Drawing.Point(x * tamañoCasillas, y * tamañoCasillas);
                    b.Margin = new System.Windows.Forms.Padding(0);
                    b.Name = "btnColumna" + x + y;
                    b.Size = new System.Drawing.Size(tamañoCasillas, tamañoCasillas);
                    b.Font = new System.Drawing.Font("Microsoft Sans Serif", tamañoFuenteBloques, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    b.UseVisualStyleBackColor = false;
                    b.Enabled = false;
                    btnBloquesColumnas[x, y] = b;
                    pnlBloquesColumnas.Controls.Add(btnBloquesColumnas[x, y]);
                }
            }
        }

        private void InicializarPaneles(Nonograma n)
        {
            int maxBloquesFilas = n.ObtenerNumeroMaxmioBloquesFilas();
            int maxBloquesColumnas = n.ObtenerNumeroMaxmioBloquesColumnas();
            int posX = maxBloquesFilas * tamañoCasillas;
            int posY = maxBloquesColumnas * tamañoCasillas;
            if(posX < 200)
            {
                posX = 200;
            }
            if(posY < 200)
            {
                posY = 200;
            }
            //Panel bloques filas
            pnlBloquesFilas.Location = new System.Drawing.Point(0, posY);
            pnlBloquesFilas.Size = new System.Drawing.Size(posX, Alto * tamañoCasillas);
            //PANEL BLOQUES COLUMAS
            pnlBloquesColumnas.Location = new System.Drawing.Point(posX, 0);
            pnlBloquesColumnas.Size = new System.Drawing.Size(Ancho* tamañoCasillas, posY);
            //Panel Nonograma
            pnlNonograma.Location = new System.Drawing.Point(posX, posY);
            pnlNonograma.Size = new System.Drawing.Size(Ancho * tamañoCasillas, Alto * tamañoCasillas);
            //Formulario
            this.Width = posX+(Ancho* tamañoCasillas) + tamañoCasillas;
            this.Height = posY+(Alto * tamañoCasillas) + 75;

        }

        //ZOOM

        private void ZoomIn()
        {
            btnZoomOut.Enabled = true;
            tamañoCasillas += 10;
            tamañoFuenteBloques += 4;
            tamañoFuenteBloques += 4;
            InicializarPaneles(director.Objetivo);
            CambiarTamañoBotonesColumnas();
            CambiarTamañoBotonesFilas();
            CambiarTamañoBotonesNonograma();
            this.Refresh();
        }

        private void ZoomOut()
        {
            tamañoCasillas -= 10;
            if(tamañoCasillas == 30)
            {
                tamañoCasillas = 30;
                btnZoomOut.Enabled = false;
            }
            tamañoFuenteBloques -= 4;
            if(tamañoFuenteBloques < 6)
            {
                tamañoFuenteBloques = 6;
            }
            InicializarPaneles(director.Objetivo);
            CambiarTamañoBotonesColumnas();
            CambiarTamañoBotonesFilas();
            CambiarTamañoBotonesNonograma();
            this.Refresh();
        }

        private void CambiarTamañoBotonesNonograma()
        {
            for (int x = 0; x < Ancho; x++)
            {
                for (int y = 0; y < Alto; y++)
                {
                    Button b = botones[x, y];
                    b.Location = new System.Drawing.Point(y * tamañoCasillas, x * tamañoCasillas); ;
                    b.Size = new System.Drawing.Size(tamañoCasillas, tamañoCasillas);
                    b.Font = new System.Drawing.Font("Microsoft Sans Serif", tamañoFuenteBloques, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    b.Refresh();
                }
            }
        }

        private void CambiarTamañoBotonesFilas()
        {
            for (int x = 0; x < Ancho; x++)
            {
                for (int y = 0; y < Alto; y++)
                {
                    Button b = btnBloquesFilas[x, y];
                    b.Location = new System.Drawing.Point(y * tamañoCasillas, x * tamañoCasillas);
                    b.Size = new System.Drawing.Size(tamañoCasillas, tamañoCasillas);
                    b.Font = new System.Drawing.Font("Microsoft Sans Serif", tamañoFuenteBloques, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    b.Refresh();
                }
            }
        }

        private void CambiarTamañoBotonesColumnas()
        {
            for (int x = 0; x < Ancho; x++)
            {
                for (int y = 0; y < Alto; y++)
                {
                    Button b = btnBloquesColumnas[x, y];
                    b.Location = new System.Drawing.Point(x * tamañoCasillas, y * tamañoCasillas);
                    b.Size = new System.Drawing.Size(tamañoCasillas, tamañoCasillas);
                    b.Font = new System.Drawing.Font("Microsoft Sans Serif", tamañoFuenteBloques, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    b.Refresh();
                }
            }
        }


        //Eventos

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if (director.menu.wmp.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                director.menu.wmp.Ctlcontrols.pause();
                btnMute.Image = Image.FromFile(Application.StartupPath + "\\resources\\img\\soundOn.png");
            }
            else
            {
                director.menu.AvanzarIndiceMusica();
                director.menu.ReproducirMusica(director.menu.indiceMusica);
                btnMute.Image = Image.FromFile(Application.StartupPath + "\\resources\\img\\soundOff.png");
            }
            btnMute.Refresh();
        }

        private void FormNonograma_FormClosing(object sender, FormClosingEventArgs e)
        {
            director.menu.Visible = true;
        }


    }
}
