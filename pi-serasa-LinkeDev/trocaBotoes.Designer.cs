namespace pi_serasa_LinkeDev
{
    partial class trocaBotoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trocaBotoes));
            btnAssine = new WiLBiT.WiLBiTButton();
            picturePerfil = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picturePerfil).BeginInit();
            SuspendLayout();
            // 
            // btnAssine
            // 
            btnAssine.BackColor = Color.FromArgb(49, 57, 60);
            btnAssine.BorderColor = Color.Black;
            btnAssine.BorderRadius = 20;
            btnAssine.BorderSize = 2;
            btnAssine.FlatAppearance.BorderSize = 0;
            btnAssine.FlatStyle = FlatStyle.Flat;
            btnAssine.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnAssine.ForeColor = Color.White;
            btnAssine.Location = new Point(38, 6);
            btnAssine.Name = "btnAssine";
            btnAssine.Size = new Size(119, 46);
            btnAssine.TabIndex = 8;
            btnAssine.Text = "Assine Já";
            btnAssine.UseVisualStyleBackColor = false;
            btnAssine.Click += btnAssine_Click;
            // 
            // picturePerfil
            // 
            picturePerfil.Image = (Image)resources.GetObject("picturePerfil.Image");
            picturePerfil.Location = new Point(163, 6);
            picturePerfil.Name = "picturePerfil";
            picturePerfil.Size = new Size(100, 62);
            picturePerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePerfil.TabIndex = 9;
            picturePerfil.TabStop = false;
            picturePerfil.Click += picturePerfil_Click;
            // 
            // trocaBotoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 112, 254);
            ClientSize = new Size(326, 101);
            Controls.Add(picturePerfil);
            Controls.Add(btnAssine);
            FormBorderStyle = FormBorderStyle.None;
            Name = "trocaBotoes";
            Text = "trocaBotoes";
            Load += trocaBotoes_Load;
            ((System.ComponentModel.ISupportInitialize)picturePerfil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private WiLBiT.WiLBiTButton btnAssine;
        private PictureBox picturePerfil;
    }
}