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
    public partial class PerfilCliente : Form
    {
        public PerfilCliente()
        {
            InitializeComponent();
        }

        private void PerfilCliente_Load(object sender, EventArgs e)
        {
            //botao
            btnFechar.Location = new Point(ClientSize.Width - 80, ClientSize.Height - 570);

            //label
            lblComprados.Location = new Point(ClientSize.Width - 520, ClientSize.Height - 430);
            lblFavoritos.Location = new Point(ClientSize.Width - 1080, ClientSize.Height - 430);
            labelNome.Location = new Point(ClientSize.Width - 610, ClientSize.Height - 478);
            //panels/perfil
            panelComprados.Location = new Point(ClientSize.Width - 520, ClientSize.Height - 400);
            panelFavoritos.Location = new Point(ClientSize.Width - 1080, ClientSize.Height - 400);
            picturePerfil.Location = new Point(ClientSize.Width - 650, ClientSize.Height - 580);

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            //   panelFavoritos.Visible = true;
            lblComprados.Visible = false;
            lblFavoritos.Visible = false;
        }

        private void wilBitButton1_Click(object sender, EventArgs e)
        {
            //  panelFavoritos.Visible = false;
            lblComprados.Visible = true;
            lblFavoritos.Visible = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)//perfil favorito
        {
            Form1.CarregaEntreTELAS(new PerfilCliente());
        }




        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1.CarregaEntreTELAS(new Templates());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panelEditar.Visible = true;
            panelComprados.Visible = false;
            panelFavoritos.Visible = false;
            lblComprados.Visible = false;
            lblFavoritos.Visible = false;
        }

        private void btnEditar2_Click(object sender, EventArgs e)
        {
            labelNome.Text = txtEditNome.Texts.ToString();
            descricao.Text = txtEditDescricao.Texts.ToString();
            panelEditar.Visible = false;
            panelComprados.Visible = true;
            panelFavoritos.Visible = true;
            lblComprados.Visible = true;
            lblFavoritos.Visible = true;


        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }
    }
}
