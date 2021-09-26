using System;
namespace Pessoa.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

        public Pessoa(int id, long codigo, string cpf, string nome, string dataNascimento, Endereco endereco)
        {
            Id = id;
            Codigo = codigo;
            Cpf = cpf;
            Nome = nome;
            DataNascimento = dataNascimento;
            Endereco = endereco;
        }

        public int Id { get; set; }
        public long Codigo { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public Endereco Endereco { get; set; }

        public void Update(long codigo, string nome, Endereco endereco)
        {
            Codigo = codigo;
            Nome = nome;
            Endereco = endereco;
        }

        public void Active()///
        {

        }
    }
}
