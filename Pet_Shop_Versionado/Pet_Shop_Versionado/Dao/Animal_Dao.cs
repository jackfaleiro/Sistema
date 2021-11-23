using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Shop_Versionado.Dao
{
    public class Animal_Dao
    {

        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public String mensagem;

        public void insere_Animal(String nome)
        {
            // Comando SQL
            cmd.CommandText = "insert into animal(nome_animal) values (@nome) ";

            cmd.Parameters.AddWithValue("@nome", nome);

            //conectar com o Banco

            try 
            {
                // Conexao Banco
                cmd.Connection = conexao.conectar();
                //Executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.desconectar();
                this.mensagem = "Cadastro realizado com sucesso";
             }
            catch (SqlException e) 
            {
                this.mensagem = "Erro" + e.StackTrace;
            }
        }
    }
}
