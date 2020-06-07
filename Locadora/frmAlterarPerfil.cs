using Locadora.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class frmAlterarPerfil : Form
    {
        public string usuarioLogado;
        public frmAlterarPerfil()
        {
            InitializeComponent();
        }

        private void frmAlterarPerfil_Load(object sender, EventArgs e)
        {
            Usuario objusuario = new Usuario();
            objusuario.CPF = usuarioLogado;
            if (objusuario.buscarUsuario(objusuario))
            {
                txtNome.Text = objusuario.NomeUsuario;
                mtxtTelefone.Text = objusuario.Telefone;
                txtLogradouro.Text = objusuario.Rua;
                txtNumero.Text = objusuario.Numero;
                txtCidade.Text = objusuario.Cidade;
                comboBoxEstados.Text = objusuario.Estado;

                this.Text = "Perfil de " + objusuario.NomeUsuario;
            }
            else
            {
                MessageBox.Show("Usuário não localizado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarAlteracao_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == string.Empty || txtNome.Text.Length < 4)
                {
                    throw new Exception("Nome Inválido");
                }
                if (txtSenha.Text == string.Empty || txtSenha.Text.Length < 4)
                {
                    throw new Exception("Insira senha antiga ou cadastre uma nova");
                }
                if (mtxtTelefone.Text == string.Empty || mtxtTelefone.Text.Length < 11)
                {
                    throw new Exception("Telefone Inválido");
                }
                if (txtLogradouro.Text == string.Empty || txtLogradouro.Text.Length < 4)
                {
                    throw new Exception("Logradouro Inválido");
                }
                if (txtCidade.Text == string.Empty)
                {
                    throw new Exception("Cidade Inválida");
                }
                if (comboBoxEstados.Text == string.Empty)
                {
                    throw new Exception("Selecione um Estado");
                }

                string senhaAlterar = Cryptografia.md5encrypt(txtSenha.Text);

                Usuario objusuario = new Usuario();
                objusuario.NomeUsuario = txtNome.Text;
                objusuario.Telefone = mtxtTelefone.Text;
                objusuario.Rua = txtLogradouro.Text;
                objusuario.Numero = txtNumero.Text;
                objusuario.Cidade = txtCidade.Text;
                objusuario.Estado = comboBoxEstados.Text;
                objusuario.Senha = senhaAlterar;

                objusuario.CPF = usuarioLogado;

                if (objusuario.alterar())
                {
                    MessageBox.Show("Dados alterados com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro inesperado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
