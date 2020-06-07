using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Locadora
{
    public partial class MenuPrincipal : Form
    {
        public String usuariologado;
        public String autorizacaoEditar;

        Thread nt;
        public MenuPrincipal(string usuario)
        {
            InitializeComponent();
            this.usuariologado = usuario;
        }

        private void verDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVerPerfil frmPerfil = new frmVerPerfil();
            frmPerfil.loginRecebido = usuariologado;
            frmPerfil.autorizacaoEditar = "Nao";

            frmPerfil.MdiParent = this;
            frmPerfil.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(inicialFmr);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void inicialFmr()
        {
            Application.Run(new frmInicial());
        }

        private void editarPerfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlterarPerfil fmrMudaP = new frmAlterarPerfil();
            fmrMudaP.usuarioLogado = usuariologado;
            fmrMudaP.MdiParent = this;
            fmrMudaP.Show();
        }

        private void excluirPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExcluirPerfil frmExcluir = new frmExcluirPerfil();
            frmExcluir.usuarioLogado = usuariologado;
            frmExcluir.MdiParent = this;
            frmExcluir.Show();
        }

        private void alugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNovaLocacao frmNovaLoc = new frmNovaLocacao();
            frmNovaLoc.usuarioLogado = usuariologado;
            frmNovaLoc.MdiParent = this;
            frmNovaLoc.Show();
        }

        private void listarLocaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarLocacoes frmList = new frmListarLocacoes();
            frmList.MdiParent = this;
            frmList.loginRecebido = usuariologado;
            frmList.Show();
        }
    }
}
