using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.BLL.Repository.Interfaces;
using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class Translator(IRepository<Season> seasonRepos, IRepository<Cloth> clothRepos) : ITranslator
    {
        private IRepository<Season> _seasonRepos = seasonRepos;
        private IRepository<Cloth> _clothRepos = clothRepos;

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

        public List<string> GetClothMaterialPaths(Cloth cloth)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<int> GetComplectionSets(Complection complection)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<int> GetPersonComplectionsIDs(Person person)
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
