
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using WP.MvcIntermediario.Dominio.Interfaces;
using WP.MvcIntermediario.Dominio.Models;
using WP.MvcIntermediario.Infra.Data.Context;

namespace WP.MvcIntermediario.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity>, IRepositoryWrite<TEntity> where TEntity : Entity, new()
    {
        protected MvcIntermediarioContext Db;
        protected DbSet<TEntity> DbSet;
        protected Repository()
        {
            Db = new MvcIntermediarioContext();
            DbSet = Db.Set<TEntity>();
        }

        public virtual TEntity Adicionar(TEntity obj)
        {
            var objReturn = DbSet.Add(obj);
            SaveChanges();
            return objReturn;
        }

        public virtual TEntity Atualizar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;
            SaveChanges();
            return obj;
        }

        public virtual void Remover(Guid id)
        {
            var entity = new TEntity { Id = id };
            DbSet.Remove(entity);
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public virtual TEntity ObterPorId(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public virtual IEnumerable<TEntity> ObterTodosPaginado(int s, int t)
        {
            return DbSet.Take(t).Skip(s);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
