namespace Pessoa.Models
{
    public abstract class CodigoUF
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
    }
}
