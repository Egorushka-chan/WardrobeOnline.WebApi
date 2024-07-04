using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Services.Extensions;
using WardrobeOnline.BLL.Services.Interfaces;
using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.BLL.Services.Implementations
{
    public class PersonProvider(
        IRepository<Person> repository,
        ICastHelper castHelper) : ICRUDProvider<PersonDTO>
    {
        private IRepository<Person> _repository = repository;
        private ICastHelper _castHelper = castHelper;

        public IReadOnlyCollection<PersonDTO> GetAll()
        {
            return (from item in _repository.GetAll()
                select item.TranslateToDTO(_castHelper)).ToList();
        }

        public Task<bool> TryAdd(PersonDTO entity)
        {
            return _repository.TryAdd((Person)entity);
        }

        public PersonDTO? TryGet(int id)
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

        public Task<bool> TryUpdate(PersonDTO entity)
        {
            return _repository.TryUpdate((Person)entity);
        }
    }
}
