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
    public partial class PerfilAssinante : Form
    {
        public PerfilAssinante()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.CarregaEntreTELAS(new Templates());
        }

        private void PerfilAssinante_Load(object sender, EventArgs e)
        {
            //label
            lblComprados.Location = new Point(ClientSize.Width - 480, ClientSize.Height - 320);
            lblNome.Location = new Point(ClientSize.Width - 610, ClientSize.Height - 478);
            lblProfissao.Location = new Point(ClientSize.Width - 650, ClientSize.Height - 460);

            //botao
            btnFechar.Location = new Point(ClientSize.Width - 80, ClientSize.Height - 570);
            btnCurriculo.Location = new Point(ClientSize.Width - 130, ClientSize.Height - 520);
            btnADD.Location = new Point(ClientSize.Width - 1080, ClientSize.Height - 350);


            //panel/perfil
            panelCompradosASS.Location = new Point(ClientSize.Width - 480, ClientSize.Height - 280);
            panelASS.Location = new Point(ClientSize.Width - 1080, ClientSize.Height - 280);
            picturePerfil.Location = new Point(ClientSize.Width - 650, ClientSize.Height - 580);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panelEditar.Visible = true;
            panelCompradosASS.Visible = false;
            panelASS.Visible = false;
            lblComprados.Visible = false;
            btnADD.Visible = false;
        }

        private void btnEditar2_Click(object sender, EventArgs e)
        {
            lblNome.Text = txtEditNome.Texts.ToString();
            descricao.Text = txtEditDescricao.Texts.ToString();
            lblProfissao.Text=txtEditDescricao.Texts.ToString() ;
            panelEditar.Visible = false;
            panelCompradosASS.Visible = true;
            panelASS.Visible = true;
            lblComprados.Visible = true;
            btnADD.Visible = true;
        }
    }
}
