using System;

namespace pi_serasa_LinkeDev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void renderizaInterface()
        {

            WindowState = FormWindowState.Maximized;
          
            panelSup.Location = new Point(0, -2);
            panelSup.Size = new Size(ClientSize.Width, 94);
            btnEntrar.Location = new Point(ClientSize.Width - 230, 25);
            btnCriar.Location = new Point(ClientSize.Width - 120, 25);

            panelCentral.Size = new Size(ClientSize.Width - panelEsquerdo.Width - 70, ClientSize.Height - panelSup.Height - 20);
            //panelEsquerdo.Size = new Size(panelEsquerdo.Width, ClientSize.Height - panelSup.Height - 20);

            imgLogo.Size = new Size(125,115);   
            imgLogo.Location = new Point(25, -9);

            imgLogoALO.Location = new Point(ClientSize.Width -1120, 10);
            imgLogo2.Location = new Point(ClientSize.Width - 1910, 540);
        }
        private void wilBitButton3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            renderizaInterface();
        }

        private void wilBitGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCriar_Click(object sender, EventArgs e)
        {

            CriarC criar1 = new CriarC();
            criar1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wilBitButton1_Click(object sender, EventArgs e)
        {

        }
    }
}