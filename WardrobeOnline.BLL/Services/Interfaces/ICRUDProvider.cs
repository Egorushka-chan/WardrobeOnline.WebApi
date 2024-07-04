using WardrobeOnline.BLL.Models.Interfaces;

namespace WardrobeOnline.BLL.Services.Interfaces
{
    public interface ICRUDProvider<TEntityDTO> where TEntityDTO : class, IEntityDTO
    {
        public IReadOnlyCollection<TEntityDTO> GetAll();
        public TEntityDTO? TryGet(int id);
        public Task<bool> TryAdd(TEntityDTO entity);
        public Task<bool> TryRemove(int id);
        public Task<bool> TryUpdate(TEntityDTO entity);
    }
}
