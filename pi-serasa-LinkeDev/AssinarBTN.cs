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

        

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Size = new Size(100, 15);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void wilBitButton21_Click(object sender, EventArgs e)
        {
            string email = txtEmail_CR.Texts;
            string senha = txtSenha_CR.Texts;
            string nome = txtUsuario_CR.Texts;

            if (email == "" && senha == "" && nome == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = new Usuario();
            usuario.insereUsuario(email, senha);

            Inicial i = new Inicial();
            Assinar assinar = new Assinar();
            assinar.Show();
            i.Show();
        }

        private void panelC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AssinarBTN_Load_1(object sender, EventArgs e)
        {
            panelC2.Location = new Point(ClientSize.Width - 1400, ClientSize.Height - 750);

            panelDES.Location = new Point(ClientSize.Width - 500, ClientSize.Height - 850);
            imgLogo.Location = new Point(ClientSize.Width - 980, ClientSize.Height - 160);
        }

        private void wilBitButton21_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail_CR.Texts;
            string senha = txtSenha_CR.Texts;
            string nome = txtUsuario_CR.Texts;

            if (email == "" && senha == "" && nome == "")
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuario usuario = new Usuario();
            usuario.insereUsuario(email, senha);
            usuario.insereAssinante(nome);

            Inicial i = new Inicial();
            i.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EntrarC entra = new EntrarC();
            entra.Show();
        }

        private void imgLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
