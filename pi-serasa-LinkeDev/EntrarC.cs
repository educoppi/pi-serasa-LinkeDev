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
    public partial class EntrarC : Form
    {
        public EntrarC()
        {
            InitializeComponent();
        }

        void limpaText()
        {
            txtEmail_LG.Texts = "";
            txtSenha_LG.Texts = "";
        }

       

       

        public void botaoEntrarAssinar_Click(object sender, EventArgs e)
        {

        }

        public void panelC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtEmail_LG__TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
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

        int x = 50;
        int y = 30;
        int quebraLinha;
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

        private void btnEntrar_LG_Click(object sender, EventArgs e)
        {
            string email = txtEmail_LG.Texts;
            string senha = txtSenha_LG.Texts;

            if (email == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpaText();
                return;
            }

            Usuario usuario = new Usuario();
            usuario = usuario.login(email, senha);

            if (usuario == null)
            {
                MessageBox.Show("Email ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpaText();
                return;
            }

            Program.usuario = usuario;

            if (Program.usuario.isAssinante)
            {
                Assinante assinante = new Assinante();
                Program.assinante = assinante.retornaAssinante(Program.usuario.id);
            }
            else
            {
                Cliente cliente = new Cliente();
                Program.cliente = cliente.retornaCliente(Program.usuario.id);
            }


            Form1.CarregaBotoes(new trocaBotoes());
            Form1.carregamenuESQ(new trocaMenuESQ());

            this.Close();

            carregaTemplates();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {

            this.Close();
            carregaImagens();
        }

        private void EntrarC_Load_1(object sender, EventArgs e)
        {
           
            panelC.Location = new Point(ClientSize.Width - 1050, ClientSize.Height - 650);
            imgLogoE.Location = new Point(ClientSize.Width - 120, ClientSize.Height - 890);
        }
    }
}
