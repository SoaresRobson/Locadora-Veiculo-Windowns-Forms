using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Locadora.util;

namespace Locadora.modelo
{
    public class Veiculo
    {
        public int idVeiculo { get; set; }
        public String placa { get; set; }
        public String modelo { get; set; }
        public String marca { get; set; }
        public Double precoLocacao { get; set; }
        public String statusVe { get; set; }

        //método para inserir um usuário no BD
        public bool cadastrar()
        {
            NpgsqlConnection conexao = null;

            try
            {
                conexao = ConectaBD.getConexao();
                conexao.Open();

                string sql = "insert into tbveiculo (placa, modelo, marca, precolocacao, statusveiculo) "
                    + "values (@placa, @modelo, @marca, @precolocacao, @statusveiculo)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@placa", this.placa);
                cmd.Parameters.AddWithValue("@modelo", this.modelo);
                cmd.Parameters.AddWithValue("@marca", this.marca);
                cmd.Parameters.AddWithValue("@precolocacao", this.precoLocacao);
                cmd.Parameters.AddWithValue("@statusveiculo", this.statusVe);
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

        public bool alterar()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaBD.getConexao();
                conexao.Open();

                string sql = "update tbveiculo set modelo=@modelo, marca=@marca, precolocacao=@precoLocacao, statusveiculo=@statusVeiculo where placa=@placa;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@modelo", this.modelo);
                cmd.Parameters.AddWithValue("@marca", this.marca);
                cmd.Parameters.AddWithValue("@precoLocacao", this.precoLocacao);
                cmd.Parameters.AddWithValue("@statusVeiculo", this.statusVe);
                cmd.Parameters.AddWithValue("@placa", this.placa);
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

        public bool buscarVeiculoSolo(Veiculo objprocurado)
        {
            NpgsqlConnection conexao = null;

            try
            {
                conexao = ConectaBD.getConexao();
                conexao.Open();

                string sql = "select * from tbveiculo where idveiculo=@idveiculo;";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@idveiculo", this.idVeiculo);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objprocurado.idVeiculo = Convert.ToInt32(dr["idveiculo"]);
                    objprocurado.placa = Convert.ToString(dr["placa"]);
                    objprocurado.modelo = Convert.ToString(dr["modelo"]);
                    objprocurado.marca = Convert.ToString(dr["marca"]);
                    objprocurado.precoLocacao = Convert.ToDouble(dr["precolocacao"]);
                    objprocurado.statusVe = Convert.ToString(dr["statusveiculo"]);

                    return true;
                }
                return false;
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
        }

        public List<Veiculo> listar()
        {
            List<Veiculo> listaVeiculo = new List<Veiculo>();

            NpgsqlConnection conexao = null;

            try
            {
                conexao = ConectaBD.getConexao();
                conexao.Open();

                string sql = "select *from tbveiculo ORDER BY idveiculo ASC";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Veiculo objVeiculo = new Veiculo();
                    objVeiculo.idVeiculo = Convert.ToInt32(dr["idveiculo"]);
                    objVeiculo.placa = dr["placa"].ToString();
                    objVeiculo.modelo = dr["modelo"].ToString();
                    objVeiculo.marca = dr["marca"].ToString();
                    objVeiculo.precoLocacao = Convert.ToDouble(dr["precolocacao"]);
                    objVeiculo.statusVe = dr["statusveiculo"].ToString();
                    
                    listaVeiculo.Add(objVeiculo);
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
            return listaVeiculo;
        }

        public List<Veiculo> buscarVeiculo(string placa)
        {
            List<Veiculo> listaVeiculo = new List<Veiculo>();
            NpgsqlConnection conexao = null;

            try
            {
                conexao = ConectaBD.getConexao();
                conexao.Open();

                string sql = "select * from tbveiculo where placa ilike ('%" + placa + "%') order by placa;";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Veiculo objVeiculo = new Veiculo();
                    objVeiculo.idVeiculo = Convert.ToInt32(dr["idVeiculo"]);
                    objVeiculo.placa = dr["placa"].ToString();
                    objVeiculo.modelo = dr["modelo"].ToString();
                    objVeiculo.marca = dr["marca"].ToString();
                    objVeiculo.precoLocacao = Convert.ToDouble(dr["precolocacao"]);
                    objVeiculo.statusVe = dr["statusveiculo"].ToString();

                    listaVeiculo.Add(objVeiculo);

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
            return listaVeiculo;
        }

        public bool excluir()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaBD.getConexao();
                conexao.Open();

                string sql = "delete from tbveiculo where idveiculo=@idVeiculo;";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@idVeiculo", this.idVeiculo);
                cmd.ExecuteNonQuery();
                return true;
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
        }

    }
}
