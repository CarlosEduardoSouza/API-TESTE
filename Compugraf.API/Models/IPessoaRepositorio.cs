using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Compugraf.API.Models
{
    public interface IPessoaRepositorio : IDisposable
    {

        void Adicionar(Pessoa pessoa);
        //IEnumerable<Pessoa> GetAll();
        List<Pessoa> ObterTodos();
        // Pessoa Find(long key);
        Pessoa ObterPorId(int id);
        void Remove(int id);
        void Atualizar(Pessoa pessoa);
        IEnumerable<Pessoa> Buscar(Expression<Func<Pessoa, bool>> predicate);
    }
}
