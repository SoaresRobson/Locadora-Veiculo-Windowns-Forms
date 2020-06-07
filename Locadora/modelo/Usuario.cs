using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Locadora.util;

namespace Locadora.modelo
{
    public class Usuario
    {
        public int ID { get; set; }
        public string NomeUsuario { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Senha { get; set; }

        //método para inserir um usuário no BD
        public bool cadastrar()
        {
            NpgsqlConnection conexao = null;

            try
            {
                conexao = ConectaBD.getConexao();
                conexao.Open();

                string sql = "insert into tbusuario (nome, cpf, telefone, rua, numero, cidade, estado, senha) "
                    + "values (@nome, @cpf, @telefone, @rua, @numero, @cidade, @estado, @senha)";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                cmd.Parameters.AddWithValue("@nome", this.NomeUsuario);
                cmd.Parameters.AddWithValue("@cpf", this.CPF);
                cmd.Parameters.AddWithValue("@telefone", this.Telefone);
                cmd.Parameters.AddWithValue("@rua", this.Rua);
                cmd.Parameters.AddWithValue("@numero", this.Numero);
                cmd.Parameters.AddWithValue("@cidade", this.Cidade);
                cmd.Parameters.AddWithValue("@estado", this.Estado);
                cmd.Parameters.AddWithValue("@senha", this.Senha);


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

        public string autenticarLogin()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaBD.getConexao();
                conexao.Open();

                string sql = "select * from tbusuario where cpf = '" + this.CPF + "' and senha =  '" + this.Senha + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                NpgsqlDataReader dr = cmd.ExecuteReader();

                //Variábel auxiliar para retornar o nível de acesso recuperado no BD
                string acessorecup = string.Empty;

                //Se o usuário e senha foram encontrados (dr.Read=true), retorna o nivel de acesso
                if (dr.Read())
                {
                    acessorecup = "sucesso";
                    return acessorecup;
                }
                //se o usuário não for encontrado (dr.Read=false), retorna string vazio no nível de acesso
                else
                {
                    return acessorecup;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public bool alterar()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaBD.getConexao();
                conexao.Open();

                string sql = "update tbusuario set nome=@nome, telefone=@telefone, rua=@rua, numero=@numero, cidade=@cidade, estado=@estado, senha=@senha where cpf=@cpf;";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@nome", this.NomeUsuario);
                cmd.Parameters.AddWithValue("@telefone", this.Telefone);
                cmd.Parameters.AddWithValue("@rua", this.Rua);
                cmd.Parameters.AddWithValue("@numero", this.Numero);
                cmd.Parameters.AddWithValue("@cidade", this.Cidade);
                cmd.Parameters.AddWithValue("@estado", this.Estado);
                cmd.Parameters.AddWithValue("@senha", this.Senha);
                cmd.Parameters.AddWithValue("@cpf", this.CPF);
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

        public bool buscarUsuario(Usuario objprocurado)
        {
            NpgsqlConnection conexao = null;

            try
            {
                conexao = ConectaBD.getConexao();
                conexao.Open();

                string sql = "select * from tbusuario where cpf='" + objprocurado.CPF + "';";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);

                NpgsqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    objprocurado.ID = Convert.ToInt32(dr["idUsuario"]);
                    objprocurado.NomeUsuario = Convert.ToString(dr["nome"]);
                    objprocurado.CPF = Convert.ToString(dr["cpf"]);
                    objprocurado.Telefone = Convert.ToString(dr["telefone"]);
                    objprocurado.Rua = Convert.ToString(dr["rua"]);
                    objprocurado.Numero = Convert.ToString(dr["numero"]);
                    objprocurado.Cidade = Convert.ToString(dr["cidade"]);
                    objprocurado.Estado = Convert.ToString(dr["estado"]);

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

        public bool excluir()
        {
            NpgsqlConnection conexao = null;
            try
            {
                conexao = ConectaBD.getConexao();
                conexao.Open();

                string sql = "delete from tbusuario where cpf= '" + this.CPF + "'; ";

                NpgsqlCommand cmd = new NpgsqlCommand(sql, conexao);
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
