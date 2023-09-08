namespace pi_serasa_LinkeDev
{
    partial class lkJatenho1
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
            panelC = new WiLBiT.WiLBiTGradientPanel();
            btnEntrar_LG = new WiLBiT.WiLBiTGradientButton();
            label3 = new Label();
            label2 = new Label();
            txtSenha_LG = new WiLBiT.WiLBiTTextBox();
            txtEmail_LG = new WiLBiT.WiLBiTTextBox();
            label1 = new Label();
            btnFechar = new WiLBiT.WiLBiTButton();
            panelC.SuspendLayout();
            SuspendLayout();
            // 
            // panelC
            // 
            panelC.BackColor = Color.FromArgb(18, 112, 254);
            panelC.BackColor2 = Color.FromArgb(18, 112, 254);
            panelC.BorderColor = Color.Black;
            panelC.BorderRadius = 6;
            panelC.BorderSize = 4;
            panelC.Controls.Add(btnEntrar_LG);
            panelC.Controls.Add(label3);
            panelC.Controls.Add(label2);
            panelC.Controls.Add(txtSenha_LG);
            panelC.Controls.Add(txtEmail_LG);
            panelC.Controls.Add(label1);
            panelC.ForeColor = Color.White;
            panelC.Location = new Point(215, 71);
            panelC.Name = "panelC";
            panelC.Size = new Size(371, 308);
            panelC.TabIndex = 1;
            panelC.Paint += panelC_Paint;
            // 
            // btnEntrar_LG
            // 
            btnEntrar_LG.BackColor = Color.FromArgb(49, 57, 60);
            btnEntrar_LG.BackColor2 = Color.FromArgb(49, 57, 60);
            btnEntrar_LG.BorderColor = Color.Black;
            btnEntrar_LG.BorderRadius = 6;
            btnEntrar_LG.BorderSize = 2;
            btnEntrar_LG.FlatAppearance.BorderSize = 0;
            btnEntrar_LG.FlatStyle = FlatStyle.Flat;
            btnEntrar_LG.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar_LG.ForeColor = Color.White;
            btnEntrar_LG.Location = new Point(117, 240);
            btnEntrar_LG.Name = "btnEntrar_LG";
            btnEntrar_LG.Size = new Size(150, 40);
            btnEntrar_LG.TabIndex = 5;
            btnEntrar_LG.Text = "Entrar";
            btnEntrar_LG.TextAlign = ContentAlignment.MiddleCenter;
            btnEntrar_LG.UseVisualStyleBackColor = true;
            btnEntrar_LG.Click += btnEntrar_LG_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(63, 141);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 4;
            label3.Text = "Senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(63, 73);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 3;
            label2.Text = "Email:";
            // 
            // txtSenha_LG
            // 
            txtSenha_LG.BackColor = SystemColors.Window;
            txtSenha_LG.BorderColor = Color.FromArgb(64, 64, 64);
            txtSenha_LG.BorderFocusColor = Color.Black;
            txtSenha_LG.BorderRadius = 4;
            txtSenha_LG.BorderSize = 2;
            txtSenha_LG.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha_LG.ForeColor = Color.FromArgb(64, 64, 64);
            txtSenha_LG.Location = new Point(63, 165);
            txtSenha_LG.Margin = new Padding(4);
            txtSenha_LG.Multiline = false;
            txtSenha_LG.Name = "txtSenha_LG";
            txtSenha_LG.Padding = new Padding(10, 7, 10, 7);
            txtSenha_LG.PasswordChar = false;
            txtSenha_LG.PlaceholderColor = Color.DarkGray;
            txtSenha_LG.PlaceholderText = "";
            txtSenha_LG.Size = new Size(250, 29);
            txtSenha_LG.TabIndex = 2;
            txtSenha_LG.Texts = "";
            txtSenha_LG.UnderlinedStyle = false;
            // 
            // txtEmail_LG
            // 
            txtEmail_LG.BackColor = SystemColors.Window;
            txtEmail_LG.BorderColor = Color.FromArgb(64, 64, 64);
            txtEmail_LG.BorderFocusColor = Color.Black;
            txtEmail_LG.BorderRadius = 4;
            txtEmail_LG.BorderSize = 2;
            txtEmail_LG.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail_LG.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail_LG.Location = new Point(63, 92);
            txtEmail_LG.Margin = new Padding(4);
            txtEmail_LG.Multiline = false;
            txtEmail_LG.Name = "txtEmail_LG";
            txtEmail_LG.Padding = new Padding(10, 7, 10, 7);
            txtEmail_LG.PasswordChar = false;
            txtEmail_LG.PlaceholderColor = Color.DarkGray;
            txtEmail_LG.PlaceholderText = "";
            txtEmail_LG.Size = new Size(250, 29);
            txtEmail_LG.TabIndex = 1;
            txtEmail_LG.Texts = "";
            txtEmail_LG.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(117, 25);
            label1.Name = "label1";
            label1.Size = new Size(136, 37);
            label1.TabIndex = 0;
            label1.Text = "Seu login";
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
            btnFechar.Location = new Point(710, 37);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(60, 40);
            btnFechar.TabIndex = 21;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lkJatenho1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 57, 60);
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(panelC);
            FormBorderStyle = FormBorderStyle.None;
            Name = "lkJatenho1";
            Text = "lkJatenho1";
            Load += lkJatenho1_Load;
            panelC.ResumeLayout(false);
            panelC.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private WiLBiT.WiLBiTGradientPanel panelC;
        private WiLBiT.WiLBiTGradientButton btnEntrar_LG;
        private Label label3;
        private Label label2;
        private WiLBiT.WiLBiTTextBox txtSenha_LG;
        private WiLBiT.WiLBiTTextBox txtEmail_LG;
        private Label label1;
        private WiLBiT.WiLBiTButton btnFechar;
    }
}