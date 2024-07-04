using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.BLL.Repository.Extensions;
using WardrobeOnline.BLL.Repository.Interfaces;
using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class ClothProvider(
        IRepository<Cloth> repository,
        ICastHelper castHelper) : ICRUDProvider<ClothDTO>
    {
        // TODO: соединить провайдер одежды с базой
        private IRepository<Cloth> _repository = repository;
        private ICastHelper _castHelper = castHelper;

        public bool TryAdd(ClothDTO entity)
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

        public bool TryRemove(int id)
        {
            return _repository.TryRemove(id);
        }

        public bool TryRemove(ClothDTO entity)
        {
            return _repository.TryRemove((Cloth)entity);
        }

        public bool TryUpdate(ClothDTO entity)
        {
            return _repository.TryUpdate((Cloth)entity);
        }
    }
}
