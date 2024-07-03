using WardrobeOnline.BLL.Repository.Interfaces;
using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class CastHelper(IRepository<Season> seasonRepos, 
        IRepository<Cloth> clothRepos,
        IRepository<ClothHasMaterials> clothHasMaterials) : ICastHelper
    {
        private IRepository<Season> _seasonRepos = seasonRepos;
        private IRepository<Cloth> _clothRepos = clothRepos;
        private IRepository<ClothHasMaterials> _clothHasMaterials = clothHasMaterials;

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

        public List<string> GetClothMaterialNames(Cloth cloth)
        {
            int[] materialIDs = _clothHasMaterials.Filter().Where(el => el.ClothID == cloth.ID).Select(el => el.MaterialID).ToArray();
            foreach(int materialID in materialIDs)
            {

            }
        }

        // TODO: доделать каст хелпер. Это первоочередная задача перед продолжением работы над другими объектами

        public IReadOnlyList<int> GetPhysiqueSets(Physique physique)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<int> GetPersonPhysiqueIDs(Person person)
        {
            throw new NotImplementedException();
        }

        public List<string> GetPhotoPaths(ICollection<Photo> photos)
        {
            throw new NotImplementedException();
        }

        public string GetSeasonName(int seasonID)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<int> GetSetClothesIDs(Set set)
        {
            throw new NotImplementedException();
        }
    }
}
