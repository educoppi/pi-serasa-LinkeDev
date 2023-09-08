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
    public partial class trocaBotoes : Form
    {
        public trocaBotoes()
        {
            InitializeComponent();
        }

        private void trocaBotoes_Load(object sender, EventArgs e)
        {

        }



        public void picturePerfil_Click(object sender, EventArgs e)
        {
            Form1.CarregaEntreTELAS(new PerfilCliente());
        }

        private void btnAssine_Click(object sender, EventArgs e)
        {
            Form1.CarregaEntreTELAS(new Assinar());
        }
    }
}
