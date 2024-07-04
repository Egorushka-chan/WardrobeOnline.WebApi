using WardrobeOnline.DAL.Entities;
using WardrobeOnline.DAL.Repositories.Interfaces;

namespace WardrobeOnline.BLL.Repository.Interfaces
{
    public interface ICastHelper
    {
        IReadOnlyList<string> GetPhotoPaths(ICollection<Photo> photos);
        IReadOnlyList<string> GetClothMaterialNames(Cloth cloth);
        bool TryFindSeasonID(string seasonName, out int id);
        IReadOnlyList<int> GetPersonPhysiqueIDs(Person person);
        IReadOnlyList<int> GetPhysiqueSetIDs(Physique physique);
        IReadOnlyList<int> GetSetClothesIDs(Set set);
        string GetSeasonName(int seasonID);
    }
}
