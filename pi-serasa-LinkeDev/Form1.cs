using System.Windows.Forms;

namespace pi_serasa_LinkeDev
{
    public partial class Form1 : Form
    {
        private object botaoEntrarAssinar;

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
            panel1.Location = new Point(ClientSize.Width - 230, 10);
           // btnCriar.Location = new Point(ClientSize.Width - 120, 25);
         //painel central
            panelCentral.Size = new Size(ClientSize.Width - panelEsquerdo.Width - 70, ClientSize.Height - panelSup.Height - 20);
        //logos
            imgLogo.Size = new Size(125,115);   
            imgLogo.Location = new Point(25, -9);

            imgLogoALO.Location = new Point(ClientSize.Width -1120, 10);
            imgLogo2.Location = new Point(ClientSize.Width - 1910, 540);

            



        }
      
        void CarregaBotoes(Form form)
        {
            form.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(form);
            form.Location = new Point(panel1.Width - 260, 22);
            
            form.Show();
        }
        void CarregaEntreTELAS(Form form)
        {
            form.TopLevel = false;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(form);
            form.Location = new Point(panelCentral.Location.X-193  , panelCentral.Location.Y-94) ;
            form.Size = new Size(panelCentral.Width, panelCentral.Height);
            form.Show();
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
            CarregaEntreTELAS(new EntrarC());
          
         



        }

        private void btnCriar_Click(object sender, EventArgs e)
        {


            CarregaEntreTELAS(new CriarC());
           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAssine_Click(object sender, EventArgs e)
        {
           

            CarregaEntreTELAS(new AssinarBTN());

            
        }

       public  void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}