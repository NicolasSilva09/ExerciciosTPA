namespace TrabalhoTPA
{
    partial class frmEx1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPublico = new System.Windows.Forms.Label();
            this.txtpublico = new System.Windows.Forms.TextBox();
            this.lblIngresso = new System.Windows.Forms.Label();
            this.txtingresso = new System.Windows.Forms.TextBox();
            this.lblsetor = new System.Windows.Forms.Label();
            this.txtSetor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPublico
            // 
            this.lblPublico.AutoSize = true;
            this.lblPublico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublico.Location = new System.Drawing.Point(12, 67);
            this.lblPublico.Name = "lblPublico";
            this.lblPublico.Size = new System.Drawing.Size(347, 25);
            this.lblPublico.TabIndex = 0;
            this.lblPublico.Text = "Escreva o Publico total do jogo:";
            // 
            // txtpublico
            // 
            this.txtpublico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpublico.Location = new System.Drawing.Point(365, 67);
            this.txtpublico.Name = "txtpublico";
            this.txtpublico.Size = new System.Drawing.Size(158, 31);
            this.txtpublico.TabIndex = 1;
            // 
            // lblIngresso
            // 
            this.lblIngresso.AutoSize = true;
            this.lblIngresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresso.Location = new System.Drawing.Point(12, 122);
            this.lblIngresso.Name = "lblIngresso";
            this.lblIngresso.Size = new System.Drawing.Size(300, 25);
            this.lblIngresso.TabIndex = 2;
            this.lblIngresso.Text = "Escreva o tipo de ingresso:";
            // 
            // txtingresso
            // 
            this.txtingresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtingresso.Location = new System.Drawing.Point(328, 116);
            this.txtingresso.Name = "txtingresso";
            this.txtingresso.Size = new System.Drawing.Size(158, 31);
            this.txtingresso.TabIndex = 3;
            // 
            // lblsetor
            // 
            this.lblsetor.AutoSize = true;
            this.lblsetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsetor.Location = new System.Drawing.Point(12, 217);
            this.lblsetor.Name = "lblsetor";
            this.lblsetor.Size = new System.Drawing.Size(259, 25);
            this.lblsetor.TabIndex = 4;
            this.lblsetor.Text = "A renda neste setor foi:";
            // 
            // txtSetor
            // 
            this.txtSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetor.Location = new System.Drawing.Point(277, 217);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.ReadOnly = true;
            this.txtSetor.Size = new System.Drawing.Size(158, 31);
            this.txtSetor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "A renda total do jogo foi:";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(290, 262);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(158, 31);
            this.txttotal.TabIndex = 7;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(492, 122);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(108, 80);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "1=popular\r\n2=geral\r\n3=cadeira\r\n4=arquibancada \r\n5=total";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(162, 368);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(109, 38);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(339, 368);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(109, 38);
            this.btnlimpar.TabIndex = 10;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(528, 368);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(109, 38);
            this.btnsair.TabIndex = 11;
            this.btnsair.Text = "Voltar";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // frmEx1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 468);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.lblsetor);
            this.Controls.Add(this.txtingresso);
            this.Controls.Add(this.lblIngresso);
            this.Controls.Add(this.txtpublico);
            this.Controls.Add(this.lblPublico);
            this.Name = "frmEx1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício1";
            this.Load += new System.EventHandler(this.frmEx1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPublico;
        private System.Windows.Forms.TextBox txtpublico;
        private System.Windows.Forms.Label lblIngresso;
        private System.Windows.Forms.TextBox txtingresso;
        private System.Windows.Forms.Label lblsetor;
        private System.Windows.Forms.TextBox txtSetor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
    }
}

