using System;
namespace Pessoa.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

        public long Codigo { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
    }
}
