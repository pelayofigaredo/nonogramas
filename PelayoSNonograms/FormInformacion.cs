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
    public partial class FormInformacion : Form
    {
        private FormMenu menu;

        public FormInformacion(FormMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            menu.Visible = true;
            this.Close();
        }
    }
}
