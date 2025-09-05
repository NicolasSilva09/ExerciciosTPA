namespace TrabalhoTPA
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício1ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício1ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercíciosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exercíciosToolStripMenuItem
            // 
            this.exercíciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercício1ToolStripMenuItem,
            this.exercício1ToolStripMenuItem2,
            this.exercício1ToolStripMenuItem3,
            this.exercício1ToolStripMenuItem4,
            this.exercício5ToolStripMenuItem});
            this.exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            this.exercíciosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.exercíciosToolStripMenuItem.Text = "Exercícios";
            // 
            // exercício1ToolStripMenuItem
            // 
            this.exercício1ToolStripMenuItem.Name = "exercício1ToolStripMenuItem";
            this.exercício1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercício1ToolStripMenuItem.Text = "Exercício1";
            this.exercício1ToolStripMenuItem.Click += new System.EventHandler(this.exercício1ToolStripMenuItem_Click);
            // 
            // exercício1ToolStripMenuItem2
            // 
            this.exercício1ToolStripMenuItem2.Name = "exercício1ToolStripMenuItem2";
            this.exercício1ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.exercício1ToolStripMenuItem2.Text = "Exercício2";
            this.exercício1ToolStripMenuItem2.Click += new System.EventHandler(this.exercício1ToolStripMenuItem2_Click);
            // 
            // exercício1ToolStripMenuItem3
            // 
            this.exercício1ToolStripMenuItem3.Name = "exercício1ToolStripMenuItem3";
            this.exercício1ToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.exercício1ToolStripMenuItem3.Text = "Exercício3";
            this.exercício1ToolStripMenuItem3.Click += new System.EventHandler(this.exercício1ToolStripMenuItem3_Click);
            // 
            // exercício1ToolStripMenuItem4
            // 
            this.exercício1ToolStripMenuItem4.Name = "exercício1ToolStripMenuItem4";
            this.exercício1ToolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.exercício1ToolStripMenuItem4.Text = "Exercício4";
            this.exercício1ToolStripMenuItem4.Click += new System.EventHandler(this.exercício1ToolStripMenuItem4_Click);
            // 
            // exercício5ToolStripMenuItem
            // 
            this.exercício5ToolStripMenuItem.Name = "exercício5ToolStripMenuItem";
            this.exercício5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercício5ToolStripMenuItem.Text = "Exercício5";
            this.exercício5ToolStripMenuItem.Click += new System.EventHandler(this.exercício5ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exercício1ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exercício1ToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem exercício5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}