using System.Runtime.CompilerServices;
using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Repository.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Repository.Extensions
{
    internal static class EntityExtensions
    {
        internal static ClothDTO TranslateToDTO(this Cloth cloth, ICastHelper translator)
        {
            List<string> photoPath = translator.GetPhotoPaths(cloth.Photos);

            List<string> materials = translator.GetClothMaterialNames(cloth);

            ClothDTO clothDTO = new(cloth.ID, cloth.Name)
            {
                Description = cloth.Description,
                Rating = cloth.Rating,
                Size = cloth.Size,
                PhotoPaths = photoPath,
                Materials = materials
            };
            return clothDTO;
        }

        internal static PersonDTO TranslateToDTO(this Person person, ICastHelper translator) 
        {
            PersonDTO personDTO = new PersonDTO(person.ID, person.Name)
            {
                Type = person.Type,
                PhysiqueIDs = translator.GetPersonPhysiqueIDs(person)
            };
            return personDTO;
        }

        internal static PhysiqueDTO TranslateToDTO(this Physique physique, ICastHelper translator)
        {
            PhysiqueDTO physiqueDTO = new PhysiqueDTO(physique.ID, physique.Growth, physique.Weight, physique.PersonID)
            {
                Description = physique.Description,
                Force = physique.Force,
                SetIDs = translator.GetPhysiqueSets(physique)
            };
            return physiqueDTO;
        }

        internal static SetDTO TranslateToDTO(this Set set, ICastHelper translator)
        {
            SetDTO setDTO = new SetDTO(set.ID, set.Name, translator.GetSeasonName(set.SeasonID), set.PhysiqueID)
            {
                Description = set.Description,
                ClothIDs = translator.GetSetClothesIDs(set)
            };
            return setDTO;
        }
    }
}
