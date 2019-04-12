using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi1.Models;

namespace webapi1.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly FoodContext context;
        private DbSet<TEntity> entities;
        string errorMessage = string.Empty;

        public Repository(FoodContext context)
        {
            this.context = context;
            entities = context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return entities.AsQueryable();
        }

        public TEntity Get(int id, bool isActive = true)
        {
            return entities.FirstOrDefault(x => x.Id == id && (x.Defig || isActive));
        }

        public void Insert(TEntity entity, bool saveChange = true)
        {
            if (entity == null)
            {
                throw new ArgumentException();
            }

            entity.InsertDate = DateTime.Now;
            entity.UpdateDate = DateTime.Now;

            entities.Add(entity);

            if (saveChange) context.SaveChanges();
        }

        public void Update(TEntity entity, bool saveChange = true)
        {
            if (entity == null)
            {
                throw new ArgumentException();
            }
            entity.UpdateDate = DateTime.Now;

            if (saveChange)
            {
                context.SaveChanges();
            }

        }
        public void Delete(TEntity entity, bool saveChange = true)
        {
            if (entity == null)
            {
                throw new ArgumentException();
            }
            entities.Remove(entity);
            if (saveChange)
            {
                
                context.SaveChanges();
            }

        }
    }
}
