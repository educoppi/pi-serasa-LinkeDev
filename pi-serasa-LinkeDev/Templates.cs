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
    public partial class Templates : Form
    {
        public Templates()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Program.idUsuarioCurtiu = 0;
            this.Close();
            carregaTemplates();
        }

        void confereFavoritado()
        {
            if (Program.usuario.isAssinante == true)
            {
                btnFavoritar.Enabled = false;
                btnFavoritar.Visible = false;
            }

            ServicosFavoritados sf = new ServicosFavoritados();
            sf = sf.retorna(Program.usuario.id, Program.servico.id);

            if (sf != null)
            {
                btnFavoritar.Enabled = false;
                btnFavoritar.Visible = false;
            }
        }

        private void Templates_Load(object sender, EventArgs e)
        {
            //botao
            btnFechar.Location = new Point(ClientSize.Width - 80, ClientSize.Height - 570);
            btnComprar.Location = new Point(ClientSize.Width - 190, ClientSize.Height - 530);
            btnCurtir.Location = new Point(ClientSize.Width - 430, ClientSize.Height - 330);
            btnFavoritar.Location = new Point(ClientSize.Width - 430, ClientSize.Height - 250);

            //label posições
            lblPreco1.Location = new Point(ClientSize.Width - 110, ClientSize.Height - 480);
            lblSifrao1.Location = new Point(ClientSize.Width - 140, ClientSize.Height - 478);
            lblValor.Location = new Point(ClientSize.Width - 190, ClientSize.Height - 476);
            lblDescricao.Location = new Point(ClientSize.Width - 190, ClientSize.Height - 380);
            lblDescricaoTXT.Location = new Point(ClientSize.Width - 190, ClientSize.Height - 350);

            lblSifrao2.Location = new Point(ClientSize.Width - 180, ClientSize.Height - 210);
            lblPreco2.Location = new Point(ClientSize.Width - 140, ClientSize.Height - 210);

            lblNumeroVendido.Location = new Point(ClientSize.Width - 340, ClientSize.Height - 476);
            lblNumeroCurtidas.Location = new Point(ClientSize.Width - 340, ClientSize.Height - 455);
            lblNumeroFavoritados.Location = new Point(ClientSize.Width - 340, ClientSize.Height - 434);

            lblVendido.Location = new Point(ClientSize.Width - 430, ClientSize.Height - 476);
            lblCurtidas.Location = new Point(ClientSize.Width - 430, ClientSize.Height - 455);
            lblFavoritados.Location = new Point(ClientSize.Width - 430, ClientSize.Height - 434);

            lblDesfazerCurtida.Location = new Point(ClientSize.Width - 330, ClientSize.Height - 315);

            lblPublicadoEm.Location = new Point(ClientSize.Width - 430, ClientSize.Height - 570);

            //label conteúdo
            lblProdutoTXT.Text = Program.servico.nome;
            lblProgamadorTXT.Text = Program.servico.nome_assinante;
            lblDescricaoTXT.Text = Program.servico.descricao;
            lblNumeroVendido.Text = (Program.servico.vendidos).ToString();
            lblPreco1.Text = (Program.servico.valor).ToString();
            lblPreco2.Text = (Program.servico.valor).ToString();
            lblNumeroCurtidas.Text = Program.servico.curtidas.ToString();
            lblNumeroFavoritados.Text = Program.servico.qtd_favoritados.ToString();
            lblPublicadoEm.Text = Program.servico.publicado_em;

            //imagens
            imagem1.LoadAsync(Program.servico.imagem_1);
            imagem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imagem2.LoadAsync(Program.servico.imagem_2);
            imagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imagem3.LoadAsync(Program.servico.imagem_3);
            imagem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            //icone do programador
            Assinante assinante = new Assinante();
            Program.assinante = assinante.retornaAssinante(Program.servico.id_assinante);
            imagemPerfil.LoadAsync(Program.assinante.imagem_icon);
            imagemPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            //Confere se o usuario que esta vendo o serviço ja favoritou esse serviço ou se é um assinante
            confereFavoritado();
        }


        int compras = Program.servico.vendidos;
        private void btnComprar_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();

            Usuario usuario = new Usuario();
            usuario = usuario.retornaEmailUsuario(Program.servico.id_assinante);

            compras++;

            servico.atualizaVendidos(compras, Program.servico.id);
            servico = servico.retornaNumeros(Program.servico.id);
            Program.servico.vendidos = servico.vendidos;

            lblNumeroVendido.Text = Program.servico.vendidos.ToString();

            MessageBox.Show("compra efetuada, entre em contato com o vendedor através do seguinte email: " + usuario.email);
        }

        private void imagemPerfil_Click(object sender, EventArgs e)
        {
            Assinante assinante = new Assinante();
            assinante = assinante.retornaAssinante(Program.servico.id_assinante);

            Program.assinante = assinante;

            Form1.CarregaEntreTELAS(new PerfilAssinante());
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


        //BOTAO CURTIR
        int numeroCurtidas = Program.servico.curtidas;
        private void btnCurtir_Click(object sender, EventArgs e)
        {
            numeroCurtidas = Program.servico.curtidas;

            Servico servico = new Servico();
            int idUsuario = Program.usuario.id;

            if (idUsuario == Program.idUsuarioCurtiu)
            {
                MessageBox.Show("Você ja curtiu essa postagem!");
                return;
            }
            numeroCurtidas++;

            Program.idUsuarioCurtiu = idUsuario;
            servico.atualizaCurtida(numeroCurtidas, Program.servico.id);
            servico = servico.retornaNumeros(Program.servico.id);
            Program.servico.curtidas = servico.curtidas;

            lblNumeroCurtidas.Text = Program.servico.curtidas.ToString();
            lblDesfazerCurtida.Visible = true;
            lblDesfazerCurtida.Enabled = true;
        }

        private void lblDesfazerCurtida_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();
            Program.servico.curtidas--;
            servico.atualizaCurtida(Program.servico.curtidas, Program.servico.id);
            servico = servico.retornaNumeros(Program.servico.id);
            Program.servico.curtidas = servico.curtidas;
            lblNumeroCurtidas.Text = Program.servico.curtidas.ToString();

            Program.idUsuarioCurtiu = 0;

            lblDesfazerCurtida.Visible = false;
            lblDesfazerCurtida.Enabled = false;
        }

        //BOTAO FAVORITAR
        int numeroFavoritados = Program.servico.qtd_favoritados;
        private void btnFavoritar_Click(object sender, EventArgs e)
        {
            numeroFavoritados = Program.servico.qtd_favoritados;

            Servico servico = new Servico();
            int idUsuario = Program.usuario.id;

            if (idUsuario == Program.idUsuarioFavoritou)
            {
                MessageBox.Show("Você ja favoritou essa postagem!");
                return;
            }
            numeroFavoritados++;

            Program.idUsuarioFavoritou = idUsuario;
            servico.atualizaFavoritado(numeroFavoritados, Program.servico.id);
            servico = servico.retornaNumeros(Program.servico.id);
            Program.servico.qtd_favoritados = servico.qtd_favoritados;

            lblNumeroFavoritados.Text = Program.servico.qtd_favoritados.ToString();

            ServicosFavoritados sf = new ServicosFavoritados();
            sf.insere(Program.usuario.id, Program.servico.id, Program.servico.nome, Program.servico.imagem_1, Program.servico.tipo);

            confereFavoritado();
        }

        private void lblDesfazerFavoritado_Click(object sender, EventArgs e)
        {
        }
    }
}
