using WardrobeOnline.BLL.Models.Interfaces;

namespace WardrobeOnline.BLL.Repository.Interfaces
{
    public interface IEntityProvider<TEntity> where TEntity : class, IEntityDTO
    {
        public IReadOnlyCollection<TEntity> GetAll();
        public TEntity Get(int id);
        public void Add(TEntity entity);
        public void Remove(int id);
        public void Remove(TEntity entity);
        public void Update(TEntity entity);
    }
}
