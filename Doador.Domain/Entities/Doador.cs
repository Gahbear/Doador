namespace Doador.Domain.Entities
{
    public class Doador
    {
        public int DoadorId { get; set; }
        public string DoadorNome { get; set; }
        public string DoadorCidade { get; set; }
        public string DoadorEstado { get; set; }
        public int DoadorCEP { get; set; }
        public string DoadorEmail { get; set; }
        public int DoadorTelefone { get; set; } = 0;
    }
}
