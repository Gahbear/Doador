namespace Doador.Domain.Commands
{
    public class ProdutoCommand
    {
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public string ProdutoDescricao { get; set; }
        public string ProdutoCategoria { get; set; }
        public bool Disponibilidade { get; set; }
        public string DoadorEmail { get; set; }
        public int DoadorTelefone { get; set; }
    }
}
