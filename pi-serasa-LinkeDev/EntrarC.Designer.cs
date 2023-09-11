namespace pi_serasa_LinkeDev
{
    partial class EntrarC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntrarC));
            this.panelC = new WiLBiT.WiLBiTGradientPanel();
            this.btnFechar = new WiLBiT.WiLBiTButton();
            this.btnEntrar_LG = new WiLBiT.WiLBiTGradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha_LG = new WiLBiT.WiLBiTTextBox();
            this.txtEmail_LG = new WiLBiT.WiLBiTTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgLogoE = new System.Windows.Forms.PictureBox();
            this.panelC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoE)).BeginInit();
            this.SuspendLayout();
            // 
            // panelC
            // 
            this.panelC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.panelC.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.panelC.BorderColor = System.Drawing.Color.Black;
            this.panelC.BorderRadius = 6;
            this.panelC.BorderSize = 4;
            this.panelC.Controls.Add(this.btnFechar);
            this.panelC.Controls.Add(this.btnEntrar_LG);
            this.panelC.Controls.Add(this.label3);
            this.panelC.Controls.Add(this.label2);
            this.panelC.Controls.Add(this.txtSenha_LG);
            this.panelC.Controls.Add(this.txtEmail_LG);
            this.panelC.Controls.Add(this.label1);
            this.panelC.ForeColor = System.Drawing.Color.White;
            this.panelC.Location = new System.Drawing.Point(227, 62);
            this.panelC.Name = "panelC";
            this.panelC.Size = new System.Drawing.Size(371, 308);
            this.panelC.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.btnFechar.BorderColor = System.Drawing.Color.Black;
            this.btnFechar.BorderRadius = 6;
            this.btnFechar.BorderSize = 2;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(299, 22);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(60, 40);
            this.btnFechar.TabIndex = 20;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // btnEntrar_LG
            // 
            this.btnEntrar_LG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.btnEntrar_LG.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.btnEntrar_LG.BorderColor = System.Drawing.Color.Black;
            this.btnEntrar_LG.BorderRadius = 6;
            this.btnEntrar_LG.BorderSize = 2;
            this.btnEntrar_LG.FlatAppearance.BorderSize = 0;
            this.btnEntrar_LG.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEntrar_LG.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar_LG.ForeColor = System.Drawing.Color.White;
            this.btnEntrar_LG.Location = new System.Drawing.Point(117, 240);
            this.btnEntrar_LG.Name = "btnEntrar_LG";
            this.btnEntrar_LG.Size = new System.Drawing.Size(150, 40);
            this.btnEntrar_LG.TabIndex = 5;
            this.btnEntrar_LG.Text = "Entrar";
            this.btnEntrar_LG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEntrar_LG.UseVisualStyleBackColor = true;
            this.btnEntrar_LG.Click += new System.EventHandler(this.btnEntrar_LG_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(63, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // txtSenha_LG
            // 
            this.txtSenha_LG.BackColor = System.Drawing.SystemColors.Window;
            this.txtSenha_LG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha_LG.BorderFocusColor = System.Drawing.Color.Black;
            this.txtSenha_LG.BorderRadius = 4;
            this.txtSenha_LG.BorderSize = 2;
            this.txtSenha_LG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenha_LG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSenha_LG.Location = new System.Drawing.Point(63, 165);
            this.txtSenha_LG.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha_LG.Multiline = false;
            this.txtSenha_LG.Name = "txtSenha_LG";
            this.txtSenha_LG.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSenha_LG.PasswordChar = false;
            this.txtSenha_LG.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSenha_LG.PlaceholderText = "";
            this.txtSenha_LG.Size = new System.Drawing.Size(250, 29);
            this.txtSenha_LG.TabIndex = 2;
            this.txtSenha_LG.Texts = "adm2";
            this.txtSenha_LG.UnderlinedStyle = false;
            // 
            // txtEmail_LG
            // 
            this.txtEmail_LG.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail_LG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail_LG.BorderFocusColor = System.Drawing.Color.Black;
            this.txtEmail_LG.BorderRadius = 4;
            this.txtEmail_LG.BorderSize = 2;
            this.txtEmail_LG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail_LG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail_LG.Location = new System.Drawing.Point(63, 92);
            this.txtEmail_LG.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail_LG.Multiline = false;
            this.txtEmail_LG.Name = "txtEmail_LG";
            this.txtEmail_LG.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail_LG.PasswordChar = false;
            this.txtEmail_LG.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail_LG.PlaceholderText = "";
            this.txtEmail_LG.Size = new System.Drawing.Size(250, 29);
            this.txtEmail_LG.TabIndex = 1;
            this.txtEmail_LG.Texts = "adm2";
            this.txtEmail_LG.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(117, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seu login";
            // 
            // imgLogoE
            // 
            this.imgLogoE.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoE.Image")));
            this.imgLogoE.Location = new System.Drawing.Point(732, 171);
            this.imgLogoE.Name = "imgLogoE";
            this.imgLogoE.Size = new System.Drawing.Size(133, 283);
            this.imgLogoE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogoE.TabIndex = 7;
            this.imgLogoE.TabStop = false;
            // 
            // EntrarC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1172, 624);
            this.Controls.Add(this.imgLogoE);
            this.Controls.Add(this.panelC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EntrarC";
            this.Text = "EntrarC";
            this.Load += new System.EventHandler(this.EntrarC_Load_1);
            this.panelC.ResumeLayout(false);
            this.panelC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WiLBiT.WiLBiTGradientPanel panelC;
        private Label label1;
        private WiLBiT.WiLBiTGradientButton btnEntrar_LG;
        private Label label3;
        private Label label2;
        private WiLBiT.WiLBiTTextBox txtSenha_LG;
        private WiLBiT.WiLBiTTextBox txtEmail_LG;
        private PictureBox imgLogoE;
        private WiLBiT.WiLBiTButton btnFechar;
    }
}