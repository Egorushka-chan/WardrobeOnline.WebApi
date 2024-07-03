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
        public T Get(int id)
        {
            _wardrobeContext.DBSet<T>();

            IQueryable queryable = _wardrobeContext.DBSet<T>();

            return _wardrobeContext.DBSet<T>().Where(el => el.ID == id).First();
        }
        public DbSet<T> Filter()
        {
            throw new NotImplementedException();
        }

        public async void Add(T entity)
        {
            _wardrobeContext.DBSet<T>().Add(entity);
            await _wardrobeContext.SaveChangesAsync();
        }

        public async void Update(T entity)
        {
            _wardrobeContext.DBSet<T>().Update(entity);
            await _wardrobeContext.SaveChangesAsync();
        }

        public async void Remove(int id)
        {
            T entity = _wardrobeContext.DBSet<T>().Where(el => el.ID == id).First();
            _wardrobeContext.DBSet<T>().Remove(entity);
            await _wardrobeContext.SaveChangesAsync();
        }

        public async void Remove(T entity)
        {
            _wardrobeContext.DBSet<T>().Remove(entity);
            await _wardrobeContext.SaveChangesAsync();
        }
    }
}
