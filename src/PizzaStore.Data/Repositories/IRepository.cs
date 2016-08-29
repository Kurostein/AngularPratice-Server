using System.Collections.Generic;

namespace PizzaStore.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        IList<TEntity> List();
        TEntity Find(int id);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
