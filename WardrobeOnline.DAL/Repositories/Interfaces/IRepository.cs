using Microsoft.EntityFrameworkCore;
using WardrobeOnline.DAL.Interfaces;

namespace WardrobeOnline.DAL.Repositories.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        public IReadOnlyCollection<T> GetAll();
        public T? TryGet(int id);
        public DbSet<T> Filter();
        public bool TryAdd(T entity);
        public bool TryRemove(int id);
        public bool TryRemove(T entity);
        public bool TryUpdate(T entity);
    }
}
