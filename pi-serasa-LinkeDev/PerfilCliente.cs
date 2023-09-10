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

        void carregaPerfil()
        {
            picturePerfil.LoadAsync(Program.cliente.imagem_icon);
            picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            descricao.Text = Program.cliente.descricao;
            labelNome.Text = Program.cliente.nome;
        }

        private void PerfilCliente_Load(object sender, EventArgs e)
        {

            ///LOCATION
            //botao
            btnFechar.Location = new Point(ClientSize.Width - 80, ClientSize.Height - 570);

            //label
            lblComprados.Location = new Point(ClientSize.Width - 520, ClientSize.Height - 430);
            lblFavoritos.Location = new Point(ClientSize.Width - 1080, ClientSize.Height - 430);
            labelNome.Location = new Point(ClientSize.Width - 620, ClientSize.Height - 470);
            //panels/perfil
            panelComprados.Location = new Point(ClientSize.Width - 520, ClientSize.Height - 400);
            panelFavoritos.Location = new Point(ClientSize.Width - 1080, ClientSize.Height - 400);
            picturePerfil.Location = new Point(ClientSize.Width - 650, ClientSize.Height - 580);

            ///CONTEUDO
            carregaPerfil();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            carregaTemplates();
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
        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //EDITA INFORMAÇÕES DE CLIENTE
        private void btnEditar2_Click_1(object sender, EventArgs e)
        {
            string editNome = txtEditNome.Text;
            string editDescricao = txtEditDescricao.Text;
            string editImagemicon = txtImagemIcone.Text;

            if (editNome == "")
            {
                editNome = Program.cliente.nome;
            }

            if (editDescricao == "")
            {
                editDescricao = Program.cliente.descricao;
            }

            if (editImagemicon == "")
            {
                editImagemicon = Program.cliente.imagem_icon;
            }


            Cliente cliente = new Cliente();
            Program.cliente = cliente.editaCliente(editNome, editDescricao, editImagemicon, Program.cliente.id);

            carregaPerfil();
            Form1.CarregaBotoes(new trocaBotoes());

            panelEditar.Visible = false;
            panelComprados.Visible = true;
            panelFavoritos.Visible = true;
            lblComprados.Visible = true;
            lblFavoritos.Visible = true;
        }

        //CARREGA TEMPLATES APOS ENTRAR NA TELA INICIAL DO SITE

        void carregaTemplates()
        {
            Servico servico = new Servico();
            List<Servico> servicos = new List<Servico>();
            servicos = servico.buscaImagensTemplates();

            foreach (Servico s in servicos)
            {
                geraimagens(s);
            }
        }

        int x = 50;
        int y = 30;
        int quebraLinha;
        void geraimagens(Servico servico)
        {

            PictureBox pic = new PictureBox();
            pic.LoadAsync(servico.imagem_1);
            pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic.Size = new Size(350, 150);
            pic.Location = new Point(x, y);

            x = x + 380;
            quebraLinha++;
            Form1.panelCentral.Controls.Add(pic);


            //pic.MouseClick += new MouseEventHandler(pictureBox1_Click);//função utilizada anteriomente
            pic.MouseClick += new MouseEventHandler((o, a) => Program.servicoClicado(servico));


            if (quebraLinha == 5)
            {
                x = 50;
                y = 300;
                pic.Location = new Point(x, y);
            }
        }
    }
}
