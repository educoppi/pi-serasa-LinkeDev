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



        void novoAssinante()
        {
            if (Program.usuario.isAssinante)
            {
                Assinante assinante = new Assinante();
                Program.assinante = assinante.retornaAssinante(Program.usuario.id);
                return;
            }

            if (Program.disparador)
            {
                Usuario usuario = new Usuario();
                usuario.insereUsuario(Program.GuardaEmail, Program.GuardaSenha, true);
                usuario = usuario.login(Program.GuardaEmail, Program.GuardaSenha);
                Program.usuario = usuario;
                usuario.insereAssinante(Program.usuario.id, Program.GuardaNome);

                Assinante assinante = new Assinante();
                assinante = assinante.retornaAssinante(Program.usuario.id);

                Program.assinante = assinante;
            }
            else
            {
                Usuario usuario = new Usuario();
                usuario.alteraClienteParaAssinante(Program.usuario);

                Assinante assinante = new Assinante();
                assinante = assinante.retornaAssinante(Program.usuario.id);

                Program.assinante = assinante;
            }
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
            List<Servico> servicos = new List<Servico>();
            Servico servico = new Servico();
            servicos = servico.buscaImagens();

            foreach (Servico s in servicos)
            {
                geraImagens(s);
            }

        }

        void geraImagens(Servico servico)
        {

            PictureBox pic = new PictureBox();
            pic.LoadAsync(servico.imagem_1);
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

        private void btnComprarSE_Click_1(object sender, EventArgs e)
        {
            novoAssinante();
            this.Close();


            Form1.CarregaBotoes(new trocaBotoes());
            Form1.carregamenuESQ(new trocaMenuESQ());
            carregaTemplates();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Program.GuardaEmail = null;
            Program.GuardaSenha = null;
            Program.GuardaNome = null;
            this.Close();
            carregaImagens();
        }

        private void btnAssinarAnu_Click_1(object sender, EventArgs e)
        {
            novoAssinante();
            this.Close();

            Form1.CarregaBotoes(new trocaBotoes());
            Form1.carregamenuESQ(new trocaMenuESQ());
            carregaTemplates();
        }

        private void btnAssinarMen_Click_1(object sender, EventArgs e)
        {
            novoAssinante();
            this.Close();

            Form1.CarregaBotoes(new trocaBotoes());
            Form1.carregamenuESQ(new trocaMenuESQ());
            carregaTemplates();
        }

        private void Assinar_Load(object sender, EventArgs e)
        {

        }
    }
}
