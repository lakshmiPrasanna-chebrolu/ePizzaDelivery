﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaDelivery.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Find(object id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void Delete(object Id);
        int SaveChanges();
    }
}
