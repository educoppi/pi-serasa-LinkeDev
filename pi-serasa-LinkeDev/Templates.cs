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
    public partial class Templates : Form
    {
        public Templates()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.CarregaEntreTELAS(new PerfilCliente());
        }

        private void picturePerfil_Click(object sender, EventArgs e)
        {
            Form1.CarregaEntreTELAS(new PerfilAssinante());


        }

        private void Templates_Load(object sender, EventArgs e)
        {
            //botao
            btnFechar.Location = new Point(ClientSize.Width - 80, ClientSize.Height - 570);
            btnComprar.Location = new Point(ClientSize.Width - 190, ClientSize.Height - 530);




            //label
            lblPreco1.Location = new Point(ClientSize.Width - 110, ClientSize.Height - 480);
            lblSifrao1.Location = new Point(ClientSize.Width - 140, ClientSize.Height - 478);
            lblValor.Location = new Point(ClientSize.Width - 190, ClientSize.Height - 476);
            lblDescricao.Location = new Point(ClientSize.Width - 190, ClientSize.Height - 380);
            lblDescricaoTXT.Location = new Point(ClientSize.Width - 190, ClientSize.Height - 350);

            lblSifrao2.Location = new Point(ClientSize.Width - 180, ClientSize.Height - 210);
            lblPreco2.Location = new Point(ClientSize.Width - 140, ClientSize.Height - 210);

            lblNumeroVendido.Location = new Point(ClientSize.Width - 350, ClientSize.Height - 476);
            lblVendido.Location = new Point(ClientSize.Width - 430, ClientSize.Height - 476);
            lblRecomendado.Location = new Point(ClientSize.Width - 560, ClientSize.Height - 476);


            //panel
            panel4.Location = new Point(ClientSize.Width - 550, ClientSize.Height - 456);
            panel1.Location = new Point(ClientSize.Width - 1050, ClientSize.Height - 456);
            panel3.Location = new Point(ClientSize.Width - 780, ClientSize.Height - 200);
            panel2.Location = new Point(ClientSize.Width - 1050, ClientSize.Height - 200);

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("comprado");
        }
    }
}
