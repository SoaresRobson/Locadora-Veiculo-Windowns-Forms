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
    public partial class frmListarLocacoes : Form
    {
        public string loginRecebido;
        public frmListarLocacoes()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Locacao objlocacao = new Locacao();
            Usuario objUsuario = new Usuario();
            objUsuario.buscarUsuario(objUsuario);
            objlocacao.usuario = objUsuario;
            
            dgvLocacoes.DataSource = objlocacao.listar();
        }
    }
}
