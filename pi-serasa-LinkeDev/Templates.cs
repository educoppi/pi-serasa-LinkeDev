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




            //label posições
            lblPreco1.Location = new Point(ClientSize.Width - 110, ClientSize.Height - 480);
            lblSifrao1.Location = new Point(ClientSize.Width - 140, ClientSize.Height - 478);
            lblValor.Location = new Point(ClientSize.Width - 190, ClientSize.Height - 476);
            lblDescricao.Location = new Point(ClientSize.Width - 190, ClientSize.Height - 380);
            lblDescricaoTXT.Location = new Point(ClientSize.Width - 190, ClientSize.Height - 350);

            lblSifrao2.Location = new Point(ClientSize.Width - 180, ClientSize.Height - 210);
            lblPreco2.Location = new Point(ClientSize.Width - 140, ClientSize.Height - 210);

            lblNumeroVendido.Location = new Point(ClientSize.Width - 350, ClientSize.Height - 476);
            lblVendido.Location = new Point(ClientSize.Width - 430, ClientSize.Height - 476);

            //label conteúdo
            lblProdutoTXT.Text = Program.servico.nome;
            lblProgamadorTXT.Text = Program.servico.nome_assinante;
            lblDescricaoTXT.Text = Program.servico.descricao;
            lblNumeroVendido.Text = (Program.servico.vendidos).ToString();
            lblPreco1.Text = (Program.servico.valor).ToString();
            lblPreco2.Text = (Program.servico.valor).ToString();

            //imagens
            imagem1.LoadAsync(Program.servico.imagem_1);
            imagem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imagem2.LoadAsync(Program.servico.imagem_2);
            imagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imagem3.LoadAsync(Program.servico.imagem_3);
            imagem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("comprado");
        }
    }
}
