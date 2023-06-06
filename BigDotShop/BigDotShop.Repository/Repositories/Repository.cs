using BigDotShop.Core.Entities;
using BigDotShop.Repository.Abstractions;
using BigDotShop.Repository.EFCore;
using System.Linq.Expressions;

namespace BigDotShop.Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly List<T> values;

        public Repository(List<T> values)
        {
            this.values = values;
        }
        public void Add(T entity)
        {
            values.Add(entity);
        }

        public void AddAll(IEnumerable<T> entities)
        {
            values.AddRange(entities);
        }

        public void Delete(T entity)
        {
            values.Remove(entity);
        }

        public void DeleteAll(IEnumerable<T> entities)
        {
            values.RemoveAll(a => entities.Contains(a));
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>>? filter)
        {
            var result = filter != null ? values.AsQueryable().Where(filter!) : values.AsQueryable();
            return result;
        }

        public T GetById(int id)
        {
            return values.Find(aa => aa.Id == id)!;
        }

        public void Update(T entity)
        {
            var find = GetById(entity.Id);
            if (find != null)
            {
                Delete(find);
                Add(entity);
            }
        }

        public void UpdateAll(IEnumerable<T> entities)
        {
            for (int i = 0; i < entities.Count(); i++)
            {
                Update(entities.ToArray()[i]);
            }
        }
    }
}
