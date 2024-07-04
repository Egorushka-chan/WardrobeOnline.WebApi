using WardrobeOnline.BLL.Models.Interfaces;

namespace WardrobeOnline.BLL.Repository.Interfaces
{
    public interface ICRUDProvider<TEntityDTO> where TEntityDTO : class, IEntityDTO
    {
        public IReadOnlyCollection<TEntityDTO> GetAll();
        public TEntityDTO? TryGet(int id);
        public bool TryAdd(TEntityDTO entity);
        public bool TryRemove(int id);
        public bool TryRemove(TEntityDTO entity);
        public bool TryUpdate(TEntityDTO entity);
    }
}
