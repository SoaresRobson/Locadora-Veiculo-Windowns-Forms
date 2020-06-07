using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Locadora.util;

namespace Locadora.modelo
{
    class Locacao
    {
        public int idlocacao { get; set; }
        public Usuario usuario { get; set; }
        public Veiculo veiculo { get; set; }
        public String datainicio { get; set; }
        public String datafim { get; set; }
        public Double valortotal { get; set; }

        //método para inserir um usuário no BD
        public bool cadastrar()
        {
            NpgsqlConnection conexao = null;

            try
            {
                conexao = ConectaBD.getConexao();
                conexao.Open();

                string sql = "insert into tblocacao (idusuario, idveiculo, valortotal, datafim, datainicio) "
                    + "values (@idusuario, @idveiculo, @valortotal, @datafim, @datainicio);";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@idusuario", this.usuario.ID);
                cmd.Parameters.AddWithValue("@idveiculo", this.veiculo.idVeiculo);
                cmd.Parameters.AddWithValue("@valortotal", this.valortotal);
                cmd.Parameters.AddWithValue("@datafim", this.datafim);
                cmd.Parameters.AddWithValue("@datainicio", this.datainicio);
                
                cmd.ExecuteNonQuery();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (conexao != null)
                {
                    conexao.Close();
                }
            }
        }

        public List<Locacao> listar()
        {
            List<Locacao> listaLocacao = new List<Locacao>();

            NpgsqlConnection conexao = null;

            try
            {
                conexao = ConectaBD.getConexao();
                conexao.Open();

                string sql = "select *from tblocacao";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Locacao objLocacao = new Locacao();
                    Usuario objUsuario = new Usuario();
                    Veiculo objVeiculo = new Veiculo();


                    objLocacao.idlocacao = Convert.ToInt32(dr["idlocacao"]);
                    
                    objUsuario.ID = Convert.ToInt32(dr["idusuario"]);
                    objUsuario.buscarUsuario(objUsuario);
                    objLocacao.usuario = objUsuario;

              
                    objVeiculo.idVeiculo = Convert.ToInt32(dr["idveiculo"]);
                    objVeiculo.buscarVeiculoSolo(objVeiculo);
                    objLocacao.veiculo = objVeiculo;
                    
                    objLocacao.valortotal = Convert.ToDouble(dr["valortotal"]);
                    objLocacao.datafim = dr["datafim"].ToString();
                    objLocacao.datainicio = dr["datainicio"].ToString();

                    listaLocacao.Add(objLocacao);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

                if (conexao != null)
                {
                    conexao.Close();
                }
            }
            return listaLocacao;
        }

    }
}
