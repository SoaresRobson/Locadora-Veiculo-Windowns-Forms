using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Locadora.modelo;

namespace Locadora
{
    public partial class frmCadastroUsuario : Form
    {
        Thread nt;
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtNomeUsuario.Text = "";
            this.mtxtCPF.Text = "";
            this.txtSenha.Text = "";
            this.txtLogradouro.Text = "";
            this.txtNumero.Text = "";
            this.txtCidade.Text = "";
            this.comboBox1.Text = "";
            this.mtxtTelefone.Text = "";
        }

        private void btnCancelarCadastroUsua_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(inicialForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void inicialForm()
        {
            Application.Run(new frmInicial());
        }

        private void btnConcluirCadastroUsua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeUsuario.Text == string.Empty || txtNomeUsuario.Text.Length < 4 || txtNomeUsuario.Text.Length > 50)
                {
                    throw new Exception("Nome Inválido");
                }
                if (mtxtCPF.Text == string.Empty || mtxtCPF.Text.Length < 11)
                {
                    throw new Exception("CPF Inválido");
                }
                if (mtxtTelefone.Text == string.Empty || mtxtTelefone.Text.Length < 11)
                {
                    throw new Exception("Telefone Inválido");
                }
                if (comboBox1.Text == string.Empty)
                {
                    throw new Exception("Estado Inválido");
                }
                if (txtSenha.Text == string.Empty ||txtSenha.Text.Length < 4)
                {
                    throw new Exception("Senha Inválida - Deve conter no mínimo 4 caracteres");
                }

                string senhaCryp = Cryptografia.md5encrypt(txtSenha.Text);

                Usuario objUsuario = new Usuario();
                objUsuario.NomeUsuario = txtNomeUsuario.Text;
                objUsuario.CPF = mtxtCPF.Text;
                objUsuario.Telefone = mtxtTelefone.Text;
                objUsuario.Rua = txtLogradouro.Text;
                objUsuario.Numero = txtNumero.Text;
                objUsuario.Cidade = txtCidade.Text;
                objUsuario.Estado = comboBox1.Text;
                objUsuario.Senha = senhaCryp;

                if (objUsuario.cadastrar())
                {
                    //MessageBox.Show("Usuário cadastrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(objUsuario.Senha);
                    this.Close();
                    nt = new Thread(inicialForm);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar o usuário...", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
