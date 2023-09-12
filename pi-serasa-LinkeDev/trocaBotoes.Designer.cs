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
            this.btnAssine = new WiLBiT.WiLBiTButton();
            this.picturePerfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAssine
            // 
            this.btnAssine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.btnAssine.BorderColor = System.Drawing.Color.Black;
            this.btnAssine.BorderRadius = 20;
            this.btnAssine.BorderSize = 2;
            this.btnAssine.FlatAppearance.BorderSize = 0;
            this.btnAssine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssine.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAssine.ForeColor = System.Drawing.Color.White;
            this.btnAssine.Location = new System.Drawing.Point(38, 6);
            this.btnAssine.Name = "btnAssine";
            this.btnAssine.Size = new System.Drawing.Size(119, 46);
            this.btnAssine.TabIndex = 8;
            this.btnAssine.Text = "Assine Já";
            this.btnAssine.UseVisualStyleBackColor = false;
            this.btnAssine.Click += new System.EventHandler(this.btnAssine_Click_1);
            // 
            // picturePerfil
            // 
            this.picturePerfil.Location = new System.Drawing.Point(163, -3);
            this.picturePerfil.Name = "picturePerfil";
            this.picturePerfil.Size = new System.Drawing.Size(78, 71);
            this.picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePerfil.TabIndex = 9;
            this.picturePerfil.TabStop = false;
            this.picturePerfil.Click += new System.EventHandler(this.picturePerfil_Click_1);
            // 
            // trocaBotoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(112)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(326, 101);
            this.Controls.Add(this.picturePerfil);
            this.Controls.Add(this.btnAssine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "trocaBotoes";
            this.Text = "trocaBotoes";
            this.Load += new System.EventHandler(this.trocaBotoes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WiLBiT.WiLBiTButton btnAssine;
        private PictureBox picturePerfil;
    }
}