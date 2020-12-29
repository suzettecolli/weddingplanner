using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(long id);
        IList<TEntity> GetAll();
        void Add(TEntity entity);

        void Update(TEntity entity);

        void Remove(TEntity entity);

    }
}
