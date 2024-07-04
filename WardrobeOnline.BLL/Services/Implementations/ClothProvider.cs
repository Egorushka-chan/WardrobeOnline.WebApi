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

        public Task<bool> TryAdd(ClothDTO entity)
        {
            return _repository.TryAdd((Cloth)entity);
        }

        public ClothDTO? TryGet(int id)
        {
            var get = _repository.TryGet(id);
            if (get == null)
                return null;

            return get.TranslateToDTO(_castHelper);
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
