namespace TrabalhoTPA
{
    partial class frmEx4
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.lblproduto = new System.Windows.Forms.Label();
            this.lblescolha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblfinal = new System.Windows.Forms.Label();
            this.txtescolha = new System.Windows.Forms.TextBox();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.btnexibir = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(201, 32);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(101, 150);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "CÓDIGO\r\n\r\n    100\r\n    101\r\n    102\r\n    103";
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpreco.Location = new System.Drawing.Point(506, 32);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(100, 150);
            this.lblpreco.TabIndex = 2;
            this.lblpreco.Text = "PREÇO\r\n\r\n25,00R$\r\n15,00R$\r\n35,00R$\r\n47,00R$";
            // 
            // lblproduto
            // 
            this.lblproduto.AutoSize = true;
            this.lblproduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduto.Location = new System.Drawing.Point(308, 32);
            this.lblproduto.Name = "lblproduto";
            this.lblproduto.Size = new System.Drawing.Size(192, 150);
            this.lblproduto.TabIndex = 3;
            this.lblproduto.Text = "    PRODUTO\r\n\r\nCachorro-Quente\r\n        Baurú\r\n    X - Burguer\r\nTriplo X-Burguer";
            // 
            // lblescolha
            // 
            this.lblescolha.AutoSize = true;
            this.lblescolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblescolha.Location = new System.Drawing.Point(175, 225);
            this.lblescolha.Name = "lblescolha";
            this.lblescolha.Size = new System.Drawing.Size(249, 24);
            this.lblescolha.TabIndex = 4;
            this.lblescolha.Text = "Digite o código desejado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfinal.Location = new System.Drawing.Point(175, 271);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(228, 24);
            this.lblfinal.TabIndex = 6;
            this.lblfinal.Text = "O pedido escolhido foi:";
            // 
            // txtescolha
            // 
            this.txtescolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtescolha.Location = new System.Drawing.Point(430, 225);
            this.txtescolha.Name = "txtescolha";
            this.txtescolha.Size = new System.Drawing.Size(204, 29);
            this.txtescolha.TabIndex = 7;
            // 
            // txtfinal
            // 
            this.txtfinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfinal.Location = new System.Drawing.Point(409, 268);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.ReadOnly = true;
            this.txtfinal.Size = new System.Drawing.Size(339, 29);
            this.txtfinal.TabIndex = 8;
            // 
            // btnexibir
            // 
            this.btnexibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexibir.Location = new System.Drawing.Point(224, 334);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(112, 39);
            this.btnexibir.TabIndex = 9;
            this.btnexibir.Text = "Exibir";
            this.btnexibir.UseVisualStyleBackColor = true;
            this.btnexibir.Click += new System.EventHandler(this.btnexibir_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(364, 334);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(112, 39);
            this.btnlimpar.TabIndex = 10;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(503, 334);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(112, 39);
            this.btnvoltar.TabIndex = 11;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmEx4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.txtescolha);
            this.Controls.Add(this.lblfinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblescolha);
            this.Controls.Add(this.lblproduto);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lblcodigo);
            this.Name = "frmEx4";
            this.Text = "Exercício 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Label lblproduto;
        private System.Windows.Forms.Label lblescolha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfinal;
        private System.Windows.Forms.TextBox txtescolha;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.Button btnexibir;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}