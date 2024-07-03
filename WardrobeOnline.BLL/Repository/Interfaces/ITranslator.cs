using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.BLL.Repository.Interfaces
{
    public interface ITranslator
    {
        List<string> GetPhotoPaths(ICollection<Photo> photos);
        List<string> GetClothMaterialPaths(Cloth cloth);
        int FindSeasonID(string seasonName);
        IReadOnlyList<int> GetPersonComplectionsIDs(Person person);
        IReadOnlyList<int> GetComplectionSets(Complection complection);
        IReadOnlyList<int> GetSetClothesIDs(Set set);
        string GetSeasonName(int seasonID);
    }
}
