namespace Locadora
{
    partial class MenuPrincipal
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
            this.controleDaContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPerfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alugarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarLocaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleDaContaToolStripMenuItem,
            this.locaçãoToolStripMenuItem,
            this.encerrarSessãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // controleDaContaToolStripMenuItem
            // 
            this.controleDaContaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDadosToolStripMenuItem,
            this.editarPerfToolStripMenuItem,
            this.excluirPerfilToolStripMenuItem});
            this.controleDaContaToolStripMenuItem.Name = "controleDaContaToolStripMenuItem";
            this.controleDaContaToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.controleDaContaToolStripMenuItem.Text = "Perfil";
            // 
            // verDadosToolStripMenuItem
            // 
            this.verDadosToolStripMenuItem.Name = "verDadosToolStripMenuItem";
            this.verDadosToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.verDadosToolStripMenuItem.Text = "Ver";
            this.verDadosToolStripMenuItem.Click += new System.EventHandler(this.verDadosToolStripMenuItem_Click);
            // 
            // editarPerfToolStripMenuItem
            // 
            this.editarPerfToolStripMenuItem.Name = "editarPerfToolStripMenuItem";
            this.editarPerfToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.editarPerfToolStripMenuItem.Text = "Editar";
            this.editarPerfToolStripMenuItem.Click += new System.EventHandler(this.editarPerfToolStripMenuItem_Click);
            // 
            // excluirPerfilToolStripMenuItem
            // 
            this.excluirPerfilToolStripMenuItem.Name = "excluirPerfilToolStripMenuItem";
            this.excluirPerfilToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.excluirPerfilToolStripMenuItem.Text = "Excluir";
            this.excluirPerfilToolStripMenuItem.Click += new System.EventHandler(this.excluirPerfilToolStripMenuItem_Click);
            // 
            // locaçãoToolStripMenuItem
            // 
            this.locaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alugarToolStripMenuItem,
            this.listarLocaçõesToolStripMenuItem});
            this.locaçãoToolStripMenuItem.Name = "locaçãoToolStripMenuItem";
            this.locaçãoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.locaçãoToolStripMenuItem.Text = "Locação";
            // 
            // alugarToolStripMenuItem
            // 
            this.alugarToolStripMenuItem.Name = "alugarToolStripMenuItem";
            this.alugarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.alugarToolStripMenuItem.Text = "Alugar Veiculo";
            this.alugarToolStripMenuItem.Click += new System.EventHandler(this.alugarToolStripMenuItem_Click);
            // 
            // listarLocaçõesToolStripMenuItem
            // 
            this.listarLocaçõesToolStripMenuItem.Name = "listarLocaçõesToolStripMenuItem";
            this.listarLocaçõesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.listarLocaçõesToolStripMenuItem.Text = "Listar Alugueis";
            this.listarLocaçõesToolStripMenuItem.Click += new System.EventHandler(this.listarLocaçõesToolStripMenuItem_Click);
            // 
            // encerrarSessãoToolStripMenuItem
            // 
            this.encerrarSessãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.encerrarSessãoToolStripMenuItem.Name = "encerrarSessãoToolStripMenuItem";
            this.encerrarSessãoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.encerrarSessãoToolStripMenuItem.Text = "Sessão";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(496, 417);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal   -   MovementCar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem controleDaContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPerfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alugarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarLocaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encerrarSessãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}