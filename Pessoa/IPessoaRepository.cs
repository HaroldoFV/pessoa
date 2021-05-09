using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pessoa
{
    public interface IPessoaRepository
    {
        Task<Models.Pessoa> BuscarPorCodigo(int codigo);
        Task<Models.Pessoa> BuscarPorNome(string nome);
        Task<Models.Pessoa> BuscarPorCpf(string cpf);
        Task<IEnumerable<Models.Pessoa>> Listar();
        Task Add(Models.Pessoa pessoa);
        Task Update(Models.Pessoa pessoa);
        Task Delete(int codigo);
    }
}