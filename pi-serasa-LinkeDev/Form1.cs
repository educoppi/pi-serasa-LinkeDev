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
         //panel Superior
            panelSup.Location = new Point(0, -2);
            panelSup.Size = new Size(ClientSize.Width, 94);
        //botoes suepriores
            btnEntrar.Location = new Point(ClientSize.Width - 230, 25);
            btnCriar.Location = new Point(ClientSize.Width - 120, 25);
         //painel central
            panelCentral.Size = new Size(ClientSize.Width - panelEsquerdo.Width - 70, ClientSize.Height - panelSup.Height - 20);
        //logos
            imgLogo.Size = new Size(125,115);   
            imgLogo.Location = new Point(25, -9);

            imgLogoALO.Location = new Point(ClientSize.Width -1120, 10);
            imgLogo2.Location = new Point(ClientSize.Width - 1910, 540);

            



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            renderizaInterface();
        }

        private void wilBitGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
           
            EntrarC entrar = new EntrarC();
            entrar.Show();
            
           
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {


            CriarC criar1 = new CriarC();
            criar1.Show();
           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAssine_Click(object sender, EventArgs e)
        {

        }
    }
}