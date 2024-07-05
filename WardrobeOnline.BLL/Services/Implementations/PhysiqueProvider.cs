using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Services.Extensions;
using WardrobeOnline.BLL.Services.Interfaces;
using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.BLL.Services.Implementations
{
    public class PhysiqueProvider(
        IRepository<Physique> repository,
        ICastHelper castHelper) : ICRUDProvider<PhysiqueDTO>
    {
        private IRepository<Physique> _repository = repository;
        private ICastHelper _castHelper = castHelper;

        public IReadOnlyCollection<PhysiqueDTO> GetAll()
        {
            return (from item in _repository.GetAll()
                   select item.TranslateToDTO(_castHelper)).ToArray();
        }

        public Task<bool> TryAdd(PhysiqueDTO entity)
        {
            return _repository.TryAdd((Physique)entity);
        }

        public PhysiqueDTO? TryGetAsync(int id)
        {
            var get = _repository.TryGet(id);
            if (get == null)
                return null;

            return get.TranslateToDTO(_castHelper);
        }

        public Task<bool> TryRemove(int id)
        {
            return _repository.TryRemove(id);
        }

        public Task<bool> TryUpdate(PhysiqueDTO entity)
        {
            return _repository.TryUpdate((Physique)entity);
        }
    }
}
