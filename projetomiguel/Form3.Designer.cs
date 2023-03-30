namespace projetomiguel
{
    partial class frm3
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
            this.lblv = new System.Windows.Forms.Label();
            this.txtv = new System.Windows.Forms.TextBox();
            this.txtr = new System.Windows.Forms.TextBox();
            this.btnvotar = new System.Windows.Forms.Button();
            this.btnencerrar = new System.Windows.Forms.Button();
            this.btnr = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblv
            // 
            this.lblv.AutoSize = true;
            this.lblv.Location = new System.Drawing.Point(36, 75);
            this.lblv.Name = "lblv";
            this.lblv.Size = new System.Drawing.Size(392, 16);
            this.lblv.TabIndex = 0;
            this.lblv.Text = "Votar.1 = José da Silva, 2 = Maria Juruma e 3 = João da Tapioca.";
            // 
            // txtv
            // 
            this.txtv.Location = new System.Drawing.Point(447, 75);
            this.txtv.Name = "txtv";
            this.txtv.Size = new System.Drawing.Size(198, 22);
            this.txtv.TabIndex = 1;
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(200, 254);
            this.txtr.Name = "txtr";
            this.txtr.Size = new System.Drawing.Size(228, 22);
            this.txtr.TabIndex = 2;
            // 
            // btnvotar
            // 
            this.btnvotar.Location = new System.Drawing.Point(295, 162);
            this.btnvotar.Name = "btnvotar";
            this.btnvotar.Size = new System.Drawing.Size(79, 26);
            this.btnvotar.TabIndex = 3;
            this.btnvotar.Text = "vote";
            this.btnvotar.UseVisualStyleBackColor = true;
            this.btnvotar.Click += new System.EventHandler(this.btnvotar_Click);
            // 
            // btnencerrar
            // 
            this.btnencerrar.Location = new System.Drawing.Point(240, 294);
            this.btnencerrar.Name = "btnencerrar";
            this.btnencerrar.Size = new System.Drawing.Size(95, 33);
            this.btnencerrar.TabIndex = 4;
            this.btnencerrar.Text = "encerrar";
            this.btnencerrar.UseVisualStyleBackColor = true;
            this.btnencerrar.Click += new System.EventHandler(this.btnencerrar_Click);
            // 
            // btnr
            // 
            this.btnr.Location = new System.Drawing.Point(362, 294);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(86, 37);
            this.btnr.TabIndex = 5;
            this.btnr.Text = "reiniciar";
            this.btnr.UseVisualStyleBackColor = true;
            this.btnr.Click += new System.EventHandler(this.btnr_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(479, 294);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(77, 37);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.btnencerrar);
            this.Controls.Add(this.btnvotar);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.txtv);
            this.Controls.Add(this.lblv);
            this.Name = "frm3";
            this.Text = "votação";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblv;
        private System.Windows.Forms.TextBox txtv;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.Button btnvotar;
        private System.Windows.Forms.Button btnencerrar;
        private System.Windows.Forms.Button btnr;
        private System.Windows.Forms.Button btnvoltar;
    }
}