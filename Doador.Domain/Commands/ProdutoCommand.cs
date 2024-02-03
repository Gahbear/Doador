using Doador.Domain.Enums;

namespace Doador.Domain.Commands
{
    public class ProdutoCommand
    {
        public int ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public ECategoriaProduto ECategoriaProduto { get; set; }
        public string NomeDoador { get; set; }
        public bool DisponibilidadeDoacao { get; set; }
    }
}
