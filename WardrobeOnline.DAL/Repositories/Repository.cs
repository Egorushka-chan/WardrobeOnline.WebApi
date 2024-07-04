using Microsoft.EntityFrameworkCore;

using WardrobeOnline.DAL.Interfaces;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.DAL.Repositories
{
    public class Repository<T>(IWardrobeContext wardrobeContext) : IRepository<T> where T : class, IEntity
    {
        //TODO: ВОПРОС: тотальные непонятки с асинхронностью
        //Яркий пример - TryGet. Там можно создать метод FindAsync
        //Можно делать от LINQ ToArrayAsync.
        //Но тогда очень много кода будет на Task

        private readonly IWardrobeContext _wardrobeContext = wardrobeContext ?? throw new ArgumentNullException(nameof(wardrobeContext));

        public IReadOnlyCollection<T> GetAll()
        {
            return _wardrobeContext.DBSet<T>().ToList().AsReadOnly();
        }
        public T? TryGet(int id)
        {           
            return _wardrobeContext.DBSet<T>().Find(id);
        }
        public DbSet<T> Filter()
        {
            return _wardrobeContext.DBSet<T>();
        }

        public async Task<bool> TryAdd(T entity)
        {
            _wardrobeContext.DBSet<T>().Add(entity);
            var changes = await _wardrobeContext.SaveChangesAsync();
            return changes == 1;
        }

        public async Task<bool> TryUpdate(T entity)
        {
            _wardrobeContext.DBSet<T>().Update(entity);
            var changes = await _wardrobeContext.SaveChangesAsync();
            return changes == 1;
        }

        public async Task<bool> TryRemove(int id)
        {
            T entity = _wardrobeContext.DBSet<T>().Where(el => el.ID == id).First();
            _wardrobeContext.DBSet<T>().Remove(entity);
            var changes = await _wardrobeContext.SaveChangesAsync();
            return changes == 1;
        }
    }
}
