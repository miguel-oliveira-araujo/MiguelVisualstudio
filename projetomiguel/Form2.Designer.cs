namespace projetomiguel
{
    partial class frm2
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
            this.lblc = new System.Windows.Forms.Label();
            this.lbll = new System.Windows.Forms.Label();
            this.lblt = new System.Windows.Forms.Label();
            this.txtc = new System.Windows.Forms.TextBox();
            this.txtl = new System.Windows.Forms.TextBox();
            this.txtt = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(63, 72);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(274, 16);
            this.lblc.TabIndex = 0;
            this.lblc.Text = "digite o combustivel ( g= gasolina, a= alcool):";
            // 
            // lbll
            // 
            this.lbll.AutoSize = true;
            this.lbll.Location = new System.Drawing.Point(63, 120);
            this.lbll.Name = "lbll";
            this.lbll.Size = new System.Drawing.Size(129, 16);
            this.lbll.TabIndex = 1;
            this.lbll.Text = "digite o total de litros";
            // 
            // lblt
            // 
            this.lblt.AutoSize = true;
            this.lblt.Location = new System.Drawing.Point(63, 160);
            this.lblt.Name = "lblt";
            this.lblt.Size = new System.Drawing.Size(35, 16);
            this.lblt.TabIndex = 2;
            this.lblt.Text = "total:";
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(343, 72);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(96, 22);
            this.txtc.TabIndex = 3;
            // 
            // txtl
            // 
            this.txtl.Location = new System.Drawing.Point(343, 120);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(96, 22);
            this.txtl.TabIndex = 4;
            // 
            // txtt
            // 
            this.txtt.Location = new System.Drawing.Point(104, 160);
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(96, 22);
            this.txtt.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(82, 237);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(76, 39);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(219, 237);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 39);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(329, 237);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 39);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtt);
            this.Controls.Add(this.txtl);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.lblt);
            this.Controls.Add(this.lbll);
            this.Controls.Add(this.lblc);
            this.Name = "frm2";
            this.Text = "Combustível";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lbll;
        private System.Windows.Forms.Label lblt;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.TextBox txtt;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}