﻿using System;
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
    public partial class CriarC : Form
    {
        public CriarC()
        {
            InitializeComponent();
        }

        void limpaText()
        {
            txtEmail_CR.Texts = "";
            txtSenha_CR.Texts = "";
            txtUsuario_CR.Texts = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Size = new Size(100, 15);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CriarC_Load(object sender, EventArgs e)
        {
            panelC.Location = new Point(ClientSize.Width - 1400, ClientSize.Height - 750);

            panelDES.Location = new Point(ClientSize.Width - 500, ClientSize.Height - 850);
            imgLogo.Location = new Point(ClientSize.Width - 960, ClientSize.Height - 110);
        }

        private void wilBitButton21_Click(object sender, EventArgs e)
        {
            string email = txtEmail_CR.Texts;
            string senha = txtSenha_CR.Texts;
            string nome = txtUsuario_CR.Texts;

            if (email == "" || senha == "" || nome == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpaText();
                return;
            }

            Usuario usuario = new Usuario();
            usuario.insereUsuario(email, senha, false);
            Program.usuario = usuario.login(email, senha);
            usuario.insereCliente(Program.usuario.id,nome);



            Form1.CarregaBotoes(new trocaBotoes());

            Form1.carregamenuESQ(new trocaMenuESQ());
            this.Close();
            carregaTemplates();
        }

        private void panelC_Paint(object sender, PaintEventArgs e)
        {

        }

        void carregaImagens()
        {
            for (int i = 22; i < 24; i++)
            {
                List<string> imagens = new List<string>();
                Servico servico = new Servico();
                servico = servico.buscaImagensTelaVisitante(i);

                imagens.Add(servico.getImagem_1);
                imagens.Add(servico.getImagem_2);
                imagens.Add(servico.getImagem_3);

                foreach (string imagem in imagens)
                {
                    geraImagens(imagem);
                }
            }
        }

        int x = 50;
        int y = 30;
        int quebraLinha;
        void geraImagens(string imagem)
        {

            PictureBox pic = new PictureBox();
            pic.LoadAsync(imagem);
            pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic.Size = new Size(350, 150);
            pic.Location = new Point(x, y);

            x = x + 380;
            quebraLinha++;
            Form1.panelCentral.Controls.Add(pic);

            pic.MouseClick += new MouseEventHandler(Form1.pictureBox1_Click);

            if (quebraLinha == 5)
            {
                x = 50;
                y = 300;
                pic.Location = new Point(x, y);
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            carregaImagens();
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
