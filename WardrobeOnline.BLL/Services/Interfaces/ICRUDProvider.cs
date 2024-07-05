using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Models.Interfaces;

namespace WardrobeOnline.BLL.Services.Interfaces
{
    public interface ICRUDProvider<TEntityDTO> where TEntityDTO : class, IEntityDTO
    {
        public IReadOnlyCollection<TEntityDTO> GetPagedQuantity(int page, int pageSize);
        public Task<TEntityDTO?> TryGetAsync(int id);
        public Task<TEntityDTO?> TryAdd(TEntityDTO entity);
        public Task<bool> TryRemove(int id);
        public Task<TEntityDTO?> TryUpdate(TEntityDTO entity);
    }
}
