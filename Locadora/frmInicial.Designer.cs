namespace Locadora
{
    partial class frmInicial
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
            this.lbbemvindo = new System.Windows.Forms.Label();
            this.btnNovoUsuario = new System.Windows.Forms.Button();
            this.btnFazerLogin = new System.Windows.Forms.Button();
            this.btnSairInicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbbemvindo
            // 
            this.lbbemvindo.AutoSize = true;
            this.lbbemvindo.BackColor = System.Drawing.Color.Transparent;
            this.lbbemvindo.Font = new System.Drawing.Font("Gabriola", 25.25F);
            this.lbbemvindo.Location = new System.Drawing.Point(122, 40);
            this.lbbemvindo.Name = "lbbemvindo";
            this.lbbemvindo.Size = new System.Drawing.Size(243, 189);
            this.lbbemvindo.TabIndex = 0;
            this.lbbemvindo.Text = "Bem - vindo \r\nLocadora de Veículos\r\nMovementCar";
            this.lbbemvindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNovoUsuario
            // 
            this.btnNovoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoUsuario.Location = new System.Drawing.Point(12, 12);
            this.btnNovoUsuario.Name = "btnNovoUsuario";
            this.btnNovoUsuario.Size = new System.Drawing.Size(90, 40);
            this.btnNovoUsuario.TabIndex = 1;
            this.btnNovoUsuario.Text = "Novo Usuário";
            this.btnNovoUsuario.UseVisualStyleBackColor = false;
            this.btnNovoUsuario.Click += new System.EventHandler(this.btnNovoUsuario_Click);
            // 
            // btnFazerLogin
            // 
            this.btnFazerLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnFazerLogin.Location = new System.Drawing.Point(381, 12);
            this.btnFazerLogin.Name = "btnFazerLogin";
            this.btnFazerLogin.Size = new System.Drawing.Size(90, 40);
            this.btnFazerLogin.TabIndex = 2;
            this.btnFazerLogin.Text = "Fazer Login";
            this.btnFazerLogin.UseVisualStyleBackColor = false;
            this.btnFazerLogin.Click += new System.EventHandler(this.btnFazerLogin_Click);
            // 
            // btnSairInicial
            // 
            this.btnSairInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSairInicial.Location = new System.Drawing.Point(209, 12);
            this.btnSairInicial.Name = "btnSairInicial";
            this.btnSairInicial.Size = new System.Drawing.Size(66, 25);
            this.btnSairInicial.TabIndex = 3;
            this.btnSairInicial.Text = "Sair";
            this.btnSairInicial.UseVisualStyleBackColor = false;
            this.btnSairInicial.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Locadora.Properties.Resources.frota1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(484, 291);
            this.Controls.Add(this.btnSairInicial);
            this.Controls.Add(this.btnFazerLogin);
            this.Controls.Add(this.btnNovoUsuario);
            this.Controls.Add(this.lbbemvindo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInicial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbbemvindo;
        private System.Windows.Forms.Button btnNovoUsuario;
        private System.Windows.Forms.Button btnFazerLogin;
        private System.Windows.Forms.Button btnSairInicial;
    }
}