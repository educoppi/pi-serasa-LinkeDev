using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi_serasa_LinkeDev
{
    public partial class TrocaPerfil : Form
    {
        public TrocaPerfil()
        {
            InitializeComponent();
        }

        private void btnAssine_Click(object sender, EventArgs e)
        {
            Form1.CarregaEntreTELAS(new Assinar());

        }

        private void picturePerfilAssinante_Click(object sender, EventArgs e)
        {
            Form1.CarregaEntreTELAS(new PerfilAssinante());

        }
    }
}
