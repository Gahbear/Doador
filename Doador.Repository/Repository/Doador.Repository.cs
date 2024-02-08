using Dapper;
using Doador.Domain.Commands;
using Doador.Domain.Interfaces;
using System.Data.SqlClient;

namespace Doador.Repository.Repository
{
    public class DoadorRepository : IDoadorRepository
    {
        private string conexao = @"Server=(localdb)\mssqllocaldb;Database=Doador;Trusted_Connection=True;MultipleActiveResultSets=True";

        public Task<IEnumerable<DoadorCommand>> GetDoadoresAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<string> PostAsync(DoadorCommand command)
        {
            string queryInsert = @"INSERT INTO Doador(DoadorNome, DoadorCidade, DoadorEstado, DoadorCEP, DoadorEmail, DoadorTelefone)
                                  VALUES(@Nome, @Cidade, @Estado, @CEP, @Email, @Telefone)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                conn.Execute(queryInsert, new
                {
                    Nome = command.DoadorNome,
                    Cidade = command.DoadorCidade,
                    Estado = command.DoadorEstado,
                    CEP = command.DoadorCEP,
                    Email = command.DoadorEmail,
                    Telefone = command.DoadorTelefone
                });
            }
            return queryInsert;
            {
                throw new NotImplementedException();
            }
        }
    }
    
}
