using System.Runtime.CompilerServices;
using WardrobeOnline.BLL.Models;
using WardrobeOnline.BLL.Repository.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Repository.Extensions
{
    internal static class EntityExtensions
    {
        internal static ClothDTO TranslateToDTO(this Cloth cloth, ITranslator translator)
        {
            List<string> photoPath = translator.GetPhotoPaths(cloth.Photos);

            List<string> materials = translator.GetClothMaterialPaths(cloth);

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

        internal static PersonDTO TranslateToDTO(this Person person, ITranslator translator) 
        {
            PersonDTO personDTO = new PersonDTO(person.ID, person.Name)
            {
                Type = person.Type,
                ComplectionIDs = translator.GetPersonComplectionsIDs(person)
            };
            return personDTO;
        }

        internal static ComplectionDTO TranslateToDTO(this Complection complection, ITranslator translator)
        {
            ComplectionDTO complectionDTO = new ComplectionDTO(complection.ID, complection.Growth, complection.Weight, complection.PersonID)
            {
                Description = complection.Description,
                Force = complection.Force,
                SetIDs = translator.GetComplectionSets(complection)
            };
            return complectionDTO;
        }

        internal static SetDTO TranslateToDTO(this Set set, ITranslator translator)
        {
            SetDTO setDTO = new SetDTO(set.ID, set.Name, translator.GetSeasonName(set.SeasonID), set.ComplectionID)
            {
                Description = set.Description,
                ClothIDs = translator.GetSetClothesIDs(set)
            };
            return setDTO;
        }
    }
}
