namespace pi_serasa_LinkeDev
{
    partial class TrocaPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocaPerfil));
            picturePerfilAssinante = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picturePerfilAssinante).BeginInit();
            SuspendLayout();
            // 
            // picturePerfilAssinante
            // 
            picturePerfilAssinante.Image = (Image)resources.GetObject("picturePerfilAssinante.Image");
            picturePerfilAssinante.Location = new Point(112, 0);
            picturePerfilAssinante.Name = "picturePerfilAssinante";
            picturePerfilAssinante.Size = new Size(93, 66);
            picturePerfilAssinante.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePerfilAssinante.TabIndex = 10;
            picturePerfilAssinante.TabStop = false;
            picturePerfilAssinante.Click += picturePerfilAssinante_Click;
            // 
            // TrocaPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 112, 254);
            ClientSize = new Size(315, 99);
            Controls.Add(picturePerfilAssinante);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrocaPerfil";
            Text = "TrocaPerfil";
            ((System.ComponentModel.ISupportInitialize)picturePerfilAssinante).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picturePerfilAssinante;
    }
}