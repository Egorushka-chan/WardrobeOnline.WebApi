using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Models.Interfaces;

namespace WardrobeOnline.BLL.Services.Interfaces
{
    public interface ICRUDProvider<TEntityDTO> where TEntityDTO : class, IEntityDTO
    {
        Task<IReadOnlyCollection<TEntityDTO>> GetPagedQuantity(int pageIndex, int pageSize);
        Task<TEntityDTO?> TryGetAsync(int id);
        Task<TEntityDTO?> TryAdd(TEntityDTO entity);
        Task<bool> TryRemove(int id);
        Task<TEntityDTO?> TryUpdate(TEntityDTO entity);
        Task<int> SaveChanges();
    }
}
