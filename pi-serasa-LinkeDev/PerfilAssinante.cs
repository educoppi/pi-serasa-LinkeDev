using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            if (Program.usuario.id == Program.assinante.id)
            {
                this.Close();
                carregaTemplates();
                return;
            }

            this.Close();
            Form1.CarregaEntreTELAS(new Templates());
        }

        void carregaPerfil()
        {
            picturePerfil.LoadAsync(Program.assinante.imagem_icon);
            picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            lblNome.Text = Program.assinante.nome;
            descricao.Text = Program.assinante.descricao;
            lblVendidos.Text = Program.assinante.itens_vendidos.ToString();

            carregaServicosFeitos();
            carregaComprados();
        }

        private void PerfilAssinante_Load(object sender, EventArgs e)
        {
            if (Program.usuario.id != Program.assinante.id)
            {
                btnEditar.Visible = false;
                btnEditar.Enabled = false;

                panelCompradosASS.Visible = false;
                lblComprados.Visible = false;
                btnADD.Visible = false;
                btnADD.Enabled = false;
            }

            //label
            lblComprados.Location = new Point(ClientSize.Width - 480, ClientSize.Height - 320);
            lblNome.Location = new Point(ClientSize.Width - 610, ClientSize.Height - 478);

            //botao
            btnFechar.Location = new Point(ClientSize.Width - 80, ClientSize.Height - 570);
            btnADD.Location = new Point(ClientSize.Width - 1080, ClientSize.Height - 350);


            //panel/perfil
            panelCompradosASS.Location = new Point(ClientSize.Width - 480, ClientSize.Height - 280);
            panelASS2.Location = new Point(ClientSize.Width - 1080, ClientSize.Height - 280);
            picturePerfil.Location = new Point(ClientSize.Width - 650, ClientSize.Height - 580);

            //Conteudo
            carregaPerfil();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panelEditar.Visible = true;
            panelCompradosASS.Visible = false;
            panelASS2.Visible = false;
            lblComprados.Visible = false;
            btnADD.Visible = false;
        }

        private void btnEditar2_Click(object sender, EventArgs e)
        {
        }

        private void btnEditar2_Click_1(object sender, EventArgs e)
        {
            string editNome = txtEditNome.Text;
            string editDescricao = txtEditDescricao.Text;
            string editImagemicon = txtEditImagemIcon.Text;

            if (editNome == "")
            {
                editNome = Program.assinante.nome;
            }

            if (editDescricao == "")
            {
                editDescricao = Program.assinante.descricao;
            }

            if (editImagemicon == "")
            {
                editImagemicon = Program.assinante.imagem_icon;
            }


            Assinante assinante = new Assinante();
            Program.assinante = assinante.editaAssinante(editNome, editDescricao, editImagemicon, Program.assinante.id);
            Servico servico = new Servico();
            servico.editaNomeAssinante(Program.assinante.id, Program.assinante.nome);

            carregaPerfil();
            Form1.CarregaBotoes(new trocaBotoes());

            panelEditar.Visible = false;
            panelCompradosASS.Visible = true;
            panelASS2.Visible = true;
            lblComprados.Visible = true;
            btnADD.Visible = true;
        }

        void carregaServicosFeitos()
        {
            Servico servico = new Servico();
            List<Servico> servicos = new List<Servico>();
            servicos = servico.buscaServicosDeAssinante(Program.assinante.id);

            foreach (Servico s in servicos)
            {
                geraLista(s);
            }
        }

        int xnome = 30;
        int ynome = 20;
        int xpicture = 30;
        int ypicture = 70;
        int xpublicado = 420;
        int ypublicado = 20;
        int xtipo = 350;
        int ytipo = 70;
        int xvendidos = 350;
        int yvendidos = 110;
        int xvalor = 350;
        int yvalor = 170;

        void geraLista(Servico servico)
        {
            Label lblNome = new Label();
            lblNome.Text = servico.nome;
            lblNome.Location = new Point(xnome, ynome);
            lblNome.Size = new Size(250, 50);
            lblNome.AutoSize = false;
            lblNome.Font = new Font("Segoe UI", 15);

            panelASS2.Controls.Add(lblNome);

            PictureBox pic = new PictureBox();
            pic.LoadAsync(servico.imagem_1);
            pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic.Size = new Size(230, 150);
            pic.Location = new Point(xpicture, ypicture);

            pic.MouseClick += new MouseEventHandler((o, a) => Program.servicoClicado(servico));

            panelASS2.Controls.Add(pic);

            Label lblPublicadoEm = new Label();
            lblPublicadoEm.Text = servico.publicado_em;
            lblPublicadoEm.Location = new Point(xpublicado, ypublicado);
            lblPublicadoEm.Size = new Size(100, 20);
            lblPublicadoEm.AutoSize = false;
            lblPublicadoEm.Font = new Font("Segoe UI", 10);

            panelASS2.Controls.Add(lblPublicadoEm);

            Label lblTipo = new Label();
            lblTipo.Text = servico.tipo;
            lblTipo.Location = new Point(xtipo, ytipo);
            lblTipo.Size = new Size(100, 40);
            lblTipo.AutoSize = false;
            lblTipo.Font = new Font("Segoe UI", 15);

            panelASS2.Controls.Add(lblTipo);

            Label lblVendidos = new Label();
            lblVendidos.Text = "Vendidos: " + servico.vendidos.ToString();
            lblVendidos.Location = new Point(xvendidos, yvendidos);
            lblVendidos.Size = new Size(100, 20);
            lblVendidos.AutoSize = false;
            lblVendidos.Font = new Font("Segoe UI", 10);

            panelASS2.Controls.Add(lblVendidos);

            Label lblValor = new Label();
            lblValor.Text = "R$" + servico.valor.ToString();
            lblValor.Location = new Point(xvalor, yvalor);
            lblValor.Size = new Size(100, 60);
            lblValor.AutoSize = false;
            lblValor.Font = new Font("Segoe UI", 20);
            lblValor.ForeColor = Color.LightBlue;

            panelASS2.Controls.Add(lblValor);
            panelASS2.AutoScroll = true;

            ynome = ynome + 250;

            ypicture = ypicture + 250;

            ypublicado = ypublicado + 250;

            ytipo = ytipo + 250;

            yvendidos = yvendidos + 250;

            yvalor = yvalor + 250;
        }

        private void lblFechar_Click(object sender, EventArgs e)
        {
            txtEditNome.Clear();
            txtEditDescricao.Clear();
            txtEditImagemIcon.Clear();

            panelEditar.Visible = false;

            panelCompradosASS.Visible = true;
            panelASS2.Visible = true;
            lblComprados.Visible = true;
            btnADD.Visible = true;
        }

        //CARREGA TEMPLATES DA TELA INICIAL
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        //BOTAO DE CRIAR SERVICO
        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNomeServico.Text;
            string descricao = txtDescricaoServico.Text;
            string tipo = retornaTipo();

            string valorNaoTratado = numericValor.Value.ToString();

            double valor = double.Parse(valorNaoTratado);
            string imagem1 = txtImagem1.Text;
            string imagem2 = txtImagem2.Text;
            string imagem3 = txtImagem3.Text;

            if (nome == "" || descricao == "" || tipo == "" || valorNaoTratado == "" || imagem1 == "" || imagem2 == "" || imagem3 == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpaCampos();
                return;
            }

            Servico servico = new Servico();
            servico.insereServico(Program.assinante.id, Program.assinante.nome, nome, descricao, tipo, valor, imagem1, imagem2, imagem3);
            carregaPerfil();
            MessageBox.Show("Postagem de Serviço efetuada com sucesso!");
            limpaCampos();
            panelPostagem.Visible = false;
            panelASS2.Visible = true;
            panelCompradosASS.Visible = true;

        }

        public string retornaTipo()
        {
            string tipo = "";

            if (rbTemplates.Checked)
            {
                tipo = rbTemplates.Text;
            }
            else if (rbMobile.Checked)
            {
                tipo = rbMobile.Text;
            }
            else if (rbWeb.Checked)
            {
                tipo = rbWeb.Text;
            }
            else if (rbGames.Checked)
            {
                tipo = rbGames.Text;
            }
            else if (rbBancoDeDados.Checked)
            {
                tipo = rbBancoDeDados.Text;
            }
            else if (rbBackEnd.Checked)
            {
                tipo = rbBackEnd.Text;
            }
            else if (rbFrontEnd.Checked)
            {
                tipo = rbFrontEnd.Text;
            }
            else if (rbFullStack.Checked)
            {
                tipo = rbFullStack.Text;
            }
            else if (rbDesktop.Checked)
            {
                tipo = rbDesktop.Text;
            }

            return tipo;
        }

        void limpaCampos()
        {
            txtNomeServico.Clear();
            txtDescricaoServico.Clear();
            rbTemplates.Checked = false;
            rbMobile.Checked = false;
            rbWeb.Checked = false;
            rbGames.Checked = false;
            rbBancoDeDados.Checked = false;
            rbBackEnd.Checked = false;
            rbFrontEnd.Checked = false;
            rbFullStack.Checked = false;
            rbDesktop.Checked = false;
            txtImagem1.Clear();
            txtImagem2.Clear();
            txtImagem3.Clear();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            panelPostagem.Visible = true;
            panelASS2.Visible = false;
            panelCompradosASS.Visible = false;
            lblComprados.Visible = false;
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

        int xxnome = 10;
        int yynome = 20;
        int xxpicture = 10;
        int yypicture = 70;
        int xxpublicado = 350;
        int yypublicado = 20;
        int xxtipo = 320;
        int yytipo = 70;
        int xxvalor = 320;
        int yyvalor = 170;

        void geraComprados(ServicosComprados sc)
        {
            Label lblNome = new Label();
            lblNome.Text = sc.nome_servico;
            lblNome.Location = new Point(xxnome, yynome);
            lblNome.Size = new Size(250, 50);
            lblNome.AutoSize = false;
            lblNome.Font = new Font("Segoe UI", 15);

            panelCompradosASS.Controls.Add(lblNome);

            PictureBox pic = new PictureBox();
            pic.LoadAsync(sc.imagem_1);
            pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic.Size = new Size(230, 150);
            pic.Location = new Point(xxpicture, yypicture);

            Servico servico = new Servico();
            pic.MouseClick += new MouseEventHandler((o, a) => Program.servicoClicado(servico.buscaPorId(sc.id_servico)));

            panelCompradosASS.Controls.Add(pic);

            Label lblPublicadoEm = new Label();
            lblPublicadoEm.Text = sc.comprado_em;
            lblPublicadoEm.Location = new Point(xxpublicado, yypublicado);
            lblPublicadoEm.Size = new Size(100, 20);
            lblPublicadoEm.AutoSize = false;
            lblPublicadoEm.Font = new Font("Segoe UI", 10);

            panelCompradosASS.Controls.Add(lblPublicadoEm);

            Label lblTipo = new Label();
            lblTipo.Text = sc.tipo;
            lblTipo.Location = new Point(xxtipo, yytipo);
            lblTipo.Size = new Size(100, 40);
            lblTipo.AutoSize = false;
            lblTipo.Font = new Font("Segoe UI", 15);

            panelCompradosASS.Controls.Add(lblTipo);

            Label lblValor = new Label();
            lblValor.Text = "R$" + sc.valor.ToString();
            lblValor.Location = new Point(xxvalor, yyvalor);
            lblValor.Size = new Size(100, 60);
            lblValor.AutoSize = false;
            lblValor.Font = new Font("Segoe UI", 20);
            lblValor.ForeColor = Color.LightBlue;

            panelCompradosASS.Controls.Add(lblValor);
            panelCompradosASS.AutoScroll = true;

            yynome = yynome + 250;

            yypicture = yypicture + 250;

            yypublicado = yypublicado + 250;

            yytipo = yytipo + 250;

            yyvalor = yyvalor + 250;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            limpaCampos();

            panelPostagem.Visible = false;
            panelASS2.Visible = true;
            panelCompradosASS.Visible = true;
            lblComprados.Visible = true;
        }
    }
}
