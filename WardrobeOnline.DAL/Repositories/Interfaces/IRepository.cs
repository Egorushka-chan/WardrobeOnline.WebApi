using Microsoft.EntityFrameworkCore;
using WardrobeOnline.DAL.Interfaces;

namespace WardrobeOnline.DAL.Repositories.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        public IReadOnlyCollection<T> GetAll();
        public T Get(int id);
        public DbSet<T> Filter();
        public void Add(T entity);
        public void Remove(int id);
        public void Remove(T entity);
        public void Update(T entity);
    }
}
