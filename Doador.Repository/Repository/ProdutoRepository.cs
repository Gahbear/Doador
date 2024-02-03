using Dapper;
using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using System.Data.SqlClient;

namespace Doador.Repository.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private string conexao = @"Server=(localdb)\mssqllocaldb;Database=Doador;Trusted_Connection=True;MultipleActiveResultSets=True";

        public Task<IEnumerable<DoadorCommand>> GetDoadoresAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(ProdutoCommand command)
        {
            string queryInsert = @"INSERT INTO Produto(NomeProduto, Descricao, ECategoriaProduto, NomeDoador, DisponibilidadeDoacao)
                                  VALUES(@Nome, @Cidade, @Estado, @CEP, @Email, @Telefone)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {
                    Nome = command.NomeProduto,
                    Descricao = command.Descricao,
                    Categoria = command.ECategoriaProduto,
                    NomeDoador = command.NomeDoador,
                    Disponibilidade = command.DisponibilidadeDoacao
                });
            }
            return queryInsert;
            {
                throw new NotImplementedException();
            }
        }
    }

}