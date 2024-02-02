namespace Doador.Domain.Commands
{
    public class DoadorCommand
    {
        public int DoadorId {  get; set; }
        public string DoadorNome { get; set; }
        public string DoadorCidade { get; set; }
        public string DoadorEstado { get; set; }
        public long DoadorCEP { get; set; }
        public string DoadorEmail { get; set; }
        public int DoadorTelefone { get; set; }
    }
}
