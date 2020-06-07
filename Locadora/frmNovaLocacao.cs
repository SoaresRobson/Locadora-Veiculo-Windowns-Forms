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
    public partial class frmNovaLocacao : Form
    {
        public string usuarioLogado;
        public frmNovaLocacao()
        {
            InitializeComponent();
        }

        private void frmNovaLocacao_Load(object sender, EventArgs e)
        {
            modelo.Veiculo objVeiculo = new modelo.Veiculo();
            cmbVeiculos.DataSource = objVeiculo.listar();
            cmbVeiculos.ValueMember = "idveiculo";
            cmbVeiculos.DisplayMember = "modelo";
            cmbVeiculos.SelectedValue = objVeiculo.idVeiculo;
            cmbVeiculos.Text = "Selecione";
            txtTotal.Text = Convert.ToString(objVeiculo.precoLocacao);
        }

        private int calculaDias()
        {
            string inicio = dateTimeInicio.Text;
            string final = dateTimeDevolucao.Text;
            DateTime inicio1 = Convert.ToDateTime(inicio);
            DateTime final1 = Convert.ToDateTime(final);
            TimeSpan date = final1-inicio1;
            int dias = date.Days;
            return dias;
        }
        private double calculaValor()
        {
            int qtd_dias = calculaDias();
            modelo.Veiculo objVeiculo = new modelo.Veiculo();
            objVeiculo.idVeiculo = Convert.ToInt32(cmbVeiculos.SelectedValue);
            objVeiculo.buscarVeiculoSolo(objVeiculo);
            double resultado = qtd_dias * objVeiculo.precoLocacao;
            return resultado;
        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbVeiculos.Text == string.Empty)
                {
                    throw new Exception("Selecione um veiculo");
                }
                if (calculaDias() <= 0)
                {
                    throw new Exception("Selecione data de Inicio e Devolução Válida");
                }
                modelo.Usuario objUsuario = new modelo.Usuario();
                modelo.Veiculo objVeiculo = new modelo.Veiculo();
                
                objUsuario.CPF = usuarioLogado;
                objUsuario.buscarUsuario(objUsuario);
                objVeiculo.idVeiculo = Convert.ToInt32(cmbVeiculos.SelectedValue);
                objVeiculo.buscarVeiculoSolo(objVeiculo);

                double teste = calculaDias();

                Locacao objLocacao = new Locacao();
                objLocacao.usuario = objUsuario;
                objLocacao.veiculo = objVeiculo;
                objLocacao.datainicio = dateTimeInicio.Text;
                objLocacao.datafim = dateTimeDevolucao.Text;
                objLocacao.valortotal = teste * objVeiculo.precoLocacao;


                if(objLocacao.cadastrar())
                    MessageBox.Show("Aluguel de veículo cadastrado com sucesso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao tentar Alugar." + ex.Message, "Falha na operação", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculaValor_Click(object sender, EventArgs e)
        {
            string valor = Convert.ToString(calculaValor());
            txtTotal.Text = valor;
        }
    }
}
