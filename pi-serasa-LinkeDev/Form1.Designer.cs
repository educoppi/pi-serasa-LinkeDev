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
            this.wilBitPanel1 = new WiLBiT.WiLBiTPanel();
            this.wilBitGradientPanel1 = new WiLBiT.WiLBiTGradientPanel();
            this.wilBitPanel2 = new WiLBiT.WiLBiTPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wilBitPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // wilBitPanel1
            // 
            this.wilBitPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.wilBitPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wilBitPanel1.BorderRadius = 6;
            this.wilBitPanel1.BorderSize = 0;
            this.wilBitPanel1.ForeColor = System.Drawing.Color.White;
            this.wilBitPanel1.Location = new System.Drawing.Point(0, -2);
            this.wilBitPanel1.Name = "wilBitPanel1";
            this.wilBitPanel1.Size = new System.Drawing.Size(801, 91);
            this.wilBitPanel1.TabIndex = 0;
            // 
            // wilBitGradientPanel1
            // 
            this.wilBitGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.wilBitGradientPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wilBitGradientPanel1.BorderRadius = 6;
            this.wilBitGradientPanel1.BorderSize = 0;
            this.wilBitGradientPanel1.ForeColor = System.Drawing.Color.White;
            this.wilBitGradientPanel1.Location = new System.Drawing.Point(180, 95);
            this.wilBitGradientPanel1.Name = "wilBitGradientPanel1";
            this.wilBitGradientPanel1.Size = new System.Drawing.Size(595, 343);
            this.wilBitGradientPanel1.TabIndex = 2;
            // 
            // wilBitPanel2
            // 
            this.wilBitPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(116)))), ((int)(((byte)(245)))));
            this.wilBitPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wilBitPanel2.BorderRadius = 6;
            this.wilBitPanel2.BorderSize = 0;
            this.wilBitPanel2.Controls.Add(this.label3);
            this.wilBitPanel2.Controls.Add(this.label2);
            this.wilBitPanel2.Controls.Add(this.label1);
            this.wilBitPanel2.Controls.Add(this.button1);
            this.wilBitPanel2.ForeColor = System.Drawing.Color.White;
            this.wilBitPanel2.Location = new System.Drawing.Point(12, 95);
            this.wilBitPanel2.Name = "wilBitPanel2";
            this.wilBitPanel2.Size = new System.Drawing.Size(135, 343);
            this.wilBitPanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mensal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Anual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Semestral";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wilBitGradientPanel1);
            this.Controls.Add(this.wilBitPanel2);
            this.Controls.Add(this.wilBitPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.wilBitPanel2.ResumeLayout(false);
            this.wilBitPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private WiLBiT.WiLBiTPanel wilBitPanel1;
        private WiLBiT.WiLBiTGradientPanel wilBitGradientPanel1;
        private WiLBiT.WiLBiTPanel wilBitPanel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}