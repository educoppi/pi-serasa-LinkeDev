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
    public partial class trocaBotoes : Form
    {
        public trocaBotoes()
        {
            InitializeComponent();
        }

        private void trocaBotoes_Load(object sender, EventArgs e)
        {
            if (Program.usuario.isAssinante)
            {
                btnAssine.Enabled = false;
                btnAssine.Visible = false;
                picturePerfil.LoadAsync(Program.assinante.imagem_icon);
                picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
            else
            {
                btnAssine.Enabled = true;
                btnAssine.Visible = true;
                picturePerfil.LoadAsync(Program.cliente.imagem_icon);
                picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
        }

        public void picturePerfil_Click(object sender, EventArgs e)
        {
            if (Program.usuario.isAssinante)
            {
                Form1.CarregaEntreTELAS(new PerfilAssinante());
            }
            else
            {
                Form1.CarregaEntreTELAS(new PerfilCliente());
            }

        }

        private void btnAssine_Click(object sender, EventArgs e)
        {
            Form1.CarregaEntreTELAS(new Assinar());
        }
    }
}
