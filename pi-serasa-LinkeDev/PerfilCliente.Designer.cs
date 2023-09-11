namespace pi_serasa_LinkeDev
{
    partial class PerfilCliente
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
            picturePerfil = new PictureBox();
            labelNome = new Label();
            lblFavoritos = new Label();
            label4 = new Label();
            descricao = new Label();
            btnFechar = new WiLBiT.WiLBiTButton();
            panelEditar = new Panel();
            btnEditar2 = new Button();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtImagemIcone = new TextBox();
            txtEditDescricao = new TextBox();
            txtEditNome = new TextBox();
            lblComprados = new Label();
            btnEditar = new WiLBiT.WiLBiTButton();
            panelFavoritos = new Panel();
            lblFavoritosNull = new Label();
            panelComprados = new Panel();
            lblFechar = new Label();
            ((System.ComponentModel.ISupportInitialize)picturePerfil).BeginInit();
            panelEditar.SuspendLayout();
            panelFavoritos.SuspendLayout();
            SuspendLayout();
            // 
            // picturePerfil
            // 
            picturePerfil.BackColor = Color.White;
            picturePerfil.Location = new Point(319, 12);
            picturePerfil.Name = "picturePerfil";
            picturePerfil.Size = new Size(131, 104);
            picturePerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePerfil.TabIndex = 10;
            picturePerfil.TabStop = false;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.ForeColor = Color.White;
            labelNome.Location = new Point(358, 111);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(0, 21);
            labelNome.TabIndex = 13;
            labelNome.Click += labelNome_Click;
            // 
            // lblFavoritos
            // 
            lblFavoritos.AutoSize = true;
            lblFavoritos.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblFavoritos.ForeColor = Color.White;
            lblFavoritos.Location = new Point(51, 332);
            lblFavoritos.Name = "lblFavoritos";
            lblFavoritos.Size = new Size(109, 32);
            lblFavoritos.TabIndex = 16;
            lblFavoritos.Text = "Favoritos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 22);
            label4.Name = "label4";
            label4.Size = new Size(112, 30);
            label4.TabIndex = 17;
            label4.Text = "Descrição:";
            // 
            // descricao
            // 
            descricao.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            descricao.ForeColor = Color.White;
            descricao.Location = new Point(130, 27);
            descricao.Name = "descricao";
            descricao.Size = new Size(228, 113);
            descricao.TabIndex = 18;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(72, 116, 245);
            btnFechar.BorderColor = Color.FromArgb(72, 116, 245);
            btnFechar.BorderRadius = 6;
            btnFechar.BorderSize = 0;
            btnFechar.FlatAppearance.BorderSize = 0;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.ForeColor = Color.White;
            btnFechar.Location = new Point(702, 22);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(60, 40);
            btnFechar.TabIndex = 19;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // panelEditar
            // 
            panelEditar.BackColor = Color.FromArgb(49, 57, 60);
            panelEditar.Controls.Add(lblFechar);
            panelEditar.Controls.Add(btnEditar2);
            panelEditar.Controls.Add(label5);
            panelEditar.Controls.Add(label3);
            panelEditar.Controls.Add(label1);
            panelEditar.Controls.Add(txtImagemIcone);
            panelEditar.Controls.Add(txtEditDescricao);
            panelEditar.Controls.Add(txtEditNome);
            panelEditar.ForeColor = Color.White;
            panelEditar.Location = new Point(402, 205);
            panelEditar.Name = "panelEditar";
            panelEditar.Size = new Size(324, 311);
            panelEditar.TabIndex = 19;
            panelEditar.Visible = false;
            // 
            // btnEditar2
            // 
            btnEditar2.BackColor = Color.FromArgb(72, 116, 245);
            btnEditar2.FlatAppearance.BorderSize = 0;
            btnEditar2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnEditar2.Location = new Point(122, 265);
            btnEditar2.Name = "btnEditar2";
            btnEditar2.Size = new Size(80, 35);
            btnEditar2.TabIndex = 24;
            btnEditar2.Text = "Editar";
            btnEditar2.UseVisualStyleBackColor = false;
            btnEditar2.Click += btnEditar2_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 9);
            label5.Name = "label5";
            label5.Size = new Size(79, 30);
            label5.TabIndex = 23;
            label5.Text = "Nome:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 164);
            label3.Name = "label3";
            label3.Size = new Size(278, 62);
            label3.TabIndex = 22;
            label3.Text = "Insira um endereço de imagem (utilize o imgur):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 85);
            label1.Name = "label1";
            label1.Size = new Size(112, 30);
            label1.TabIndex = 21;
            label1.Text = "Descrição:";
            // 
            // txtImagemIcone
            // 
            txtImagemIcone.Location = new Point(32, 234);
            txtImagemIcone.Name = "txtImagemIcone";
            txtImagemIcone.Size = new Size(258, 23);
            txtImagemIcone.TabIndex = 2;
            // 
            // txtEditDescricao
            // 
            txtEditDescricao.Location = new Point(32, 123);
            txtEditDescricao.Name = "txtEditDescricao";
            txtEditDescricao.Size = new Size(258, 23);
            txtEditDescricao.TabIndex = 1;
            // 
            // txtEditNome
            // 
            txtEditNome.Location = new Point(30, 45);
            txtEditNome.Name = "txtEditNome";
            txtEditNome.Size = new Size(258, 23);
            txtEditNome.TabIndex = 0;
            // 
            // lblComprados
            // 
            lblComprados.AutoSize = true;
            lblComprados.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblComprados.ForeColor = Color.White;
            lblComprados.Location = new Point(456, 96);
            lblComprados.Name = "lblComprados";
            lblComprados.Size = new Size(170, 30);
            lblComprados.TabIndex = 15;
            lblComprados.Text = "Itens Comprados";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(72, 116, 245);
            btnEditar.BorderColor = Color.FromArgb(72, 116, 245);
            btnEditar.BorderRadius = 6;
            btnEditar.BorderSize = 0;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(620, 53);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(50, 40);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // panelFavoritos
            // 
            panelFavoritos.BackColor = Color.FromArgb(49, 57, 60);
            panelFavoritos.Controls.Add(lblFavoritosNull);
            panelFavoritos.Location = new Point(51, 522);
            panelFavoritos.Name = "panelFavoritos";
            panelFavoritos.Size = new Size(473, 268);
            panelFavoritos.TabIndex = 29;
            // 
            // lblFavoritosNull
            // 
            lblFavoritosNull.AutoSize = true;
            lblFavoritosNull.ForeColor = Color.White;
            lblFavoritosNull.Location = new Point(104, 141);
            lblFavoritosNull.Name = "lblFavoritosNull";
            lblFavoritosNull.Size = new Size(254, 15);
            lblFavoritosNull.TabIndex = 0;
            lblFavoritosNull.Text = "Os serviços que você favoritar aparecerão aqui!";
            // 
            // panelComprados
            // 
            panelComprados.BackColor = Color.FromArgb(49, 57, 60);
            panelComprados.Location = new Point(415, 157);
            panelComprados.Name = "panelComprados";
            panelComprados.Size = new Size(473, 372);
            panelComprados.TabIndex = 30;
            // 
            // lblFechar
            // 
            lblFechar.AutoSize = true;
            lblFechar.Font = new Font("Segoe UI", 20.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblFechar.ForeColor = Color.IndianRed;
            lblFechar.Location = new Point(286, 4);
            lblFechar.Name = "lblFechar";
            lblFechar.Size = new Size(35, 38);
            lblFechar.TabIndex = 30;
            lblFechar.Text = "X";
            lblFechar.Click += lblFechar_Click;
            // 
            // PerfilCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(1094, 788);
            Controls.Add(panelEditar);
            Controls.Add(panelComprados);
            Controls.Add(panelFavoritos);
            Controls.Add(btnEditar);
            Controls.Add(lblFavoritos);
            Controls.Add(lblComprados);
            Controls.Add(btnFechar);
            Controls.Add(descricao);
            Controls.Add(label4);
            Controls.Add(labelNome);
            Controls.Add(picturePerfil);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PerfilCliente";
            Text = "PerfilCliente";
            Load += PerfilCliente_Load;
            ((System.ComponentModel.ISupportInitialize)picturePerfil).EndInit();
            panelEditar.ResumeLayout(false);
            panelEditar.PerformLayout();
            panelFavoritos.ResumeLayout(false);
            panelFavoritos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picturePerfil;
        private Label labelNome;
        private Label lblFavoritos;
        private Label label4;
        private Label descricao;
        private WiLBiT.WiLBiTButton btnFechar;
        private Label lblComprados;
        private WiLBiT.WiLBiTButton btnEditar;
        private Panel panelEditar;
        private Button btnEditar2;
        private Label label5;
        private Label label3;
        private Label label1;
        private TextBox txtImagemIcone;
        private TextBox txtEditDescricao;
        private TextBox txtEditNome;
        private Panel panelFavoritos;
        private Label lblFavoritosNull;
        private Panel panelComprados;
        private Label lblFechar;
    }
}