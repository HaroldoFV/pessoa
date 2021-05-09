using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Pessoa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        // GET: api/Pessoa
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Models.Pessoa>>> ListarPessoas()
        {
            var pessoas = await _pessoaRepository.Listar();
            return Ok(pessoas);
        }

        // GET: api/Pessoa/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Models.Pessoa>> BuscarPessoaPorId(int id)
        {
            var pessoa = await _pessoaRepository.BuscarPorCodigo(id);

            if (pessoa == null)
            {
                return NotFound();
            }

            return Ok(pessoa);
        }

        // GET: api/Pessoa/
        [HttpGet("nome/{nome}")]
        public async Task<ActionResult<Models.Pessoa>> BuscarPessoaPorNome(string nome)
        {
            var pessoa = await _pessoaRepository.BuscarPorNome(nome);

            if (pessoa == null)
            {
                return NotFound();
            }

            return Ok(pessoa);
        }

        // GET: api/Pessoa/
        [HttpGet("cpf/{cpf}")]
        public async Task<ActionResult<Models.Pessoa>> BuscarPessoaPorCpf(string cpf)
        {
            var pessoa = await _pessoaRepository.BuscarPorCpf(cpf);

            if (pessoa == null)
            {
                return NotFound();
            }

            return Ok(pessoa);
        }

        // PUT: api/Pessoa/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPessoa(int id, Models.Pessoa pessoa)
        {
            if (id != pessoa.Id)
            {
                return BadRequest();
            }


            try
            {
                await _pessoaRepository.Update(pessoa);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        // POST: api/Pessoa
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Models.Pessoa>> PostPessoa(Models.Pessoa pessoa)
        {
            await _pessoaRepository.Add(pessoa);

            return CreatedAtAction("GetPessoa", new { id = pessoa.Id }, pessoa);
        }

        // DELETE: api/Pessoa/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePessoa(int id)
        {
            await _pessoaRepository.Delete(id);

            return NoContent();
        }

    }
}
