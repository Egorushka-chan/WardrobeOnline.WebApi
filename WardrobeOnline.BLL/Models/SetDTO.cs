using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.BLL.Repository.Implementations;
using WardrobeOnline.BLL.Repository.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Models
{
    public record SetDTO(int iD, string name, string season, int physiqueID) : IEntityDTO
    {
        public int ID { get; init; } = iD;
        public string Name { get; init; } = name;
        public string? Description { get; init; }
        public string Season { get; init; } = season;
        public int PhysiqueID { get; init; } = physiqueID;
        public IReadOnlyList<int>? ClothIDs { get; init; }

        /// <summary>
        /// Это преобразование требует после себя обязательного определения Session/SessionID
        /// </summary>
        public static explicit operator Set(SetDTO self)
        {
            Set set = new()
            {
                ID = self.ID,
                Name = self.Name,
                Description = self.Description,
                PhysiqueID = self.PhysiqueID
            };
            return set;
        }

        //internal Set TranslateToDB(ITranslator translator)
        //{
        //    int id;
        //    if (translator.TryFindSeasonID(Season, out id))
        //    {
        //        Set set = new()
        //        {
        //            ID = ID,
        //            Name = Name,
        //            Description = Description,
        //            SeasonID = id,
        //            ComplectionID = ComplectionID
        //        };
        //        return set;
        //    }
        //    else
        //    {
        //        Set set = new()
        //        {
        //            ID = ID,
        //            Name = Name,
        //            Description = Description,
        //            Season = new Season() { Name = Season},
        //            ComplectionID = ComplectionID
        //        };
        //        return set;
        //    }
        //}
    }
}
