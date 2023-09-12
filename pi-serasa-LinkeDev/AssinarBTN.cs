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
    public partial class AssinarBTN : Form
    {
        public AssinarBTN()
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



        private void wilBitButton21_Click(object sender, EventArgs e)
        {
           
        }


        private void panelC_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void wilBitButton21_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
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

        private void btnFechar_Click(object sender, EventArgs e)
        {

        }

        private void AssinarBTN_Load(object sender, EventArgs e)
        {
            btnFechar.Location = new Point(btnFechar.Location.X, btnFechar.Location.Y - 150);
            panelC2.Location = new Point(ClientSize.Width - 1400, ClientSize.Height - 750);

            panelDES.Location = new Point(ClientSize.Width - 500, ClientSize.Height - 850);
            imgLogo.Location = new Point(ClientSize.Width - 980, ClientSize.Height - 160);

        }

        private void wilBitButton21_Click_2(object sender, EventArgs e)
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

            Usuario usuario = new Usuario(email, senha, false);
            Program.usuario = usuario;

            Program.GuardaEmail = email;
            Program.GuardaSenha = senha;
            Program.GuardaNome = nome;
            Program.disparador = true;

            //Usuario usuario = new Usuario();
            // usuario.insereUsuario(email, senha, true);
            //  Program.usuario = usuario.login(email, senha);
            // usuario.insereAssinante(Program.usuario.id, nome);

            Form1.CarregaEntreTELAS(new Assinar());
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1.CarregaEntreTELAS(new lkJatenho1());
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
            carregaImagens();
        }
    }
}
