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

        void carregaPerfil()
        {
            picturePerfil.LoadAsync(Program.assinante.imagem_icon);
            picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            lblNome.Text = Program.assinante.nome;
            descricao.Text = Program.assinante.descricao;
            lblVendidos.Text = Program.assinante.itens_vendidos.ToString();

            carregaServicosFeitos();
        }

        private void PerfilAssinante_Load(object sender, EventArgs e)
        {
            if (Program.usuario.id != Program.assinante.id)
            {
                btnEditar.Visible = false;
                btnEditar.Enabled = false;

                panelCompradosASS.Visible = false;
                lblComprados.Visible = false;
            }

            //label
            lblComprados.Location = new Point(ClientSize.Width - 480, ClientSize.Height - 320);
            lblNome.Location = new Point(ClientSize.Width - 610, ClientSize.Height - 478);

            //botao
            btnFechar.Location = new Point(ClientSize.Width - 80, ClientSize.Height - 570);
            btnADD.Location = new Point(ClientSize.Width - 1080, ClientSize.Height - 350);


            //panel/perfil
            panelCompradosASS.Location = new Point(ClientSize.Width - 480, ClientSize.Height - 280);
            panelASS.Location = new Point(ClientSize.Width - 1080, ClientSize.Height - 280);
            picturePerfil.Location = new Point(ClientSize.Width - 650, ClientSize.Height - 580);

            //Conteudo
            carregaPerfil();
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

            carregaPerfil();
            Form1.CarregaBotoes(new trocaBotoes());

            panelEditar.Visible = false;
            panelCompradosASS.Visible = true;
            panelASS.Visible = true;
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

            panelASS.Controls.Add(lblNome);

            PictureBox pic = new PictureBox();
            pic.LoadAsync(servico.imagem_1);
            pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic.Size = new Size(230, 150);
            pic.Location = new Point(xpicture, ypicture);

            panelASS.Controls.Add(pic);

            Label lblPublicadoEm = new Label();
            lblPublicadoEm.Text = servico.publicado_em;
            lblPublicadoEm.Location = new Point(xpublicado, ypublicado);
            lblPublicadoEm.Size = new Size(100, 20);
            lblPublicadoEm.AutoSize = false;
            lblPublicadoEm.Font = new Font("Segoe UI", 10);

            panelASS.Controls.Add(lblPublicadoEm);

            Label lblTipo = new Label();
            lblTipo.Text = servico.tipo;
            lblTipo.Location = new Point(xtipo, ytipo);
            lblTipo.Size = new Size(100, 40);
            lblTipo.AutoSize = false;
            lblTipo.Font = new Font("Segoe UI", 15);

            panelASS.Controls.Add(lblTipo);

            Label lblVendidos = new Label();
            lblVendidos.Text = "Vendidos: " + servico.vendidos.ToString();
            lblVendidos.Location = new Point(xvendidos, yvendidos);
            lblVendidos.Size = new Size(100, 20);
            lblVendidos.AutoSize = false;
            lblVendidos.Font = new Font("Segoe UI", 10);

            panelASS.Controls.Add(lblVendidos);

            Label lblValor = new Label();
            lblValor.Text = "R$" + servico.valor.ToString();
            lblValor.Location = new Point(xvalor, yvalor);
            lblValor.Size = new Size(100, 60);
            lblValor.AutoSize = false;
            lblValor.Font = new Font("Segoe UI", 20);
            lblValor.ForeColor = Color.LightBlue;

            panelASS.Controls.Add(lblValor);
            panelASS.AutoScroll = true;



            panelASS.Height = 250;

            int newy = 220;

            ynome =+ 250;

            ypicture =+ 280;

            ypublicado =+ 250;

            ytipo =+ 330;

            yvendidos =+ 370;

            yvalor =+ 400;
        }
    }
}
