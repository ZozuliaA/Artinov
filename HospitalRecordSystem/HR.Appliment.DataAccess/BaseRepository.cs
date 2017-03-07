using System;
using System.Data.Entity;
using System.Linq;

namespace HospitalAppointment.DataAccess
{
    public class BaseRepository<T> where T : class 
    {
        protected readonly HaContext Context;

        public BaseRepository()
        {
            Context = new HaContext();
        }
       
        public virtual IQueryable<T> GetAll()
        {
            return Context.Set<T>();
        }

        public virtual T GetById(Guid id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }

        public virtual void DeleteById(Guid id)
        {
            T entity = Context.Set<T>().Find(id); 
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }

        public void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}