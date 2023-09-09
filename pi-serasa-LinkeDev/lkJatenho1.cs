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
    public partial class lkJatenho1 : Form
    {
        public lkJatenho1()
        {
            InitializeComponent();
        }

        private void lkJatenho1_Load(object sender, EventArgs e)
        {
            panelC.Location = new Point(ClientSize.Width - 1050, ClientSize.Height - 650);
        }
        private void btnEntrar_LGClick(object sender, EventArgs e)
        {


        }

        private void EntrarC_Load(object sender, EventArgs e)
        {
            // panelC.Location = new Point(ClientSize.Width - 1050, ClientSize.Height - 650);
            //imgLogoE.Location = new Point(ClientSize.Width - 120, ClientSize.Height - 890);
        }

        private void btnEntrar_LG_Click(object sender, EventArgs e)
        {
            string email = txtEmail_LG.Texts;
            string senha = txtSenha_LG.Texts;

            if (email == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = new Usuario();
            usuario = usuario.login(email, senha);

            if (usuario == null)
            {
                MessageBox.Show("Email ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;            
            }
            usuario.alteraClienteParaAssinante(usuario);
            Program.usuario = usuario;

            

            Form1.CarregaEntreTELAS(new Assinar());
            this.Close();
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
    }
}
