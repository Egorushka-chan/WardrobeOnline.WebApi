using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.BLL.Repository.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Repository.Implementations
{
    public class Translator : ITranslator
    {
        public int FindSeasonID(string seasonName)
        {
            throw new NotImplementedException();
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
