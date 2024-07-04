using Microsoft.EntityFrameworkCore;
using WardrobeOnline.DAL.Interfaces;

namespace WardrobeOnline.DAL.Repositories.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        public IReadOnlyCollection<T> GetAll();
        public T? TryGet(int id);
        public DbSet<T> Filter();
        public Task<bool> TryAdd(T entity);
        public Task<bool> TryRemove(int id);
        public Task<bool> TryUpdate(T entity);
    }
}
