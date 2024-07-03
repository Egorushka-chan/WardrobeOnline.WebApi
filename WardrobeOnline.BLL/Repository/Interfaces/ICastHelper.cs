using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.BLL.Repository.Interfaces
{
    public interface ICastHelper
    {
        List<string> GetPhotoPaths(ICollection<Photo> photos);
        List<string> GetClothMaterialNames(Cloth cloth);
        bool TryFindSeasonID(string seasonName, out int id);
        IReadOnlyList<int> GetPersonPhysiqueIDs(Person person);
        IReadOnlyList<int> GetPhysiqueSets(Physique physique);
        IReadOnlyList<int> GetSetClothesIDs(Set set);
        string GetSeasonName(int seasonID);
    }
}
