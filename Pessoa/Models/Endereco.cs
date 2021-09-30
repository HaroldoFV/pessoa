namespace Pessoa.Models
{
    public class Endereco
    {
        public Endereco()
        {
        }

        public Endereco(long id, string cep, string logradouro, int numero, string complemento, Cidade cidade, Estado estado, Pais pais)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
        }

        public long Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public Cidade Cidade { get; set; }
        public Estado Estado { get; set; }
        public Pais Pais { get; set; }

        public void Alterar(long id, string cep, string logradouro, int numero, string complemento, Cidade cidade, Estado estado, Pais pais)
        {
            Id = id;
            Cep = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
        }

        public void Desativar()
        {

        }
    }
}
