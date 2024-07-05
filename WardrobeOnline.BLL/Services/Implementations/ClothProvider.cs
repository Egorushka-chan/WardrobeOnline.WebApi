using System.Collections.Immutable;
using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.BLL.Services.Extensions;
using WardrobeOnline.BLL.Services.Interfaces;
using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.BLL.Services.Implementations
{
    public class ClothProvider(
        IRepository<Cloth> repository,
        ICastHelper castHelper) : ICRUDProvider<ClothDTO>
    {
        private IRepository<Cloth> _repository = repository;
        private ICastHelper _castHelper = castHelper;

        public async Task<bool> TryAdd(ClothDTO entity)
        {
            entity.TranslateToDB(out Cloth? cloth, _castHelper);
            if (cloth == null)
                return false;
            return await _repository.TryAdd(cloth);
        }

        public ClothDTO? TryGetAsync(int id)
        {
            var get = _repository.TryGet(id);
            if (get == null)
                return null;

            get.TranslateToDTO(out ClothDTO? clothDTO, _castHelper);

            return clothDTO;
        }

        public IReadOnlyCollection<ClothDTO> GetAll()
        {
            return (from item in _repository.GetAll()
                   select item.TranslateToDTO(_castHelper)).ToArray();
        }

        public Task<bool> TryRemove(int id)
        {
            return _repository.TryRemove(id);
        }

        public Task<bool> TryUpdate(ClothDTO entity)
        {
            return _repository.TryUpdate((Cloth)entity);
        }
    }
}
