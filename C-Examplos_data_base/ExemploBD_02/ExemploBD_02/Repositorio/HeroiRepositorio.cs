using ExemploBD_02.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBD_02.Repositorio
{
    public class HeroiRepositorio
    {
        private string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\i3i\Documents\exemploBD_02.mdf;Integrated Security=True;Connect Timeout=30";

        private SqlConnection connection = null;

        public HeroiRepositorio()
        {
            connection = new SqlConnection(connectionString);
        }        

        public bool inserir(Heroi heroi) {
            connection.Open();
            SqlCommand insert = new SqlCommand();
            insert.Connection = connection;
            insert.CommandText = "INSERT INTO Herois (Nome, Escuridao, NomePessoa, Raca, ContaBancaria, DataNascimento, Sexo, QtdFilmes, Descricao) VALUES (@Nome, @Escuridao, @NomePessoa, @Raca, @ContaBancaria, @DataNascimento, @Sexo, @QtdFilmes, @Descricao)";

            insert.Parameters.AddWithValue("@Nome", heroi.Nome);
            insert.Parameters.AddWithValue("@Escuridao", heroi.Escuridao);
            insert.Parameters.AddWithValue("@NomePessoa", heroi.NomePessoa);
            insert.Parameters.AddWithValue("@Raca", heroi.Raca);
            insert.Parameters.AddWithValue("@ContaBancaria", heroi.ContaBancaria);
            insert.Parameters.AddWithValue("@DataNascimento", heroi.DataNascimento);
            insert.Parameters.AddWithValue("@Sexo", heroi.Sexo);
            insert.Parameters.AddWithValue("@QtdFilmes", heroi.QtdFilmes);
            insert.Parameters.AddWithValue("@Descricao", heroi.Descricao);

            int qtdRegistros = insert.ExecuteNonQuery();
            connection.Close();
            return qtdRegistros == 1; 
        }

        public bool alterar(Heroi heroi) { 
        
            return false;
        }
        
        public List<Heroi>obterTodos() { 
        
            return null;
        }

        public bool apagar(int codigo) { 
        
            return false; 
        }

        public bool Inserir(Heroi heroi)
        {
            throw new NotImplementedException();
        }
    }
}

