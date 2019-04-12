using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi1.Models;

namespace webapi1.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(int id, bool isActive = true);
        void Insert(TEntity entity, bool saveChange = true);
        void Update(TEntity entity, bool saveChange = true);
        void Delete(TEntity entity, bool saveChange = true);


    }
}
