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
        }

        private void btnComprarSE_Click(object sender, EventArgs e)
        {
            Form1.CarregaBotoes(new TrocaPerfil());
            Form1.carregamenuESQ(new trocaMenuESQ());
            this.Close();
        }

        private void btnAssinarAnu_Click(object sender, EventArgs e)
        {
            Form1.CarregaBotoes(new TrocaPerfil());
            Form1.carregamenuESQ(new trocaMenuESQ());
            this.Close();
        }

        private void btnAssinarMen_Click(object sender, EventArgs e)
        {
            Form1.CarregaBotoes(new TrocaPerfil());
            Form1.carregamenuESQ(new trocaMenuESQ());
            this.Close();
        }



    }
}
