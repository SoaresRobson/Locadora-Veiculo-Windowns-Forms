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
    public partial class frmInicial : Form
    {
        Thread nt;
        public frmInicial()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovoUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(cadastroForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }


        private void btnFazerLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(loginForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void loginForm()
        {
            Application.Run(new frmLogin());
        }


        private void cadastroForm()
        {
            Application.Run(new frmCadastroUsuario());
        }

    }
}
