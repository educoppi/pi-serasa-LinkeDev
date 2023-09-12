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

            carregaFavoritos();
            carregaComprados();
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


        //CARREGA FAVORITADOS

        void carregaFavoritos()
        {
            int ynome = 20;
            int ypicture = 70;
            int ytipo = 100;

            ServicosFavoritados sf = new ServicosFavoritados();
            List<ServicosFavoritados> favoritados = new List<ServicosFavoritados>();
            favoritados = sf.buscaServicosFavoritados(Program.usuario.id);

            foreach (ServicosFavoritados s in favoritados)
            {
                if (s == null)
                {
                    lblFavoritosNull.Visible = true;
                }
                else
                {
                    lblFavoritosNull.Visible = false;
                }

                geraFavoritos(s, ynome, ypicture, ytipo);

                ynome = ynome + 250;

                ypicture = ypicture + 250;

                ytipo = ytipo + 250;
            }
        }

        void geraFavoritos(ServicosFavoritados sf, int ynome, int ypicture, int ytipo)
        {
            Label lblNome = new Label();
            lblNome.Text = sf.nome_servico;
            lblNome.Location = new Point(30, ynome);
            lblNome.Size = new Size(250, 50);
            lblNome.AutoSize = false;
            lblNome.Font = new Font("Segoe UI", 15);

            panelFavoritos.Controls.Add(lblNome);

            PictureBox pic = new PictureBox();
            pic.LoadAsync(sf.imagem_1);
            pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic.Size = new Size(260, 170);
            pic.Location = new Point(30, ypicture);

            Servico servico = new Servico();

            pic.MouseClick += new MouseEventHandler((o, a) => Program.servicoClicado(servico.buscaPorId(sf.id_servico)));

            panelFavoritos.Controls.Add(pic);

            Label lblTipo = new Label();
            lblTipo.Text = sf.tipo;
            lblTipo.Location = new Point(300, ytipo);
            lblTipo.Size = new Size(130, 40);
            lblTipo.AutoSize = false;
            lblTipo.Font = new Font("Segoe UI", 20);

            panelFavoritos.Controls.Add(lblTipo);

            Label lblDeletar = new Label();
            lblDeletar.Text = "X";
            lblDeletar.Location = new Point(530, ytipo - 90);
            lblDeletar.Size = new Size(50, 100);
            lblDeletar.AutoSize = false;
            lblDeletar.Font = new Font("Segoe UI", 25);
            lblDeletar.ForeColor = Color.IndianRed;

            lblDeletar.MouseClick += new MouseEventHandler((o, a) => deletou(Program.deletaServicoFavoritado(sf.id_usuario, sf.id_servico)));

            panelFavoritos.Controls.Add(lblDeletar);

            panelFavoritos.AutoScroll = true;
        }

        public void deletou(bool deletou)
        {
            if (deletou)
            {
                panelFavoritos.Controls.Clear();
                carregaFavoritos();
            }
        }

        //CARREGA SERVICOS COMPRADOS

        void carregaComprados()
        {
            ServicosComprados sc = new ServicosComprados();
            List<ServicosComprados> comprados = new List<ServicosComprados>();
            comprados = sc.buscaServicosComprados(Program.usuario.id);

            foreach (ServicosComprados s in comprados)
            {
                geraComprados(s);
            }
        }

        int xnome = 10;
        int ynome = 20;
        int xpicture = 10;
        int ypicture = 70;
        int xpublicado = 560;
        int ypublicado = 20;
        int xtipo = 320;
        int ytipo = 70;
        int xvalor = 320;
        int yvalor = 170;

        void geraComprados(ServicosComprados sc)
        {
            Label lblNome = new Label();
            lblNome.Text = sc.nome_servico;
            lblNome.Location = new Point(xnome, ynome);
            lblNome.Size = new Size(250, 50);
            lblNome.AutoSize = false;
            lblNome.Font = new Font("Segoe UI", 15);

            panelComprados.Controls.Add(lblNome);

            PictureBox pic = new PictureBox();
            pic.LoadAsync(sc.imagem_1);
            pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic.Size = new Size(260, 170);
            pic.Location = new Point(xpicture, ypicture);

            Servico servico = new Servico();
            pic.MouseClick += new MouseEventHandler((o, a) => Program.servicoClicado(servico.buscaPorId(sc.id_servico)));

            panelComprados.Controls.Add(pic);

            Label lblPublicadoEm = new Label();
            lblPublicadoEm.Text = sc.comprado_em;
            lblPublicadoEm.Location = new Point(xpublicado, ypublicado);
            lblPublicadoEm.Size = new Size(120, 40);
            lblPublicadoEm.AutoSize = false;
            lblPublicadoEm.Font = new Font("Segoe UI", 15);

            panelComprados.Controls.Add(lblPublicadoEm);

            Label lblTipo = new Label();
            lblTipo.Text = sc.tipo;
            lblTipo.Location = new Point(xtipo, ytipo);
            lblTipo.Size = new Size(130, 40);
            lblTipo.AutoSize = false;
            lblTipo.Font = new Font("Segoe UI", 20);

            panelComprados.Controls.Add(lblTipo);

            Label lblValor = new Label();
            lblValor.Text = "R$" + sc.valor.ToString();
            lblValor.Location = new Point(xvalor, yvalor);
            lblValor.Size = new Size(120, 60);
            lblValor.AutoSize = false;
            lblValor.Font = new Font("Segoe UI", 25);
            lblValor.ForeColor = Color.LightBlue;

            panelComprados.Controls.Add(lblValor);
            panelComprados.AutoScroll = true;

            ynome = ynome + 250;

            ypicture = ypicture + 250;

            ypublicado = ypublicado + 250;

            ytipo = ytipo + 250;

            yvalor = yvalor + 250;
        }



        private void PerfilCliente_Load_1(object sender, EventArgs e)
        {

            ///LOCATION
            //botao
            btnFechar.Location = new Point(ClientSize.Width - 80, ClientSize.Height -890);
            btnEditar.Location = new Point(ClientSize.Width - 76, ClientSize.Height - 845);

            //label
            lblComprados.Location = new Point(ClientSize.Width - 770, ClientSize.Height - 430);
            lblFavoritos.Location = new Point(ClientSize.Width - 1600, ClientSize.Height - 430);
            labelNome.Location = new Point(ClientSize.Width - 860, ClientSize.Height - 780);
            //panels/perfil
            panelComprados.Location = new Point(ClientSize.Width - 770, ClientSize.Height - 400);
            panelFavoritos.Location = new Point(ClientSize.Width - 1600, ClientSize.Height - 400);
            picturePerfil.Location = new Point(ClientSize.Width - 900, ClientSize.Height - 890);
            panelEditar.Location = new Point(ClientSize.Width - 1035, ClientSize.Height - 600);

            ///CONTEUDO
            carregaPerfil();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)


        {
            this.Close();
            carregaTemplates();
           

        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            panelEditar.Visible = true;
            panelComprados.Visible = false;
            panelFavoritos.Visible = false;
            lblComprados.Visible = false;
            lblFavoritos.Visible = false;
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            txtEditNome.Clear();
            txtEditDescricao.Clear();
            txtImagemIcone.Clear();

            panelEditar.Visible = false;

            panelComprados.Visible = true;
            panelFavoritos.Visible = true;
            lblComprados.Visible = true;
            lblFavoritos.Visible = true;
        }

        private void btnEditar2_Click_2(object sender, EventArgs e)
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
    }
}
