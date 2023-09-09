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
            carregaImagens();
        }

        void carregaImagens()
        {
            Servico servico = new Servico();
            List<Servico> servicos = new List<Servico>();
            servicos = servico.buscaImagensTemplates();

            foreach (Servico s in servicos)
            {
                geraTemplates(s);
            }
        }

        int x = 50;
        int y = 30;
        int quebraLinha;
        void geraTemplates(Servico servico)
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
            pic.MouseClick += new MouseEventHandler((o, a) => servicoClicado(servico));//

            if (quebraLinha == 5)
            {
                x = 50;
                y = 300;
                pic.Location = new Point(x, y);
            }
        }

        void servicoClicado(Servico servico)
        {
            Program.servico = servico;
            CarregaEntreTELAS(new Templates());
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
    }
}
