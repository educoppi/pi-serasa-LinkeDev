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

            Usuario usuario = new Usuario();
            bool confere = usuario.login(email, senha);

            if (confere)
            {
                Form1.CarregaEntreTELAS(new Assinar());
                this.Close();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelC_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
