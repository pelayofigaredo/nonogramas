using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NonogramasDePelayo
{
    public partial class FormFelicitacion : Form
    {
        private FormMenu menu;
        private Random r;
        private SoundPlayer sp;

        public FormFelicitacion(FormMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            r = new Random();
            sp = new SoundPlayer(Application.StartupPath + "\\resources\\sound\\victoriaAbsoluta.wav");
            sp.PlayLooping();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            menu.Visible = true;
            sp.Stop();
            this.Close();
            menu.AvanzarIndiceMusica();
            menu.ReproducirMusica(menu.indiceMusica);
        }

        private void timCambiColor_Tick(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(r.Next(250), r.Next(250), r.Next(250));
            this.BackColor = color;
            this.Refresh();
        }

        private void FormFelicitacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            menu.Visible = true;
            sp.Stop();
        }
    }
}
