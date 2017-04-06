using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using HospitalAppointment.DataAccess;

namespace HospitalAppointment.Logic
{
    public class BusinessLogic<TEntity, TRepository> where TEntity : class
        where TRepository : BaseRepository<TEntity>, new()
    {
        protected readonly TRepository Repository;

        public BusinessLogic()
        {
            Repository = new TRepository();
        }

        public void Insert(TEntity item)
        {
            Repository.Insert(item);
        }

        public IQueryable<TEntity> GetAll()
        {
            return Repository.GetAll();
        }

        public TEntity GetById(Guid entityId)
        {
            return Repository.GetById(entityId);
        }

        public void DeleteById(Guid entityId)
        {
            Repository.DeleteById(entityId);
        }

        public void Delete(TEntity entity)
        {
            Repository.Delete(entity);
        }

        public void Update(TEntity entity)
        {
            Repository.Update(entity);
        }
    }
}
