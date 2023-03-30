namespace projetomiguel
{
    partial class frm4
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
            this.lbln = new System.Windows.Forms.Label();
            this.lblr = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.txtr = new System.Windows.Forms.TextBox();
            this.btnw = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.btndowhile = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.Location = new System.Drawing.Point(259, 70);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(308, 16);
            this.lbln.TabIndex = 0;
            this.lbln.Text = "escolha o número que você quer saber a tabuada:";
            // 
            // lblr
            // 
            this.lblr.AutoSize = true;
            this.lblr.Location = new System.Drawing.Point(259, 118);
            this.lblr.Name = "lblr";
            this.lblr.Size = new System.Drawing.Size(66, 16);
            this.lblr.TabIndex = 1;
            this.lblr.Text = "rseultado:";
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(564, 67);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(84, 22);
            this.txtn.TabIndex = 2;
            // 
            // txtr
            // 
            this.txtr.Location = new System.Drawing.Point(564, 112);
            this.txtr.Multiline = true;
            this.txtr.Name = "txtr";
            this.txtr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtr.Size = new System.Drawing.Size(93, 103);
            this.txtr.TabIndex = 5;
            // 
            // btnw
            // 
            this.btnw.Location = new System.Drawing.Point(223, 257);
            this.btnw.Name = "btnw";
            this.btnw.Size = new System.Drawing.Size(129, 32);
            this.btnw.TabIndex = 8;
            this.btnw.Text = "calcular while";
            this.btnw.UseVisualStyleBackColor = true;
            this.btnw.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(387, 257);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(108, 32);
            this.btnfor.TabIndex = 9;
            this.btnfor.Text = "calcular for";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btndowhile
            // 
            this.btndowhile.Location = new System.Drawing.Point(530, 257);
            this.btndowhile.Name = "btndowhile";
            this.btndowhile.Size = new System.Drawing.Size(139, 32);
            this.btndowhile.TabIndex = 10;
            this.btndowhile.Text = "calcular do while";
            this.btndowhile.UseVisualStyleBackColor = true;
            this.btndowhile.Click += new System.EventHandler(this.btndowhile_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(70, 192);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 11;
            this.btnvoltar.Text = "voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(70, 234);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 12;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // frm4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btndowhile);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btnw);
            this.Controls.Add(this.txtr);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.lblr);
            this.Controls.Add(this.lbln);
            this.Name = "frm4";
            this.Text = "tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbln;
        private System.Windows.Forms.Label lblr;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.TextBox txtr;
        private System.Windows.Forms.Button btnw;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btndowhile;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
    }
}