namespace Doador.Domain.Entities
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string NomeDoador { get; set; }
        public bool DisponibilidadeDoacao { get; set; }
    }
}
