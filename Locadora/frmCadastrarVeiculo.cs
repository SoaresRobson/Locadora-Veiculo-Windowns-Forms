using Locadora.modelo;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Locadora
{
    public partial class frmCadastrarVeiculo : Form
    {
        Thread nt;
        public frmCadastrarVeiculo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(inicialControleForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void inicialControleForm()
        {
            Application.Run(new frmControleVeiculo());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPlaca.Text == string.Empty || txtPlaca.Text.Length != 7)
                {
                    throw new Exception("Placa deve ter 7 dígitos obrigatório.");
                }

                if (txtModelo.Text == string.Empty)
                {
                    throw new Exception("Preenchimento do modelo é obrigatório.");
                }

                if (txtMarca.Text == string.Empty)
                {
                    throw new Exception("Preenchimento da Marca é obrigatório.");
                }

                if (txtPreco.Text == string.Empty)
                {
                    throw new Exception("Preenchimento do Preço é obrigatório.");
                }

                Veiculo objVeiculo = new Veiculo();
                objVeiculo.placa = txtPlaca.Text;
                objVeiculo.modelo = txtModelo.Text;
                objVeiculo.marca = txtMarca.Text;
                objVeiculo.precoLocacao = Convert.ToDouble(txtPreco.Text);
                objVeiculo.statusVe = "Disponivel";
                if (objVeiculo.cadastrar())
                    MessageBox.Show("Veículo cadastrado com sucesso!");
                this.Close();
                nt = new Thread(inicialControleForm);
                nt.SetApartmentState(ApartmentState.STA);
                nt.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar cadastrar." + ex.Message, "Falha na operação", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
