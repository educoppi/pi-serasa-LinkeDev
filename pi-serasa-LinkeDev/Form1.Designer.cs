namespace pi_serasa_LinkeDev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSup = new WiLBiT.WiLBiTPanel();
            panel1 = new System.Windows.Forms.Panel();
            this.btnEntrar = new WiLBiT.WiLBiTButton();
            this.btnCriar = new WiLBiT.WiLBiTButton();
            this.imgLogoALO = new System.Windows.Forms.PictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            panelCentral = new WiLBiT.WiLBiTGradientPanel();
            panelEsquerdo = new WiLBiT.WiLBiTPanel();
            this.wilBitButton3 = new WiLBiT.WiLBiTButton();
            this.wilBitButton2 = new WiLBiT.WiLBiTButton();
            this.label1 = new System.Windows.Forms.Label();
            this.wilBitButton4 = new WiLBiT.WiLBiTButton();
            this.btnAssine = new WiLBiT.WiLBiTButton();
            imgLogo2 = new System.Windows.Forms.PictureBox();
            p = new WiLBiT.WiLBiTPanel();
            panelSup.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoALO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            panelEsquerdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(imgLogo2)).BeginInit();
            p.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSup
            // 
            panelSup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            panelSup.BorderColor = System.Drawing.Color.PaleVioletRed;
            panelSup.BorderRadius = 6;
            panelSup.BorderSize = 0;
            panelSup.Controls.Add(panel1);
            panelSup.Controls.Add(this.imgLogoALO);
            panelSup.Controls.Add(this.imgLogo);
            panelSup.ForeColor = System.Drawing.Color.White;
            panelSup.Location = new System.Drawing.Point(0, -3);
            panelSup.Name = "panelSup";
            panelSup.Size = new System.Drawing.Size(801, 92);
            panelSup.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(this.btnEntrar);
            panel1.Controls.Add(this.btnCriar);
            panel1.Location = new System.Drawing.Point(562, 15);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(236, 73);
            panel1.TabIndex = 9;
            panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(127)))));
            this.btnEntrar.BorderColor = System.Drawing.Color.Black;
            this.btnEntrar.BorderRadius = 6;
            this.btnEntrar.BorderSize = 2;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(8, 16);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(84, 47);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(127)))));
            this.btnCriar.BorderColor = System.Drawing.Color.Black;
            this.btnCriar.BorderRadius = 6;
            this.btnCriar.BorderSize = 2;
            this.btnCriar.FlatAppearance.BorderSize = 0;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCriar.ForeColor = System.Drawing.Color.White;
            this.btnCriar.Location = new System.Drawing.Point(132, 16);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(84, 47);
            this.btnCriar.TabIndex = 5;
            this.btnCriar.Text = "Criar conta";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // imgLogoALO
            // 
            this.imgLogoALO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLogoALO.BackColor = System.Drawing.Color.Transparent;
            this.imgLogoALO.Image = ((System.Drawing.Image)(resources.GetObject("imgLogoALO.Image")));
            this.imgLogoALO.Location = new System.Drawing.Point(202, 15);
            this.imgLogoALO.Name = "imgLogoALO";
            this.imgLogoALO.Size = new System.Drawing.Size(296, 74);
            this.imgLogoALO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogoALO.TabIndex = 8;
            this.imgLogoALO.TabStop = false;
            this.imgLogoALO.Click += new System.EventHandler(this.imgLogoALO_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(3, 4);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(102, 85);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 7;
            this.imgLogo.TabStop = false;
            this.imgLogo.Click += new System.EventHandler(this.imgLogo_Click);
            // 
            // panelCentral
            // 
            panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(252)))));
            panelCentral.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(252)))));
            panelCentral.BorderColor = System.Drawing.Color.Black;
            panelCentral.BorderRadius = 6;
            panelCentral.BorderSize = 0;
            panelCentral.ForeColor = System.Drawing.Color.White;
            panelCentral.Location = new System.Drawing.Point(202, 110);
            panelCentral.Name = "panelCentral";
            panelCentral.Size = new System.Drawing.Size(573, 333);
            panelCentral.TabIndex = 2;
            panelCentral.Paint += new System.Windows.Forms.PaintEventHandler(this.wilBitGradientPanel1_Paint);
            // 
            // panelEsquerdo
            // 
            panelEsquerdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            panelEsquerdo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(252)))));
            panelEsquerdo.BorderRadius = 6;
            panelEsquerdo.BorderSize = 3;
            panelEsquerdo.Controls.Add(this.wilBitButton3);
            panelEsquerdo.Controls.Add(this.wilBitButton2);
            panelEsquerdo.Controls.Add(this.label1);
            panelEsquerdo.Controls.Add(this.wilBitButton4);
            panelEsquerdo.Controls.Add(this.btnAssine);
            panelEsquerdo.ForeColor = System.Drawing.Color.White;
            panelEsquerdo.Location = new System.Drawing.Point(3, 3);
            panelEsquerdo.Name = "panelEsquerdo";
            panelEsquerdo.Size = new System.Drawing.Size(171, 404);
            panelEsquerdo.TabIndex = 1;
            // 
            // wilBitButton3
            // 
            this.wilBitButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(159)))), ((int)(((byte)(255)))));
            this.wilBitButton3.BorderColor = System.Drawing.Color.Black;
            this.wilBitButton3.BorderRadius = 6;
            this.wilBitButton3.BorderSize = 2;
            this.wilBitButton3.FlatAppearance.BorderSize = 0;
            this.wilBitButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wilBitButton3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wilBitButton3.ForeColor = System.Drawing.Color.Black;
            this.wilBitButton3.Location = new System.Drawing.Point(15, 18);
            this.wilBitButton3.Name = "wilBitButton3";
            this.wilBitButton3.Size = new System.Drawing.Size(137, 54);
            this.wilBitButton3.TabIndex = 10;
            this.wilBitButton3.Text = "Mensal";
            this.wilBitButton3.UseVisualStyleBackColor = false;
            // 
            // wilBitButton2
            // 
            this.wilBitButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.wilBitButton2.BorderColor = System.Drawing.Color.Black;
            this.wilBitButton2.BorderRadius = 6;
            this.wilBitButton2.BorderSize = 2;
            this.wilBitButton2.FlatAppearance.BorderSize = 0;
            this.wilBitButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wilBitButton2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wilBitButton2.ForeColor = System.Drawing.Color.Black;
            this.wilBitButton2.Location = new System.Drawing.Point(15, 77);
            this.wilBitButton2.Name = "wilBitButton2";
            this.wilBitButton2.Size = new System.Drawing.Size(137, 54);
            this.wilBitButton2.TabIndex = 9;
            this.wilBitButton2.Text = "Semestral";
            this.wilBitButton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 110);
            this.label1.TabIndex = 8;
            this.label1.Text = "Assine para poder divulgar seus trabalhos, e trabalhar atraves do LinkeDev.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // wilBitButton4
            // 
            this.wilBitButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(90)))), ((int)(((byte)(204)))));
            this.wilBitButton4.BorderColor = System.Drawing.Color.Black;
            this.wilBitButton4.BorderRadius = 6;
            this.wilBitButton4.BorderSize = 2;
            this.wilBitButton4.FlatAppearance.BorderSize = 0;
            this.wilBitButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wilBitButton4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wilBitButton4.ForeColor = System.Drawing.Color.Black;
            this.wilBitButton4.Location = new System.Drawing.Point(15, 137);
            this.wilBitButton4.Name = "wilBitButton4";
            this.wilBitButton4.Size = new System.Drawing.Size(137, 54);
            this.wilBitButton4.TabIndex = 7;
            this.wilBitButton4.Text = "Anual";
            this.wilBitButton4.UseVisualStyleBackColor = false;
            // 
            // btnAssine
            // 
            this.btnAssine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(127)))));
            this.btnAssine.BorderColor = System.Drawing.Color.White;
            this.btnAssine.BorderRadius = 20;
            this.btnAssine.BorderSize = 2;
            this.btnAssine.FlatAppearance.BorderSize = 0;
            this.btnAssine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssine.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAssine.ForeColor = System.Drawing.Color.White;
            this.btnAssine.Location = new System.Drawing.Point(15, 211);
            this.btnAssine.Name = "btnAssine";
            this.btnAssine.Size = new System.Drawing.Size(137, 44);
            this.btnAssine.TabIndex = 4;
            this.btnAssine.Text = "Assine Já";
            this.btnAssine.UseVisualStyleBackColor = false;
            this.btnAssine.Click += new System.EventHandler(this.btnAssine_Click);
            // 
            // imgLogo2
            // 
            imgLogo2.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo2.Image")));
            imgLogo2.Location = new System.Drawing.Point(845, 153);
            imgLogo2.Name = "imgLogo2";
            imgLogo2.Size = new System.Drawing.Size(137, 320);
            imgLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            imgLogo2.TabIndex = 3;
            imgLogo2.TabStop = false;
            // 
            // p
            // 
            p.BackColor = System.Drawing.Color.Transparent;
            p.BorderColor = System.Drawing.Color.PaleVioletRed;
            p.BorderRadius = 6;
            p.BorderSize = 0;
            p.Controls.Add(panelEsquerdo);
            p.ForeColor = System.Drawing.Color.White;
            p.Location = new System.Drawing.Point(12, 107);
            p.Name = "p";
            p.Size = new System.Drawing.Size(184, 548);
            p.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1141, 667);
            this.Controls.Add(p);
            this.Controls.Add(imgLogo2);
            this.Controls.Add(panelCentral);
            this.Controls.Add(panelSup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            panelSup.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoALO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            panelEsquerdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(imgLogo2)).EndInit();
            p.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WiLBiT.WiLBiTPanel panelSup;
        private WiLBiT.WiLBiTButton btnEntrar;
        private WiLBiT.WiLBiTButton btnCriar;
        private WiLBiT.WiLBiTButton btnAssine;
        private PictureBox imgLogo;
        private PictureBox imgLogoALO;
        private Label label1;
        private WiLBiT.WiLBiTButton wilBitButton4;
        private WiLBiT.WiLBiTButton wilBitButton3;
        private WiLBiT.WiLBiTButton wilBitButton2;
        private static WiLBiT.WiLBiTGradientPanel panelCentral;
        private static WiLBiT.WiLBiTPanel p;
        public static PictureBox imgLogo2;
        public static WiLBiT.WiLBiTPanel panelEsquerdo;
        public static Panel panel1;
    }
}