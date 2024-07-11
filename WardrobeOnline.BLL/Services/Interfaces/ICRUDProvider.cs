﻿using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Models.Interfaces;

namespace WardrobeOnline.BLL.Services.Interfaces
{
    public interface ICRUDProvider<TEntityDTO> where TEntityDTO : class, IEntityDTO
    {
        Task<IReadOnlyList<TEntityDTO>> GetPagedQuantity(int pageIndex, int pageSize);
        Task<TEntityDTO?> TryGetAsync(int id);
        Task<TEntityDTO?> TryAddAsync(TEntityDTO entity);
        Task<bool> TryRemoveAsync(int id);
        Task<TEntityDTO?> TryUpdateAsync(TEntityDTO entity);
        Task<int> SaveChangesAsync();
    }
}
