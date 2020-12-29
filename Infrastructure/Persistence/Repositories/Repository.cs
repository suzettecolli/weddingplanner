using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;

using Application.Interfaces;

using Domain.Entities;

using Infrastructure.Persistence.DataMappers;

namespace Infrastructure.Persistence.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private DataMapper<TEntity> dataMapper;

        public Repository(DataMapper<TEntity> dataMapper)
        {
            this.dataMapper = dataMapper;
        }
        public void Add(TEntity entity)
        {
            dataMapper.Insert(entity);
        }

        public TEntity Get(long id)
        {
            return dataMapper.Get(id);
        }

        public IList<TEntity> GetAll()
        {
            return dataMapper.GetAll();
        }

        public void Remove(TEntity entity)
        {
            dataMapper.Delete(entity);
        }

        public void Update(TEntity entity)
        {
            dataMapper.Update(entity); //netusim jestli funguje
        }
    }
}
