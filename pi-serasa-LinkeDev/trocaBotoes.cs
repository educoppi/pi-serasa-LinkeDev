﻿using System;
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

        }

        private void btnAssine_Click(object sender, EventArgs e)
        {
            
        }

        private void trocaBotoes_Load_1(object sender, EventArgs e)
        {
            if (Program.usuario.isAssinante)
            {
                btnAssine.Enabled = false;
                btnAssine.Visible = false;
                picturePerfil.LoadAsync(Program.assinante.imagem_icon);
                picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
            else
            {
                btnAssine.Enabled = true;
                btnAssine.Visible = true;
                picturePerfil.LoadAsync(Program.cliente.imagem_icon);
                picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnAssine_Click_1(object sender, EventArgs e)
        {
            Program.sinalizador = true;
            Form1.CarregaEntreTELAS(new Assinar());
        }

        private void picturePerfil_Click_1(object sender, EventArgs e)
        {
            if (Program.usuario.isAssinante)
            {
                Assinante assinante = new Assinante();
                Program.assinante = assinante.retornaAssinante(Program.usuario.id);

                Form1.CarregaEntreTELAS(new PerfilAssinante());
            }
            else
            {
                Cliente cliente = new Cliente();
                Program.cliente = cliente.retornaCliente(Program.usuario.id);

                Form1.CarregaEntreTELAS(new PerfilCliente());
            }
        }
    }
}
