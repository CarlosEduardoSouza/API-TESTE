using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore;

namespace Compugraf.API.Models
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        private readonly AppDbContext _context;

        public PessoaRepositorio(AppDbContext context)
        {
            _context = context;
        }
        //public async Task Adicionar(Pessoa item)
        //{
        //    _context.Pessoas.Add(item);
        //    await _context.SaveChangesAsync();
        //}

        //public async Task<Pessoa> ObterPorId(int id)
        //{
        //    return await _context.Pessoas.FindAsync(id);
        //}


        //public IEnumerable<Pessoa> GetAll()
        //{
        //    return _context.Pessoas.ToList();
        //}

        //public async Task Atualizar(Pessoa pessoa)
        //{
        //    _context.Pessoas.Update(pessoa);
        //    await SaveChanges();
        //}

        //public async Task Remover(int id)
        //{
        //    var pessoa = _context.Pessoas.First(t => t.PessoaId == id);
        //    _context.Pessoas.Remove(pessoa);
        //    await SaveChanges();
        //}



        //public async Task<List<Pessoa>> ObterTodos()
        //{
        //    return await _context.ToListAsync();
        //}



        ////public async Task<IEnumerable<Pessoa>> Buscar(Expression<Func<Pessoa, bool>> predicate)
        ////{
        ////    return await _context.
        ////}

        //public async Task<int> SaveChanges()
        //{
        //    return await _context.SaveChangesAsync();
        //}


        public void Adicionar(Pessoa item)
        {
            _context.Pessoas.Add(item);
            _context.SaveChanges();
        }

        public Pessoa ObterPorId(int id)
        {
            return _context.Pessoas.Find(id);
        }

        public List<Pessoa> ObterTodos()
        {
            return _context.Pessoas.ToList();
        }

        public void Remove(int id)
        {
            var pessoa = _context.Pessoas.First(t => t.PessoaId == id);
            _context.Pessoas.Remove(pessoa);
            _context.SaveChanges();
        }

        public void Atualizar(Pessoa pessoa)
        {
            _context.Pessoas.Update(pessoa);
            _context.SaveChanges();
        }

      

        public void Dispose()
        {
            _context?.Dispose();
        }

    

        public IEnumerable<Pessoa> Buscar(Expression<Func<Pessoa, bool>> predicate)
        {
            return _context.Pessoas.Where(predicate).ToList();
        }
    }
}
