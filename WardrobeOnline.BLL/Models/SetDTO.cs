using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardrobeOnline.BLL.Models.Interfaces;
using WardrobeOnline.BLL.Repository.Interfaces;
using WardrobeOnline.DAL.Entities;

namespace WardrobeOnline.BLL.Models
{
    public record SetDTO(int iD, string name, string season, int complectionID) : IEntityDTO
    {
        public int ID { get; init; } = iD;
        public string Name { get; init; } = name;
        public string? Description { get; init; }
        public string Season { get; init; } = season;
        public int ComplectionID { get; init; } = complectionID;
        public IReadOnlyList<int>? ClothIDs { get; init; }

        internal Set TranslateToDB(ITranslator translator)
        {
            Set set = new()
            {
                ID = ID,
                Name = Name,
                Description = Description,
                SeasonID = translator.FindSeasonID(Season),
                ComplectionID = ComplectionID
            };
            return set;
        }
    }
}
