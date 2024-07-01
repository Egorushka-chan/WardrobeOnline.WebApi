using WardrobeOnline.DAL.Interfaces;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.DAL.Repositories
{
    internal class Repository<T>(IWardrobeContext wardrobeContext) : IRepository<T> where T : class, IEntity
    {
        private readonly IWardrobeContext _wardrobeContext = wardrobeContext ?? throw new ArgumentNullException(nameof(wardrobeContext));

        public IReadOnlyCollection<T> GetAll()
        {
            return _wardrobeContext.DBSet<T>().ToList().AsReadOnly();
        }
        public T Get(int id)
        {
            return _wardrobeContext.DBSet<T>().Where(el => el.ID == id).First();
        }

        public void Add(T entity)
        {
            _wardrobeContext.DBSet<T>().Add(entity);
            _wardrobeContext.Context().SaveChanges();
        }

        public void Update(T entity)
        {
            _wardrobeContext.DBSet<T>().Update(entity);
            _wardrobeContext.Context().SaveChanges();
        }

        public void Remove(int id)
        {
            T entity = _wardrobeContext.DBSet<T>().Where(el => el.ID == id).First();
            _wardrobeContext.DBSet<T>().Remove(entity);
            _wardrobeContext.Context().SaveChanges();
        }

        public void Remove(T entity)
        {
            _wardrobeContext.DBSet<T>().Remove(entity);
            _wardrobeContext.Context().SaveChanges();
        }
    }
}
