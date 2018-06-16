using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
           where TContext : DbContext, new()

    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext Context = new TContext())
            {
                return Context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public void Add(TEntity Entity)
        {
            using (TContext Context = new TContext())
            {
                var addedEntity = Context.Entry(Entity);
                addedEntity.State = EntityState.Added;
                Context.SaveChanges();
            }
        }

        public void Delete(TEntity Entity)
        {
            using (TContext Context = new TContext())
            {
                var deletedEntity = Context.Entry(Entity);
                deletedEntity.State = EntityState.Deleted;
                Context.SaveChanges();
            }
        }

        public void Update(TEntity Entity)
        {
            using (TContext Context = new TContext())
            {
                var uptatedEntity = Context.Entry(Entity);
                uptatedEntity.State = EntityState.Modified;
                Context.SaveChanges();
            }
        }
    }
}
