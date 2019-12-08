using System;
using WP.MvcIntermediario.Dominio.Models;

namespace WP.MvcIntermediario.Dominio.Interfaces
{
    public interface IRepositoryWrite<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity Adicionar(TEntity obj);
        TEntity Atualizar(TEntity obj);
        void Remover(Guid id);
        int SaveChanges();
    }
}
