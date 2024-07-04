using Microsoft.EntityFrameworkCore;

using WardrobeOnline.BLL.Services.Interfaces;
using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.BLL.Services.Implementations
{


    public class CastHelper(IRepository<Season> seasonRepos, 
        IRepository<Cloth> clothRepos,
        IRepository<ClothHasMaterials> clothHasMaterials,
        IRepository<SetHasClothes> setClothRepository,
        IRepository<Set> setRepository,
        IRepository<Physique> physiqueRepository,
        IImageProvider imageProvider) : ICastHelper
    {
        // TODO: ВОПРОС: performance issue
        // Т.к. много запросов на получение, на изменение, добавление должны делать минимум 2 запроса
        // Что влияет на производительносьб
        // А точно тогда паттерн CRUD операции в IRepository нужны

        private IRepository<Season> _seasonRepos = seasonRepos;
        private IRepository<Cloth> _clothRepos = clothRepos;
        private IRepository<ClothHasMaterials> _clothHasMaterials = clothHasMaterials;
        private IRepository<Set> _setRepository = setRepository;
        private IRepository<Physique> _physiqueRepository = physiqueRepository;
        private IImageProvider _imageProvider = imageProvider;
        private IRepository<SetHasClothes> _setClothRepository= setClothRepository;
        /// <summary>
        /// Возвращает булево значение в зависимости от существования такого сезона
        /// </summary>
        /// <param name="seasonName">Строковое представление названия сезона</param>
        /// <param name="id">Возвращает 0, если Season не найден</param>
        /// <returns></returns>
        public bool TryFindSeasonID(string seasonName, out int id)
        {
            var result = _seasonRepos.GetAll().FirstOrDefault(ent => ent.Name == seasonName);
            if(result is null)
            {
                id = 0;
                return false;
            }

            id = result.ID;
            return true;
        }

        public IReadOnlyList<string> GetClothMaterialNames(Cloth cloth)
        {
            ClothHasMaterials[] clothMaterials = _clothHasMaterials.Filter().Where(el => el.ClothID == cloth.ID).Include(m => m.Material).ToArray();
            var materialIDs = clothMaterials.Select(el => el.MaterialID);

            return (from int materialID in materialIDs
                    select clothMaterials[materialID].Material.Name).ToList();
        }
        
        public IReadOnlyList<int> GetPhysiqueSetIDs(Physique physique)
        {
            return _setRepository.Filter().Where(s => s.PhysiqueID == physique.ID).Select(s => s.ID).ToList();
        }

        public IReadOnlyList<int> GetPersonPhysiqueIDs(Person person)
        {
            return  _physiqueRepository.Filter().Where(p => p.PersonID == person.ID).Select(p=> p.ID).ToList();
        }

        public IReadOnlyList<string> GetPhotoPaths(ICollection<Photo> photos)
        {
            return (from Photo photo in photos
                    select _imageProvider.GetImageLink(photo.ID)).ToList();
        }

        public string GetSeasonName(int seasonID)
        {
            string result = "";
            var query = _seasonRepos.TryGet(seasonID);
            if(query == null)
                result = "Unknown";
            else
                result = query.ToString();
            return result;
        }

        public IReadOnlyList<int> GetSetClothesIDs(Set set)
        {
            return _setClothRepository.Filter().Where(sc => sc.SetID == set.ID).Select(sc => sc.ClothID).ToList();
        }
    }
}
