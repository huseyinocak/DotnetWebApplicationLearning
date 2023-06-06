using System.Linq.Expressions;

namespace BigDotShop.Repository.Abstractions
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll(Expression<Func<T, bool>>? filter);

        T GetById(int id);
        void Update(T entity);
        void Delete(T entity);
        void UpdateAll(IEnumerable<T> entities);
        void DeleteAll(IEnumerable<T> entities);
        void Add(T entity);
        void AddAll(IEnumerable<T> entities);


    }
}
