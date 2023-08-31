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
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }
        void Atualiza()
        {
            WindowState = FormWindowState.Maximized;

            panelSup.Location = new Point(0, -2);
            panelSup.Size = new Size(ClientSize.Width, 94);
           
            panelCentral.Size = new Size(ClientSize.Width - panelEsquerdo.Width - 70, ClientSize.Height - panelSup.Height - 40);
            perfil.Location = new Point(ClientSize.Width - 90,19);
            btnAssine.Location = new Point(ClientSize.Width - 290, 30);

            imgLogo.Size = new Size(125, 115);
            imgLogo.Location = new Point(25, -9);

            imgLogoALO.Location = new Point(ClientSize.Width - 1120, 10);
            
        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Inicial_Load(object sender, EventArgs e)
        {
           Atualiza();
        }

        private void perfil_Click(object sender, EventArgs e)
        {

        }
    }
}
