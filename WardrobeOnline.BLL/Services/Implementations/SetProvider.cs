using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Services.Extensions;
using WardrobeOnline.BLL.Services.Interfaces;
using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.BLL.Services.Implementations
{
    public class SetProvider(
        IRepository<Set> repository,
        ICastHelper castHelper) : ICRUDProvider<SetDTO>
    {
        private IRepository<Set> _repository = repository;
        private ICastHelper _castHelper = castHelper;

        public IReadOnlyCollection<SetDTO> GetAll()
        {
            return (from item in _repository.GetAll()
                    select item.TranslateToDTO(_castHelper)).ToList();
        }

        public Task<bool> TryAdd(SetDTO entity)
        {
            Set set = (Set)entity;
            int id;
            if (_castHelper.TryFindSeasonID(entity.Season, out id))
            {
                set.SeasonID = id;
            }
            else
            {
                set.Season = new Season() { Name = entity.Name};
            }
            return _repository.TryAdd(set);
        }

        public SetDTO? TryGetAsync(int id)
        {
            var get = _repository.TryGet(id);
            if (get == null)
                return null;

            return new SetDTO(get.ID, get.Name, get.Season?.Name ?? string.Empty, get.PhysiqueID)
            {

            };
        }

        public Task<bool> TryRemove(int id)
        {
            return _repository.TryRemove(id);
        }

        public Task<bool> TryUpdate(SetDTO entity)
        {
            Set set = (Set)entity;
            int id;
            if (_castHelper.TryFindSeasonID(entity.Season, out id))
            {
                set.SeasonID = id;
            }
            else
            {
                set.Season = new Season() { Name = entity.Name};
            }
            return _repository.TryUpdate(set);
        }
    }
}
