using BigDotShop.Core.ServiceAbstract;
using BigDotShop.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BigDotShop.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IRepository<T> repository;

        public Service(IRepository<T> repository)
        {
            this.repository = repository;
        }
        public void Add(T entity)
        {
            repository.Add(entity);
        }

        public void AddAll(IEnumerable<T> entities)
        {
            repository.AddAll(entities);
        }

        public void Delete(T entity)
        {
            repository.Delete(entity);
        }

        public void DeleteAll(IEnumerable<T> entities)
        {
            repository.DeleteAll(entities);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>>? filter)
        {
            return repository.GetAll(filter);
        }

        public T GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Update(T entity)
        {
            repository.Update(entity);
        }

        public void UpdateAll(IEnumerable<T> entities)
        {
            repository.UpdateAll(entities);
        }
    }
}
