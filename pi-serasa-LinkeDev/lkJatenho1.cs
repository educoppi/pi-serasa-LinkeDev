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

        void limparText()
        {
            txtEmail_LG.Texts = "";
            txtSenha_LG.Texts = "";
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

      
        private void panelC_Paint(object sender, PaintEventArgs e)
        {

        }


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
                y = y + 270;
                pic.Location = new Point(x, y);
                quebraLinha = 0;
            }

        }

       
        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            carregaImagens();
        }

        private void btnEntrar_LG_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail_LG.Texts;
            string senha = txtSenha_LG.Texts;

            if (email == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparText();
                return;
            }

            Usuario usuario = new Usuario();
            usuario = usuario.login(email, senha);

            if (usuario == null)
            {
                MessageBox.Show("Email ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limparText();
                return;
            }
            // o metodo | usuario.alteraClienteParaAssinante(usuario) | tenta encontrar um cliente 
            //na tabela de clientes, para transforma-lo em assinante, se não for encontrado
            //o metodo lança um erro, por isso utilizei o Try Catch.
            //try
           // {
           //     usuario.alteraClienteParaAssinante(usuario);
         //   }
          //  catch (Exception)
          //  {
          //      MessageBox.Show("Perfil não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
          //      limparText();
         //       return;
         //   }
            Program.usuario = usuario;

            Program.disparador = false;

            Form1.CarregaEntreTELAS(new Assinar());
            this.Close();
        }

        private void lkJatenho1_Load_1(object sender, EventArgs e)
        {
            panelC.Location = new Point(ClientSize.Width - 1050, ClientSize.Height - 650);
        }
    }
}
