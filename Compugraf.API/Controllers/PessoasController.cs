using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compugraf.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Compugraf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;

        public PessoasController(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }

        [HttpGet]
        public List<Pessoa> ObterTodos()
        {
            return _pessoaRepositorio.ObterTodos();
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            var pessoa = _pessoaRepositorio.ObterPorId(id);
            if (pessoa == null)
            {
                return NotFound();
            }
            return new ObjectResult(pessoa);
        }

        [HttpPost]
       // public IActionResult Adicionar([FromBody] Pessoa pessoa)
        public IActionResult Adicionar(Pessoa pessoa)
        {
            if (pessoa == null)
            {
                return BadRequest("Os dados de cadastro são de preenchimento obrigatorio");
            }

            //VERIFICA SE JA TEM UM CPF CADASTRADO
            var retorno = _pessoaRepositorio.Buscar(c => c.CPF == pessoa.CPF).Any();
            if (retorno == true) { return BadRequest("cpf já cadastrado com esse número"); }

            _pessoaRepositorio.Adicionar(pessoa);
            return Ok(pessoa);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Pessoa pessoa)
        {
            if (pessoa == null || pessoa.PessoaId != id)
            {
                return BadRequest();
            }
            var novaPessoa = _pessoaRepositorio.ObterPorId(id);
            if (novaPessoa == null)
            {
                return NotFound();
            }
            
            novaPessoa.Nome = pessoa.Nome;
            novaPessoa.Sobrenome = pessoa.Sobrenome;
            novaPessoa.Nacionalidade = pessoa.Nacionalidade;
            novaPessoa.CEP = pessoa.CEP;
            novaPessoa.CPF = pessoa.CPF;
            novaPessoa.Estado = pessoa.Estado;
            novaPessoa.Cidade = pessoa.Cidade;
            novaPessoa.Logradouro = pessoa.Logradouro;
            novaPessoa.Email = pessoa.Email;
            novaPessoa.Telefone = pessoa.Telefone;

            _pessoaRepositorio.Atualizar(novaPessoa);
            // return new NoContentResult();

            return Ok(pessoa);
        }

        [HttpDelete("{id}")]
        public IActionResult Remover(int id)
        {
            var pessoa = _pessoaRepositorio.ObterPorId(id);
            if (pessoa == null)
            {
                return NotFound();
            }
            _pessoaRepositorio.Remove(id);
            //return new NoContentResult();
            return Ok();
        }
    }
}