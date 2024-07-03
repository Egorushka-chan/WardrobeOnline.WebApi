using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.BLL.Repository.Interfaces
{
    public interface ITranslator
    {
        List<string> GetPhotoPaths(ICollection<Photo> photos);
        List<string> GetClothMaterialPaths(Cloth cloth);
        bool TryFindSeasonID(string seasonName, out int id);
        IReadOnlyList<int> GetPersonComplectionsIDs(Person person);
        IReadOnlyList<int> GetComplectionSets(Complection complection);
        IReadOnlyList<int> GetSetClothesIDs(Set set);
        string GetSeasonName(int seasonID);
    }
}
