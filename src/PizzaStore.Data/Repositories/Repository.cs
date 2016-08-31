using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace PizzaStore.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly PizzaContext _context;
        public Repository(PizzaContext context)
        {
            _context = context;
        }
        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public IList<TEntity> List()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity Find(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            try
            {
                _context.SaveChanges();
            }catch(DbUpdateConcurrencyException ex)
            {
                var dbProperties = _context.Entry(entity).GetDatabaseValues();
                _context.Entry(entity).OriginalValues.SetValues(dbProperties);
                _context.SaveChanges();
            }            
        }
    }
}
