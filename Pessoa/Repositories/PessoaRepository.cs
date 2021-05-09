using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pessoa.Data;

namespace Pessoa.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly PessoaContext _context;

        public PessoaRepository(PessoaContext context)
        {
            _context = context;
        }

        public async Task Add(Models.Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            await _context.SaveChangesAsync();
        }

        public async Task<Models.Pessoa> BuscarPorCodigo(int codigo)
        {
            return await _context.Pessoas.FindAsync(codigo);
        }

        public async Task<Models.Pessoa> BuscarPorCpf(string cpf)
        {
            var query = await _context.Pessoas.FirstOrDefaultAsync(x => x.Cpf == cpf);

            return query;
        }

        public async Task<Models.Pessoa> BuscarPorNome(string nome)
        {
            var query = await _context.Pessoas.FirstOrDefaultAsync(x => x.Nome.Contains(nome));

            return query;
        }

        public async Task Delete(int codigo)
        {
            var pessoa = await _context.Pessoas.FindAsync(codigo);
            if (pessoa == null)
                throw new NullReferenceException();

            _context.Pessoas.Remove(pessoa);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Models.Pessoa>> Listar()
        {
            return await _context.Pessoas.ToListAsync();
        }

        public async Task Update(Models.Pessoa pessoa)
        {
            var pessoaExist = await _context.Pessoas.FindAsync(pessoa.Id);
            if (pessoaExist == null)
                throw new NullReferenceException();
            pessoaExist.Update(pessoa.Codigo, pessoa.Nome, pessoa.Endereco);
            await _context.SaveChangesAsync();
        }
    }
}
