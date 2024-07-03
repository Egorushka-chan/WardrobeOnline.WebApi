using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.BLL.Repository.Interfaces;
using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class ClothProvider(IRepository<Cloth> repository) : IEntityProvider<ClothDTO>
    {
        private IRepository<Cloth> _repository = repository;
        public void Add(ClothDTO entity)
        {
            throw new NotImplementedException();
        }

        public ClothDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<ClothDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(ClothDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Update(ClothDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
