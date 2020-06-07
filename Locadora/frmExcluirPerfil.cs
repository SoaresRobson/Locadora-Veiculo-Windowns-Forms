using Locadora.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class frmExcluirPerfil : Form
    {
        Thread nt;
        public string usuarioLogado;
        public frmExcluirPerfil()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario objusuario = new Usuario();
                objusuario.CPF = usuarioLogado;
                
                if (objusuario.excluir())
                {
                    MessageBox.Show("Registro excluido com sucesso", "Informação",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                    nt = new Thread(inicialFmr);
                    nt.SetApartmentState(ApartmentState.STA);
                    nt.Start();
                }
                else
                {
                    MessageBox.Show("Exclusão não realizada", "Alerta",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    private void inicialFmr()
        {
            Application.Run(new frmInicial());
        }
    }
}
