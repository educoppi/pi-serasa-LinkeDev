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
    public partial class Assinar : Form
    {
        public Assinar()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            carregaImagens();
        }

        private void btnComprarSE_Click(object sender, EventArgs e)
        {
            Form1.CarregaBotoes(new TrocaPerfil());
            Form1.carregamenuESQ(new trocaMenuESQ());
            this.Close();
            carregaTemplates();
        }

        private void btnAssinarAnu_Click(object sender, EventArgs e)
        {
            Form1.CarregaBotoes(new TrocaPerfil());
            Form1.carregamenuESQ(new trocaMenuESQ());
            this.Close();
            carregaTemplates();
        }

        private void btnAssinarMen_Click(object sender, EventArgs e)
        {
            Form1.CarregaBotoes(new TrocaPerfil());
            Form1.carregamenuESQ(new trocaMenuESQ());
            this.Close();
            carregaTemplates();
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

        //CARREGA IMAGENS DA TELA DE VISITANTE, APOS CLICAR NO BOTAO DE FECHAR

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

    }
}
