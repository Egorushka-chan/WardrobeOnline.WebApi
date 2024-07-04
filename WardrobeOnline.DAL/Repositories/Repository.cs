using Microsoft.EntityFrameworkCore;
using WardrobeOnline.DAL.Interfaces;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.DAL.Repositories
{
    public class Repository<T>(IWardrobeContext wardrobeContext) : IRepository<T> where T : class, IEntity
    {
        //TODO: Update, Add, Delete перевести на bool. Заменить везде сейвы на асинхронные

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

        public async bool TryAdd(T entity)
        {
            _wardrobeContext.DBSet<T>().Add(entity);
            await _wardrobeContext.SaveChangesAsync();
        }

        public async bool TryUpdate(T entity)
        {
            _wardrobeContext.DBSet<T>().Update(entity);
            await _wardrobeContext.SaveChangesAsync();
        }

        public async bool TryRemove(int id)
        {
            T entity = _wardrobeContext.DBSet<T>().Where(el => el.ID == id).First();
            _wardrobeContext.DBSet<T>().Remove(entity);
            await _wardrobeContext.SaveChangesAsync();
        }

        public async bool TryRemove(T entity)
        {
            _wardrobeContext.DBSet<T>().Remove(entity);
            await _wardrobeContext.SaveChangesAsync();
        }
    }
}
