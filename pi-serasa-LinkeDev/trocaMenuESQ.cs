using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiLBiT;

namespace pi_serasa_LinkeDev
{
    public partial class trocaMenuESQ : Form
    {

        public trocaMenuESQ()
        {
            InitializeComponent();
        }

        private void panelEsquerdo2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void wilBitButton2_Click(object sender, EventArgs e)
        {

        }

        void atualizaCoordenadas()
        {
            x = 50;
            y = 30;
            quebraLinha = 0;
        }

        void carregaTemplates()
        {
            Servico servico = new Servico();
            List<Servico> servicos = new List<Servico>();
            servicos = servico.buscaImagensTemplates();

            foreach (Servico s in servicos)
            {
                geraimagens(s);
            }
        }

        int x = 50;
        int y = 30;
        int quebraLinha;
        void geraimagens(Servico servico)
        {

            PictureBox pic = new PictureBox();
            pic.LoadAsync(servico.imagem_1);
            pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pic.Size = new Size(350, 150);
            pic.Location = new Point(x, y);

            x = x + 380;
            quebraLinha++;
            Form1.panelCentral.Controls.Add(pic);


            //pic.MouseClick += new MouseEventHandler(pictureBox1_Click);//função utilizada anteriomente
            pic.MouseClick += new MouseEventHandler((o, a) => Program.servicoClicado(servico));//

            if (quebraLinha == 5)
            {
                x = 50;
                y = 300;
                pic.Location = new Point(x, y);
            }
        }

        public static void CarregaEntreTELAS(Form form)
        {

            form.TopLevel = false;
            Form1.panelCentral.Controls.Clear();
            Form1.panelCentral.Controls.Add(form);
            form.Location = new Point(Form1.panelCentral.Location.X - 202, Form1.panelCentral.Location.Y - 109);
            form.Size = new Size(Form1.panelCentral.Width, Form1.panelCentral.Height);
            form.Show();
        }

        private void wilBitButton12_Click(object sender, EventArgs e)
        {

        }

        private void wilBitButton11_Click(object sender, EventArgs e)
        {

        }

        private void wilBitButton3_Click(object sender, EventArgs e)
        {

        }

        private void wilBitButton5_Click(object sender, EventArgs e)
        {

        }

        private void wilBitButton1_Click(object sender, EventArgs e)
        {

        }

        private void wilBitButton4_Click(object sender, EventArgs e)
        {

        }

        private void wilBitButton8_Click(object sender, EventArgs e)
        {

        }





        //NOVO LOAD

        private void panelEsquerdo2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        //NOVOS BOTOES

        private void wilBitButton2_Click_1(object sender, EventArgs e)
        {

            Form1.panelCentral.Controls.Clear();
            atualizaCoordenadas();
            carregaTemplates();
        }

        private void wilBitButton12_Click_1(object sender, EventArgs e)
        {
            atualizaCoordenadas();
            Form1.panelCentral.Controls.Clear();
            Servico servico = new Servico();
            List<Servico> servicos = new List<Servico>();
            servicos = servico.buscaImagensMobile();

            foreach (Servico s in servicos)
            {
                geraimagens(s);
            }
        }

        private void wilBitButton11_Click_1(object sender, EventArgs e)
        {
            atualizaCoordenadas();
            Form1.panelCentral.Controls.Clear();
            Servico servico = new Servico();
            List<Servico> servicos = new List<Servico>();
            servicos = servico.buscaImagensWeb();

            foreach (Servico s in servicos)
            {
                geraimagens(s);
            }
        }

        private void wilBitButton3_Click_1(object sender, EventArgs e)
        {
            atualizaCoordenadas();
            Form1.panelCentral.Controls.Clear();
            Servico servico = new Servico();
            List<Servico> servicos = new List<Servico>();
            servicos = servico.buscaImagensGames();

            foreach (Servico s in servicos)
            {
                geraimagens(s);
            }
        }

        private void wilBitButton5_Click_1(object sender, EventArgs e)
        {
            atualizaCoordenadas();
            Form1.panelCentral.Controls.Clear();
            Servico servico = new Servico();
            List<Servico> servicos = new List<Servico>();
            servicos = servico.buscaImagensBancoDeDados();

            foreach (Servico s in servicos)
            {
                geraimagens(s);
            }
        }

        private void wilBitButton1_Click_1(object sender, EventArgs e)
        {
            atualizaCoordenadas();
            Form1.panelCentral.Controls.Clear();
            Servico servico = new Servico();
            List<Servico> servicos = new List<Servico>();
            servicos = servico.buscaImagensBackEnd();

            foreach (Servico s in servicos)
            {
                geraimagens(s);
            }
        }

        private void wilBitButton4_Click_1(object sender, EventArgs e)
        {
            atualizaCoordenadas();
            Form1.panelCentral.Controls.Clear();
            Servico servico = new Servico();
            List<Servico> servicos = new List<Servico>();
            servicos = servico.buscaImagensFrontEnd();

            foreach (Servico s in servicos)
            {
                geraimagens(s);
            }
        }

        private void wilBitButton8_Click_1(object sender, EventArgs e)
        {
            atualizaCoordenadas();
            Form1.panelCentral.Controls.Clear();
            Servico servico = new Servico();
            List<Servico> servicos = new List<Servico>();
            servicos = servico.buscaImagensFullStack();

            foreach (Servico s in servicos)
            {
                geraimagens(s);
            }
        }

        private void wilBitButton9_Click(object sender, EventArgs e)
        {
            atualizaCoordenadas();
            Form1.panelCentral.Controls.Clear();
            Servico servico = new Servico();
            List<Servico> servicos = new List<Servico>();
            servicos = servico.buscaImagensDesktop();

            foreach (Servico s in servicos)
            {
                geraimagens(s);
            }
        }
    }
}
