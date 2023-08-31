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

        private void btnEntrar_LGClick(object sender, EventArgs e)
        {
            string email = txtEmail_LG.Texts;
            string senha = txtSenha_LG.Texts;

            Usuario usuario = new Usuario();
            bool confere = usuario.login(email, senha);

            if (confere)
            {
                Inicial i = new Inicial();
                i.Show();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
