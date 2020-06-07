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
    public partial class frmVerPerfil : Form
    {
        public string loginRecebido;
        public string autorizacaoEditar;
        public frmVerPerfil()
        {
            InitializeComponent();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            Usuario objusuario = new Usuario();
            objusuario.CPF = loginRecebido;
            if (objusuario.buscarUsuario(objusuario))
            {
                label7.Text = objusuario.NomeUsuario;
                label8.Text = objusuario.CPF;
                label9.Text = objusuario.Rua;
                label10.Text = objusuario.Numero;
                label11.Text = objusuario.Cidade;
                label12.Text = objusuario.Estado;
                
                this.Text = "Perfil de " + objusuario.NomeUsuario;
            }
            else
            {
                MessageBox.Show("Usuário não localizado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
