using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using WP.MvcIntermediario.Dominio.Models;

namespace WP.MvcIntermediario.Dominio.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity ObterPorId(Guid id);
        IEnumerable<TEntity> ObterTodos();
        IEnumerable<TEntity> ObterTodosPaginado(int s, int t);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
    }
}
