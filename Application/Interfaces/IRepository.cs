using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(long id);
        IList<TEntity> GetAll();

        int GetLastID();
        TEntity Add(TEntity entity);

        void Update(TEntity entity, string item);

        void Remove(long id);

    }
}
