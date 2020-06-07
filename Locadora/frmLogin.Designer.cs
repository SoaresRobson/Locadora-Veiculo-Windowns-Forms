using System;

namespace Locadora
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutenticarSenha = new System.Windows.Forms.TextBox();
            this.btnVoltarInicio = new System.Windows.Forms.Button();
            this.btnIniciarSessao = new System.Windows.Forms.Button();
            this.txtAutenticarCPF = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Iniciar Sessão";
            // 
            // txtAutenticarSenha
            // 
            this.txtAutenticarSenha.CausesValidation = false;
            this.txtAutenticarSenha.Location = new System.Drawing.Point(125, 115);
            this.txtAutenticarSenha.Name = "txtAutenticarSenha";
            this.txtAutenticarSenha.PasswordChar = '*';
            this.txtAutenticarSenha.Size = new System.Drawing.Size(181, 20);
            this.txtAutenticarSenha.TabIndex = 4;
            // 
            // btnVoltarInicio
            // 
            this.btnVoltarInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltarInicio.Location = new System.Drawing.Point(49, 161);
            this.btnVoltarInicio.Name = "btnVoltarInicio";
            this.btnVoltarInicio.Size = new System.Drawing.Size(70, 32);
            this.btnVoltarInicio.TabIndex = 5;
            this.btnVoltarInicio.Text = "Voltar";
            this.btnVoltarInicio.UseVisualStyleBackColor = false;
            this.btnVoltarInicio.Click += new System.EventHandler(this.btnVoltarInicio_Click);
            // 
            // btnIniciarSessao
            // 
            this.btnIniciarSessao.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarSessao.Location = new System.Drawing.Point(303, 161);
            this.btnIniciarSessao.Name = "btnIniciarSessao";
            this.btnIniciarSessao.Size = new System.Drawing.Size(77, 32);
            this.btnIniciarSessao.TabIndex = 6;
            this.btnIniciarSessao.Text = "Iniciar";
            this.btnIniciarSessao.UseVisualStyleBackColor = false;
            this.btnIniciarSessao.Click += new System.EventHandler(this.btnIniciarSessao_Click);
            // 
            // txtAutenticarCPF
            // 
            this.txtAutenticarCPF.Location = new System.Drawing.Point(125, 85);
            this.txtAutenticarCPF.Mask = "000.000.000-00";
            this.txtAutenticarCPF.Name = "txtAutenticarCPF";
            this.txtAutenticarCPF.Size = new System.Drawing.Size(181, 20);
            this.txtAutenticarCPF.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Acesso ADMIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Locadora.Properties.Resources.frota1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(421, 312);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAutenticarCPF);
            this.Controls.Add(this.btnIniciarSessao);
            this.Controls.Add(this.btnVoltarInicio);
            this.Controls.Add(this.txtAutenticarSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sessão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAutenticarSenha;
        private System.Windows.Forms.Button btnVoltarInicio;
        private System.Windows.Forms.Button btnIniciarSessao;
        private System.Windows.Forms.MaskedTextBox txtAutenticarCPF;
        private System.Windows.Forms.Button button1;
    }
}