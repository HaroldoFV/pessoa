namespace Pessoa.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

        public Pessoa(long codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public long Codigo { get; set; }
        public string Nome { get; set; }

        public void Alterar(string nome)
        {
            Nome = nome;
        }
    }
}
