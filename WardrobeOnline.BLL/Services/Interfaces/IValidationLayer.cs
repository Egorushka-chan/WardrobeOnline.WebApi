﻿using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Models.Interfaces;

namespace WardrobeOnline.BLL.Services.Interfaces
{
    public interface IValidationLayer<TEntityDTO> where TEntityDTO : class, IEntityDTO
    {
        Task<(ErrorResponse?, TEntityDTO?)> Post(TEntityDTO entityDTO);
        Task<(ErrorResponse?, TEntityDTO?)> Get(int id);
        Task<(ErrorResponse?, TEntityDTO?)> Put(int? id, TEntityDTO entityDTO);
        Task<ErrorResponse?> Delete(int id);
        Task<(ErrorResponse?, IReadOnlyList<TEntityDTO>? entityDTOs)> GetPaged(int page, int pageQuantity);
    }
}
