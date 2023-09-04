namespace pi_serasa_LinkeDev
{
    partial class Formtroca1
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
            this.perfil = new WiLBiT.WiLBiTButton();
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
            this.btnAssine.Location = new System.Drawing.Point(2, 12);
            this.btnAssine.Name = "btnAssine";
            this.btnAssine.Size = new System.Drawing.Size(166, 44);
            this.btnAssine.TabIndex = 8;
            this.btnAssine.Text = "Assine Já";
            this.btnAssine.UseVisualStyleBackColor = false;
            // 
            // perfil
            // 
            this.perfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(57)))), ((int)(((byte)(60)))));
            this.perfil.BorderColor = System.Drawing.Color.Black;
            this.perfil.BorderRadius = 33;
            this.perfil.BorderSize = 0;
            this.perfil.FlatAppearance.BorderSize = 0;
            this.perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.perfil.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.perfil.ForeColor = System.Drawing.Color.White;
            this.perfil.Location = new System.Drawing.Point(174, 4);
            this.perfil.Name = "perfil";
            this.perfil.Size = new System.Drawing.Size(73, 67);
            this.perfil.TabIndex = 9;
            this.perfil.Text = "Perfil";
            this.perfil.UseVisualStyleBackColor = false;
            // 
            // Formtroca1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 76);
            this.Controls.Add(this.perfil);
            this.Controls.Add(this.btnAssine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formtroca1";
            this.Text = "Formtroca1";
            this.ResumeLayout(false);

        }

        #endregion

        private WiLBiT.WiLBiTButton btnAssine;
        private WiLBiT.WiLBiTButton perfil;
    }
}