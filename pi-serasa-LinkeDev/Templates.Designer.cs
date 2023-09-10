namespace pi_serasa_LinkeDev
{
    partial class Templates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProduto = new Label();
            lblProdutoTXT = new Label();
            lblProgamador = new Label();
            lblProgamadorTXT = new Label();
            lblDescricao = new Label();
            lblDescricaoTXT = new Label();
            lblValor = new Label();
            lblPreco1 = new Label();
            btnComprar = new WiLBiT.WiLBiTButton();
            lblVendido = new Label();
            lblNumeroVendido = new Label();
            lblPreco2 = new Label();
            lblSifrao1 = new Label();
            lblSifrao2 = new Label();
            btnFechar = new WiLBiT.WiLBiTButton();
            imagem1 = new PictureBox();
            imagem2 = new PictureBox();
            imagem3 = new PictureBox();
            imagemPerfil = new PictureBox();
            lblCurtidas = new Label();
            lblNumeroCurtidas = new Label();
            lblFavoritados = new Label();
            lblNumeroFavoritados = new Label();
            btnCurtir = new Button();
            btnFavoritar = new Button();
            lblDesfazerCurtida = new Label();
            lblPublicadoEm = new Label();
            ((System.ComponentModel.ISupportInitialize)imagem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagemPerfil).BeginInit();
            SuspendLayout();
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProduto.ForeColor = Color.White;
            lblProduto.Location = new Point(355, 12);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(92, 25);
            lblProduto.TabIndex = 0;
            lblProduto.Text = "Produto:";
            // 
            // lblProdutoTXT
            // 
            lblProdutoTXT.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProdutoTXT.ForeColor = Color.White;
            lblProdutoTXT.Location = new Point(443, 12);
            lblProdutoTXT.Name = "lblProdutoTXT";
            lblProdutoTXT.Size = new Size(149, 63);
            lblProdutoTXT.TabIndex = 1;
            // 
            // lblProgamador
            // 
            lblProgamador.AutoSize = true;
            lblProgamador.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblProgamador.ForeColor = Color.White;
            lblProgamador.Location = new Point(118, 9);
            lblProgamador.Name = "lblProgamador";
            lblProgamador.Size = new Size(131, 25);
            lblProgamador.TabIndex = 2;
            lblProgamador.Text = "Progamador:";
            // 
            // lblProgamadorTXT
            // 
            lblProgamadorTXT.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblProgamadorTXT.ForeColor = Color.White;
            lblProgamadorTXT.Location = new Point(118, 36);
            lblProgamadorTXT.Name = "lblProgamadorTXT";
            lblProgamadorTXT.Size = new Size(231, 73);
            lblProgamadorTXT.TabIndex = 3;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescricao.ForeColor = Color.White;
            lblDescricao.Location = new Point(807, 187);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(88, 21);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição:";
            // 
            // lblDescricaoTXT
            // 
            lblDescricaoTXT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescricaoTXT.ForeColor = Color.White;
            lblDescricaoTXT.Location = new Point(715, 222);
            lblDescricaoTXT.Name = "lblDescricaoTXT";
            lblDescricaoTXT.Size = new Size(173, 102);
            lblDescricaoTXT.TabIndex = 5;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblValor.ForeColor = Color.White;
            lblValor.Location = new Point(612, 81);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(50, 20);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor:";
            // 
            // lblPreco1
            // 
            lblPreco1.AutoSize = true;
            lblPreco1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPreco1.ForeColor = Color.White;
            lblPreco1.Location = new Point(682, 73);
            lblPreco1.Name = "lblPreco1";
            lblPreco1.Size = new Size(0, 30);
            lblPreco1.TabIndex = 7;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.FromArgb(72, 116, 245);
            btnComprar.BorderColor = Color.Black;
            btnComprar.BorderRadius = 9;
            btnComprar.BorderSize = 2;
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(612, 30);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(98, 40);
            btnComprar.TabIndex = 8;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // lblVendido
            // 
            lblVendido.AutoSize = true;
            lblVendido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblVendido.ForeColor = Color.White;
            lblVendido.Location = new Point(431, 103);
            lblVendido.Name = "lblVendido";
            lblVendido.Size = new Size(77, 20);
            lblVendido.TabIndex = 9;
            lblVendido.Text = "Vendidos:";
            // 
            // lblNumeroVendido
            // 
            lblNumeroVendido.AutoSize = true;
            lblNumeroVendido.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroVendido.ForeColor = Color.White;
            lblNumeroVendido.Location = new Point(511, 104);
            lblNumeroVendido.Name = "lblNumeroVendido";
            lblNumeroVendido.Size = new Size(0, 20);
            lblNumeroVendido.TabIndex = 11;
            // 
            // lblPreco2
            // 
            lblPreco2.AutoSize = true;
            lblPreco2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPreco2.ForeColor = Color.White;
            lblPreco2.Location = new Point(716, 401);
            lblPreco2.Name = "lblPreco2";
            lblPreco2.Size = new Size(0, 40);
            lblPreco2.TabIndex = 12;
            // 
            // lblSifrao1
            // 
            lblSifrao1.AutoSize = true;
            lblSifrao1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSifrao1.ForeColor = Color.White;
            lblSifrao1.Location = new Point(656, 76);
            lblSifrao1.Name = "lblSifrao1";
            lblSifrao1.Size = new Size(33, 25);
            lblSifrao1.TabIndex = 16;
            lblSifrao1.Text = "R$";
            // 
            // lblSifrao2
            // 
            lblSifrao2.AutoSize = true;
            lblSifrao2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblSifrao2.ForeColor = Color.White;
            lblSifrao2.Location = new Point(682, 401);
            lblSifrao2.Name = "lblSifrao2";
            lblSifrao2.Size = new Size(50, 40);
            lblSifrao2.TabIndex = 17;
            lblSifrao2.Text = "R$";
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(72, 116, 245);
            btnFechar.BorderColor = Color.FromArgb(72, 116, 245);
            btnFechar.BorderRadius = 6;
            btnFechar.BorderSize = 0;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(750, 9);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(38, 30);
            btnFechar.TabIndex = 22;
            btnFechar.Text = " X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // imagem1
            // 
            imagem1.Location = new Point(12, 122);
            imagem1.Name = "imagem1";
            imagem1.Size = new Size(296, 174);
            imagem1.TabIndex = 24;
            imagem1.TabStop = false;
            // 
            // imagem2
            // 
            imagem2.Location = new Point(12, 313);
            imagem2.Name = "imagem2";
            imagem2.Size = new Size(296, 174);
            imagem2.TabIndex = 25;
            imagem2.TabStop = false;
            // 
            // imagem3
            // 
            imagem3.Location = new Point(323, 222);
            imagem3.Name = "imagem3";
            imagem3.Size = new Size(301, 174);
            imagem3.TabIndex = 26;
            imagem3.TabStop = false;
            // 
            // imagemPerfil
            // 
            imagemPerfil.Location = new Point(12, 9);
            imagemPerfil.Name = "imagemPerfil";
            imagemPerfil.Size = new Size(100, 92);
            imagemPerfil.TabIndex = 27;
            imagemPerfil.TabStop = false;
            imagemPerfil.Click += imagemPerfil_Click;
            // 
            // lblCurtidas
            // 
            lblCurtidas.AutoSize = true;
            lblCurtidas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurtidas.ForeColor = Color.White;
            lblCurtidas.Location = new Point(437, 138);
            lblCurtidas.Name = "lblCurtidas";
            lblCurtidas.Size = new Size(71, 20);
            lblCurtidas.TabIndex = 28;
            lblCurtidas.Text = "Curtidas:";
            // 
            // lblNumeroCurtidas
            // 
            lblNumeroCurtidas.AutoSize = true;
            lblNumeroCurtidas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroCurtidas.ForeColor = Color.White;
            lblNumeroCurtidas.Location = new Point(504, 138);
            lblNumeroCurtidas.Name = "lblNumeroCurtidas";
            lblNumeroCurtidas.Size = new Size(0, 20);
            lblNumeroCurtidas.TabIndex = 29;
            // 
            // lblFavoritados
            // 
            lblFavoritados.AutoSize = true;
            lblFavoritados.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFavoritados.ForeColor = Color.White;
            lblFavoritados.Location = new Point(409, 169);
            lblFavoritados.Name = "lblFavoritados";
            lblFavoritados.Size = new Size(95, 20);
            lblFavoritados.TabIndex = 30;
            lblFavoritados.Text = "Favoritados:";
            // 
            // lblNumeroFavoritados
            // 
            lblNumeroFavoritados.AutoSize = true;
            lblNumeroFavoritados.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNumeroFavoritados.ForeColor = Color.White;
            lblNumeroFavoritados.Location = new Point(500, 169);
            lblNumeroFavoritados.Name = "lblNumeroFavoritados";
            lblNumeroFavoritados.Size = new Size(0, 20);
            lblNumeroFavoritados.TabIndex = 31;
            // 
            // btnCurtir
            // 
            btnCurtir.BackColor = Color.FromArgb(72, 116, 245);
            btnCurtir.ForeColor = Color.White;
            btnCurtir.Location = new Point(612, 165);
            btnCurtir.Name = "btnCurtir";
            btnCurtir.Size = new Size(91, 43);
            btnCurtir.TabIndex = 32;
            btnCurtir.Text = "Curtir";
            btnCurtir.UseVisualStyleBackColor = false;
            btnCurtir.Click += btnCurtir_Click;
            // 
            // btnFavoritar
            // 
            btnFavoritar.BackColor = Color.FromArgb(72, 116, 245);
            btnFavoritar.ForeColor = Color.White;
            btnFavoritar.Location = new Point(612, 235);
            btnFavoritar.Name = "btnFavoritar";
            btnFavoritar.Size = new Size(91, 43);
            btnFavoritar.TabIndex = 33;
            btnFavoritar.Text = "Favoritar";
            btnFavoritar.UseVisualStyleBackColor = false;
            btnFavoritar.Click += btnFavoritar_Click;
            // 
            // lblDesfazerCurtida
            // 
            lblDesfazerCurtida.AutoSize = true;
            lblDesfazerCurtida.Enabled = false;
            lblDesfazerCurtida.ForeColor = Color.White;
            lblDesfazerCurtida.Location = new Point(723, 177);
            lblDesfazerCurtida.Name = "lblDesfazerCurtida";
            lblDesfazerCurtida.Size = new Size(51, 15);
            lblDesfazerCurtida.TabIndex = 34;
            lblDesfazerCurtida.Text = "Desfazer";
            lblDesfazerCurtida.Visible = false;
            lblDesfazerCurtida.Click += lblDesfazerCurtida_Click;
            // 
            // lblPublicadoEm
            // 
            lblPublicadoEm.AutoSize = true;
            lblPublicadoEm.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPublicadoEm.ForeColor = Color.White;
            lblPublicadoEm.Location = new Point(431, 55);
            lblPublicadoEm.Name = "lblPublicadoEm";
            lblPublicadoEm.Size = new Size(103, 20);
            lblPublicadoEm.TabIndex = 35;
            lblPublicadoEm.Text = "publicado em";
            // 
            // Templates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(900, 552);
            Controls.Add(lblPublicadoEm);
            Controls.Add(lblDesfazerCurtida);
            Controls.Add(btnFavoritar);
            Controls.Add(btnCurtir);
            Controls.Add(lblNumeroFavoritados);
            Controls.Add(lblFavoritados);
            Controls.Add(lblNumeroCurtidas);
            Controls.Add(lblCurtidas);
            Controls.Add(imagemPerfil);
            Controls.Add(imagem3);
            Controls.Add(imagem2);
            Controls.Add(imagem1);
            Controls.Add(btnFechar);
            Controls.Add(lblSifrao2);
            Controls.Add(lblSifrao1);
            Controls.Add(lblPreco2);
            Controls.Add(lblNumeroVendido);
            Controls.Add(lblVendido);
            Controls.Add(btnComprar);
            Controls.Add(lblPreco1);
            Controls.Add(lblValor);
            Controls.Add(lblDescricaoTXT);
            Controls.Add(lblDescricao);
            Controls.Add(lblProgamadorTXT);
            Controls.Add(lblProgamador);
            Controls.Add(lblProdutoTXT);
            Controls.Add(lblProduto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Templates";
            Text = "Templates";
            Load += Templates_Load;
            ((System.ComponentModel.ISupportInitialize)imagem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagemPerfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduto;
        private Label lblProdutoTXT;
        private Label lblProgamador;
        private Label lblProgamadorTXT;
        private Label lblDescricao;
        private Label lblDescricaoTXT;
        private Label lblValor;
        private Label lblPreco1;
        private WiLBiT.WiLBiTButton btnComprar;
        private Label lblVendido;
        private Label lblNumeroVendido;
        private Label lblPreco2;
        private Label lblSifrao1;
        private Label lblSifrao2;
        private WiLBiT.WiLBiTButton btnFechar;
        private PictureBox imagem1;
        private PictureBox imagem2;
        private PictureBox imagem3;
        private PictureBox imagemPerfil;
        private Label lblCurtidas;
        private Label lblNumeroCurtidas;
        private Label lblFavoritados;
        private Label lblNumeroFavoritados;
        private Button btnCurtir;
        private Button btnFavoritar;
        private Label lblDesfazerCurtida;
        private Label lblPublicadoEm;
    }
}