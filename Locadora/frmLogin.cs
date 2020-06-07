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
    public partial class frmLogin : Form
    {
        Thread nt;
        String auxiliar;
        public frmLogin()
        {
            InitializeComponent();
        }


        private void btnVoltarInicio_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(inicioForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }


        private void inicioForm()
        {
            Application.Run(new frmInicial());
        }

        private void btnIniciarSessao_Click(object sender, EventArgs e)
        {
            try
            {
                string senha = Cryptografia.md5encrypt(txtAutenticarSenha.Text);
                Usuario objUsuario = new Usuario();

                objUsuario.CPF = txtAutenticarCPF.Text;
                objUsuario.Senha = senha;

                string nivelAcesso = objUsuario.autenticarLogin();

                if (nivelAcesso != string.Empty)
                {
                    this.Close();
                    MessageBox.Show("Usuário logado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    auxiliar = objUsuario.CPF;


                    // tem que chamar o menu princil
                    nt = new Thread(principalForm);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();

                }
                else
                {
                    MessageBox.Show("Login ou Senha inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void principalForm()
        {
            Application.Run(new MenuPrincipal(auxiliar));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(adminForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void adminForm()
        {
            Application.Run(new frmControleVeiculo());
        }
    }
}
