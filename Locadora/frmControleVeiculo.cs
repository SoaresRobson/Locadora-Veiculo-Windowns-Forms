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
    public partial class frmControleVeiculo : Form
    {
        Thread nt;
        public frmControleVeiculo()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Veiculo objVeiculo = new Veiculo();
            dgvVeiculos.DataSource = objVeiculo.listar();
        }
        private void atualizarListagem()
        {
            Veiculo objVeiculo = new Veiculo();

            dgvVeiculos.AutoGenerateColumns = false;

            //carrega valores no dgv vindos da tabela tbveiculo
            dgvVeiculos.DataSource = objVeiculo.listar();
        }
        private void limparCaixasTextos()
        {
            txtid.Clear();
            txtModelo.Clear();
            txtMarca.Clear();
            txtPlaca.Clear();
            txtPreco.Clear();
            txtStatus.Clear();
        }

        private void btntrazerDados_Click(object sender, EventArgs e)
        {
            try
            {
                Veiculo objVeiculo = new Veiculo();
                objVeiculo.idVeiculo = Convert.ToInt32(txtid.Text);
            
                if (objVeiculo.buscarVeiculoSolo(objVeiculo))
                {
                    txtPlaca.Text = objVeiculo.placa;
                    txtModelo.Text = objVeiculo.modelo;
                    txtMarca.Text = objVeiculo.marca;
                    txtPreco.Text = Convert.ToString(objVeiculo.precoLocacao);
                    txtStatus.Text = objVeiculo.statusVe;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Id não encontrado ou inválido" + ex.Message, "Falha na operação", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
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

        private void btncadastroVeiculo_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(cadastraVeiculoForm);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void cadastraVeiculoForm()
        {
            Application.Run(new frmCadastrarVeiculo());
        }

        private void btnsalvar_Click(object sender, EventArgs e)
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
                if (txtStatus.Text == string.Empty)
                {
                    throw new Exception("Preenchimento do Status é obrigatório.");
                }

                Veiculo objVeiculo = new Veiculo();
                objVeiculo.placa = txtPlaca.Text;
                objVeiculo.modelo = txtModelo.Text;
                objVeiculo.marca = txtMarca.Text;
                objVeiculo.precoLocacao = Convert.ToDouble(txtPreco.Text);
                objVeiculo.statusVe = "Disponivel";
                if (objVeiculo.alterar())
                    MessageBox.Show("Veículo alterado com sucesso!");
                limparCaixasTextos();
                dgvVeiculos.DataSource = objVeiculo.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar Alterar." + ex.Message, "Falha na operação", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dtResultado = MessageBox.Show("Confirma a exclusão do veículo?",
                    "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dtResultado == DialogResult.Yes)
                {
                    Veiculo objVeiculo = new Veiculo();
                    objVeiculo.idVeiculo = Convert.ToInt32(txtid.Text);
                    if (objVeiculo.excluir())
                    {
                        MessageBox.Show("Veículo Excluido com sucesso!");
                        limparCaixasTextos();
                        dgvVeiculos.DataSource = objVeiculo.listar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar Excluir." + ex.Message, "Falha na operação", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
