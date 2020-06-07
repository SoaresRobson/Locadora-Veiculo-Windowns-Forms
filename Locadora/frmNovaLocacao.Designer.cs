namespace Locadora
{
    partial class frmNovaLocacao
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlugar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalculaValor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dateTimeDevolucao = new System.Windows.Forms.DateTimePicker();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.cmbVeiculos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(45, 276);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 26);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAlugar
            // 
            this.btnAlugar.Location = new System.Drawing.Point(180, 276);
            this.btnAlugar.Name = "btnAlugar";
            this.btnAlugar.Size = new System.Drawing.Size(95, 26);
            this.btnAlugar.TabIndex = 1;
            this.btnAlugar.Text = "Alugar";
            this.btnAlugar.UseVisualStyleBackColor = true;
            this.btnAlugar.Click += new System.EventHandler(this.btnAlugar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dateTimeDevolucao);
            this.groupBox1.Controls.Add(this.dateTimeInicio);
            this.groupBox1.Controls.Add(this.cmbVeiculos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 208);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha sua Locação";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalculaValor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Location = new System.Drawing.Point(125, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 90);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valor R$";
            // 
            // btnCalculaValor
            // 
            this.btnCalculaValor.Location = new System.Drawing.Point(23, 19);
            this.btnCalculaValor.Name = "btnCalculaValor";
            this.btnCalculaValor.Size = new System.Drawing.Size(143, 23);
            this.btnCalculaValor.TabIndex = 8;
            this.btnCalculaValor.Text = "Simular Valor Total";
            this.btnCalculaValor.UseVisualStyleBackColor = true;
            this.btnCalculaValor.Click += new System.EventHandler(this.btnCalculaValor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.txtTotal.Location = new System.Drawing.Point(88, 50);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(79, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // dateTimeDevolucao
            // 
            this.dateTimeDevolucao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDevolucao.Location = new System.Drawing.Point(125, 88);
            this.dateTimeDevolucao.MinDate = new System.DateTime(2020, 6, 4, 0, 0, 0, 0);
            this.dateTimeDevolucao.Name = "dateTimeDevolucao";
            this.dateTimeDevolucao.Size = new System.Drawing.Size(138, 20);
            this.dateTimeDevolucao.TabIndex = 7;
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimeInicio.Location = new System.Drawing.Point(125, 62);
            this.dateTimeInicio.MinDate = new System.DateTime(2020, 6, 4, 0, 0, 0, 0);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(138, 20);
            this.dateTimeInicio.TabIndex = 6;
            // 
            // cmbVeiculos
            // 
            this.cmbVeiculos.FormattingEnabled = true;
            this.cmbVeiculos.Location = new System.Drawing.Point(125, 31);
            this.cmbVeiculos.Name = "cmbVeiculos";
            this.cmbVeiculos.Size = new System.Drawing.Size(138, 21);
            this.cmbVeiculos.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Data de Devolução:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data de Início:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Veículo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Realizar Aluguel";
            // 
            // frmNovaLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAlugar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNovaLocacao";
            this.Text = "Nova Locação";
            this.Load += new System.EventHandler(this.frmNovaLocacao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlugar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeDevolucao;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.ComboBox cmbVeiculos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculaValor;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}